# How to use this code

From PowerShell, apply EF migrations to your database with the following command:

```
cd ./GqlDemo.Server

dotnet ef database update
```

The `data-seed.sql` file contains a SQL script to populate your database with some dummy data. Feel free to run it with your tool of choice.