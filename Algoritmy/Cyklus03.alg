{ }   // V�po�et p�t�ho prvku posloupnosti a(n)=a(n-2)*a(n-1)
za��tek
�ti (x);
�ti (y);
jestli�e x<y pak
za��tek
// tady bude v�po�et posloupnosti
napi�("Zadej kolikaty prvek chces spocitat: ");
�ti(poradi);
pro i od 3 do poradi opakuj
// v�po�et prvk� posloupnosti v cyklu for
za��tek
dalsi:= x*y;
x:=y;
y:=dalsi;
konec;


napi� (poradi," prvek posloupnosti je: ", dalsi);
konec
jinak
napi� ("chybn� zadan� vstupn� hodnoty"); 
konec