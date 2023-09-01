FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["KaydenMiller.TableTob.LootTableGenerator.Site/KaydenMiller.TableTob.LootTableGenerator.Site.csproj", "KaydenMiller.TableTob.LootTableGenerator.Site/"]
RUN dotnet restore "KaydenMiller.TableTob.LootTableGenerator.Site/KaydenMiller.TableTob.LootTableGenerator.Site.csproj"
COPY . .
WORKDIR "/src/KaydenMiller.TableTob.LootTableGenerator.Site"
RUN dotnet build "KaydenMiller.TableTob.LootTableGenerator.Site.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KaydenMiller.TableTob.LootTableGenerator.Site.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KaydenMiller.TableTob.LootTableGenerator.Site.dll"]
