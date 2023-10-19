namespace _17_Cyklus_while_počítání_čísel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej konečné číslo");
            int final = int.Parse(Console.ReadLine());
            int soucet= 0;

            /* while (soucet <= final)
             {
                 Console.WriteLine(soucet);
                 soucet = soucet + 1;

                 Console.ReadKey();
             }*/
            while (soucet < final)
           {
                soucet = soucet + 1;
                Console.WriteLine(soucet);
                Console.ReadKey();
           }


        }
    }
}