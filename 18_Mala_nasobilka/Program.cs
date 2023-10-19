namespace _18_Mala_nasobilka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo mezi 1 - 10, kde chceš vypočítat malou násobilku");
            int cislo = int.Parse(Console.ReadLine());
            while (cislo > 10)
            {
                Console.WriteLine("Číslo musí být v rozmezí 1 -10. Zadej jej znova");
                cislo = int.Parse(Console.ReadLine());
            }
            int i = 0;
            int soucin = 0;
            while (i <= 10)
            {
                Console.WriteLine($"{cislo} * {i} = {soucin}");
                i++;
                soucin = cislo * i;
            }
        }
    }
}