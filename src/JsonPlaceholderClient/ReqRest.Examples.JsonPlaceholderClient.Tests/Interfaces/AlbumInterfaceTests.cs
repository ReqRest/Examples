namespace IntegrationTests.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;

    public class AlbumInterfaceTests : SingleResourceRestInterfaceTests<Album>
    {

        public override SingleResourceRestInterface<Album> GetInterface(int id) =>
            Client.Albums(id);

        public override (Album NewResource, Album Expected) CreatePutData(int id)
        {
            var newResource = new Album()
            {
                Id = 123456,
                UserId = 1,
                Title = "Foo",
            };

            var expected = new Album()
            {
                Id = id, // JSON Placeholder doesn't allow overwriting the ID.
                UserId = 1,
                Title = "Foo",
            };

            return (newResource, expected);
        }

        public override (Album NewResource, Album Expected) CreatePatchData(int id)
        {
            var item = new Album()
            {
                Id = 123456, // The ID actually gets overwritten.
                Title = "Foo",
            };
            return (item, item);
        }
    }

}
