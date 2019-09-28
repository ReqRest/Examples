namespace IntegrationTests.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;

    public class UsersInterfaceTests : MultiResourceRestInterfaceTests<User>
    {

        public override MultiResourceRestInterface<User> GetInterface() =>
            Client.Users();

        public override User CreatePostData() =>
            new User() { Name = "Foo" };

    }

}
