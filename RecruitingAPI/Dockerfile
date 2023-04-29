#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
ENV RecruitingDB="Server=host.docker.internal,1433; Database=RecruitingDB; User Id=sa; Password=#Wmafs6119107; TrustServerCertificate=true"
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RecruitingAPI/RecruitingAPI.csproj", "RecruitingAPI/"]
COPY ["Recruiting.ApplicationCore/Recruiting.ApplicationCore.csproj", "Recruiting.ApplicationCore/"]
COPY ["Recruiting.Infrastructure/Recruiting.Infrastructure.csproj", "Recruiting.Infrastructure/"]
RUN dotnet restore "RecruitingAPI/RecruitingAPI.csproj"
COPY . .
WORKDIR "/src/RecruitingAPI"
RUN dotnet build "RecruitingAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RecruitingAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RecruitingAPI.dll"]
