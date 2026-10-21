# Zgjidhjet e detyrave pa zgjidhje

Ky branch (`zgjidhje`) përmban gjithçka që ka `main`, plus folderin `zgjidhje/` me zgjidhjet e **të gjitha detyrave pa zgjidhje** të librit "Përmbledhje detyrash për C#", të organizuara sipas kapitujve. Çdo zgjidhje është projekt console më vete (`dotnet run` brenda folderit), me përjashtim të kapitullit 15, ku të shtata detyrat janë në një projekt të vetëm me meny.

> Provo së pari vetë. Zgjidhjet këtu janë për krahasim pasi ta kesh shkruar kodin tënd, jo për ta kopjuar: të kuptuarit vjen nga përpjekja, jo nga leximi.

## Struktura

```
zgjidhje/
  Kap01/Z-01-01-TriRreshta/      <- Z {kapitulli}-{numri i detyrës}
  ...
  Kap15/Z-15-EntityFramework/    <- detyrat 15.1-15.7 me meny
```

Emërtimi `Z-04-10` do të thotë: zgjidhja e detyrës së 10-të nga lista "Detyra pa zgjidhje" e kapitullit 4 (jo "Detyra 4.10"). Dy zgjidhje të bashkuara (p.sh. `Z-09-01-02`) mbulojnë dy detyra që ndërtohen mbi të njëjtin kod.

## Si t'i marrësh

```bash
git clone https://github.com/fisko/csharp-permbledhje.git
cd csharp-permbledhje
git checkout zgjidhje
```

Ose në GitHub zgjidh branch-in `zgjidhje` nga menuja ku shkruan `main` (lart majtas).

## Shënime

- Të gjitha projektet e kapitujve 1-14 janë **kompiluar dhe verifikuar**.
- Projekti i kapitullit 15 kërkon: `dotnet tool install --global dotnet-ef` dhe `dotnet ef migrations add Fillimi` para nisjes së parë.
- Konventa e kalimit: nota **mbi 5** kalon (si në libër).
