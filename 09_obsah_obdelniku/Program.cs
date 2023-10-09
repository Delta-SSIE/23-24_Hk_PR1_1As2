namespace _09_obsah_obdelnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej stanu a obdelníku");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej stanu a obdelníku");
            int b = int.Parse(Console.ReadLine());
            int obsah = a * b;
            int obvod = 2 * (a + b);
            Console.WriteLine($"Obdelnik o staně {a} a {b} má obvod {obvod} a obsah {obsah}");
            Console.ReadKey();
        }
    }
}