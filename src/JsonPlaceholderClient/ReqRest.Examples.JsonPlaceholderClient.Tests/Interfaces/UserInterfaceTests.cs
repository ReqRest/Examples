namespace IntegrationTests.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;

    public class UserInterfaceTests : SingleResourceRestInterfaceTests<User>
    {

        public override SingleResourceRestInterface<User> GetInterface(int id) =>
            Client.Users(id);

        public override (User NewResource, User Expected) CreatePutData(int id)
        {
            var newResource = new User()
            {
                Id = 123456,
                Name = "Foo",
            };

            var expected = new User()
            {
                Id = id, // JSON Placeholder doesn't allow overwriting the ID.
                Name = "Foo",
            };

            return (newResource, expected);
        }

        public override (User NewResource, User Expected) CreatePatchData(int id)
        {
            var user = new User()
            {
                Id = 123456, // The ID actually gets overwritten.
                Name = "Foo",
            };
            return (user, user);
        }
    }

}
