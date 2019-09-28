namespace ReqRest.Examples.JsonPlaceholderClient.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;

    /// <summary>
    ///     Defines requests which can be made against the "/comments/{id}" interface of the
    ///     JSON Placeholder API.
    /// </summary>
    public sealed class CommentInterface : SingleResourceRestInterface<Comment>
    {

        internal CommentInterface(int id, JsonPlaceholderClient restClient, IUrlProvider? baseUrlProvider = null)
            : base("comments", id, restClient, baseUrlProvider) { }

    }

}
