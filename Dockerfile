#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY *.sln .


COPY ["Dockita/Dockita.csproj", "Dockita/"]
RUN dotnet restore "Dockita/Dockita.csproj"
COPY . .

WORKDIR /src/Dockita
RUN dotnet build

FROM build AS publish
WORKDIR /src/Dockita
RUN dotnet publish -c Release -o /src/publish


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
