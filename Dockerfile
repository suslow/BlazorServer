FROM mcr.microsoft.com/dotnet/aspnet:3.1-focal AS base
WORKDIR /app
EXPOSE 5000


ENV ASPNETCORE_URLS=http://+:5000

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:3.1-focal AS build
WORKDIR /src
COPY ["BlazorServer.csproj", "./"]
RUN dotnet restore "BlazorServer.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "BlazorServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorServer.csproj" -c Release -o /app/publish


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
USER root
RUN apt-get update && apt-get install -y vim

ENTRYPOINT ["dotnet", "BlazorServer.dll"]
