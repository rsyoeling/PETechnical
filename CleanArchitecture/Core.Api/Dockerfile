#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Core.Api.csproj", "."]
RUN dotnet restore "./Core.Api.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Core.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Core.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Core.Api.dll"]