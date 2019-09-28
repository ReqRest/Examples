namespace IntegrationTests.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;

    public class CommentsInterfaceTests : MultiResourceRestInterfaceTests<Comment>
    {

        public override MultiResourceRestInterface<Comment> GetInterface() =>
            Client.Comments();

        public override Comment CreatePostData() =>
            new Comment() { Body = "Foo" };

    }

}
