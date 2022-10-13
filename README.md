Packages used:
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Tools -> for Package Manager Console
- Pomelo.EntityFrameworkCore.MySql -> For Connecting MySql Database & code first migrations

Program.cs
```
var connectionString = builder.Configuration.GetConnectionString("MySqlConnection");
builder.Services.AddDbContext<BlogDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});
```