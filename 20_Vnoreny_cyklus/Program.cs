namespace _20_Vnoreny_cyklus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo;
            Console.WriteLine("Zadej číslo");
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Má to být číslo.");
            }
            int soucet = cislo;
            while (soucet < 1000)
            {
                Console.WriteLine("Zadej číslo");
                while (!int.TryParse(Console.ReadLine(), out cislo))
                {
                    Console.WriteLine("Má to být číslo.");
                }
                soucet += cislo;
            }


            Console.WriteLine("Celkový součet je: {0}", soucet);
        }
    }
}