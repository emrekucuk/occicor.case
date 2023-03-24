# Occicor Case Project

## Migration

```sh
cd Infastructure
dotnet-ef migrations add MigrationName -s ../WebApi
dotnet-ef database update -s ../WebApi
```

## Run Project

```sh
cd WebApi
dotnet run
```

## Url

- Swagger Url : url/swagger