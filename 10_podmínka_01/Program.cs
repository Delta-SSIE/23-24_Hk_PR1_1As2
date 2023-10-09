namespace _10_podmínka_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej stranu a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej stranu a");
            int b = int.Parse(Console.ReadLine());
            string tvar;
            int obvod;
            int obsah;

            if (a == b)
                {
                    tvar = "čtverec";
                    obvod = 4 * a;
                    obsah = a * a;
                }
            else
                {
                    tvar = "obdelník";
                    obvod = 2 * (a + b);
                    obsah = a * b;
                }

            Console.WriteLine($"Zadal jsi objekt, kterým je {tvar}, jeho obsah je {obsah} a obvod je {obvod}");

        }
    }
}