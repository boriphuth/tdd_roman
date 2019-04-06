#!/bin/bash
# token="$(cat sonar.txt)"
dir="$(pwd)"
# https://docs.sonarqube.org/display/SONAR/Analysis+Parameters
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=\"opencover,lcov\" /p:CoverletOutput=./lcov calculation.tests/calculation.tests.csproj
dotnet build-server shutdown
dotnet sonarscanner begin /k:"Number" /d:sonar.host.url="http://localhost:9000" /d:sonar.language="cs" /d:sonar.exclusions="**/bin/**/*,**/obj/**/*" /d:sonar.cs.opencover.reportsPaths="${dir}/lcov.opencover.xml"
dotnet build
dotnet sonarscanner 
