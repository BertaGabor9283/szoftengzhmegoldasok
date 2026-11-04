# 3A_allatkorhaz — ZH3A

Megnyitás: `ZH3A.slnx` Visual Studióban. Az alap a `ZHElott` megoldás: ugyanaz a felépítés és ugyanazok a megoldások (context mező, LINQ lekérdezés, BindingSource + `.ToList()`, `Add`/`SaveChanges`/`RemoveRange`, `//ToDo: try-catch`).

| Lépés | Hol | Mit |
|---|---|---|
| ①② | Form1.Designer.cs, ProcedureDoneItem.cs | projekt, felület |
| ③ | Form1_Load, textBoxAnimalFilter_TextChanged | szűrhető állat-lista |
| ④ | Form1_Load | kezelés-típusok (Procedure) lista |
| ⑤ | animalBindingSource_CurrentChanged → ReadTreatments() | kezelések, megjelenített mező: Date |
| ⑥⑦ | ProcedureDoneItem.cs, procedureDoneItemBindingSource | harmadik lista adatforrása |
| ⑧ | treatmentBindingSource_CurrentChanged → ReadProcedureDones() | elvégzett kezelések |
| ⑨ | buttonAdd_Click | + |
| Ⓐ | buttonSaveXml_Click | Animal → XML, SaveFileDialog |
| Ⓑ | Form1_Load | állatok száma (az egész táblában) a címkében |

## Ami nincs a ZHElott programban, de a lap kéri

- XML mentés: `SaveFileDialog` + `System.Xml.Linq` (`XDocument`/`XElement`, LINQ lekérdezéssel).
- Számláló címke: `BindingSource.Count` / `Count()`.

## Figyelem

A `Models/` mappát a séma-ábráról kézzel írtam (az adatbázis-szerver innen nem volt elérhető). Ha eltér a `Scaffold-DbContext` eredménye (mező-/típusnevek), futtasd le a lapon lévő parancsot, és igazítsd hozzá a kódot.
