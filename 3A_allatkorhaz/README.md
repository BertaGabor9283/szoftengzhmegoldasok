# ZH 3A – Állatkórház

## Megnyitás
Visual Studio-ban nyisd meg a `ZH3A.slnx` fájlt (`ZH3A/ZH3A.csproj`, net10.0-windows, EF Core SqlServer). Az űrlap a Visual Studio tervezőjében is megnyitható (`Form1.cs` -> Designer).

## Lépések és megoldásuk

| Lépés | Hol található |
|---|---|
| ① Modell osztályok | `ZH3A/Models/*.cs` (lásd az első megjegyzést!) |
| ② Felület | `Form1.Designer.cs` |
| ③ Bal lista: állatok, szűrhetően | `Form1.cs` – `ReadAnimals()`, `textBoxAnimalFilter_TextChanged` |
| ④ Jobb lista: eljárások | `Form1.cs` – `ReadProcedures()` |
| ⑤ Kiválasztott állat kezelései (dátum) | `Form1.cs` – `animalBindingSource_CurrentChanged`, `ReadTreatments()` |
| ⑥ `ProcedureDoneItem` osztály | `ProcedureDoneItem.cs` |
| ⑦ Harmadik lista adatforrása | `Form1.Designer.cs` – `procedureDoneItemBindingSource` (`typeof(ProcedureDoneItem)`) |
| ⑧ Kiválasztott kezelés elvégzett eljárásai | `Form1.cs` – `treatmentBindingSource_CurrentChanged`, `ReadProcedureDones()` |
| ⑨ `+` gomb: új `ProcedureDone` | `Form1.cs` – `buttonAdd_Click` |
| Ⓐ Animal tábla mentése XML-be | `Form1.cs` – `buttonSaveXml_Click`, `AnimalXml.cs` |
| Ⓑ Állatok száma címkében | `Form1.cs` – `Form1_Load` (`labelCount`) |

## Megjegyzések
- A `Models/` mappát kézzel írtam meg a sémaábra (`se_pets.png`) alapján, mert az adatbázis-szerver nem volt elérhető. Éles használat előtt futtasd újra a feladatlapon szereplő `Scaffold-DbContext` parancsot, és ha a nevek vagy típusok eltérnek, javítsd a kódot. Tippelt típusok: `Treatment.Date` `DateOnly?`, `Treatment.Paid` `bool?`, `Procedure.Price` `decimal?` (money).
- Az Ⓑ címke a teljes `Animals` tábla elemszámát mutatja (nem a szűrt listáét), betöltéskor számolódik.
- Az XML mentéshez külön, csak egyszerű tulajdonságokat tartalmazó `AnimalXml` osztályt használunk (az entitás navigációs gyűjteményeit az `XmlSerializer` nem tudná szerializálni).
- A `Properties/DataSources/*.datasource` fájlok a Visual Studio adatforrás-kezelőjéhez kellenek.
