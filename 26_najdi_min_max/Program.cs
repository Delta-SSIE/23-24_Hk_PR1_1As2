namespace _26_najdi_min_max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej počet hodnot, v kterých chceš nalézt minimum a maximum");
            int pocet = int.Parse(Console.ReadLine());
            int i = 0;
            int cislo;
            int min = int.MaxValue;
            int pozice_min = 0;
            int max = int.MinValue;
            int pozice_max = 0;
            
            while (pocet > i)
            {
                Console.WriteLine($"Zadej {i + 1}. hodnotu");
                cislo = int.Parse(Console.ReadLine());
                i++;
                if (cislo < min)
                { 
                    min = cislo;
                    pozice_min = i;
                }
                if (cislo > max)
                { 
                    max = cislo;
                    pozice_max = i;
                }
            }
            if (pocet > 1)
            {
                Console.WriteLine($"Minimální zadaná hodnota je {min} a byla zadána jako {pozice_min}.\n Maximální zadaná hodnota je {max} a byla zadána jako {pozice_max}.");
            }


        }
    }
}