using System;

namespace Test_No._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 3;
            int column = 3;
            int[,] Number = new int[row, column];

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Number[j, i] = int.Parse(Console.ReadLine());
                }
            }

            int NewNumber = int.Parse(Console.ReadLine());

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    Console.Write(Number[a, b]);
                    Console.Write("");
                }
                Console.WriteLine();
            }
        }
    }
}
