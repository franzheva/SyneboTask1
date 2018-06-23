using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyneboTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input A:");
                int A = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input B (must be bigger than A):");

                int B = Int32.Parse(Console.ReadLine());

                if (A <= B)
                {
                    int C = Count(A, B);
                    Console.WriteLine($"This interval has {C} whole squares");
                }
                else
                {
                    Console.WriteLine("Wrong input! Press any key to exit");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }
        static int Count(int a, int b)
        {
            int length = b - a;
            int c = 0;

            for (int i = 0; i <= length; i++)
            {
                if ((Math.Sqrt(a) % 1) == 0)
                    c++;
                a++;
            }
            return c;

        }

    }
}
