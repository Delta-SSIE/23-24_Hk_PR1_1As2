{ }   // Výpoèet pátého prvku posloupnosti a(n)=a(n-2)*a(n-1)
zaèátek
èti (x);
èti (y);
jestliže x<y pak
zaèátek
// tady bude výpoèet posloupnosti
napiš("Zadej kolikaty prvek chces spocitat: ");
èti(poradi);
pro i od 3 do poradi opakuj
// výpoèet prvkù posloupnosti v cyklu for
zaèátek
dalsi:= x*y;
x:=y;
y:=dalsi;
konec;


napiš (poradi," prvek posloupnosti je: ", dalsi);
konec
jinak
napiš ("chybnì zadané vstupní hodnoty"); 
konec