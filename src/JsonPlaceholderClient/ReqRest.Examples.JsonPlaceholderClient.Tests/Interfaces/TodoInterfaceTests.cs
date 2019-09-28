namespace IntegrationTests.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;

    public class TodoInterfaceTests : SingleResourceRestInterfaceTests<TodoItem>
    {

        public override SingleResourceRestInterface<TodoItem> GetInterface(int id) =>
            Client.Todos(id);

        public override (TodoItem NewResource, TodoItem Expected) CreatePutData(int id)
        {
            var newResource = new TodoItem()
            {
                Id = 123456,
                Title = "Foo",
                UserId = 1,
                Completed = null,
            };

            var expected = new TodoItem()
            {
                Id = id, // JSON Placeholder doesn't allow overwriting the ID.
                Title = "Foo",
                UserId = 1,
                Completed = null,
            };

            return (newResource, expected);
        }

        public override (TodoItem NewResource, TodoItem Expected) CreatePatchData(int id)
        {
            var item = new TodoItem()
            {
                Id = 123456, // The ID actually gets overwritten.
                Title = "Foo",
            };
            return (item, item);
        }
    }

}
