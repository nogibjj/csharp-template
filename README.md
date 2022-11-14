[![.NET](https://github.com/nogibjj/live-coding-csharp/actions/workflows/main.yml/badge.svg)](https://github.com/nogibjj/live-coding-csharp/actions/workflows/main.yml)

# live-coding-csharp (Can use as a GitHub Codespaces Template for .NET 7)

### Lesson 1:  Setup Blazor .NET7

[Followed guide here](https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/install)
1. `dotnet new blazorserver -o BlazorApp --no-https -f net7.0`
2. `cd BlazorApp`

## Setup .devcontainer for .NET7

I followed example config files [here](https://github.com/devcontainers/images/tree/main/src/dotnet)
Used `Dockerfile`:  https://github.com/devcontainers/images/blob/main/src/dotnet/.devcontainer/Dockerfile

## Codespaces and csharp:  Console apps

`dotnet new --list` finds all templates
* Follow Console App Tutorial:  https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0

`mkdir ConsoleHello && mkdir ConsoleHello`
`dotnet new console --framework net6.0`

Day 1 of live coding with C# and .NET

## Blazor Steps

`dotnet new blazorserver -o BlazorApp --no-https -f net6.0`

## Day 2- Follow along with projects and co-pilot

basic stuff and console app

* [numbers tutorial](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp-local)
* [loops](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/branches-and-loops-local)


## References

* [Codespaces dotnet starter kit](https://github.com/codespaces-examples/dotnetcore)
* [Blazor Tutorial](https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/create)
