namespace ReqRest.Examples.JsonPlaceholderClient
{
    using System;
    using ReqRest.Examples.JsonPlaceholderClient.Interfaces;
    using ReqRest.Examples.JsonPlaceholderClient.Model;

    /// <summary>
    ///     An API client for the JSON Placeholder REST API which can be found at
    ///     https://jsonplaceholder.typicode.com.
    /// </summary>
    public sealed class JsonPlaceholderClient : RestClient<JsonPlaceholderClientConfiguration>
    {

        private static readonly JsonPlaceholderClientConfiguration DefaultConfiguration = new JsonPlaceholderClientConfiguration()
        {
            BaseUrl = new Uri("https://jsonplaceholder.typicode.com"),
        };

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonPlaceholderClient"/> class.
        /// </summary>
        /// <param name="configuration">
        ///     An optional configuration to be used.
        ///     If this is <see langword="null"/>, a default configuration which accesses the
        ///     https://jsonplaceholder.typicode.com base URL is used instead.
        /// </param>
        public JsonPlaceholderClient(JsonPlaceholderClientConfiguration? configuration = null) 
            : base(configuration ?? DefaultConfiguration) { }

        /// <summary>
        ///     Allows you to access multiple <see cref="TodoItem"/> resources at once or create new ones.
        /// </summary>
        public TodosInterface Todos() =>
            new TodosInterface(this);

        /// <summary>
        ///     Allows you to access a <see cref="TodoItem"/> with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the single <see cref="TodoItem"/> to be accessed.</param>
        public TodoInterface Todos(int id) =>
            new TodoInterface(id, this);

        /// <summary>
        ///     Allows you to access multiple <see cref="Post"/> resources at once or create new ones.
        /// </summary>
        public PostsInterface Posts() =>
            new PostsInterface(this);

        /// <summary>
        ///     Allows you to access a <see cref="Post"/> with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the single <see cref="Post"/> to be accessed.</param>
        public PostInterface Posts(int id) =>
            new PostInterface(id, this);
        
        /// <summary>
        ///     Allows you to access multiple <see cref="Comment"/> resources at once or create new ones.
        /// </summary>
        public CommentsInterface Comments() =>
            new CommentsInterface(this);

        /// <summary>
        ///     Allows you to access a <see cref="Comment"/> with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the single <see cref="Comment"/> to be accessed.</param>
        public CommentInterface Comments(int id) =>
            new CommentInterface(id, this);
        
        /// <summary>
        ///     Allows you to access multiple <see cref="Album"/> resources at once or create new ones.
        /// </summary>
        public AlbumsInterface Albums() =>
            new AlbumsInterface(this);

        /// <summary>
        ///     Allows you to access a <see cref="Album"/> with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the single <see cref="Album"/> to be accessed.</param>
        public AlbumInterface Albums(int id) =>
            new AlbumInterface(id, this);

        /// <summary>
        ///     Allows you to access multiple <see cref="Photo"/> resources at once or create new ones.
        /// </summary>
        public PhotosInterface Photos() =>
            new PhotosInterface(this);

        /// <summary>
        ///     Allows you to access a <see cref="Photo"/> with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the single <see cref="Photo"/> to be accessed.</param>
        public PhotoInterface Photos(int id) =>
            new PhotoInterface(id, this);

        /// <summary>
        ///     Allows you to access multiple <see cref="User"/> resources at once or create new ones.
        /// </summary>
        public UsersInterface Users() =>
            new UsersInterface(this);

        /// <summary>
        ///     Allows you to access a <see cref="User"/> with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the single <see cref="User"/> to be accessed.</param>
        public UserInterface Users(int id) =>
            new UserInterface(id, this);

    }

}
