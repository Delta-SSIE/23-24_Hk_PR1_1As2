{ }   // Výpoèet pátého prvku posloupnosti a(n)=a(n-2)*a(n-1)
zaèátek
èti (x);
èti (y);
jestliže x<y pak
zaèátek
// tady bude výpoèet posloupnosti
i:= 3;
dokud i<= 5 opakuj
// výpoèet prvkù posloupnosti v cyklu
zaèátek
dalsi:= x*y;
x:=y;
y:=dalsi;
i:=i+1;
konec;
napiš ("Pátý prvek posloupnosti je: ", dalsi);
konec
jinak
napiš ("chybnì zadané vstupní hodnoty"); 
konec