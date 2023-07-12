FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env-des


WORKDIR /app


EXPOSE 83

COPY *.csproj .
RUN dotnet restore


COPY . .

RUN dotnet build --configuration Release --no-restore

RUN dotnet publish -c Release --no-build --output /app/publish


FROM mcr.microsoft.com/dotnet/aspnet:6.0

WORKDIR /app


COPY --from=build-env-des /app/publish .


ENTRYPOINT ["dotnet", "ApiGateway.dll"]