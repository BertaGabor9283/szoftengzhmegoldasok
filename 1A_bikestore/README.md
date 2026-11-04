# 1A_bikestore — ZH1A

Megnyitás: `ZH1A.slnx` Visual Studióban. Az alap a `ZHElott` megoldás: ugyanaz a felépítés és ugyanazok a megoldások (context mező, LINQ lekérdezés, BindingSource + `.ToList()`, `Add`/`SaveChanges`/`RemoveRange`, `//ToDo: try-catch`).

| Lépés | Hol | Mit |
|---|---|---|
| ①② | Form1.Designer.cs, DetailedStockItem.cs | projekt, felület, adatforrások |
| ③ | Form1_Load, textBoxStoreFilter_TextChanged | szűrhető bolt-lista |
| ④ | Form1_Load | termék-lista |
| ⑤⑥ | DetailedStockItem.cs, detailedStockItemBindingSource | rács adatforrása |
| ⑦ | storeBindingSource_CurrentChanged → ReadStocks() | készlet a kiválasztott boltra |
| ⑧ | buttonAdd_Click | + (összetett kulcs: StoreSk + ProductFk) |
| ⑨ | buttonDelete_Click | - |
| Ⓐ | buttonSaveXml_Click | Products → XML, SaveFileDialog |
| Ⓑ | ReadStocks() | termékek száma a címkében |

## Ami nincs a ZHElott programban, de a lap kéri

- A lap szövegdobozt említ a mennyiséghez; a ZHElott mintájára NumericUpDown van (`(int)...Value` / decimalnál `.Value`).
- XML mentés: `SaveFileDialog` + `System.Xml.Linq` (`XDocument`/`XElement`, LINQ lekérdezéssel).
- Számláló címke: `BindingSource.Count` / `Count()`.
