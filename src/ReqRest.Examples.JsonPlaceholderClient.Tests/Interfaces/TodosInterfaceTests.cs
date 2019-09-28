namespace IntegrationTests.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;

    public class TodosInterfaceTests : MultiResourceRestInterfaceTests<TodoItem>
    {

        public override MultiResourceRestInterface<TodoItem> GetInterface() =>
            Client.Todos();

        public override TodoItem CreatePostData() =>
            new TodoItem() { Title = "Foo" };

    }

}
