namespace ReqRest.Examples.JsonPlaceholderClient.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;

    /// <summary>
    ///     Defines requests which can be made against the "/todos/{id}" interface of the
    ///     JSON Placeholder API.
    /// </summary>
    public sealed class TodoInterface : SingleResourceRestInterface<TodoItem>
    {

        internal TodoInterface(int id, JsonPlaceholderClient restClient, IUrlProvider? baseUrlProvider = null) 
            : base("todos", id, restClient, baseUrlProvider) { }

    }

}
