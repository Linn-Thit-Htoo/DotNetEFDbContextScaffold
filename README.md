# DotNetEFDbContextScaffold

## notes

### To solve dot net ef not found issue
> dotnet tool install --global dotnet-ef --version 7

### Updating the tools
> dotnet tool update --global dotnet-ef

### .NET CLI
> dotnet ef dbcontext scaffold "Server=.;Database=testDb;User ID=sa;Password=sasa@123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -c AppDbContext
