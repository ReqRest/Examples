namespace IntegrationTests.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;

    public class PhotosInterfaceTests : MultiResourceRestInterfaceTests<Photo>
    {

        public override MultiResourceRestInterface<Photo> GetInterface() =>
            Client.Photos();

        public override Photo CreatePostData() =>
            new Photo() { Title = "Foo" };

    }

}
