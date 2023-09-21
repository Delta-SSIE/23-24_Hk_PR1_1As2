{ }
zaèátek
èti (pocet);
vetsich5:=0;
soucet:=0;
// èást která naète hodnoty od uživatele
//vyhodnotí zda splòují pomínku
pro i od 1 do pocet opakuj
zaèátek
   èti(x); 
   jestliže x>5 pak
      zaèátek
      vetsich5:=vetsich5 + 1;
      soucet:=soucet+x;
      konec;
konec; 
// Øízený výpis výsledku
jestliže vetsich5 > 0 pak
   zaèátek
   napiš("Soucet hodnot vetších než 5 je: ", soucet);
   napiš("Pocet zadaných hodnot vìtších než 5 bylo: ", vetsich5); 
   konec
jinak
napiš("Žádné ze zadaných èísel nebylo vštší než 5");    
konec