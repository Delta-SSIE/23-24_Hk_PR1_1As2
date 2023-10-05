namespace _05_Ciselne_datove_typy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nacteno;
            Console.WriteLine("Zadej celé číslo");
            
            /* Toto je moc dlouhé a ukacané
             nacteno = Console.ReadLine();


             int cislo; //delkaruji pormněou typi INTEGER - celá čísla
             cislo = int.Parse(nacteno); // Přetypování datového typu string na integer
             //cislo = cislo + 1; // zvyšuji hodnotu proměnné číslo o 1
             cislo++; // inkrementace hodnoty o 1 místo cislo = cislo + 1
             Console.WriteLine($"Zvětšené číslo má novou hodnotu {cislo}");
             */

            // Zlatá třední cesta
            int cislo = int.Parse(Console.ReadLine());
            cislo++;
            Console.WriteLine($"Zvětšené číslo má novou hodnotu {cislo}");

            // extremní minimalistická verze
            //Console.WriteLine("Zvětšeno: " + (int.Parse(Console.ReadLine()) + 1));


        }
    }
}