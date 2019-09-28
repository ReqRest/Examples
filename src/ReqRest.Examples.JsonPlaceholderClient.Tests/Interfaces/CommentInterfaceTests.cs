namespace IntegrationTests.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;

    public class CommentInterfaceTests : SingleResourceRestInterfaceTests<Comment>
    {

        public override SingleResourceRestInterface<Comment> GetInterface(int id) =>
            Client.Comments(id);

        public override (Comment NewResource, Comment Expected) CreatePutData(int id)
        {
            var newResource = new Comment()
            {
                Id = 123456,
                PostId = 1,
                Body = "Foo",
            };

            var expected = new Comment()
            {
                Id = id, // JSON Placeholder doesn't allow overwriting the ID.
                PostId = 1,
                Body = "Foo",
            };

            return (newResource, expected);
        }

        public override (Comment NewResource, Comment Expected) CreatePatchData(int id)
        {
            var item = new Comment()
            {
                Id = 123456, // The ID actually gets overwritten.
                Body = "Foo",
            };
            return (item, item);
        }
    }

}
