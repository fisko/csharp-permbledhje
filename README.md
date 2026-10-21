# Përmbledhje detyrash për C#

Kodi shoqërues i librit **"Përmbledhje detyrash për C#"** — console apps për konceptet
themelore dhe programimin e orientuar në objekte. Çdo detyrë e zgjidhur e librit gjendet
këtu si projekt më vete, gati për t'u ekzekutuar, me kodin ashtu siç është shtypur në libër.

**Teknologjia:** .NET 10 · C# 14 · Visual Studio 2026 (ose VS Code)

---

## Si fillosh

### 1. Instalo çfarë të duhet

Të duhet **një** nga këto dy:

- **Visual Studio 2026** (Community është falas) me workload-in *".NET desktop development"*.
- ose **.NET 10 SDK** ([dotnet.microsoft.com/download](https://dotnet.microsoft.com/download))
  bashkë me **VS Code** dhe zgjerimin *C# Dev Kit* — shih shtojcën "Zhvillimi me VS Code" në libër.

Kontrollo në terminal:

```bash
dotnet --version
```

Nëse kthen një numër që fillon me 10, je gati.

### 2. Merr kodin

```bash
git clone https://github.com/fisko/csharp-permbledhje.git
cd csharp-permbledhje
```

Pa Git: kliko butonin e gjelbër **Code** → **Download ZIP**.

### 3. Ekzekuto detyrën e parë

```bash
cd src/Kap01-Hyrje/01-01-PershendetjeBota
dotnet run
```

Ose në Visual Studio: hap `csharp-permbledhje.sln`, zgjidh projektin dhe shtyp **Ctrl+F5**.

---

## Si është organizuar

```
src/
  Kap06-Klasat/
    06-01-KrijoStudent/            <- Detyra 6.1
    06-02-KonstruktoriStudent/     <- Detyra 6.2
    ...
    06-D1-MesatarjaEStudentit/     <- Detyrë shtesë — më sfiduese (pa numër në libër)
  Kap07-Properties/
    07-U1-Topi/                    <- Detyra për ushtrime 7.U1
  Shtesa/
    Kap07-BankAccountEncapsulation/  <- Zgjerim praktik / detyra S1 e kapitullit 7
```

- **numër i thjeshtë** (6.2) — detyra të zgjidhura brenda kapitullit
- **U** (7.U1) — detyrat përmbledhëse për ushtrime
- **D** (6.D1) — "Detyrë shtesë — më sfiduese" e kapitullit
- **Shtesa** — kodi i plotë për "Zgjerim praktik" dhe detyrat **S** (p.sh. 7.S1); libri ka vetëm zgjidhjen orientuese

Detyrat pa zgjidhje (për vetëpunim) **nuk** janë në branch-in `main` — ato pritet t'i zgjidhësh vetë. Zgjidhjet e tyre ndodhen në branch-in `zgjidhje` (shih më poshtë); provoji së pari vetë.

---

## Kapitulli 15 kërkon një hap më shumë

Projektet me Entity Framework përdorin SQLite. Migrimet vijnë bashkë me repon (folderi `Migrations/` te çdo projekt), prandaj **nuk** ekzekuton `migrations add`. Para nisjes së parë, brenda folderit të projektit:

```bash
dotnet tool install --global dotnet-ef   # vetëm herën e parë, për makinën
dotnet ef database update
dotnet run
```

(`15-U1-KamioniEF` e zbaton vetë migrimin me `Migrate()`, prandaj mjafton `dotnet run`.) Skedari `.db` krijohet vetë dhe nuk ruhet në repo. Çdo projekt ka README.md me hapat.
Nëse ngec, shih "Ndihmë e shpejtë: kur migrimi ngec" në kapitullin 15 të librit.

---

## Harta: detyra → folderi

| Detyra | Titulli | Folderi |
|---|---|---|
| 1.1 | Përshëndetja e parë | `src/Kap01-Hyrje/01-01-PershendetjeBota` |
| 1.2 | E njëjta gjë, e shkruar plotësisht | `src/Kap01-Hyrje/01-02-FormaEPlote` |
| 1.3 | Pyet dhe përshëndet | `src/Kap01-Hyrje/01-03-PyetDhePershendet` |
| 1.D1 | Detyrë shtesë — më sfiduese | `src/Kap01-Hyrje/01-D1-FormularRegjistrimi` |
| 2.1 | Të dhënat e një studenti | `src/Kap02-Variablat/02-01-TeDhenatEStudentit` |
| 2.2 | Tipi i duhur për secilën vlerë | `src/Kap02-Variablat/02-02-TipiIDuhur` |
| 2.3 | Vlera që nuk ndryshojnë | `src/Kap02-Variablat/02-03-Konstantet` |
| 2.4 | Një kartelë studenti | `src/Kap02-Variablat/02-04-KartelaEStudentit` |
| 2.5 | Analizë e një emri | `src/Kap02-Variablat/02-05-AnalizaEEmrit` |
| 2.D1 | Detyrë shtesë — më sfiduese | `src/Kap02-Variablat/02-D1-FaturaMeTvsh` |
| 3.1 | Një makinë e vogël llogaritëse | `src/Kap03-Operatoret/03-01-MakineLlogaritese` |
| 3.2 | Nota mesatare, si duhet | `src/Kap03-Operatoret/03-02-NotaMesatare` |
| 3.3 | A ka kaluar studenti? | `src/Kap03-Operatoret/03-03-KaKaluarStudenti` |
| 3.4 | Kaluar apo mbetur, me një rresht | `src/Kap03-Operatoret/03-04-KaluarApoMbetur` |
| 3.D1 | Detyrë shtesë — më sfiduese | `src/Kap03-Operatoret/03-D1-VitiIBrishte` |
| 4.1 | Kaluar apo mbetur | `src/Kap04-Cikle/04-01-KaluarApoMbetur` |
| 4.2 | Mesazh sipas stinës | `src/Kap04-Cikle/04-02-MesazhSipasStines` |
| 4.3 | Numëro deri në pesë | `src/Kap04-Cikle/04-03-NumeroDeriNePese` |
| 4.4 | Shuma e numrave | `src/Kap04-Cikle/04-04-ShumaENumrave` |
| 4.5 | Shuma dhe mesatarja e një vargu | `src/Kap04-Cikle/04-05-ShumaDheMesatarja` |
| 4.6 | Nota më e lartë | `src/Kap04-Cikle/04-06-NotaMeELarte` |
| 4.7 | Shuma e elementeve në matricë | `src/Kap04-Cikle/04-07-ShumaMatrice` |
| 4.8 | Shuma sipas rreshtave dhe kolonave | `src/Kap04-Cikle/04-08-ShumaRreshtaKolona` |
| 4.9 | Diagonalja kryesore dhe diagonala sekondare | `src/Kap04-Cikle/04-09-Diagonalet` |
| 4.10 | Numër i thjeshtë | `src/Kap04-Cikle/04-10-NumerIThjeshte` |
| 4.11 | Palindrom | `src/Kap04-Cikle/04-11-Palindrom` |
| 4.12 | Fibonacci | `src/Kap04-Cikle/04-12-Fibonacci` |
| 4.13 | Kërkim linear | `src/Kap04-Cikle/04-13-KerkimLinear` |
| 4.14 | Bubble Sort | `src/Kap04-Cikle/04-14-BubbleSort` |
| 4.D1 | Detyrë shtesë — më sfiduese | `src/Kap04-Cikle/04-D1-NumratEThjeshte` |
| 4.U1 | Shuma e numrave deri te fjala FUND | `src/Kap04-Cikle/04-U1-Fund` |
| 5.1 | Metoda e parë | `src/Kap05-Metodat/05-01-MetodaEPare` |
| 5.2 | Përshëndetje me emër | `src/Kap05-Metodat/05-02-PershendetjeMeEmer` |
| 5.3 | Mesatarja që kthehet | `src/Kap05-Metodat/05-03-MesatarjaQeKthehet` |
| 5.4 | Prodhimi me parametra opsionalë | `src/Kap05-Metodat/05-04-ParametraOpsionale` |
| 5.5 | Kalkulator i mbingarkuar | `src/Kap05-Metodat/05-05-MbingarkimiMetodave` |
| 5.6 | Shembull: TryParse me out (seksioni 5.6) | `src/Kap05-Metodat/05-06-TryParseOut` |
| 5.D1 | Detyrë shtesë — më sfiduese | `src/Kap05-Metodat/05-D1-FaktorieliRekursiv` |
| 6.1 | Krijo klasën Student | `src/Kap06-Klasat/06-01-KrijoStudent` |
| 6.2 | Konstruktori i Student-it | `src/Kap06-Klasat/06-02-KonstruktoriStudent` |
| 6.3 | Sjellje për Student-in | `src/Kap06-Klasat/06-03-RegjistrohuMetode` |
| 6.4 | Bëje Student-in të shtypshëm | `src/Kap06-Klasat/06-04-ToStringStudent` |
| 6.D1 | Detyrë shtesë — më sfiduese | `src/Kap06-Klasat/06-D1-MesatarjaEStudentit` |
| 7.1 | Studenti me property | `src/Kap07-Properties/07-01-StudentMeProperty` |
| 7.2 | Mosha që nuk pranon vlera të pavlefshme | `src/Kap07-Properties/07-02-ValidimiIMoshes` |
| 7.3 | Studenti i plotë, i enkapsuluar | `src/Kap07-Properties/07-03-StudentIEnkapsuluar` |
| 7.4 | Statusi i pagesës | `src/Kap07-Properties/07-04-EnumStatusPagese` |
| 7.5 | Shembull: record (seksioni 7.5) | `src/Kap07-Properties/07-05-RecordStudentDto` |
| 7.D1 | Detyrë shtesë — më sfiduese | `src/Kap07-Properties/07-D1-LlogariPaTeNegative` |
| 7.U1 | Klasa Topi me property validuese | `src/Kap07-Properties/07-U1-Topi` |
| 8.1 | Numëro studentët | `src/Kap08-Statike/08-01-NumeroStudentet` |
| 8.2 | Mbledhja e dy shumave parash | `src/Kap08-Statike/08-02-ParaMeOperator` |
| 8.D1 | Detyrë shtesë — më sfiduese | `src/Kap08-Statike/08-D1-Thyesa` |
| 9.1 | Njeri, Student, Profesor | `src/Kap09-Trashegimia/09-01-NjeriStudentProfesor` |
| 9.2 | Konstruktorët në hierarki | `src/Kap09-Trashegimia/09-02-KonstruktoretNeHierarki` |
| 9.3 | Secili prezantohet ndryshe | `src/Kap09-Trashegimia/09-03-PrezantimiPolimorfik` |
| 9.4 | Profesor me lëndë | `src/Kap09-Trashegimia/09-04-ProfesorMeLende` |
| 9.D1 | Detyrë shtesë — më sfiduese | `src/Kap09-Trashegimia/09-D1-PrezantimiNeHierarki` |
| 10.1 | Njeriu abstrakt | `src/Kap10-Interfaces/10-01-NjeriAbstrakt` |
| 10.2 | Një kontratë e përbashkët | `src/Kap10-Interfaces/10-02-KontrataEPerbashket` |
| 10.3 | Rendit produktet (IComparable / IComparer) | `src/Kap10-Interfaces/10-03-KrahasimiProdukteve` |
| 10.D1 | Detyrë shtesë — më sfiduese | `src/Kap10-Interfaces/10-D1-FiguraMeSyprinaMaksimale` |
| 10.U1 | Ora e mësimit: Ligjerata dhe Ushtrime | `src/Kap10-Interfaces/10-U1-OraLigjerataUshtrime` |
| 11.1 | Pjesëtim i sigurt | `src/Kap11-Perjashtimet/11-01-PjesetimISigurt` |
| 11.2 | Nga specifiku te i përgjithshmi | `src/Kap11-Perjashtimet/11-02-RadhaECatcheve` |
| 11.3 | Përjashtim i yti | `src/Kap11-Perjashtimet/11-03-PerjashtimIYti` |
| 11.D1 | Detyrë shtesë — më sfiduese | `src/Kap11-Perjashtimet/11-D1-TerheqjeMeFonde` |
| 12.1 | Një listë studentësh | `src/Kap12-Koleksione/12-01-ListaEStudenteve` |
| 12.2 | Regjistri i notave | `src/Kap12-Koleksione/12-02-RegjistriINotave` |
| 12.D1 | Detyrë shtesë — më sfiduese | `src/Kap12-Koleksione/12-D1-GrupimiSipasFakultetit` |
| 13.1 | Kush ka kaluar | `src/Kap13-Linq/13-01-KushKaKaluar` |
| 13.2 | Emrat me shkronjë të madhe | `src/Kap13-Linq/13-02-EmratMeTeMedha` |
| 13.3 | Statistika të grupit | `src/Kap13-Linq/13-03-StatistikaEGrupit` |
| 13.D1 | Detyrë shtesë — më sfiduese | `src/Kap13-Linq/13-D1-MesatarjaSipasFakultetit` |
| 13.U1 | Pyetjet mbi autobusët me parametër hyrës | `src/Kap13-Linq/13-U1-AutobusiLinq` |
| 14.1 | Ruaj dhe lexo një student | `src/Kap14-SystemIO/14-01-RuajLexoStudent` |
| 14.2 | Lexo studentët nga CSV | `src/Kap14-SystemIO/14-02-LexoCsv` |
| 14.S1 | Regjistër notash në CSV | `src/Kap14-SystemIO/14-S1-RegjistriNotaveCsv` |
| 15.1 | Krijo bazën dhe shto një student | `src/Kap15-EntityFramework/15-01-KrijoBazenShtoStudent` |
| 15.2 | Të katër veprimet (CRUD) | `src/Kap15-EntityFramework/15-02-Crud` |
| 15.D1 | Detyrë shtesë — më sfiduese | `src/Kap15-EntityFramework/15-D1-ProfesorMeStudentet` |
| 15.U1 | Krijo, Paraqit, Ndrysho dhe Pyetjet për klasën Kamioni | `src/Kap15-EntityFramework/15-U1-KamioniEF` |

**Kodi i plotë i "Zgjerim praktik" (detyrat S):**

| Projekti | Folderi |
|---|---|
| Kap01-InputProfile | `src/Shtesa/Kap01-InputProfile` |
| Kap02-InvoiceCalculator | `src/Shtesa/Kap02-InvoiceCalculator` |
| Kap03-GradeAnalyzer | `src/Shtesa/Kap03-GradeAnalyzer` |
| Kap04-ParkingMachine | `src/Shtesa/Kap04-ParkingMachine` |
| Kap05-MethodToolkit | `src/Shtesa/Kap05-MethodToolkit` |
| Kap06-StudentClassAdvanced | `src/Shtesa/Kap06-StudentClassAdvanced` |
| Kap07-BankAccountEncapsulation | `src/Shtesa/Kap07-BankAccountEncapsulation` |
| Kap08-MoneyOperator | `src/Shtesa/Kap08-MoneyOperator` |
| Kap09-VehicleInheritance | `src/Shtesa/Kap09-VehicleInheritance` |
| Kap10-PaymentInterfaces | `src/Shtesa/Kap10-PaymentInterfaces` |
| Kap11-RobustInput | `src/Shtesa/Kap11-RobustInput` |
| Kap12-InventoryCollections | `src/Shtesa/Kap12-InventoryCollections` |
| Kap13-StudentLinqReports | `src/Shtesa/Kap13-StudentLinqReports` |
| Kap14-StudentFileRegistry | `src/Shtesa/Kap14-StudentFileRegistry` |
| Kap15-UniversityEfDesign | `src/Shtesa/Kap15-UniversityEfDesign` |

---

## Si ta përdorësh këtë repo si duhet

Kodi këtu është **rrjeta e sigurisë, jo rruga e shkurtër.**

1. Lexo detyrën në libër dhe mbylle librin.
2. Shkruaje vetë zgjidhjen, sado e gabuar të dalë herën e parë.
3. Ekzekutoje. Nëse rrëzohet, lexoje mesazhin e gabimit.
4. **Vetëm pastaj** hape kodin këtu dhe krahasoje me tëndin.

Kopjimi i kodit pa e provuar vetë e krijon ndjesinë e të kuptuarit, jo të kuptuarit.

---

## Gjete një gabim?

1. Shih te [ERRATA.md](ERRATA.md) nëse është raportuar tashmë.
2. Nëse jo, [hap një issue](../../issues/new/choose) me shabllonin *Gabim në libër*.

---

## Pyetje të shpeshta

**A punon kodi me .NET 8?** Shumica e projekteve po: ndrysho `net10.0` në `net8.0` te `.csproj`. Por për librin, .NET 10 është referenca.

**Pse disa programe japin paralajmërime të verdha (CS8600, CS8604, CS8618)?** Projektet e reja .NET 10 kanë "nullable" të aktivizuar. Kodi i librit është shkruar për të mësuar, jo për të heshtur çdo paralajmërim; kuptimi i tyre shpjegohet te seksioni 6.5.

**Ku janë zgjidhjet e detyrave pa zgjidhje?** Në branch-in `zgjidhje` të këtij repo-je: `git checkout zgjidhje`, ose zgjidh branch-in `zgjidhje` në GitHub (menuja ku shkruan `main`, lart majtas). Provoji së pari vetë dhe krahasoji më pas.

**A mund ta përdor këtë kod në projektin tim?** Po, kodi është nën licencë MIT. Teksti i librit është i mbrojtur me të drejta autori.

---

## Licenca

- **Kodi** (gjithçka nën `src/` dhe `zgjidhje/`): [MIT](LICENSE).
- **Teksti i librit**: © 2026 Fisnik Doko, të gjitha të drejtat të rezervuara.
