namespace IntegrationTests.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;

    public class PhotoInterfaceTests : SingleResourceRestInterfaceTests<Photo>
    {

        public override SingleResourceRestInterface<Photo> GetInterface(int id) =>
            Client.Photos(id);

        public override (Photo NewResource, Photo Expected) CreatePutData(int id)
        {
            var newResource = new Photo()
            {
                Id = 123456,
                AlbumId = 1,
                Title = "Foo",
            };

            var expected = new Photo()
            {
                Id = id, // JSON Placeholder doesn't allow overwriting the ID.
                AlbumId = 1,
                Title = "Foo",
            };

            return (newResource, expected);
        }

        public override (Photo NewResource, Photo Expected) CreatePatchData(int id)
        {
            var item = new Photo()
            {
                Id = 123456, // The ID actually gets overwritten.
                Title = "Foo",
            };
            return (item, item);
        }
    }

}
