# ZH 4A – Bike Store (customers → orders → order items ← products)

## Megnyitás
Visual Studio-ban nyisd meg a `ZH4A.slnx` fájlt (`ZH4A/ZH4A.csproj`, net10.0-windows, EF Core SqlServer). Az űrlap a Visual Studio tervezőjében is megnyitható (`Form1.cs` -> Designer).

## Lépések és megoldásuk

| Lépés | Hol található |
|---|---|
| ① Modell osztályok | `ZH4A/Models/*.cs` (Scaffold-DbContext eredménye) |
| ② Felület | `Form1.Designer.cs` |
| ③ Bal lista: vásárlók, szűrhetően (e-mail) | `Form1.cs` – `ReadCustomers()`, `textBoxCustomerFilter_TextChanged` |
| ④ Jobb lista: termékek | `Form1.cs` – `ReadProducts()` |
| ⑤ Kiválasztott vásárló megrendelései | `Form1.cs` – `customerBindingSource_CurrentChanged`, `ReadOrders()` |
| ⑥ `DetailedOrderItem` osztály | `DetailedOrderItem.cs` |
| ⑦ Rács adatforrása | `Form1.Designer.cs` – `detailedOrderItemBindingSource` (`typeof(DetailedOrderItem)`) |
| ⑧ Kiválasztott rendelés tételei | `Form1.cs` – `orderBindingSource_CurrentChanged`, `ReadItems()` |
| ⑨ `+` gomb: új `OrderItem` (mennyiség 1) | `Form1.cs` – `buttonAdd_Click` |
| `-` gomb: tétel törlése | `Form1.cs` – `buttonDelete_Click` |
| Ⓐ Vásárlók (e-mail, név) mentése XML-be | `Form1.cs` – `buttonSaveXml_Click`, `CustomerXml.cs` |
| Ⓑ Rendelés értéke címkében | `Form1.cs` – `ReadItems()` (`labelValue`) |

## Megjegyzések
- Az `OrderItem` tábla összetett kulcsú (`order_FK`, `product_FK`) – az adatbázisban nincs `item_id` oszlop, bár az ábrán szerepel. Ezért a `+` gomb előbb ellenőrzi, hogy a pár létezik-e már (ha igen, üzenetet ír ki), a `-` gomb pedig `context.OrderItems.Find(OrderFk, ProductFk)` hívással keresi meg a törlendő tételt.
- A rendelés értéke: Σ mennyiség × listaár × (1 − kedvezmény); hiányzó (null) listaár/kedvezmény 0-nak számít. A kedvezmény nincs a `DetailedOrderItem`-ben, ezért az érték külön lekérdezésből készül.
- Az XML mentéshez külön, csak egyszerű tulajdonságokat tartalmazó `CustomerXml` osztályt használunk (az entitás navigációs gyűjteményeit az `XmlSerializer` nem tudná szerializálni).
- A `Properties/DataSources/*.datasource` fájlok a Visual Studio adatforrás-kezelőjéhez kellenek.
