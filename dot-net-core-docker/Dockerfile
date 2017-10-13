FROM microsoft/aspnetcore-build:2.0.0-jessie as builder
WORKDIR /app
COPY dist ./
ENTRYPOINT ["dotnet", "dot-net-core-docker.dll"]
