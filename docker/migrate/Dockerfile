# docker/migrate/Dockerfile

FROM mcr.microsoft.com/dotnet/sdk:9.0

WORKDIR /src

# 1) skopiuj cały kod (Infrastructure + Server + Shared)
COPY . .

# 2) zainstaluj EF Core CLI jako globalny tool
RUN dotnet tool install --global dotnet-ef --version 9.0.6

# 3) użyj pełnej ścieżki do dotnet-ef, żeby nie martwić się o PATH
ENTRYPOINT ["/root/.dotnet/tools/dotnet-ef", "database", "update", \
  "--project", "ProductionApp.Infrastructure", \
  "--startup-project", "ProductionApp.Server"]
