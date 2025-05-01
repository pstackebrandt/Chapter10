# Working with EFCore

## Create Northwind SQLite Db

*** Get the db ***
from scripts/sql-scripts/Northwind4SQLite.sql

*** Install the db ***
in WorkingWithEFCore folder:

```ps
sqlite3 Northwind.db -init ../scripts/sql-scripts/Northwind4SQLite.sql

2x ctrl + c (to leave sqlite3)
```

## Manage db in SQLITE Studio

*** Install ***
https://sqlitestudio.pl/

*** Connect db to SQLITE Studio ***
I connected the db as NorthwindCs13net9 because of a older connection "Northwind".

### Create the EF Core DbContext

```ps
dotnet ef dbcontext scaffold "Data Source=northwind.db" Microsoft.EntityFrameworkCore.Sqlite --output-dir Models
```
