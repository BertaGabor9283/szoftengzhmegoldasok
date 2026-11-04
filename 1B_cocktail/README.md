# 1B_cocktail — ZH1B

Megnyitás: `ZH1B.slnx` Visual Studióban. Az alap a `ZHElott` megoldás: ugyanaz a felépítés és ugyanazok a megoldások (context mező, LINQ lekérdezés, BindingSource + `.ToList()`, `Add`/`SaveChanges`/`RemoveRange`, `//ToDo: try-catch`).

| Lépés | Hol | Mit |
|---|---|---|
| ①② | Form1.Designer.cs, DetailedRecipeItem.cs | projekt, felület |
| ③ | Form1_Load, textBoxCocktailFilter_TextChanged | szűrhető koktél-lista |
| ④ | Form1_Load | alapanyag-lista |
| ⑤⑥ | DetailedRecipeItem.cs | rács adatforrása |
| ⑦ | cocktailBindingSource_CurrentChanged → ReadRecipes() | receptek a kiválasztott koktélra |
| ⑧ | buttonAdd_Click | + (mennyiség: NumericUpDown, 2 tizedes) |
| ⑨ | buttonDelete_Click | - |
| Ⓐ | buttonSaveXml_Click | Cocktail → XML, SaveFileDialog |
| Ⓑ | ReadRecipes() | hozzávalók száma a címkében |

## Ami nincs a ZHElott programban, de a lap kéri

- A lap szövegdobozt említ a mennyiséghez; a ZHElott mintájára NumericUpDown van (`(int)...Value` / decimalnál `.Value`).
- XML mentés: `SaveFileDialog` + `System.Xml.Linq` (`XDocument`/`XElement`, LINQ lekérdezéssel).
- Számláló címke: `BindingSource.Count` / `Count()`.

## Figyelem

A `Models/` mappát a séma-ábráról kézzel írtam (az adatbázis-szerver innen nem volt elérhető). Ha eltér a `Scaffold-DbContext` eredménye (mező-/típusnevek), futtasd le a lapon lévő parancsot, és igazítsd hozzá a kódot.
