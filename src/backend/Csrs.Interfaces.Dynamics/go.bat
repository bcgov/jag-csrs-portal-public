@echo off

echo Updating meta data
set NODE_OPTIONS=--max-old-space-size=16384
dotnet run -p ..\OData.OpenAPI\odata2openapi\odata2openapi.csproj adoxio generatePaths
dotnet run -p ..\OData.OpenAPI\odata2openapi\odata2openapi.csproj adoxio 
echo Updating client

autorest --legacy --debug --verbose Readme.md