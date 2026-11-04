# 4A_bikestore — ZH4A

Megnyitás: `ZH4A.slnx` Visual Studióban. Az alap a `ZHElott` megoldás: ugyanaz a felépítés és ugyanazok a megoldások (context mező, LINQ lekérdezés, BindingSource + `.ToList()`, `Add`/`SaveChanges`/`RemoveRange`, `//ToDo: try-catch`).

| Lépés | Hol | Mit |
|---|---|---|
| ①② | Form1.Designer.cs, DetailedOrderItem.cs | projekt, felület |
| ③ | Form1_Load, textBoxCustomerFilter_TextChanged | szűrhető vásárló-lista (Email) |
| ④ | Form1_Load | termék-lista |
| ⑤ | customerBindingSource_CurrentChanged → ReadOrders() | rendelések, megjelenített mező: OrderDate |
| ⑥⑦ | DetailedOrderItem.cs, detailedOrderItemBindingSource | rács adatforrása |
| ⑧ | orderBindingSource_CurrentChanged → ReadItems() | tételek a kiválasztott rendeléshez |
| ⑨ | buttonAdd_Click | + (mennyiség mindig 1; kulcs: OrderFk + ProductFk — a DB-ben nincs item_id) |
| — | buttonDelete_Click | - (a UI-képen szerepel) |
| Ⓐ | buttonSaveXml_Click | Customers e-mail + név → XML, SaveFileDialog |
| Ⓑ | ReadItems() | rendelés értéke = Σ mennyiség × ár × (1 − kedvezmény) |

## Ami nincs a ZHElott programban, de a lap kéri

- XML mentés: `SaveFileDialog` + `System.Xml.Linq` (`XDocument`/`XElement`, LINQ lekérdezéssel).
- Rendelés értéke: `Sum()` a LINQ lekérdezésen.
