{ }
zaèátek
  napiš ("Zadej cenu zboží");
  èti(cena);
  napiš ("Zadej výši platby");
  èti (zaplaceno);
  vyplatit:= zaplaceno - cena;
  m50:=vyplatit div 50;
  vyplatit:= vyplatit mod 50;
  
  m20:=vyplatit div 20;
  vyplatit:= vyplatit mod 20;
  
  m10:=vyplatit div 10;
  vyplatit:= vyplatit mod 10;
  
  m5:=vyplatit div 5;
  vyplatit:= vyplatit mod 5;
  
  m2:=vyplatit div 2;
  m1:= vyplatit mod 2;
  
  napiš("Poèet 50Kè ", m50);
  napiš("Poèet 20Kè ", m20);
  napiš("Poèet 10Kè ", m10);
  napiš("Poèet 5Kè ", m5);
  napiš("Poèet 2Kè ", m2);
  napiš("Poèet 1Kè ", m1);
konec