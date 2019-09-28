using ReqRest.Examples.JsonPlaceholderClient.Model;

namespace ReqRest.Examples.JsonPlaceholderClient.Interfaces
{

    /// <summary>
    ///     Defines requests which can be made against the "/comments" interface of the
    ///     JSON Placeholder API.
    /// </summary>
    public sealed class CommentsInterface : MultiResourceRestInterface<Comment>
    {

        internal CommentsInterface(RestClient restClient, IUrlProvider? baseUrlProvider = null)
            : base("comments", restClient, baseUrlProvider) { }

    }

}
