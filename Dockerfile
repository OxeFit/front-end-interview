FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS prepare
WORKDIR src
COPY api/PounceFitness.Api.sln api/
COPY api/PounceFitness.Api/PounceFitness.Api.csproj api/PounceFitness.Api/PounceFitness.Api.csproj
RUN dotnet restore -f api/PounceFitness.Api/PounceFitness.Api.csproj

FROM prepare AS build
COPY api/ api/
RUN dotnet build api/PounceFitness.Api.sln

FROM build AS publish
RUN dotnet publish --no-build --no-restore -o out api/PounceFitness.Api/PounceFitness.Api.csproj

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS run
WORKDIR app
EXPOSE 80
COPY --from=publish /src/out/ .
ENTRYPOINT ["dotnet", "PounceFitness.Api.dll"]