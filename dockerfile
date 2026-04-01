FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app

COPY . .

RUN dotnet restore
RUN dotnet publish -c Release -o out

EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

CMD ["dotnet", "out/dotnet-docker-demo.dll"]
