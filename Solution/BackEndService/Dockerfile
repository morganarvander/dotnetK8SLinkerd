FROM microsoft/dotnet:2.2-sdk
WORKDIR /app
EXPOSE 5000

COPY *.csproj ./
RUN dotnet restore

# copy and build everything else
COPY . ./
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "out/BackEndService.dll"]