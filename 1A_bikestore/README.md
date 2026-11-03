# ZH 1A – Bike Store

## Megnyitás
Visual Studio-ban nyisd meg a `ZH1A.slnx` fájlt (`ZH1A/ZH1A.csproj`, net10.0-windows, EF Core SqlServer). Az űrlap a Visual Studio tervezőjében is megnyitható (`Form1.cs` -> Designer).

## Lépések és megoldásuk

| Lépés | Hol található |
|---|---|
| ① Modell osztályok | `ZH1A/Models/*.cs` (Scaffold-DbContext eredménye) |
| ② Felület | `Form1.Designer.cs` |
| ③ Bal lista: boltok, szűrhetően | `Form1.cs` – `ReadStores()`, `textBoxStoreFilter_TextChanged` |
| ④ Jobb lista: termékek | `Form1.cs` – `ReadProducts()`, `textBoxProductFilter_TextChanged` |
| ⑤ `DetailedStockItem` osztály | `DetailedStockItem.cs` |
| ⑥ Rács adatforrása | `Form1.Designer.cs` – `detailedStockItemBindingSource` (`typeof(DetailedStockItem)`) |
| ⑦ Kiválasztott bolt készlete | `Form1.cs` – `storeBindingSource_CurrentChanged`, `ReadStocks()` |
| ⑧ `+` gomb: új készlet elem | `Form1.cs` – `buttonAdd_Click` |
| ⑨ `-` gomb: törlés | `Form1.cs` – `buttonDelete_Click` |
| Ⓐ Products mentése XML-be | `Form1.cs` – `buttonSaveXml_Click`, `ProductXml.cs` |
| Ⓑ Termékek száma címkében | `Form1.cs` – `ReadStocks()` (`labelCount`) |

## Megjegyzések
- A `Stock` tábla összetett kulcsú (`store_SK`, `product_FK`), ezért a `+` gomb előbb ellenőrzi, hogy a pár létezik-e már.
- Az XML mentéshez külön, csak egyszerű tulajdonságokat tartalmazó `ProductXml` osztályt használunk (az entitás navigációs gyűjteményeit az `XmlSerializer` nem tudná szerializálni).
- A `Properties/DataSources/*.datasource` fájlok a Visual Studio adatforrás-kezelőjéhez kellenek.
