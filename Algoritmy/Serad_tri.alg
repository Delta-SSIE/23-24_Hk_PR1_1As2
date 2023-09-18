{ }
zaèátek
èti (x);
èti (y);
èti (z);
jestlie x < y pak
  zaèátek
    temp := x;
    x := y;
    y := temp;
  konec;
  
jestlie x < z pak
  zaèátek
    temp := x;
    x := z;
    z := temp;
  konec;
  
jestlie y < z pak
  zaèátek
    temp := y;
    y := z;
    z := temp;
  konec;

  // Vypište hodnoty ve správném poøadí
  napiš('x = ', x);
  napiš('y = ', y);
  napiš('z = ', z);

konec