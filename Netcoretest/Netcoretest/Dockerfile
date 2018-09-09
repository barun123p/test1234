FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY Netcoretest/Netcoretest.csproj Netcoretest/
RUN dotnet restore Netcoretest/Netcoretest.csproj
COPY . .
WORKDIR /src/Netcoretest
RUN dotnet build Netcoretest.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Netcoretest.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Netcoretest.dll"]
