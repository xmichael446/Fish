FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

WORKDIR ./

COPY . .

RUN dotnet restore

WORKDIR ./Fish
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS runtime
WORKDIR ./
COPY --from=build /Fish/out ./
CMD ["dotnet", "Fish.dll"]