namespace _32_Nahodna_cislo_prumer_kladnych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int pocetHodnot = 20;
            int soucet = 0;
            int pocetKladnychHodnot = 0;

            int i = 0;

            while (i < pocetHodnot)
            {
                int nahodnaHodnota = random.Next(-10, 11);

                // Pokud je hodnota kladná, vypíšeme ji a přičteme k součtu
                if (nahodnaHodnota > 0)
                {
                    Console.WriteLine("Kladná hodnota: " + nahodnaHodnota);
                    pocetKladnychHodnot++;
                    soucet += nahodnaHodnota;
                }

                i++;
            }

            // Pokud byly vygenerovány alespoň jedna kladná hodnota, vypočítáme průměr
            if (pocetKladnychHodnot > 0)
            {
                double prumer = (double)soucet / pocetKladnychHodnot;
                Console.WriteLine("Průměr kladných hodnot: " + prumer);
            }
            else
            {
                Console.WriteLine("Nebyly vygenerovány žádné kladné hodnoty.");
            }

            Console.ReadLine(); // Pauza na zobrazení výsledků
        }
    }
}