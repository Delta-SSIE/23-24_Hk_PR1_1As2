namespace _23_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo dne (1-7): ");
            int cislo = int.Parse(Console.ReadLine());

            string den;
            /*
            if (cislo == 1)
            {
                den = "pondělí"; // Console.WriteLine($"Dnes je ponděli.");
            } 
            else if (cislo == 2)
            {
                den = "úterý";
            }
            else if (cislo == 3)
            {
                den = "středa";
            }
            else if (cislo == 4)
            {
                den = "čtvrtek";
            }
            else if (cislo == 5)
            {
                den = "pátek";
            }
            else if (cislo == 6)
            {
                den = "sobota";
            }
            else if (cislo == 7)
            {
                den = "neděle";
            }
            else
            {
                den = "nějaký divný den";
            }
            */

            switch (cislo)
            {
                case 1:
                    den = "pondělí";
                    break;
                case 2:
                    den = "úterý";
                    break;
                case 3:
                    den = "středa";
                    break;
                case 4:
                    den = "čtvrtek";
                    break;
                case 5:
                    den = "pátek";
                    break;
                case 6:
                    den = "sobota";
                    break;
                case 7:
                    den = "neděle";
                    break;
                default:
                    den = "nějaký divný den";
                    break;
            }
            Console.WriteLine($"Dnes je {den}.");
        }
    }
}