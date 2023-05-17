using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur stora sidor ska kvadraten ha? : ");
            int Sida=Convert.ToInt32(Console.ReadLine());
            Console.Write("Vilket tecken ska kvadraten ha? : ");
            string tecken = Console.ReadLine();
            Console.Write("Hur stort mellanrum ska det vara? : ");
            int mellanrum = Convert.ToInt32(Console.ReadLine());
            RitaKvadrat(Sida, tecken, mellanrum);
        }

        static void RitaKvadrat(int Sida, string tecken, int mellanrum)
        {
            for(int i = 0; i < Sida; i++)
            {
                for(int j = 0; j < Sida; j++)
                {
                    Console.Write(tecken);
                    for(int k = 0; k <mellanrum; k++)
                        Console.Write(" ");

                }

                for (int k = 0; k <= mellanrum; k++)
                {
                    Console.WriteLine();
                }
            }
        }


    }
}