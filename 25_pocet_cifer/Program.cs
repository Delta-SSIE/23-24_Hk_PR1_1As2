namespace _25_pocet_cifer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Načtení čísla z uživatele
            Console.Write("Zadejte číslo: ");
            int cislo;
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Má to být číslo.");
            }
            
                // Určení počtu cifer v čísle
                int pocetCifer = 0;
                int zbytek = Math.Abs(cislo);
                string text;

                while (zbytek > 0)
                {
                    zbytek /= 10;
                    pocetCifer++;
                }

                switch (pocetCifer)
                {
                    case 1:
                        text = "Zadané číslo je jednociferné";
                        break;
                    case 2:
                        text = "Zadané číslo je dvojciferné";
                        break;
                    case 3:
                        text = "Zadané číslo je trojociferné";
                        break;
                    case 4:
                        text = "Zadané číslo je čtyřciferné";
                        break;
                    case 5:
                        text = "Zadané číslo je pěticiferné";
                        break;
                    case 6:
                        text = "Zadané číslo je šesticiferné";
                        break;
                    case 7:
                        text = "Zadané číslo je sedmiciferné";
                        break;
                    case 8:
                        text = "Zadané číslo je osmiciferné";
                        break;
                    case 9:
                        text = "Zadané číslo devíticiferné";
                        break;
                    case 10:
                        text = "Zadané číslo je deseticiferné";
                        break;
                    default:
                        text = "Zadané číslo má více než deset cifer a na mě je už moc velké :)))";
                        break;
                }


                Console.WriteLine(text);
          
        }
    }
}