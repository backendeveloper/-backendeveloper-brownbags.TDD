# brownbags.TDD Sample

# User Story

As a journey service, i should list all journeys
  - Given there is no journey then return information about non existence
  - Given there exists any journeys then return them
  
# Tech

* [.NET 5.0] - .NET is a free, cross-platform, open-source developer platform for building many different types of applications
* [xunit] - Free, open source, community-focused unit testing tool for the .NET Framework
* [moq] - The most popular and friendly mocking library for .NET
* [FluentAssertions] - A very extensive set of extension methods that allow you to more naturally specify the expected outcome of a TDD or BDD-style unit tests
* [Docker] - We help developers and development teams build and ship apps
* [Resharper] - The Visual Studio Extension for .NET Developers

[.NET 5.0]: <https://devblogs.microsoft.com/dotnet/introducing-net-5/>
   [xunit]: <https://xunit.net/>
   [moq]: <https://github.com/moq/moq4>
   [FluentAssertions]: <https://fluentassertions.com/>
   [Docker]: <https://www.docker.com/>
   [Resharper]: <https://www.jetbrains.com/resharper/>
   [d1]: <https://dotnet.microsoft.com/download>
   [d2]: <https://code.visualstudio.com/>
   [d3]: <https://www.docker.com/products/docker-desktop>
   
# Installation

* .NET 5.0 [Download][D1]
* Any Ide (Optional: Visual Studio Code) [Download][D2]
* Any SQL Server Database

### Optional Installation
* Local SQL Server Database Docker:
    * Docker for Windows [Download][d3]

```sh
$ docker pull backendeveloper/local-mssql-server-db
```
Listing images and check Docker DB:
```sh
$ docker images
```

Running docker image:
```sh
$ docker run sql-server-db -d
```

Running docker check:
```sh
$ docker ps
```

Create Database:
```sh
$ docker exec -it sql-server-db "bash"
$ /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P super_duper_password
1> create database dbo
2> go
```

Check Database:
```sh
1> select name from sys.Databases
2> go
```

Create Table:
```sh
1> use dbo
2> go
1> create table journey (id INT)
2> go
```

and then running local DB!

----
License
MIT
