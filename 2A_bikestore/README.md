# ZH 2A – Bike Store

## Megnyitás
Visual Studio-ban nyisd meg a `ZH2A.slnx` fájlt (`ZH2A/ZH2A.csproj`, net10.0-windows, EF Core SqlServer). Az űrlapok a Visual Studio tervezőjében is megnyithatók.

## Lépések és megoldásuk

| Lépés | Hol található |
|---|---|
| ① Modell osztályok | `ZH2A/Models/*.cs` (Scaffold-DbContext eredménye) |
| ② Felület | `Form1.Designer.cs` |
| ③ Bal lista: boltok, szűrhetően | `Form1.cs` – `ReadStores()`, `textBoxStoreFilter_TextChanged` |
| ④ Jobb lista: termékek | `Form1.cs` – `ReadProducts()`, `textBoxProductFilter_TextChanged` |
| ⑤ `DetailedStockItem` osztály | `DetailedStockItem.cs` |
| ⑥ Rács adatforrása | `Form1.Designer.cs` – `detailedStockItemBindingSource` |
| ⑦ Kiválasztott bolt készlete | `Form1.cs` – `storeBindingSource_CurrentChanged`, `ReadStocks()` |
| ⑧ `+` gomb: új készlet elem | `Form1.cs` – `buttonAdd_Click` |
| ⑨ `-` gomb: törlés | `Form1.cs` – `buttonDelete_Click` |
| Ⓐ Termékek kezelése másik űrlapon, mentéssel | `Form1.cs` – `buttonProducts_Click`; `FormProducts.cs` – `FormProducts_Load`, `buttonSave_Click` |
| Ⓑ Márka és kategória legördülő dobozból | `FormProducts.Designer.cs` – `brandIdDataGridViewComboBoxColumn`, `categoryFkDataGridViewComboBoxColumn`; `FormProducts.cs` – `FormProducts_Load` |

## Megjegyzések
- A `FormProducts` konstruktora megkapja a `Form1` `context`-jét, így közös a szerkesztés. A rács forrása `context.Products.Local.ToBindingList()` (a `Microsoft.EntityFrameworkCore` using kell hozzá), ezért a hozzáadás, módosítás és törlés követve van; a `Mentés` gomb egyetlen `SaveChanges()`.
- A `FormProducts` bezárása után `Form1` újraolvassa a termékeket (`ReadProducts()`).
- Új sornál a márkát és a kategóriát ki kell választani, különben az adatbázis idegen kulcs hibát jelez (a hibaüzenet `MessageBox`-ban jelenik meg).
- A `ProductSk` oszlop rejtett és csak olvasható; navigációs oszlopok nincsenek.
- A `FormProducts` paraméter nélküli konstruktora csak a Visual Studio tervezőjének kell.
