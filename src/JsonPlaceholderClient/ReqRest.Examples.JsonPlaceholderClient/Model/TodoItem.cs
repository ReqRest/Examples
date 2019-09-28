namespace ReqRest.Examples.JsonPlaceholderClient.Model
{
    using Newtonsoft.Json;

    /// <summary>
    ///     Represents a todo item belonging to a user.
    /// </summary>
    public class TodoItem
    {

        /// <summary>
        ///     Gets or sets the item's ID.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///     Gets or sets the ID of the user to which this item belongs.
        /// </summary>
        [JsonProperty("userId")]
        public int? UserId { get; set; }

        /// <summary>
        ///     Gets or sets the item's title, i.e. the task to be done.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the item has already been completed.
        /// </summary>
        [JsonProperty("completed")]
        public bool? Completed { get; set; }

    }

}
