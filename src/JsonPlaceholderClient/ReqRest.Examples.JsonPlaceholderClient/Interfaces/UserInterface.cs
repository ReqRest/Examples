namespace ReqRest.Examples.JsonPlaceholderClient.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;

    /// <summary>
    ///     Defines requests which can be made against the "/users/{id}" interface of the
    ///     JSON Placeholder API.
    /// </summary>
    public sealed class UserInterface : SingleResourceRestInterface<User>
    {

        internal UserInterface(int id, JsonPlaceholderClient restClient, IUrlProvider? baseUrlProvider = null)
            : base("users", id, restClient, baseUrlProvider) { }

        /// <summary>
        ///     Allows you to access the <see cref="Album"/> resources belonging to the current user.
        /// </summary>
        public AlbumsInterface Albums() =>
            new AlbumsInterface(Client, this);
        
        /// <summary>
        ///     Allows you to access the <see cref="TodoItem"/> resources belonging to the current user.
        /// </summary>
        public TodosInterface Todos() =>
            new TodosInterface(Client, this);
        
        /// <summary>
        ///     Allows you to access the <see cref="Post"/> resources belonging to the current user.
        /// </summary>
        public PostsInterface Posts() =>
            new PostsInterface(Client, this);

    }

}
