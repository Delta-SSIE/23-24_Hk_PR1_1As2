namespace Test_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte tři rozměry (délky stran) krychle nebo kvádru:");

            // Načteme tři celá čísla ze vstupu
            Console.Write("Strana a trojrozměrné tělesa: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Strana b trojrozměrné tělesa: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Strana c trojrozměrné tělesa: ");
            int c = int.Parse(Console.ReadLine());

            if (a < 1 || b < 1 || c < 1)
            {
                Console.WriteLine("NEJEDNÁ se o krychli ani kvádr.");
            }
            else
            if (a == b && b == c)
            {
                // Všechny strany jsou stejné, jedná se o krychli
                int objem = a * a * a;
                int povrch = 6 * a * a;
                Console.WriteLine("Jedná se o krychli.");
                Console.WriteLine($"Objem krychle: {objem}");
                Console.WriteLine($"Povrch krychle: {povrch}");
            }
            else
            {
                int objem = a * b * c;
                int povrch = 2 * (a * b + b * c + a * c);
                Console.WriteLine("Jedná se o kvádr.");
                Console.WriteLine($"Objem kvádru: {objem}");
                Console.WriteLine($"Povrch kvádru: {povrch}");
            }



        }
    }
}