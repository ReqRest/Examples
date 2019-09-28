namespace ReqRest.Examples.JsonPlaceholderClient.Model
{
    using Newtonsoft.Json;

    /// <summary>
    ///     Represents an album belonging to a user.
    /// </summary>
    public class Album
    {

        /// <summary>
        ///     Gets or sets the album's ID.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///     Gets or sets the ID of user to which the album belongs.
        /// </summary>
        [JsonProperty("userId")]
        public int? UserId { get; set; }

        /// <summary>
        ///     Gets or sets the album's title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

    }

}
