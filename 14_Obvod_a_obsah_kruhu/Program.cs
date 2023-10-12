namespace _14_Obvod_a_obsah_kruhu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej poloměr kružice");
            double polomer = double.Parse(Console.ReadLine());
            if (polomer < 0)
                Console.WriteLine("Špatně zadaný poloměr");
            else
            {
                double obvod = 2 * Math.PI * polomer;
                double obsah = Math.PI * Math.Pow(polomer, 2); //Pow = druhá mocnina proměnné poloměr
                Console.WriteLine($"Kužnice o poloměru {polomer:N3} má obvod {obvod:N3} a obsah {obsah:N3}");
            }
        }
    }
}