FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["KaydenMiller.TableTop.LootTableGenerator.Site/KaydenMiller.TableTop.LootTableGenerator.Site.csproj", "KaydenMiller.TableTop.LootTableGenerator.Site/"]
RUN dotnet restore "KaydenMiller.TableTop.LootTableGenerator.Site/KaydenMiller.TableTop.LootTableGenerator.Site.csproj"
COPY . .
WORKDIR "/src/KaydenMiller.TableTop.LootTableGenerator.Site"
RUN dotnet build "KaydenMiller.TableTop.LootTableGenerator.Site.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KaydenMiller.TableTop.LootTableGenerator.Site.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KaydenMiller.TableTop.LootTableGenerator.Site.dll"]
