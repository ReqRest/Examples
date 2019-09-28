namespace IntegrationTests.Interfaces
{
    using System.Threading.Tasks;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;
    using Xunit;
    using ReqRest.Http;
    using FluentAssertions;

    public abstract class SingleResourceRestInterfaceTests<T> : JsonPlaceholderClientTests
        where T : class
    {

        private const int DefaultId = 1;
        private const int NotFoundId = 999999999;

        public abstract SingleResourceRestInterface<T> GetInterface(int id);
        public abstract (T NewResource, T Expected) CreatePutData(int id);
        public abstract (T NewResource, T Expected) CreatePatchData(int id);

        #region Get()

        [Theory]
        [InlineData(DefaultId, StatusCode.Ok)]
        [InlineData(NotFoundId, StatusCode.NotFound)]
        public async Task Get_Returns_Expected_Status_Code(int id, int expectedStatusCode)
        {
            var response = await GetInterface(id).Get().FetchResponseAsync().ConfigureAwait(false);
            Assert.Equal(expectedStatusCode, (int)response.StatusCode);
        }

        [Fact]
        public async Task Get_Returns_Expected_Resource()
        {
            var resource = await GetInterface(DefaultId).Get().FetchResourceAsync().ConfigureAwait(false);
            Assert.IsType<T>(resource.Value);
        }

        [Fact]
        public async Task Get_Returns_Empty_Variant_If_Resource_Doesnt_Exist()
        {
            var resource = await GetInterface(NotFoundId).Get().FetchResourceAsync().ConfigureAwait(false);
            Assert.True(resource.IsEmpty);
        }

        #endregion

        #region Put()

        [Theory]
        [InlineData(DefaultId, StatusCode.Ok)]
        [InlineData(NotFoundId, StatusCode.InternalServerError)] // PUT crashes when the ID doesn't exist.
        public async Task Put_Returns_Expected_Status_Code(int id, int expectedStatusCode)
        {
            var (newResource, _) = CreatePutData(id);
            var response = await GetInterface(id).Put(newResource).FetchResponseAsync().ConfigureAwait(false);
            Assert.Equal(expectedStatusCode, (int)response.StatusCode);
        }

        [Fact]
        public async Task Put_Returns_Updated_Resource()
        {
            var (newResource, expected) = CreatePutData(DefaultId);
            var result = (T)await GetInterface(DefaultId).Put(newResource).FetchResourceAsync().ConfigureAwait(false);
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public async Task Put_Returns_Empty_Variant_If_Resource_Doesnt_Exist()
        {
            var resource = await GetInterface(NotFoundId).Get().FetchResourceAsync().ConfigureAwait(false);
            Assert.True(resource.IsEmpty);
        }

        #endregion

        #region Patch()

        [Theory]
        [InlineData(DefaultId, StatusCode.Ok)]
        [InlineData(NotFoundId, StatusCode.Ok)] // PATCH always works for some reason.
        public async Task Patch_Returns_Expected_Status_Code(int id, int expectedStatusCode)
        {
            var (newResource, _) = CreatePatchData(id);
            var response = await GetInterface(id).Patch(newResource).FetchResponseAsync().ConfigureAwait(false);
            Assert.Equal(expectedStatusCode, (int)response.StatusCode);
        }

        #endregion

        #region Delete()

        [Theory]
        [InlineData(DefaultId, StatusCode.Ok)]
        [InlineData(NotFoundId, StatusCode.Ok)] // DELETE doesn't return 404s.
        public async Task Delete_Returns_Expected_Status_Code(int id, int expectedStatusCode)
        {
            var response = await GetInterface(id).Delete().FetchResponseAsync().ConfigureAwait(false);
            Assert.Equal(expectedStatusCode, (int)response.StatusCode);
        }

        [Theory]
        [InlineData(DefaultId)]
        [InlineData(NotFoundId)]
        public async Task Delete_Returns_Expected_Resource(int id)
        {
            var resource = await GetInterface(id).Delete().FetchResourceAsync().ConfigureAwait(false);
            Assert.IsType<NoContent>(resource.Value);
        }

        #endregion

    }

}
