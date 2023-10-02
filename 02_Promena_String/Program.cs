namespace _02_Promena_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš jak se jmenuješ:");
            string name;    //oznámím počítači, že budu používat proměnnou name
                            // a bude to řetězec (kus textu) - string
            name = Console.ReadLine();
            Console.WriteLine("Ahoj " + name + "!");
            string  name2 = "Ahoj " + name + "!"; // deklarovat proměnou při jejím prvním použití
            Console.WriteLine(name2);
            Console.WriteLine("Obsah proměnné name: "+name);
            //Console.WriteLine(nameof(name)); // vypíše jak se daná proměnná jmenuje
            Console.WriteLine("Obsah proměnné "+nameof(name)+" je "+name);
            Console.ReadKey();
        }
    }
}