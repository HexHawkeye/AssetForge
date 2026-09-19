FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore AssetForge.sln && dotnet publish AssetForge.Web/AssetForge.Web.csproj -c Release -o /app --no-restore
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app .
RUN mkdir -p /data
ENV ASPNETCORE_URLS=http://+:8080 ConnectionStrings__AssetForge="Data Source=/data/assetforge.db"
EXPOSE 8080
ENTRYPOINT ["dotnet","AssetForge.Web.dll"]
