# CluedIn.Enricher.AIAgent

CluedIn External Search for AI

------

## Overview

This repository contains the code and associated tests for enriching with images based of Entities and Clues that have set a value for a vocabulary. 

## Usage

### NuGet Packages

To use the `AI` External Search with the `CluedIn` server you will have to add the CluedIn.Enricher.AI nuget package to your environment.

### Running Tests

A mocked environment is required to run `integration` and `acceptance` tests. The mocked environment can be built and run using the following [Docker](https://www.docker.com/) command:

```Shell
docker-compose up --build -d
```

Use the following commands to run all `Unit` and `Integration` tests within the repository:

```Shell
dotnet test .\ExternalSearch.AIAgent.sln --filter Unit
dotnet test .\ExternalSearch.AIAgent.sln --filter Integration
```

To run [Pester](https://github.com/pester/Pester) `acceptance` tests

```PowerShell
invoke-pester
```

To review the [WireMock](http://wiremock.org/) HTTP proxy logs

```Shell
docker-compose logs wiremock
```

### Tooling

- [Docker](https://www.docker.com/)
- [Pester](https://github.com/pester/Pester)
- [WireMock](http://wiremock.org/)
