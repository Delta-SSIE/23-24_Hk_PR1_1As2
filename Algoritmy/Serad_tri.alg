{ }
za��tek
�ti (x);
�ti (y);
�ti (z);
jestli�e x < y pak
  za��tek
    temp := x;
    x := y;
    y := temp;
  konec;
  
jestli�e x < z pak
  za��tek
    temp := x;
    x := z;
    z := temp;
  konec;
  
jestli�e y < z pak
  za��tek
    temp := y;
    y := z;
    z := temp;
  konec;

  // Vypi�te hodnoty ve spr�vn�m po�ad�
  napi�('x = ', x);
  napi�('y = ', y);
  napi�('z = ', z);

konec