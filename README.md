## Configure
- Install .NET SDK 2.0 `https://dotnet.microsoft.com/en-us/download/dotnet`

- Create a space for a solution
```
mkdir WebsocketClient
cd WebsocketClient
```

- Create a template
```
dotnet new console

# or in case of Unity plugin
dotnet new classlib
```

- Open a solution in Rider and verify that Target Runtime is set to either `netcoreapp2.0` or `netstandard2.0` (in case of classlib),
this can be done by right clicking the solution and opening Properties

- Open nuGet tab on the bottom and install the latest version of `Websocket.Client`

- Release build can be done from a command line
```
dotnet build WebsocketClient.csproj -c Release
```
