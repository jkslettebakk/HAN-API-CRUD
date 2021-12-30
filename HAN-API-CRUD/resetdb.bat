dotnet ef migrations remove --force
dotnet ef database drop
dotnet ef migrations add InitialEF
dotnet ef database update
