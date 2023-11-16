namespace _31_Dec_to_Hex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Napiště program, který převede zadané číslo v dsítkové soustavě do hexadecimílní osustavy.
             * Pro ověření využijte funkci Convert.ToString(proměnná, 16)
             */

            // ŘEŠENÍ   
            string hexCislo = "";
            string hexZbytek;
            Console.WriteLine("Zadej cislo v desítkové suustavě, které chceš převést");
            int cislo = int.Parse(Console.ReadLine());
            int cislo2 = cislo;
            string overeni = Convert.ToString(cislo, 16).ToUpper();
            Console.WriteLine("Prevedená hodnota vestavenou funkcí je: " + overeni);
            while (cislo > 0)
            {
                int zbytek = cislo % 16;
                cislo /= 16;
                switch (zbytek)
                {
                    case 0:
                        hexCislo = zbytek + hexCislo;
                        break;
                    case 1:
                        hexCislo = zbytek + hexCislo;
                        break;
                    case 2:
                        hexCislo = zbytek + hexCislo;
                        break;
                    case 3:
                        hexCislo = zbytek + hexCislo;
                        break;
                    case 4:
                        hexCislo = zbytek + hexCislo;
                        break;
                    case 5:
                        hexCislo = zbytek + hexCislo;
                        break;
                    case 6:
                        hexCislo = zbytek + hexCislo;
                        break;
                    case 7:
                        hexCislo = zbytek + hexCislo;
                        break;
                    case 8:
                        hexCislo = zbytek + hexCislo;
                        break;
                    case 9:
                        hexCislo = zbytek + hexCislo;
                        break;
                    case 10:
                        hexZbytek = "A";
                        hexCislo = hexZbytek + hexCislo;
                        break;
                    case 11:
                        hexZbytek = "B";
                        hexCislo = hexZbytek + hexCislo;
                        break;
                    case 12:
                        hexZbytek = "C";
                        hexCislo = hexZbytek + hexCislo;
                        break;
                    case 13:
                        hexZbytek = "D";
                        hexCislo = hexZbytek + hexCislo;
                        break;
                    case 14:
                        hexZbytek = "E";
                        hexCislo = hexZbytek + hexCislo;
                        break;
                    case 15:
                        hexZbytek = "F";
                        hexCislo = hexZbytek + hexCislo;
                        break;
                    default:
                        hexCislo = zbytek + hexCislo;
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Prevedená hodnota {cislo2} desikové soustavy je v osmičkové soustavě: {hexCislo}");

            Console.ReadKey();
        }
    }
}