namespace ReqRest.Examples.JsonPlaceholderClient
{
    using Newtonsoft.Json;

    /// <summary>
    ///     Provides the configurable properties for the <see cref="JsonPlaceholderClient"/> class.
    /// </summary>
    public class JsonPlaceholderClientConfiguration : RestClientConfiguration
    {
        // Properties from this class can be accessed in any RestInterface<JsonPlaceholderClient>.
        // As a result, default or global, configurable values can be defined here and then
        // used in the appropriate places.

        /// <summary>
        ///     Gets or sets a default <see cref="Newtonsoft.Json.JsonSerializerSettings"/> instance which 
        ///     will be used for (de-)serializing objects to and from JSON.
        ///     
        ///     This can be <see langword="null"/>. If so, a default configuration will be used.
        /// </summary>
        public JsonSerializerSettings? JsonSerializerSettings { get; set; }

    }

}
