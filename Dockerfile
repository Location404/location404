FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-stage
WORKDIR /src
COPY . .

RUN dotnet restore src --disable-parallel
RUN dotnet publish src -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-stage /app ./

EXPOSE 8080
ENTRYPOINT [ "dotnet", "MapShare.AppHost.dll" ]