namespace _28_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetDelitelnych8 = 0;
            int celkovyPocetZadanychCisel = 0;

            Console.WriteLine("Zadej pět čísel dělitelných osmi:");

            while (pocetDelitelnych8 < 5)
            {
                Console.Write("Zadej číslo: ");
                int cislo;
                if (int.TryParse(Console.ReadLine(), out cislo))
                {
                    celkovyPocetZadanychCisel++;
                    if (cislo % 8 == 0)
                    {
                        Console.WriteLine($"{cislo} je dělitelné osmi.");
                        pocetDelitelnych8++;
                    }
                    else
                    {
                        Console.WriteLine($"{cislo} není dělitelné osmi.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Neplatný vstup. Zadej platné celé číslo.\n");
                }
            }

            Console.WriteLine($"Bylo zadáno pět čísel dělitelných osmi. Celkem bylo zadáno {celkovyPocetZadanychCisel} čísel. Program končí.");
        }
    }
    
}