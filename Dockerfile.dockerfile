From mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /publish

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine3.9
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet","DotNetCoreDockerExample.dll"]