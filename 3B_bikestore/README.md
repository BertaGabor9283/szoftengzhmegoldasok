# ZH 3B – Bike Store

## Megnyitás
Visual Studio-ban nyisd meg a `ZH3B.slnx` fájlt (`ZH3B/ZH3B.csproj`, net10.0-windows, EF Core SqlServer). Az űrlapok a Visual Studio tervezőjében is megnyithatók.

## Lépések és megoldásuk

| Lépés | Hol található |
|---|---|
| ① Modell osztályok | `ZH3B/Models/*.cs` (Scaffold-DbContext eredménye) |
| ② Felület | `Form1.Designer.cs` |
| ③ Bal lista: boltok, szűrhetően | `Form1.cs` – `ReadStores()`, `textBoxStoreFilter_TextChanged` |
| ④ Jobb lista: termékek | `Form1.cs` – `ReadProducts()`, `textBoxProductFilter_TextChanged` |
| ⑤ `DetailedStockItem` osztály | `DetailedStockItem.cs` |
| ⑥ Rács adatforrása | `Form1.Designer.cs` – `detailedStockItemBindingSource` |
| ⑦ Kiválasztott bolt készlete | `Form1.cs` – `storeBindingSource_CurrentChanged`, `ReadStocks()` |
| ⑧ `+` gomb: új készlet elem | `Form1.cs` – `buttonAdd_Click` |
| ⑨ `-` gomb: törlés | `Form1.cs` – `buttonDelete_Click` |
| Ⓐ Új bolt felvétele külön űrlapon, csak OK esetén mentve | `Form1.cs` – `buttonNewStore_Click`; `FormAddStore.cs`, `FormAddStore.Designer.cs` |
| Ⓑ Üres mező esetén nem zárható be az űrlap | `FormAddStore.cs` – `FormAddStore_FormClosing` |

## Megjegyzések
- A `FormAddStore` a `NewStore` publikus mezőbe gyűjti az adatokat (`storeBindingSource.DataSource = NewStore`). `Form1` csak `DialogResult.OK` esetén adja hozzá a `context.Stores`-hoz és menti; sikertelen mentésnél az új elem le van választva (`EntityState.Detached`).
- Üres vagy csak szóközt tartalmazó mezővel az OK gomb nem zár (`FormClosing`, `e.Cancel = true`); a Mégse mindig bezár.
- Az adatbázis hosszkorlátai miatt a `State` (10), a `ZipCode` (5) és a `Phone` (25) mezőn `MaxLength` van beállítva.
