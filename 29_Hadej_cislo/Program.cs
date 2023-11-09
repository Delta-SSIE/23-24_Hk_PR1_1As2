namespace _29_Uhadni_cislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random(); // vytvářím konstruktor třídy Random se jménem generator
            Console.WriteLine("Náhodně vygeneruji číslo z intervalu <0, 10 >");
            int tajne_cislo = generator.Next(0, 11);

            Console.WriteLine("Kolik chceš pokusů?");
            int pokusu;
            while (!int.TryParse(Console.ReadLine(), out pokusu))
            {
                Console.WriteLine("Musíš zadat číslo!");
            }

            int pocet_kol = 0;
            int tip;

            while (pocet_kol < pokusu)
            {
                Console.WriteLine("Zadej číslo, které si myslíš, že jsem vygeneroval:");
                while (!int.TryParse(Console.ReadLine(), out tip))
                {
                    Console.WriteLine("Musíš zadat číslo!");
                }
                pocet_kol++;
                if (tip > tajne_cislo && pocet_kol < pokusu)
                    Console.WriteLine("Tajné číslo je menší než tebou zadané");
                else
                {
                    if (tip < tajne_cislo && pocet_kol < pokusu)
                        Console.WriteLine("Tajné číslo je větší než tebou zadané");
                    else
                    {
                        if (tip == tajne_cislo)
                        {
                            Console.WriteLine($"Gratuluji uhádl jsi tajné číslo na {pocet_kol} pokus. ");
                            break;
                        }
                    }
                }
            }

            if (pocet_kol >= pokusu)
                Console.WriteLine($"Tajné číslo bylo {tajne_cislo} a neuhádl jsi ho!");
        }
    }
    
}