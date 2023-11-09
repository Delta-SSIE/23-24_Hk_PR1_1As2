namespace _30_Dec_to_bin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo v desítkové soustavě: ");

            int cislo = int.Parse(Console.ReadLine());
            int cislo2 = cislo;
            string overeni = Convert.ToString(cislo, 2); // volaní konverze z desítkové do binární soustavy
            Console.WriteLine("Prevedená hodnota vestavenou funkcí je: " + overeni);
            
            
            string binCislo = ""; // založení proměnní typu string pro výsledek

            while (cislo > 0)
            {
                int zbytek = cislo % 2;
                binCislo = zbytek + binCislo;
                cislo /= 2;
            }

            Console.WriteLine();
            Console.WriteLine($"Prevedená hodnota {cislo2} desikové soustavy je v binární soustavě: {binCislo}");
            Console.ReadKey();
        }
    }
}
