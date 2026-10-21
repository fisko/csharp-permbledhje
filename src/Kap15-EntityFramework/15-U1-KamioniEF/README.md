# Detyra 15.U1 — Kamioni me EF Core

Programi e zbaton vetë migrimin me `db.Database.Migrate()`. Migrimi vjen bashkë me kodin (folderi `Migrations/`), ndaj mjafton:

```bash
dotnet tool install --global dotnet-ef   # vetëm nëse do të krijosh migrime të reja
dotnet run
```

Skedari `.db` krijohet vetë dhe nuk ruhet në repo. Nëse e ndryshon klasat: `dotnet ef migrations add EmriPerpjekjes`, pastaj `dotnet run`. Nëse ngec, fshi skedarin `.db` dhe folderin `Migrations`, pastaj `dotnet ef migrations add Fillimi`.
