namespace _35_trojuhlenik_kreslení
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Zadejte délku strany čtverce: ");
            int delkaStrany = Convert.ToInt32(Console.ReadLine());
            int aktualniRadek = 1;

           while (aktualniRadek <= delkaStrany)
            {
                int pocetZnaku = 1;

                // Vykreslení znaků v řádku
                while (pocetZnaku <= delkaStrany)
                {
                    Console.Write("#");
                    pocetZnaku++;   
                }
                // Přechod na nový řádek
               Console.WriteLine();
                // Přechod na další řádek
               aktualniRadek++;
                
           }*/
            
                
                    Console.WriteLine("Zadejte počet řádků trojúhelníku: ");
                    int pocetRadku = Convert.ToInt32(Console.ReadLine());

                    int aktualniRadek = 1;

                    while (aktualniRadek <= pocetRadku)
                    {
                        int pocetMezer = pocetRadku - aktualniRadek;

                        // Vykreslení mezer před trojúhelníkem
                        int i = 0;
                        while (i < pocetMezer)
                        {
                            Console.Write("_");
                            i++;
                        }
                        // Vykreslení znaků trojúhelníku
                        int pocetZnaku = 2 * aktualniRadek - 1;
                        int j = 0;
                        while (j < pocetZnaku)
                        {
                            Console.Write("#");
                            j++;
                        }

                        // Přechod na nový řádek
                        Console.WriteLine();

                        // Přechod na další řádek
                        aktualniRadek++;
                    }
                Console.ReadLine();

        }
    }
}