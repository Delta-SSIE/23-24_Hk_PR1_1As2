namespace _11_podminka_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik je ti let: ");
            string nacteno = Console.ReadLine();
            int vek = int.Parse(nacteno);
            /*
                        if (vek < 18)
                        {
                            Console.WriteLine("Jdi raději do kina");
                        }
                        else 
                        {
                            Console.WriteLine("OK můžeš jít volit");
                        }

                        if (vek == 18)
                        {
                            Console.WriteLine("…ale je to natěsno");
                        }*/

            if (vek < 18)
            {
                Console.WriteLine("Jdi raději do kika");
            }
            else
            {
                if (vek == 18)
                {
                    Console.WriteLine("Můžeš jít volit, ale je to těsně");
                }
                else
                {
                    Console.WriteLine("Můžeš jít volit");
                }
            }
        }
    }
}