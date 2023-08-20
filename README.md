# CodeFirstEFCore
CRUD using Code First

Steps for Making code first

# STEP 1
Install 3 Package in your ASP.NET Core MVC application.
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Design

# STEP 2
Create Model Class
Create DbContext Class

# STEP 3 
Create a Connection String in appsetting.json</br>
 "ConnectionStrings": {</br>
    <&nbsp>"dbcs": "Server=servername;Database=databsaename;Trusted_Connection=true;"</br>
  },


# STEP 4
Registering Connection String in program.cs file

var provider = builder.Services.BuildServiceProvider();</br>
var config = provider.GetRequiredService<IConfiguration> ();</br>
builder.Services.AddDbContext<StudentDBContext>(item => item.UseSqlServer(config.GetConnectionString("dbcs")))

# STEP 5 
Add Migration and Run Migration</br>
Go Tools -> NuGet Package Manager -> Package Manager console</br>
add-migration CodeFirstCreateDB and then Enter</br>
update-database and then Enter
