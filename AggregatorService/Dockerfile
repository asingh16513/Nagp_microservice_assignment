#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 9002

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["AggregatorService.csproj", ""]
RUN dotnet restore "./AggregatorService.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "AggregatorService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AggregatorService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:9002
ENTRYPOINT ["dotnet", "AggregatorService.dll"]