namespace ReqRest.Examples.JsonPlaceholderClient.Model
{
    using Newtonsoft.Json;

    /// <summary>
    ///     Represents a photo belonging to an album.
    /// </summary>
    public class Photo
    {

        /// <summary>
        ///     Gets or sets the photo's ID.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///     Gets or sets the ID of album to which the photo belongs.
        /// </summary>
        [JsonProperty("albumId")]
        public int? AlbumId { get; set; }

        /// <summary>
        ///     Gets or sets the photo's title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        ///     Gets or sets an URL to the photo.
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        ///     Gets or sets an URL to the photo's thumbnail.
        /// </summary>
        public string? ThumbnailUrl { get; set; }

    }

}
