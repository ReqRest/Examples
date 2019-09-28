namespace ReqRest.Examples.JsonPlaceholderClient.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;

    /// <summary>
    ///     Defines requests which can be made against the "/posts/{id}" interface of the
    ///     JSON Placeholder API.
    /// </summary>
    public sealed class PostInterface : SingleResourceRestInterface<Post>
    {

        internal PostInterface(int id, JsonPlaceholderClient restClient, IUrlProvider? baseUrlProvider = null)
            : base("posts", id, restClient, baseUrlProvider) { }

        /// <summary>
        ///     Allows you to access the <see cref="Comment"/> resources belonging to the current post.
        /// </summary>
        public CommentsInterface Comments() =>
            new CommentsInterface(Client, this);

    }

}
