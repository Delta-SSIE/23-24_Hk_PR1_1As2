{ }   // V�po�et p�t�ho prvku posloupnosti a(n)=a(n-2)*a(n-1)
za��tek
�ti (x);
�ti (y);
jestli�e x<y pak
za��tek
// tady bude v�po�et posloupnosti
i:= 3;
dokud i<= 5 opakuj
// v�po�et prvk� posloupnosti v cyklu
za��tek
dalsi:= x*y;
x:=y;
y:=dalsi;
i:=i+1;
konec;
napi� ("P�t� prvek posloupnosti je: ", dalsi);
konec
jinak
napi� ("chybn� zadan� vstupn� hodnoty"); 
konec