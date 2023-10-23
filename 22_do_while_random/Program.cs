namespace Test02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int cislo;
            int i;
            bool znova;
            do
            {
                cislo = generator.Next(-5, 5);
                i = 1;
                while ((cislo % 2) == 0)
                {
                    cislo = generator.Next(-5, 6);
                    i++;
                }
                Console.WriteLine($"\nLiché cislo {cislo} jsem vygeneroval na {i}. pokus.\n ");
                Console.WriteLine($"Chceš generování opakovat? N/Y\n");
                znova = (Console.ReadKey().KeyChar != 'Y') ? false:true; //  ternární operátor
            } while (znova);
        }
    }
}