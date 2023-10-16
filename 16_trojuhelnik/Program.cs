namespace _16_trojuhelnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte stranu A trojhuleníku ABC v cm");
            string stranaA = Console.ReadLine();
            Console.WriteLine("Zadejte stranu B trojhuleníku ABC v cm");
            string stranaB = Console.ReadLine();
            Console.WriteLine("Zadejte stranu C trojhuleníku ABC v cm");
            string stranaC = Console.ReadLine();

            double strA = double.Parse(stranaA);
            double strB = double.Parse(stranaB);
            double strC = double.Parse(stranaC);
            bool trojuhelnik = true;

            if (!(strA+strB<strC || strA+strC<strB || strB+strC<strA))  //(strA + strB > strC == strA + strC > strB && strA + strB > strC == strB + strC > strA && strA + strC > strB == strB + strC > strA)

            {
                Console.WriteLine("Zadaný Trojuhelník je správný");

                if (strA == strB && strB == strC && strA == strC)

                {
                    Console.WriteLine("Trojuhelník je Rovnostraný");
                }

                    else if (strA == strB || strB == strC || strA == strC)

                    {
                     Console.WriteLine("Zadaný Trojuhelník je Rovnoramený");
                    }

                        else if (Math.Pow(strC, 2) == Math.Pow(strA, 2) + Math.Pow(strB, 2) || Math.Pow(strB, 2) == Math.Pow(strA, 2) + Math.Pow(strC, 2) || Math.Pow(strA, 2) == Math.Pow(strB, 2) + Math.Pow(strC, 2))

                        {
                           Console.WriteLine("Trojuhelník je Pravoúhlý");
                        }

                            else

                            {
                                Console.WriteLine("Trojuhelník je obecný");
                            }
            }
                    else
                        { 
                         Console.WriteLine("Trojúhelník není správný");
                         trojuhelnik = false;
                        }

            if (trojuhelnik)
                {
                double obvod = strA + strB + strC;
                double s =(strA + strB + strC) / 2;
                double obsah = Math.Sqrt(s * (s - strA) * (s - strB) * (s - strC));
                Console.WriteLine($"Troúhelník o stanách {stranaA}, {stranaB}, {stranaC} má obvod {obvod:N3}  v cm a obsah {obsah:N3} v cm2") ;
                }

        }
    }
}