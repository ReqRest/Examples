using ReqRest.Examples.JsonPlaceholderClient.Model;

namespace ReqRest.Examples.JsonPlaceholderClient.Interfaces
{

    /// <summary>
    ///     Defines requests which can be made against the "/users" interface of the
    ///     JSON Placeholder API.
    /// </summary>
    public sealed class UsersInterface : MultiResourceRestInterface<User>
    {

        internal UsersInterface(JsonPlaceholderClient restClient, IUrlProvider? baseUrlProvider = null)
            : base("users", restClient, baseUrlProvider) { }

    }

}
