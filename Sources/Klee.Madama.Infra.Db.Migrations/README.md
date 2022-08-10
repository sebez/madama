# Migration

## Presentation

This projects allows to update the Db.

## Requirement
You have to install the Entity Framework dotnet tool before lauching the commands.
To do so, open a terminal and do the following command :
`dotnet tool install --global dotnet-ef`

## Usage

### Prepare a migration

When you develop a User Story with model changes, you shall add a EF core migration ([Documentation](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/managing?tabs=dotnet-core-cli)).

Right click on the migration project > Open in Terminal

`dotnet ef migrations add [Jira-number-What-It-Does]`

This will compute the diff between previous migrations and current DbContext state.

### Update database

`dotnet ef database update`

### Rollback database

To roll back to before migration N, update to migration N-1.

`dotnet ef database update [Migration N-1]`

