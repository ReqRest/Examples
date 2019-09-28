namespace ReqRest.Examples.JsonPlaceholderClient.Model
{
    using Newtonsoft.Json;

    /// <summary>
    ///     Represents a user.
    /// </summary>
    public class User
    {

        /// <summary>
        ///     Gets or sets the user's ID.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///     Gets or sets the user's name.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Gets or sets the user's display name.
        /// </summary>
        [JsonProperty("username")]
        public string? UserName { get; set; }

        /// <summary>
        ///     Gets or sets the user's E-Mail address.
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        ///     Gets or sets the user's address.
        /// </summary>
        [JsonProperty("address")]
        public Address? Address { get; set; }

        /// <summary>
        ///     Gets or sets the user's phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        ///     Gets or sets a link to the user's web site.
        /// </summary>
        [JsonProperty("website")]
        public string? WebSite { get; set; }

        /// <summary>
        ///     Gets or sets the user's company.
        /// </summary>
        [JsonProperty("company")]
        public Company? Company { get; set; }

    }

    /// <summary>
    ///     Represents an address.
    /// </summary>
    public class Address
    {

        /// <summary>
        ///     Gets or sets the street.
        /// </summary>
        [JsonProperty("street")]
        public string? Street { get; set; }

        /// <summary>
        ///     Gets or sets the suite.
        /// </summary>
        [JsonProperty("suite")]
        public string? Suite { get; set; }

        /// <summary>
        ///     Gets or sets the city.
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        ///     Gets or sets the zip code.
        /// </summary>
        [JsonProperty("zipcode")]
        public string? ZipCode { get; set; }

        /// <summary>
        ///     Gets or sets the geographical location.
        /// </summary>
        [JsonProperty("geo")]
        public Location? Geo { get; set; }

    }

    /// <summary>
    ///     Defines a location on a world map.
    /// </summary>
    public class Location
    {

        /// <summary>
        ///     Gets or sets the latitude.
        /// </summary>
        [JsonProperty("lat")]
        public string? Lat { get; set; }

        /// <summary>
        ///     Gets or sets the longitude.
        /// </summary>
        [JsonProperty("lng")]
        public string? Lng { get; set; }

    }

    /// <summary>
    ///     Defines information about a company.
    /// </summary>
    public class Company
    {

        /// <summary>
        ///     Gets or sets the company's name.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Gets or sets the company's catch phrase.
        /// </summary>
        [JsonProperty("catchPhrase")]
        public string? CatchPhrase { get; set; }

        // What does this even mean? Not a native english speaker, sorry...
        [JsonProperty("bs")]
        public string? Bs { get; set; }

    }

}
