namespace ReqRest.Examples.JsonPlaceholderClient.Model
{
    using Newtonsoft.Json;

    /// <summary>
    ///     Represents a post made by a user.
    /// </summary>
    public class Post
    {

        /// <summary>
        ///     Gets or sets the post's ID.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///     Gets or sets the ID of the user to which this post belongs.
        /// </summary>
        [JsonProperty("userId")]
        public int? UserId { get; set; }

        /// <summary>
        ///     Gets or sets the post's title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        ///     Gets or sets the post's body (or content).
        /// </summary>
        [JsonProperty("body")]
        public string? Body { get; set; }

    }

}
