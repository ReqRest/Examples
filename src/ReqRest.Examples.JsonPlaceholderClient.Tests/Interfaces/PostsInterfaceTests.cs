namespace IntegrationTests.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;

    public class PostsInterfaceTests : MultiResourceRestInterfaceTests<Post>
    {

        public override MultiResourceRestInterface<Post> GetInterface() =>
            Client.Posts();

        public override Post CreatePostData() =>
            new Post() { Title = "Foo" };

    }

}
