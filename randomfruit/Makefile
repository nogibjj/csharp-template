setup:
	## setup the project and install the dependencies
	dotnet new console --framework net7.0
	dotnet add package System.CommandLine --version 2.0.0-beta4.22272.1

install:
	#install linter
	dotnet tool install dotnet-format --global
format:
	dotnet format

build:
	dotnet build

run:
	dotnet run -- --help