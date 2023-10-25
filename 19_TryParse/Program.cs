namespace _18_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo: ");

            int cislo;
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Má to být číslo.");
            }



            Console.WriteLine("Zadal jsi {0}", cislo);
        }
    }
}