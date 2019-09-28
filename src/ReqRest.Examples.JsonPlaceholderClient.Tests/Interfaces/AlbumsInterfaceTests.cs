namespace IntegrationTests.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;

    public class AlbumsInterfaceTests : MultiResourceRestInterfaceTests<Album>
    {

        public override MultiResourceRestInterface<Album> GetInterface() =>
            Client.Albums();

        public override Album CreatePostData() =>
            new Album() { Title = "Foo" };

    }

}
