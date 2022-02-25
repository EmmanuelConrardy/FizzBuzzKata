FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

COPY ["./FizzBuzzKata.Server/FizzBuzzKata.Server.csproj", "src/"]
COPY ["./FizzBuzzKata.Prod/FizzBuzzKata.Prod.csproj", "src/"]

RUN dotnet restore "src/FizzBuzzKata.Server.csproj"

COPY . .
WORKDIR "/src/"

RUN dotnet build "FizzBuzzKata.Server/FizzBuzzKata.Server.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "FizzBuzzKata.Server/FizzBuzzKata.Server.csproj" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ["dotnet", "FizzBuzzKata.Server.dll"]