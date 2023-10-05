namespace _07_Datovy_typ_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char pismeno = 'A';
            Console.WriteLine("Písmenko je: " + pismeno);

            char pismeno2 = (char)(pismeno + 1);
            Console.WriteLine("Písmenko je: " + pismeno2);

            char pismeno3 = (char)(pismeno + 'b');
            Console.WriteLine("Písmenko je: " + pismeno3);
           
        }
    }
}