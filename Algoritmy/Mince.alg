{ }
za��tek
  napi� ("Zadej cenu zbo��");
  �ti(cena);
  napi� ("Zadej v��i platby");
  �ti (zaplaceno);
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
  
  napi�("Po�et 50K� ", m50);
  napi�("Po�et 20K� ", m20);
  napi�("Po�et 10K� ", m10);
  napi�("Po�et 5K� ", m5);
  napi�("Po�et 2K� ", m2);
  napi�("Po�et 1K� ", m1);
konec