namespace ReqRest.Examples.JsonPlaceholderClient.Interfaces
{
    using System;
    using System.Collections.Generic;
    using ReqRest.Builders;
    using ReqRest.Serializers.NewtonsoftJson;
    using ReqRest.Http;

    /// <summary>
    ///     An abstract base class extending <see cref="RestInterface"/> which defines the
    ///     requests that can be made against every single JSON Placeholder endpoint which
    ///     interacts with a multiple resources (or "resource lists"), e.g. the "/todos" or "/comments"
    ///     endpoints.
    ///     
    ///     All of these endpoints support the GET, and POST methods.
    ///     Furthermore, these endpoints all behave the same, i.e. they return the same resource
    ///     format and status codes.
    ///     This means that there is no reason to re-implement these separately for each resource.
    ///     Instead, the functionality can simply be extracted into this base class which ultimately
    ///     means a lot less code to write.
    /// </summary>
    /// <typeparam name="T">
    ///     The resource which is accessed by the interface.
    /// </typeparam>
    public abstract class MultiResourceRestInterface<T> : RestInterface<JsonPlaceholderClient>
        where T : class
    {

        private readonly string _interfaceName;

        /// <summary>
        ///     Initializes a new instance of the <see cref="MultiResourceRestInterface{T}"/> class.
        /// </summary>
        /// <param name="interfaceName">
        ///     The name of the interface itself which should get appended to the URL, e.g. "todos".
        /// </param>
        /// <param name="restClient">
        ///     The <see cref="JsonPlaceholderClient"/> which ultimately manages this interface.
        /// </param>
        /// <param name="baseUrlProvider">
        ///     An <see cref="IUrlProvider"/> which is the logical parent of this interface.
        ///     The URL which is provided by this <see cref="IUrlProvider"/> is used as this 
        ///     interface's URL. If <see langword="null"/>, the <paramref name="restClient"/> is
        ///     used instead.
        /// </param>
        public MultiResourceRestInterface(
            string interfaceName, 
            JsonPlaceholderClient restClient, 
            IUrlProvider? baseUrlProvider = null)
            : base(restClient, baseUrlProvider)
        {
            _interfaceName = interfaceName ?? throw new ArgumentNullException(nameof(interfaceName));
        }

        /// <summary>
        ///     Enhances the specified <paramref name="baseUrl"/> with the interface name
        ///     specified in the constructor.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        protected sealed override UrlBuilder BuildUrl(UrlBuilder baseUrl) =>
            baseUrl / _interfaceName;

        /// <summary>
        ///     Creates a GET request for getting all available resources.
        /// </summary>
        /// <param name="start">
        ///     An optional parameter for filtering the result list.
        ///     If set, the result list starts at this index.
        ///     
        ///     Important: This parameter will have no effect without <paramref name="limit"/> being set.
        /// </param>
        /// <param name="limit">
        ///     An optional parameter for filtering the result list.
        ///     If set, the result list will not contain more items than this value.
        /// </param>
        public ApiRequest<IList<T>> Get(int? start = null, int? limit = null) =>
            BuildRequest()
                .Get()
                .If(start != null, req => req.ConfigureRequestUri(url => url & ("_start", $"{start}"))) 
                .If(limit != null, req => req.ConfigureRequestUri(url => url & ("_limit", $"{limit}"))) 
                .Receive<IList<T>>().AsJson(Client.Configuration.JsonSerializerSettings, StatusCode.Ok);
        // Note: 
        // The .If(...) above is admittedly somewhat ugly.
        // In a larger code base, this would ideally be replaced with an extension method like this:
        //
        // public static T AddQueryParameterIfNotNull<T>(this T builder, string parameterName, object? value)
        //    where T : IRequestUriBuilder
        // {
        //     if (value != null)
        //     {
        //         builder.ConfigureRequestUri(url => url & (parameterName, $"{value}"));
        //     }
        //     return builder;
        // }
        //
        // In this small example library, that's not necessary though, because the construct
        // only appears here.

        /// <summary>
        ///     Creates a POST request for creating the specified <paramref name="resource"/>.
        /// </summary>
        /// <param name="resource">The resource to be created.</param>
        public ApiRequest<T> Post(T? resource) =>
            BuildRequest()
                .PostJson(resource)
                .Receive<T>().AsJson(Client.Configuration.JsonSerializerSettings, StatusCode.Created);

    }

}
