namespace ReqRest.Examples.JsonPlaceholderClient.Model
{
    using Newtonsoft.Json;

    /// <summary>
    ///     Represents a comment made in response to a post.
    /// </summary>
    public class Comment
    {

        /// <summary>
        ///     Gets or sets the comment's ID.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///     Gets or sets the ID of the post to which this comment belongs.
        /// </summary>
        [JsonProperty("postId")]
        public int? PostId { get; set; }

        /// <summary>
        ///     Gets or sets the comments's name.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Gets or sets the E-Mail address of the user who made the comment.
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        ///     Gets or sets the comment's body (or content).
        /// </summary>
        [JsonProperty("body")]
        public string? Body { get; set; }

    }

}
