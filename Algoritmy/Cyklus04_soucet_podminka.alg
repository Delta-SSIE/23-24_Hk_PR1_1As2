{ }
za��tek
�ti (pocet);
vetsich5:=0;
soucet:=0;
// ��st kter� na�te hodnoty od u�ivatele
//vyhodnot� zda spl�uj� pom�nku
pro i od 1 do pocet opakuj
za��tek
   �ti(x); 
   jestli�e x>5 pak
      za��tek
      vetsich5:=vetsich5 + 1;
      soucet:=soucet+x;
      konec;
konec; 
// ��zen� v�pis v�sledku
jestli�e vetsich5 > 0 pak
   za��tek
   napi�("Soucet hodnot vet��ch ne� 5 je: ", soucet);
   napi�("Pocet zadan�ch hodnot v�t��ch ne� 5 bylo: ", vetsich5); 
   konec
jinak
napi�("��dn� ze zadan�ch ��sel nebylo v�t�� ne� 5");    
konec