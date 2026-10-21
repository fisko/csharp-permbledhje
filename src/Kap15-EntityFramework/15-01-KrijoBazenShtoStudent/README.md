# Detyra 15.1 — Krijo bazën dhe shto një student

Ky projekt përdor SQLite përmes Entity Framework Core. Para nisjes së parë, brenda këtij folderi:

```bash
dotnet tool install --global dotnet-ef   # vetëm herën e parë, për makinën
dotnet ef database update
dotnet run
```

Migrimet vijnë bashkë me kodin (folderi `Migrations/` në këtë projekt), prandaj **nuk** ekzekuton `migrations add`. Skedari `.db` krijohet vetë dhe nuk ruhet në repo.

Nëse e ndryshon klasat: `dotnet ef migrations add EmriPerpjekjes`, pastaj `dotnet ef database update`. Nëse ngec, shih "Ndihmë e shpejtë: kur migrimi ngec" në kapitullin 15 të librit; zgjidhja e sigurt gjatë mësimit është të fshish skedarin `.db` dhe folderin `Migrations`, pastaj `dotnet ef migrations add Fillimi` dhe `dotnet ef database update`.
