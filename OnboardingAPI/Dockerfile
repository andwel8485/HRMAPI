#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
ENV OnboardingDB="Server=host.docker.internal,1433; Database=OnboardingDB; User Id=sa; Password=#Wmafs6119107; TrustServerCertificate=true"
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OnboardingAPI/OnboardingAPI.csproj", "OnboardingAPI/"]
COPY ["Onboarding.Infrastructure/Onboarding.Infrastructure.csproj", "Onboarding.Infrastructure/"]
COPY ["Onboarding.ApplicationCore/Onboarding.ApplicationCore.csproj", "Onboarding.ApplicationCore/"]
RUN dotnet restore "OnboardingAPI/OnboardingAPI.csproj"
COPY . .
WORKDIR "/src/OnboardingAPI"
RUN dotnet build "OnboardingAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnboardingAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnboardingAPI.dll"]
