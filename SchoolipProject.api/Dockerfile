# Base image for runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Build image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["./SchoolipProject.api/SchoolipProject.api.csproj", "SchoolipProject.api/"]
COPY ["./SchoolipProject.Core/SchoolipProject.Core.csproj", "SchoolipProject.Core/"]
COPY ["./SchoolipProject.Data/SchoolipProject.Data.csproj", "SchoolipProject.Data/"]
COPY ["./SchoolipProject.Infrastructure/SchoolipProject.Infrastructure.csproj", "SchoolipProject.Infrastructure/"]
COPY ["./SchoolipProject.Service/SchoolipProject.Service.csproj", "SchoolipProject.Service/"]
RUN dotnet restore "SchoolipProject.api/SchoolipProject.api.csproj"
COPY . .
WORKDIR "/src/SchoolipProject.api"
RUN dotnet build "SchoolipProject.api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish image
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "SchoolipProject.api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SchoolipProject.api.dll"]
