# ZH 2B – Cocktails

## Megnyitás
Visual Studio-ban nyisd meg a `ZH2B.slnx` fájlt (`ZH2B/ZH2B.csproj`, net10.0-windows, EF Core SqlServer). Az űrlapok a Visual Studio tervezőjében is megnyithatók.

## Lépések és megoldásuk

| Lépés | Hol található |
|---|---|
| ① Modell osztályok | `ZH2B/Models/*.cs` (lásd a megjegyzést) |
| ② Felület | `Form1.Designer.cs` |
| ③ Bal lista: koktélok, szűrhetően | `Form1.cs` – `ReadCocktails()`, `textBoxCocktailFilter_TextChanged` |
| ④ Jobb lista: alapanyagok | `Form1.cs` – `ReadMaterials()`, `textBoxMaterialFilter_TextChanged` |
| ⑤ `DetailedRecipeItem` osztály | `DetailedRecipeItem.cs` |
| ⑥ Rács adatforrása | `Form1.Designer.cs` – `detailedRecipeItemBindingSource` (`typeof(DetailedRecipeItem)`) |
| ⑦ Kiválasztott koktél receptje | `Form1.cs` – `cocktailBindingSource_CurrentChanged`, `ReadRecipes()` |
| ⑧ `+` gomb: új recept elem | `Form1.cs` – `buttonAdd_Click` |
| ⑨ `-` gomb: törlés | `Form1.cs` – `buttonDelete_Click` |
| Ⓐ Koktélok kezelése másik űrlapon, mentéssel | `Form1.cs` – `buttonCocktails_Click`; `FormCocktails.cs` – `FormCocktails_Load`, `buttonSave_Click` |
| Ⓑ Típus legördülő dobozból | `FormCocktails.Designer.cs` – `typeFkDataGridViewComboBoxColumn`; `FormCocktails.cs` – `FormCocktails_Load` |

## Megjegyzések
- A `Models/` mappát kézzel írtam meg az adatbázis-diagram (`se_cocktails.png`) alapján, mert az adatbázis-szerver nem volt elérhető. Ha tudsz csatlakozni, futtasd le a feladatlapon szereplő `Scaffold-DbContext` parancsot, és ha a tulajdonságnevek vagy típusok eltérnek, igazítsd hozzájuk a kódot.
- A `Type` entitás neve ütközik a `System.Type`-pal, ezért a kódban mindenhol `Models.Type` szerepel.
- A mennyiség mezőben a tizedesvessző és a tizedespont is elfogadott.
- A `FormCocktails` konstruktora megkapja a `Form1` `context`-jét, így közös a szerkesztés. A rács forrása `context.Cocktails.Local.ToBindingList()` (a `Microsoft.EntityFrameworkCore` using kell hozzá), ezért a hozzáadás, módosítás és törlés követve van; a `Mentés` gomb egyetlen `SaveChanges()`.
- A `FormCocktails` bezárása után `Form1` újraolvassa a koktélokat (`ReadCocktails()`).
- Olyan koktél, amelyhez recept tartozik, nem törölhető (idegen kulcs hiba); a hibaüzenet `MessageBox`-ban jelenik meg.
- A `CocktailSk` oszlop rejtett és csak olvasható; navigációs oszlopok nincsenek.
- A `FormCocktails` paraméter nélküli konstruktora csak a Visual Studio tervezőjének kell.
- A `Properties/DataSources/*.datasource` fájlok a Visual Studio adatforrás-kezelőjéhez kellenek.
