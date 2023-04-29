#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
ENV AuthenticationDB="Server=host.docker.internal,1433; Database=AuthenticationDB; User Id=sa; Password=#Wmafs6119107; TrustServerCertificate=true"

EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AuthenticationAPI/AuthenticationAPI.csproj", "AuthenticationAPI/"]
COPY ["Authentication.ApplicationCore/Authentication.ApplicationCore.csproj", "Authentication.ApplicationCore/"]
COPY ["Authentication.Infrastructure/Authentication.Infrastructure.csproj", "Authentication.Infrastructure/"]
RUN dotnet restore "AuthenticationAPI/AuthenticationAPI.csproj"
COPY . .
WORKDIR "/src/AuthenticationAPI"
RUN dotnet build "AuthenticationAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AuthenticationAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuthenticationAPI.dll"]
