namespace ReqRest.Examples.JsonPlaceholderClient.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;

    /// <summary>
    ///     Defines requests which can be made against the "/todos" interface of the
    ///     JSON Placeholder API.
    /// </summary>
    public sealed class TodosInterface : MultiResourceRestInterface<TodoItem>
    {

        internal TodosInterface(JsonPlaceholderClient restClient, IUrlProvider? baseUrlProvider = null)
            : base("todos", restClient, baseUrlProvider) { }

    }

}
