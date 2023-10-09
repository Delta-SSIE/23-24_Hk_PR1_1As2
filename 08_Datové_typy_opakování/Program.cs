namespace _08_Datové_typy_opakování
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetRohliku = 5; // pro celé číslo použijeme datový typ int
            Console.WriteLine("Kup " + pocetRohliku + " rohlíků");


            double cenaZaLitr = 33.5; // Desetinná čísla ukládáme jako datový typ double
            Console.WriteLine("Za litr nafty dnes zaplatíte " + cenaZaLitr + "Kč");


            char prvniPismeno = 'A'; // Datový typ char znamená jeden jediný znak, píšeme v jednoduchých uvozovkách
            Console.WriteLine("První písmeno abecedy je \"" + prvniPismeno + "\".");


            string textZpravy = "Už mě neuvidíš"; // Pro texty používáme typ string a uzavřeme do dvojitých uvozovek
            Console.WriteLine("Přišla mi zpráva s tímto textem: " + textZpravy);


            int autaZaDen = 547; // celé číslo
            Console.WriteLine("Dnes naší ulicí projelo " + autaZaDen + " aut.");


            char interpunkcniZnamenko = '.'; // jeden znak
            Console.WriteLine("K oddělení vět v souvětí používáme symbol \"" + interpunkcniZnamenko + "\"");


            double delkaHrany = 33.5; // délka hrany je číslo, může mít i desetiny
            Console.WriteLine("Základna trojúhleníka měří " + delkaHrany + " cm.");


            string prijmeni = "Novák"; // více než jeden znak => řetězec
            Console.WriteLine(prijmeni + " je časté příjmení.");
        }
    }
}