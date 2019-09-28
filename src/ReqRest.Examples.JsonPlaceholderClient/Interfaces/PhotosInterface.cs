using ReqRest.Examples.JsonPlaceholderClient.Model;

namespace ReqRest.Examples.JsonPlaceholderClient.Interfaces
{

    /// <summary>
    ///     Defines requests which can be made against the "/photos" interface of the
    ///     JSON Placeholder API.
    /// </summary>
    public sealed class PhotosInterface : MultiResourceRestInterface<Photo>
    {

        internal PhotosInterface(RestClient restClient, IUrlProvider? baseUrlProvider = null)
            : base("photos", restClient, baseUrlProvider) { }

    }

}
