FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["LojaManoel.API/LojaManoel.API.csproj", "LojaManoel.API/"]
RUN dotnet restore "LojaManoel.API/LojaManoel.API.csproj" --use-current-runtime
COPY . .
WORKDIR "/src/LojaManoel.API"
RUN dotnet build "LojaManoel.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LojaManoel.API.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LojaManoel.API.dll"]