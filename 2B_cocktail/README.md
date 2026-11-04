# 2B_cocktail — ZH2B

Megnyitás: `ZH2B.slnx` Visual Studióban. Az alap a `ZHElott` megoldás: ugyanaz a felépítés és ugyanazok a megoldások (context mező, LINQ lekérdezés, BindingSource + `.ToList()`, `Add`/`SaveChanges`/`RemoveRange`, `//ToDo: try-catch`).

| Lépés | Hol | Mit |
|---|---|---|
| ①–⑨ | Form1.cs | azonos az 1B-vel |
| Ⓐ | Form1.buttonCocktails_Click, FormCocktails.cs | másik űrlap rácson a koktélokkal; +, -, Mentés |
| Ⓑ | FormCocktails.Designer.cs (DataGridViewComboBoxColumn) | típus legördülő dobozból |

## Ami nincs a ZHElott programban, de a lap kéri

- A lap szövegdobozt említ a mennyiséghez; a ZHElott mintájára NumericUpDown van (`(int)...Value` / decimalnál `.Value`).
- A `+` gomb a második űrlapon kitalált alapértékekkel vesz fel sort ("Új termék"/"Új koktél", ár 0, ModelYear 2016, a legördülő első eleme). A lap csak szerkeszthető rácsot és mentést kér, a `+`/`-` ezen felül van.
- `DataGridViewComboBoxColumn` (DataSource/DisplayMember/ValueMember/DataPropertyName) a külső kulcsokhoz.
- A második űrlap a `context`-et publikus mezőn kapja meg (mint a `FormAddProduct.NewProduct`). Mentés nélküli bezárás után a módosítások a közös contextben maradnak.

## Figyelem

A `Models/` mappát a séma-ábráról kézzel írtam (az adatbázis-szerver innen nem volt elérhető). Ha eltér a `Scaffold-DbContext` eredménye (mező-/típusnevek), futtasd le a lapon lévő parancsot, és igazítsd hozzá a kódot.
