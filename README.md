# An example to use Clean Architecture with C# using vscode + .NET CLI

## Steps to create the folders structure

Reference: [https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln)

- Solution: New Solution `dotnet new sln -n SocialMedia`
- Web API: New webapi project inside the solution `dotnet new webapi -o SocialMedia.Api`
- Core: New class library project `dotnet new classlib -o SocialMedia.Core`
- Infraestructure: New class library project `dotnet new classlib -o SocialMedia.Infraestructure`
- Add webapi project to the solution `dotnet sln SocialMedia.sln add SocialMedia.Api/SocialMedia.Api.csproj`
- Add webapi project to the solution `dotnet sln SocialMedia.sln add SocialMedia.Core/SocialMedia.Core.csproj`
- Add webapi project to the solution `dotnet sln SocialMedia.sln add SocialMedia.Infraestructure/SocialMedia.Infraestructure.csproj`

## How to Reference the Projects

- SocialMedia.Api project
  - Add SocialMedia.Core reference: `dotnet add SocialMedia.Api/SocialMedia.Api.csproj reference SocialMedia.Core/SocialMedia.Core.csproj`
  - Add SocialMedia.Infraestructure reference:`dotnet add SocialMedia.Api/SocialMedia.Api.csproj reference SocialMedia.Infraestructure/SocialMedia.Infraestructure.csproj`
- SocialMedia.Infraestructure
  - Add SocialMedia.Core reference: `dotnet add SocialMedia.Infraestructure/SocialMedia.Infraestructure.csproj reference SocialMedia.Core/SocialMedia.Core.csproj`

## How to Add Test Solution

I recommend to use `vscode-solution-explorer` extension over vscode to show **Tests** solution folder.

- xUnit Solution: New xunit project `dotnet new xunit -o SocialMedia.UnitTests`
- Add project to solution folder `dotnet sln SocialMedia.sln add SocialMedia.UnitTests/SocialMedia.UnitTests.csproj --solution-folder Tests`
- xUnit Solution: New xunit project `dotnet new xunit -o SocialMedia.IntegrationTests`
- Add project to solution folder `dotnet sln SocialMedia.sln add SocialMedia.IntegrationTests/SocialMedia.IntegrationTests.csproj --solution-folder Tests`
