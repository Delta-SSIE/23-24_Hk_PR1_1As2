namespace _27_posleni_nactene_vetsi_nez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool nalezeno = false;
            int posledni_vetsi = 0;

            Console.Write("Zadejte počet zadáavných čísel: ");
            int p = int.Parse(Console.ReadLine());

            int i = 1;
            while (i <= p)
            {
                Console.Write("Zadejte číslo: ");
                int cislo = int.Parse(Console.ReadLine());

                if (cislo > 15)
                {
                    posledni_vetsi = cislo;
                    nalezeno = true;
                }

                i++;
            }

            if (nalezeno)
            {
                Console.WriteLine("Poslední načtené číslo větší než 15 je: " + posledni_vetsi);
            }
            else
            {
                Console.WriteLine("Mezi načtenými čísly nebylo žádné číslo větší než 15.");
            }
        }
    }
}