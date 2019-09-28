namespace ReqRest.Examples.JsonPlaceholderClient.Interfaces
{
    using ReqRest.Examples.JsonPlaceholderClient.Model;

    /// <summary>
    ///     Defines requests which can be made against the "/albums/{id}" interface of the
    ///     JSON Placeholder API.
    /// </summary>
    public sealed class AlbumInterface : SingleResourceRestInterface<Album>
    {

        internal AlbumInterface(int id, JsonPlaceholderClient restClient, IUrlProvider? baseUrlProvider = null)
            : base("albums", id, restClient, baseUrlProvider) { }

        /// <summary>
        ///     Allows you to access the <see cref="Photo"/> resources belonging to the current album.
        /// </summary>
        public PhotosInterface Photos() =>
            new PhotosInterface(Client, this);

    }

}
