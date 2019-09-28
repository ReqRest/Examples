namespace ReqRest.Examples.JsonPlaceholderClient.Interfaces
{
    using ReqRest.Builders;
    using ReqRest.Serializers.NewtonsoftJson;
    using ReqRest.Http;
    using System;

    /// <summary>
    ///     An abstract base class extending <see cref="RestInterface"/> which defines the
    ///     requests that can be made against every single JSON Placeholder endpoint which
    ///     interacts with a single resource, e.g. the "/todos/{id}" or "/comments/{id}" endpoints.
    ///     
    ///     All of these endpoints support the GET, PUT, PATCH and DELETE methods.
    ///     Furthermore, these endpoints all behave the same, i.e. they return the same resource
    ///     format and status codes.
    ///     This means that there is no reason to re-implement these separately for each resource.
    ///     Instead, the functionality can simply be extracted into this base class which ultimately
    ///     means a lot less code to write.
    /// </summary>
    /// <typeparam name="T">
    ///     The resource which is accessed by the interface.
    /// </typeparam>
    public abstract class SingleResourceRestInterface<T> : RestInterface
        where T : class
    {

        private readonly string _interfaceName;
        private readonly int _id;

        /// <summary>
        ///     Initializes a new instance of the <see cref="SingleResourceRestInterface{T}"/> class.
        /// </summary>
        /// <param name="interfaceName">
        ///     The name of the interface itself which should get appended to the URL.
        ///     For "/todos/123", this should be "todos".
        /// </param>
        /// <param name="id">
        ///     The ID of the resource being accessed.
        ///     For "/todos/123", this should be "123".
        /// </param>
        /// <param name="restClient">
        ///     The <see cref="RestClient"/> which ultimately manages this interface.
        /// </param>
        /// <param name="baseUrlProvider">
        ///     An <see cref="IUrlProvider"/> which is the logical parent of this interface.
        ///     The URL which is provided by this <see cref="IUrlProvider"/> is used as this 
        ///     interface's URL. If <see langword="null"/>, the <paramref name="restClient"/> is
        ///     used instead.
        /// </param>
        internal SingleResourceRestInterface(
            string interfaceName, 
            int id, 
            JsonPlaceholderClient restClient, 
            IUrlProvider? baseUrlProvider = null)
            : base(restClient, baseUrlProvider)
        {
            _interfaceName = interfaceName ?? throw new ArgumentNullException(nameof(interfaceName));
            _id = id;
        }

        /// <summary>
        ///     Enhances the specified <paramref name="baseUrl"/> with the interface name and
        ///     ID specified in the constructor.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        protected sealed override UrlBuilder BuildUrl(UrlBuilder baseUrl) =>
            baseUrl / _interfaceName / $"{_id}";

        /// <summary>
        ///     Creates a GET request for getting the resource.
        /// </summary>
        public ApiRequest<T> Get() =>
            BuildRequest()
                .Get()
                .Receive<T>().AsJson(StatusCode.Ok);

        /// <summary>
        ///     Creates a PUT request for replacing the resource with a new one.
        /// </summary>
        /// <param name="newResource">
        ///     The new resource with which the existing one should be replaced.
        /// </param>
        public ApiRequest<T> Put(T? newResource) =>
            BuildRequest()
                .PutJson(newResource)
                .Receive<T>().AsJson(StatusCode.Ok);

        /// <summary>
        ///     Creates a PATCH request for replacing a selected set of the resource's values.
        /// </summary>
        /// <param name="newValues">
        ///     The new values with which the resource's existing values should be replaced.
        /// </param>
        public ApiRequest<T> Patch(T? newValues) =>
            BuildRequest()
                .PatchJson(newValues)
                .Receive<T>().AsJson(StatusCode.Ok);

        /// <summary>
        ///     Creates a DELETE request for removing deleting the resource.
        /// </summary>
        public ApiRequest<NoContent> Delete() =>
            BuildRequest()
                .Delete()
                .ReceiveNoContent(StatusCode.Ok, StatusCode.NoContent);

    }

}
