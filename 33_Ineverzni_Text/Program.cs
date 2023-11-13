namespace _33_Text_a_cyklus_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializace proměnných
            string vstup = "";
            int pocetOpakovani = 0;

            // Výzva k zadání textu od uživatele
            Console.WriteLine("Zadejte text (pro ukončení napište 'konec'):");

            // Cyklus while pro opakování zadávání textu
            while (vstup.ToLower() != "konec")
            {
                // Získání vstupu od uživatele
                Console.Write("Vstup {0}: ", pocetOpakovani + 1);
                vstup = Console.ReadLine();

                // Výpis délky zadaného textu
                Console.WriteLine("Délka zadaného textu: " + vstup.Length);

                // Výpis inverzního textu bez použití cyklu for
                Console.Write("Inverzní text: ");
                int i = vstup.Length - 1;
                while (i >= 0)
                {
                    Console.Write(vstup[i]);
                    i--;
                }
                Console.WriteLine();

                // Zvýšení počtu opakování
                pocetOpakovani++;
            }

            Console.WriteLine("Program ukončen. Celkový počet opakování: " + pocetOpakovani);

            Console.ReadLine(); // Pauza na zobrazení výsledků
        }
    }
}