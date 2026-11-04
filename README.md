# ZH megoldások — a ZHElott program stílusában

Mind a 8 változat (1A, 1B, 2A, 2B, 3A, 3B, 4A, 4B) a `ZHElott` megoldásból készült: a lépések ugyanazokat az eszközöket használják, mint az ott lévő `Form1.cs`, `Form1.Designer.cs`, `FormAddProduct.*`, `StockDetail.cs`.

Mappánként: a feladatlap (`*_zh.html`), a séma- és UI-kép, a `.slnx`, a projekt és egy `README.md` a lépés → metódus megfeleltetéssel.

A feladatlap által kért, de a ZHElott programban nem szereplő részek (XML mentés, legördülő doboz, számláló, üres mező ellenőrzés) a változatok README-jében fel vannak sorolva.

Nincs benne `try/catch`, hibakezelés: a ZHElott sem használ (csak `//ToDo: try-catch`). Hibás művelet (pl. már meglévő készlet felvétele, hivatkozott rekord törlése) kivételt dob.

Figyelem: hiba után (pl. már meglévő készlet, hivatkozott rekord törlése) a sikertelen elem a contextben marad, és minden további `SaveChanges` újra hibázik, amíg az alkalmazást újra nem indítod.
