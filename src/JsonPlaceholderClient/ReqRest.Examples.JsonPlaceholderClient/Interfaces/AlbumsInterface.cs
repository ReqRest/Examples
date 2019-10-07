using ReqRest.Examples.JsonPlaceholderClient.Model;

namespace ReqRest.Examples.JsonPlaceholderClient.Interfaces
{

    /// <summary>
    ///     Defines requests which can be made against the "/albums" interface of the
    ///     JSON Placeholder API.
    /// </summary>
    public sealed class AlbumsInterface : MultiResourceRestInterface<Album>
    {

        internal AlbumsInterface(JsonPlaceholderClient restClient, IUrlProvider? baseUrlProvider = null)
            : base("albums", restClient, baseUrlProvider) { }

    }

}
