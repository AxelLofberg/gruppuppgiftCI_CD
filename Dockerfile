# Använd ett .NET Core SDK-baserat image för att bygga och testa
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Kopiera allt från projektet till arbetskatalogen
COPY . .

# Bygg applikationen
RUN dotnet build -c Release

# Kör xUnit-tester
RUN dotnet test

# Ange arbetskatalogen för att köra applikationen
WORKDIR /app/bin/Release/net8.0

# Ange entrypoint för att köra applikationen
CMD ["dotnet", "gruppuppgiftCI_CD.dll"]
