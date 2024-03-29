[![.NET](https://github.com/nogibjj/live-coding-csharp/actions/workflows/main.yml/badge.svg)](https://github.com/nogibjj/live-coding-csharp/actions/workflows/main.yml)

# live-coding-csharp (Can use as a GitHub Codespaces Template for .NET 7)

### Lesson 5:  Build another CLI tool but with multiple source code files

* expand beyond just `Program.cs`


### Lesson 4:  Build more CLI!!!!

Run it!

```csharp
Pineapple
@noahgift ➜ /workspaces/csharp-template/randomfruit (main ✗) $ dotnet run -- --count 5
Banana
Pineapple
Pear
Pineapple
Orange
```


1. `mkdir randomfruit && cd randomfruit`
2. `dotnet new console --framework net7.0`
3. `dotnet add package System.CommandLine --version 2.0.0-beta4.22272.1`


* add linter! (added via `make install`)

* To run a previous project at a root level just pass in the --project flag
```bash
dotnet run --project MarcoPolo -- MarcoPolo --name Marco
```

#### Reference

* `dotnet` linter:  [https://dev.to/srmagura/c-linting-and-formatting-tools-in-2021-bna](https://dev.to/srmagura/c-linting-and-formatting-tools-in-2021-bna)


### Lesson 3: (Keep build with System.CommandLine)


`dotnet run -- MarcoPolo --name Marco`

### Lesson 2:  Create Command-line tools for .NET

* [Official Repo for System.CommandLine](https://github.com/dotnet/command-line-api)
* [System.CommandLine docs](https://learn.microsoft.com/en-us/dotnet/standard/commandline/get-started-tutorial)

1. `mkdir <myproject> && cd <myproject>`
2. `dotnet new console --framework net7.0`
3. `dotnet add package System.CommandLine --prerelease`
4. `dotnet build`
5. `dotnet run -- --help`
6. `dotnet run -- --repeat 5 --phrase apple`

Surprise this actually works with .NET 7!
`@noahgift ➜ /workspaces/csharp-template/SystemCommandLineDemo (main ✗) $ dotnet run -- --help`

### Lesson 1:  Setup Blazor .NET7

[Followed guide here](https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/install)
1. `dotnet new blazorserver -o BlazorApp --no-https -f net7.0`
2. `cd BlazorApp`

Second example console app:

`mkdir app && cd app`
`dotnet new console --framework net7.0`
`dotnet add package System.CommandLine --prerelease`


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
