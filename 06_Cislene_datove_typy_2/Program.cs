namespace _06_Cislene_datove_typy_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 8;
            int b = 10;

            //Základní matemaztické operace
            int soucet = a + b;
            int rozdil = a - b;
            int soucin = a * b;
            //int podil = a / b; // toto není dobře - pracuji s integer
            // double podil = a / b; // toto taé nestačí - stup je integer - pouze dávám více místa pro výsledek, ale nepočítám s poloucí desetinou čárkou
            double podil = (double)a / (double)b;// toto řešení již je dobře - přetypovali jsme vstup
            Console.WriteLine($"Soucet hodnot {a} a {b} je: {soucet} rozdil je: {rozdil}, součin je: {soucin} a podil je: {podil}");
        */
            /* Výpočet nebude dobře, protže jsme překročilil paměťpové místo datového typu
             double cislo = 1.01 * 1000000000000000000; // Vyrábím moc velké číslo
             double vetsicilo = cislo + 1;
             double rozdil = vetsicilo - cislo;

             Console.WriteLine($"Číslo je: {cislo:N3}");
             Console.WriteLine($"Větší číslo je: {vetsicilo:N3}");

             */

            decimal cislo = (decimal)1.01 * 1000000000000000000; // Vyrábím moc velké číslo
            decimal vetsicilo = cislo + 1;
            decimal rozdil = vetsicilo - cislo;

            Console.WriteLine($"Číslo je: {cislo:F3}");
            Console.WriteLine($"Větší číslo je: {vetsicilo:F3}");
            Console.WriteLine($"Rozdíl čísel je: {rozdil:F3}");



        }
    }
}