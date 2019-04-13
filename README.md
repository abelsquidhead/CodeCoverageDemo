# Code Coverage Demo
This repo holds the code sample for my [blog post](https://abelsquidhead.com/index.php/2019/04/13/getting-code-coverage-info-for-a-net-core-app-in-azure-pipelines/) where I used to demonstrate how to collect code coverage info for a .net core app in Azure Pipelines. 

Included are
* asp.net core web app - CodeCoverageDemo.Web
* ms test project - CodeCoverageDemo.MSTest.Tests
* yml build file - azure-pipelines.yml

The azure-pipelines.yml defines a build definition for Azure Pipelines that does the following
* restores projects
* builds projects
* runs unit tests and calculates code coverage
* Generate code coverage reports
* publish thest results and coverage info
* bundle everything needed as a build artifact, ready for a release pileine
* publish build artifacts back to Azure Pipelines


