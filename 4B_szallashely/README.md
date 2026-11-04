# 4B_szallashely — ZH4B

Megnyitás: `ZH4B.slnx` Visual Studióban. Az alap a `ZHElott` megoldás: ugyanaz a felépítés és ugyanazok a megoldások (context mező, LINQ lekérdezés, BindingSource + `.ToList()`, `Add`/`SaveChanges`/`RemoveRange`, `//ToDo: try-catch`).

| Lépés | Hol | Mit |
|---|---|---|
| ①② | Form1.Designer.cs | projekt, felület |
| ③ | Form1_Load, textBoxFilter_TextChanged | szűrhető szálláshely-lista (SzallasNev) |
| ④ | Form1_Load | vendég-lista (Nev) |
| ⑤ | szallashelyBindingSource_CurrentChanged → ReadSzobak() | szobaszámok |
| ⑥⑦ | foglalasBindingSource (typeof Models.Foglalas), szobaBindingSource_CurrentChanged → ReadFoglalasok() | foglalások a rácsban |
| ⑧ | Form1.Designer.cs | kulcsoszlopok rejtve; cellák szerkeszthetők; sorokat a +/- gombok kezelik (a lap mondata nem egyértelmű, a UI-kép szerint értelmeztem) |
| ⑨ | buttonAdd_Click | + (felnőtt: 1; vendég: a jobb listában kijelölt) |
| ⑩ | buttonSave_Click | Save |
| ⑪ | buttonDelete_Click | - |
| Ⓐ | buttonSaveXml_Click | szálláshelyek nevei → XML, SaveFileDialog |
| Ⓑ | Form1_Load | szálláshelyek száma a címkében |

## Ami nincs a ZHElott programban, de a lap kéri

- XML mentés: `SaveFileDialog` + `System.Xml.Linq` (`XDocument`/`XElement`, LINQ lekérdezéssel).
- Számláló címke: `BindingSource.Count` / `Count()`.
- `DateOnly.FromDateTime` az új foglalás dátumaihoz (a modell DateOnly mezőket használ).

## Figyelem

A `Models/` mappát a séma-ábráról kézzel írtam (az adatbázis-szerver innen nem volt elérhető). Ha eltér a `Scaffold-DbContext` eredménye (mező-/típusnevek), futtasd le a lapon lévő parancsot, és igazítsd hozzá a kódot.
