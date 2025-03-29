# Estágio de build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-stage

WORKDIR /src
COPY . .
RUN dotnet restore --project MapShare.AppHost/MapShare.AppHost.csproj --disable-parallel
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0

WORKDIR /app
COPY --from=build-stage /app/publish ./

EXPOSE 8080
ENTRYPOINT [ "dotnet", "MapShare.AppHost.dll" ]
