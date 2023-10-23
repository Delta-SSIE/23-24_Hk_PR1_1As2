namespace _24_hra_v_kostky_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random(); // vytvářím konstruktor třídy Random se jménem generator
            bool pokracovat = true;
            int hra = 0;
            bool dalsi_hod = true;
            char volba2;
            Console.ReadKey();
            do
            {
                Console.Clear();
                while (dalsi_hod)
                {
                    int kostka_a = generator.Next(0, 7);
                    int kostka_b = generator.Next(0, 7);
                    hra++;
                    if (kostka_a == kostka_b)
                    {
                        Console.WriteLine($"Na první kostce padlo číslo {kostka_a} a na druhé kostce padlo {kostka_b}.\n Hra je po {hra} hodech ukočena.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Padli hodnoty {kostka_a} a {kostka_b}. Stikni libovonou klávesu s jedeme dál.");
                        Console.ReadKey();
                    }
                }
                Console.WriteLine("Pro novou hru stiskni a");
                string volba = (Console.ReadLine()).ToLower();
                volba2 = char.Parse(volba);
                if (volba2 != 'a')
                    break;
            } while (pokracovat);
        }
    }
}