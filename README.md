# core-sqlite-api
core-sqlite-api

Rudras-MacBook-Pro:coreapi rudrasingh$ dotnet ef

                     _/\__       
               ---==/    \\      
         ___  ___   |.    \|\    
        | __|| __|  |  )   \\\   
        | _| | _|   \_/ |  //|\\ 
        |___||_|       /   \\\/\\

Entity Framework Core .NET Command-line Tools 2.1.1-rtm-30846

Usage: dotnet ef [options] [command]

Options:
  --version        Show version information
  -h|--help        Show help information
  -v|--verbose     Show verbose output.
  --no-color       Don't colorize output.
  --prefix-output  Prefix output with level.

Commands:
  database    Commands to manage the database.
  dbcontext   Commands to manage DbContext types.
  migrations  Commands to manage migrations.

Use "dotnet ef [command] --help" for more information about a command.
Rudras-MacBook-Pro:coreapi rudrasingh$ dotnet ef migrations add InitialMigration
info: Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 2.1.1-rtm-30846 initialized 'DataBaseContext' using provider 'Microsoft.EntityFrameworkCore.Sqlite' with options: None
Done. To undo this action, use 'ef migrations remove'
Rudras-MacBook-Pro:coreapi rudrasingh$ dotnet ef database update