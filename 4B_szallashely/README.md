# ZH 4B – Szálláshely

## Megnyitás
Visual Studio-ban nyisd meg a `ZH4B.slnx` fájlt (`ZH4B/ZH4B.csproj`, net10.0-windows, EF Core SqlServer). Az űrlap a Visual Studio tervezőjében is megnyitható (`Form1.cs` -> Designer).

## Lépések és megoldásuk

| Lépés | Hol található |
|---|---|
| ① Modell osztályok | `ZH4B/Models/*.cs` (kézzel írva, lásd alább) |
| ② Felület | `Form1.Designer.cs` |
| ③ Bal lista: szálláshelyek, szűrhetően | `Form1.cs` – `ReadSzallashelyek()`, `textBoxFilter_TextChanged` |
| ④ Jobb lista: vendégek | `Form1.cs` – `ReadVendegek()` |
| ⑤ Kiválasztott szálláshely szobái | `Form1.cs` – `szallashelyBindingSource_CurrentChanged`, `ReadSzobak()` |
| ⑥ Rács adatforrása (`Models.Foglalas`) | `Form1.Designer.cs` – `foglalasBindingSource` (`typeof(Models.Foglalas)`) |
| ⑦ Kiválasztott szoba foglalásai | `Form1.cs` – `szobaBindingSource_CurrentChanged`, `ReadFoglalasok()` |
| ⑧ Kulcsmezők elrejtése, cellák szerkeszthetők | `Form1.Designer.cs` – `dataGridViewFoglalas` oszlopai |
| ⑨ `+` gomb: új foglalás (1 felnőtt) | `Form1.cs` – `buttonAdd_Click` |
| ⑩ `Save` gomb: módosítások mentése | `Form1.cs` – `buttonSave_Click` |
| ⑪ `-` gomb: foglalás törlése | `Form1.cs` – `buttonDelete_Click` |
| Ⓐ Szálláshelyek mentése XML-be | `Form1.cs` – `buttonSaveXml_Click`, `SzallashelyXml.cs` |
| Ⓑ Szálláshelyek száma címkében | `Form1.cs` – `Form1_Load` (`labelCount`) |

## Megjegyzések
- **A `Models/` mappa kézzel készült az adatbázisdiagramból**, mert az adatbázis-szerver nem volt elérhető. Ha eléred a szervert, futtasd újra a feladatlap `Scaffold-DbContext` parancsát (`-NoPluralize` kapcsolóval), és javítsd a kódban a nevek/típusok eltéréseit. Tippelt részletek: `SzobaSzama` string, `Mettol`/`Meddig` `DateOnly`, `FoglalasPk` identity kulcs.
- A ⑧ lépés mondata a feladatlapon hibás/érthetetlen; úgy értelmeztem: a rácson **nincs** beépített sorfelvétel/törlés (`AllowUserToAddRows = false`, `AllowUserToDeleteRows = false`), a cellák viszont szerkeszthetők (`ReadOnly = false`), sorokat a `+` / `-` gombok adnak hozzá / törölnek.
- A rács közvetlenül a követett `Models.Foglalas` entitásokhoz kötődik, ezért a cellák szerkesztését a `Save` gomb (`EndEdit` + `SaveChanges`) menti. Érvénytelen cellaérték (pl. rossz dátum) esetén a `DataError` eseménykezelő üzenetet ad összeomlás helyett.
- Az új foglalás `UgyfelFk`-ja a jobb listában kiválasztott vendég `Usernev`-e; kezdő/záró dátum: ma / holnap.
- Az XML mentéshez külön, csak egyszerű tulajdonságokat tartalmazó `SzallashelyXml` osztályt használunk.
- A `Properties/DataSources/*.datasource` fájlok a Visual Studio adatforrás-kezelőjéhez kellenek.
