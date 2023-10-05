namespace _04_String_retezec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jmeno = "František";
            int pocet = 4;

            //Jak můžeme řetezec vypsat

            Console.WriteLine(jmeno + " má " + pocet + " psy");
            Console.WriteLine("{0} má {1} psy", jmeno, pocet);
            Console.WriteLine($"{jmeno} má {pocet} psy");

        }
    }
}