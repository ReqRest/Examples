namespace IntegrationTests.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;

    public class PostInterfaceTests : SingleResourceRestInterfaceTests<Post>
    {

        public override SingleResourceRestInterface<Post> GetInterface(int id) =>
            Client.Posts(id);

        public override (Post NewResource, Post Expected) CreatePutData(int id)
        {
            var newResource = new Post()
            {
                Id = 123456,
                UserId = 1,
                Title = "Foo",
                Body = null,
            };

            var expected = new Post()
            {
                Id = id, // JSON Placeholder doesn't allow overwriting the ID.
                UserId = 1,
                Title = "Foo",
                Body = null,
            };

            return (newResource, expected);
        }

        public override (Post NewResource, Post Expected) CreatePatchData(int id)
        {
            var item = new Post()
            {
                Id = 123456, // The ID actually gets overwritten.
                Title = "Foo",
            };
            return (item, item);
        }
    }

}
