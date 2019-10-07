namespace ReqRest.Examples.JsonPlaceholderClient.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;

    /// <summary>
    ///     Defines requests which can be made against the "/posts" interface of the
    ///     JSON Placeholder API.
    /// </summary>
    public sealed class PostsInterface : MultiResourceRestInterface<Post>
    {

        internal PostsInterface(JsonPlaceholderClient restClient, IUrlProvider? baseUrlProvider = null)
            : base("posts", restClient, baseUrlProvider) { }

    }

}
