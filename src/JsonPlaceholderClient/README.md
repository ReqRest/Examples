# JsonPlaceholderClient [![Nuget](https://img.shields.io/nuget/v/ReqRest.Examples.JsonPlaceholderClient)](https://www.nuget.org/packages/ReqRest.Examples.JsonPlaceholderClient)

This example project shows how ReqRest can be used to build a fully fledged API client.

The final client is able to interact with all resources provided by the [JSON Placeholder](https://jsonplaceholder.typicode.com/)
API created by [typicode](https://github.com/typicode) and thus supports interacting with the following
endpoints:

* `/todos`
* `/todos/{id}`
* `/posts`
* `/posts/{id}`
* `/posts/{id}/comments`
* `/comments`
* `/comments/{id}`
* `/albums`
* `/albums/{id}`
* `/albums/{id}/photos`
* `/photos`
* `/photos/{id}`
* `/users`
* `/users/{id}`
* `/users/{id}/todos`
* `/users/{id}/posts`
* `/users/{id}/albums`

This project is also published on [NuGet](https://www.nuget.org/packages/ReqRest.Examples.JsonPlaceholderClient)
and can be downloaded and used for learning how to use API clients written with the help of ReqRest.
In fact, the [Getting Started](https://reqrest.github.io/articles/getting-started) guide uses this
client for teaching purposes.


## Using the Code

The client can be used like any other API client written with ReqRest. Please have a look at the
[Getting Started guides](https://reqrest.github.io/articles/getting-started) to learn how ReqRest
works.

Nontheless, the client allows access to the endpoints listed above via the following methods:

```csharp
using ReqRest.Examples.JsonPlaceholderClient;

var client = new JsonPlaceholderClient();

client.Todos();
client.Todos(123);

client.Posts();
client.Posts(123);
client.Posts(123).Comments();

client.Comments();
client.Comments(123);

client.Albums();
client.Albums(123);
client.Albums(123).Photos();

client.Photos();
client.Photos(123);

client.Users();
client.Users(123);
client.Users(123).Todos();
client.Users(123).Posts();
client.Users(123).Albums();
```


## Understanding the Code

> :information: **Note:**
> This project is supposed to show the best practices when using ReqRest. Keep this in mind when
> look at the source code. At some places, especially in the `/Interfaces` folder, the required
> amount of code could be reduced by quite a lot.
> It would, however, be harder to understand when getting started with ReqRest, hence it is written
> the way it is.

Before having a look at the client's code, be sure that you have gone through the [Getting Started guides](https://reqrest.github.io/articles/getting-started).
These guides explain in detail how ReqRest's core features works. Understanding these makes most
of the code in this project trivial to understand.

In addition, the entire code is documented via XML comments. These should, ideally, provide enough
details about why an implementation was done the way it is.

A good way to get started with the code is to look at the following files, in order:

* `JsonPlaceholderClient.cs` <br/>
  _Lists all the available interfaces and shows how a `RestClientConfiguration` is ideally used.`_
* `Interfaces/SingleResourceRestInterface.cs` <br/>
  _Defines all possible requests against interfaces with an ID in the URL, e.g. `/todos/123`._
* `Interfaces/MultiResourceRestInterface.cs` <br/>
  _Defines all possible requests against interfaces without an ID in the URL, e.g. `/todos`._
* `Interfaces/UserInterface.cs` <br/>
  _Shows how you can define nested interfaces like `/users/123/todos`._

You may also want to have a look at the integration tests project, but this is optional.
