# 3B_bikestore — ZH3B

Megnyitás: `ZH3B.slnx` Visual Studióban. Az alap a `ZHElott` megoldás: ugyanaz a felépítés és ugyanazok a megoldások (context mező, LINQ lekérdezés, BindingSource + `.ToList()`, `Add`/`SaveChanges`/`RemoveRange`, `//ToDo: try-catch`).

| Lépés | Hol | Mit |
|---|---|---|
| ①–⑨ | Form1.cs | azonos az 1A-val |
| Ⓐ | Form1.buttonAddStore_Click, FormAddStore.cs | új bolt: csak OK esetén kerül az adatbázisba (mint a FormAddProduct) |
| Ⓑ | FormAddStore.buttonOk_Click | az OK gombnak nincs DialogResult-ja a tervezőben; csak akkor állítja OK-ra, ha minden mező ki van töltve |

## Ami nincs a ZHElott programban, de a lap kéri

- A lap szövegdobozt említ a mennyiséghez; a ZHElott mintájára NumericUpDown van (`(int)...Value` / decimalnál `.Value`).
- `string.IsNullOrWhiteSpace` és `MessageBox.Show` az üres mezők ellenőrzéséhez.
