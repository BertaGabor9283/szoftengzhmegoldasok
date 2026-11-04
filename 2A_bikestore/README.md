# 2A_bikestore — ZH2A

Megnyitás: `ZH2A.slnx` Visual Studióban. Az alap a `ZHElott` megoldás: ugyanaz a felépítés és ugyanazok a megoldások (context mező, LINQ lekérdezés, BindingSource + `.ToList()`, `Add`/`SaveChanges`/`RemoveRange`, `//ToDo: try-catch`).

| Lépés | Hol | Mit |
|---|---|---|
| ①–⑨ | Form1.cs | azonos az 1A-val |
| Ⓐ | Form1.buttonProducts_Click, FormProducts.cs | másik űrlap rácson a termékekkel; +, -, Mentés (SaveChanges) |
| Ⓑ | FormProducts.Designer.cs (DataGridViewComboBoxColumn) | márka és kategória legördülő dobozból; adataik a Load-ban a rács előtt töltődnek |

## Ami nincs a ZHElott programban, de a lap kéri

- A lap szövegdobozt említ a mennyiséghez; a ZHElott mintájára NumericUpDown van (`(int)...Value` / decimalnál `.Value`).
- A `+` gomb a második űrlapon kitalált alapértékekkel vesz fel sort ("Új termék"/"Új koktél", ár 0, ModelYear 2016, a legördülő első eleme). A lap csak szerkeszthető rácsot és mentést kér, a `+`/`-` ezen felül van.
- `DataGridViewComboBoxColumn` (DataSource/DisplayMember/ValueMember/DataPropertyName) a külső kulcsokhoz.
- A második űrlap a `context`-et publikus mezőn kapja meg (mint a `FormAddProduct.NewProduct`). Mentés nélküli bezárás után a módosítások a közös contextben maradnak.
