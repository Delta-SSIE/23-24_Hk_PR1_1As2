namespace _03_Promenna_string_zapis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, jsem virtuální papoušek Lóra, rád opakuji!");
            Console.WriteLine("Napiš něco: ");

            /*
            string vstup;   // vytnoření proměnné datového typu string
            vstup = Console.ReadLine(); // uložní zadaného textu do proměnné vstup
            */
           
            string vstup = Console.ReadLine();
            //vstup = vstup + " " + vstup + " " + vstup + "!";*/ // modifikuji proměnou samotnou - ztrácím její původní hodnotu
            string vstup2 = vstup + " " + vstup + " " + vstup + "!"; // Nová proměná umožní zachovat hodnotu původní proměnné
           
            
            //Console.WriteLine(Console.ReadLine()); // Výpis toho co jsem zadal n konzoli


           Console.WriteLine(vstup2);
            Console.ReadKey();
        }
    }
}