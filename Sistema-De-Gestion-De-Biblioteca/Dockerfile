# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/runtime:9.0-bookworm-slim AS base
USER $APP_UID
WORKDIR /app


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:9.0-bookworm-slim AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Sistema-De-Gestion-De-Biblioteca/Sistema-De-Gestion-De-Biblioteca.csproj", "Sistema-De-Gestion-De-Biblioteca/"]
RUN dotnet restore "./Sistema-De-Gestion-De-Biblioteca/Sistema-De-Gestion-De-Biblioteca.csproj"
COPY . .
WORKDIR "/src/Sistema-De-Gestion-De-Biblioteca"
RUN dotnet build "./Sistema-De-Gestion-De-Biblioteca.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Sistema-De-Gestion-De-Biblioteca.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sistema-De-Gestion-De-Biblioteca.dll"]