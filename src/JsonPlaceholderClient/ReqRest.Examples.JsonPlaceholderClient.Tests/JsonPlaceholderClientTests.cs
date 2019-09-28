namespace IntegrationTests
{
    using ReqRest.Examples.JsonPlaceholderClient;

    /// <summary>
    ///     A base class for test classes that require a <see cref="JsonPlaceholderClient"/> instance.
    /// </summary>
    public abstract class JsonPlaceholderClientTests
    {

        /// <summary>
        ///     Gets a <see cref="JsonPlaceholderClient"/> instance which can be used for the tests.
        /// </summary>
        public JsonPlaceholderClient Client { get; } = new JsonPlaceholderClient();

    }

}
