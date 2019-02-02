FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MA.WebApi/MA.WebApi.csproj", "MA.WebApi/"]
RUN dotnet restore "MA.WebApi/MA.WebApi.csproj"
COPY . .
WORKDIR "/src/MA.WebApi"
RUN dotnet build "MA.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MA.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MA.WebApi.dll"]