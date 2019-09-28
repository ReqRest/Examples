namespace ReqRest.Examples.JsonPlaceholderClient.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;

    /// <summary>
    ///     Defines requests which can be made against the "/photos/{id}" interface of the
    ///     JSON Placeholder API.
    /// </summary>
    public sealed class PhotoInterface : SingleResourceRestInterface<Photo>
    {

        internal PhotoInterface(int id, JsonPlaceholderClient restClient, IUrlProvider? baseUrlProvider = null)
            : base("photos", id, restClient, baseUrlProvider) { }

    }

}
