namespace IntegrationTests.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using Xunit;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;
    using System.Net;
    using FluentAssertions;
    using ReqRest.Http;

    public abstract class MultiResourceRestInterfaceTests<T> : JsonPlaceholderClientTests
        where T : class
    {

        public abstract MultiResourceRestInterface<T> GetInterface();

        public abstract T CreatePostData();

        #region Get()

        [Fact]
        public async Task Get_Returns_Expected_Status_Code()
        {
            var response = await GetInterface().Get().FetchResponseAsync().ConfigureAwait(false);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Get_Returns_Expected_Resource()
        {
            var resource = await GetInterface().Get().FetchResourceAsync().ConfigureAwait(false);
            Assert.IsAssignableFrom<IList<T>>(resource.Value);
        }

        [Fact]
        public async Task Get_Limits_Resources()
        {
            var resource = await GetInterface().Get(limit: 5).FetchResourceAsync().ConfigureAwait(false);
            resource.GetValue(out var items);
            Assert.Equal(5, items.Count);
        }

        [Fact]
        public async Task Get_Skips_Resources()
        {
            var first = await GetInterface().Get(start: 0, limit: 1).FetchResourceAsync().ConfigureAwait(false);
            var second = await GetInterface().Get(start: 1, limit: 1).FetchResourceAsync().ConfigureAwait(false);
            first.GetValue(out var firstItems);
            second.GetValue(out var secondItems);

            firstItems.First().Should().NotBeEquivalentTo(secondItems.First());
        }

        #endregion

        #region Post

        [Fact]
        public async Task Post_Returns_Expected_Status_Code()
        {
            var newResource = CreatePostData();
            var response = await GetInterface().Post(newResource).FetchResponseAsync().ConfigureAwait(false);
            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }
        
        [Fact]
        public async Task Post_Returns_Expected_Resource()
        {
            var newResource = CreatePostData();
            var result = await GetInterface().Post(newResource).FetchResourceAsync().ConfigureAwait(false);
            Assert.IsType<T>(result.Value);
        }

        #endregion

    }

}
