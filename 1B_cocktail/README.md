# ZH 1B – Cocktails

## Megnyitás
Visual Studio-ban nyisd meg a `ZH1B.slnx` fájlt (`ZH1B/ZH1B.csproj`, net10.0-windows, EF Core SqlServer). Az űrlap a Visual Studio tervezőjében is megnyitható (`Form1.cs` -> Designer).

## Lépések és megoldásuk

| Lépés | Hol található |
|---|---|
| ① Modell osztályok | `ZH1B/Models/*.cs` (lásd a megjegyzést) |
| ② Felület | `Form1.Designer.cs` |
| ③ Bal lista: koktélok, szűrhetően | `Form1.cs` – `ReadCocktails()`, `textBoxCocktailFilter_TextChanged` |
| ④ Jobb lista: alapanyagok | `Form1.cs` – `ReadMaterials()`, `textBoxMaterialFilter_TextChanged` |
| ⑤ `DetailedRecipeItem` osztály | `DetailedRecipeItem.cs` |
| ⑥ Rács adatforrása | `Form1.Designer.cs` – `detailedRecipeItemBindingSource` (`typeof(DetailedRecipeItem)`) |
| ⑦ Kiválasztott koktél receptje | `Form1.cs` – `cocktailBindingSource_CurrentChanged`, `ReadRecipes()` |
| ⑧ `+` gomb: új recept elem | `Form1.cs` – `buttonAdd_Click` |
| ⑨ `-` gomb: törlés | `Form1.cs` – `buttonDelete_Click` |
| Ⓐ Cocktail tábla mentése XML-be | `Form1.cs` – `buttonSaveXml_Click`, `CocktailXml.cs` |
| Ⓑ Hozzávalók száma címkében | `Form1.cs` – `ReadRecipes()` (`labelCount`) |

## Megjegyzések
- A `Models/` mappát kézzel írtam meg az adatbázis-diagram (`se_cocktails.png`) alapján, mert az adatbázis-szerver nem volt elérhető. Ha tudsz csatlakozni, futtasd le a feladatlapon szereplő `Scaffold-DbContext` parancsot, és ha a tulajdonságnevek vagy típusok eltérnek, igazítsd hozzájuk a kódot.
- A `Type` entitás neve ütközik a `System.Type`-pal, ezért a kódban mindenhol `Models.Type` szerepel.
- A mennyiség mezőben a tizedesvessző és a tizedespont is elfogadott.
- Az XML mentéshez külön, csak egyszerű tulajdonságokat tartalmazó `CocktailXml` osztályt használunk (az entitás navigációs gyűjteményeit az `XmlSerializer` nem tudná szerializálni).
- A `Properties/DataSources/*.datasource` fájlok a Visual Studio adatforrás-kezelőjéhez kellenek.
