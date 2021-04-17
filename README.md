To install Razor file compilation run in terminal the follow command: 
    $ dotnet add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation --version 5.0.4 
From website: https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation/

To install Entity Framework Core, run this follow command:
    $ dotnet add package Microsoft.EntityFrameworkCore -v 2.1.14 -> change to 5.0 version to use MYSQL
    $ dotnet add package Microsoft.EntityFrameworkCore.tools -v 2.1.14
    $ dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 2.1.14
    Update Mysql EF version to use MySQL
    $ dotnet add package MySql.EntityFrameworkCore --version 5.0.0+m8.0.23

Migration overview
* Install dotnet-ef: 
    dotnet tool install --global dotnet-ef
- Adding migration: 
    dotnet ef migrations add NewMigragiton
- Creating or Updating Database:
    dotnet ef database update
- Adding new column for schema:
    dotnet ef migrations add TableNameColumnName
- Removing a Migration
    dotnet ef migrations remove
- Reverting a Migration
    dotnet ef database update Migration
- Generating a SQL Script
    dotnet ef migrations script
// Need to add Factory File. References: 
    https://docs.microsoft.com/vi-vn/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli
- Install dotnet add packageMysql.Data.EntityFrameworkCore

- Instal Jquery 
    dotnet add package Microsoft.jQuery.Unobtrusive.Validation --version 3.2.12
    