using System;
using Grid_Class;

namespace Zadanie2
{

    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid(5, 4);

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 4; j++)
                    grid.tab[i][j] = 2 * i + j;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(grid.tab[i][j] + " ");
                }
                Console.WriteLine();
            }

            int u = grid[1, 0];
            Console.WriteLine(u);
            grid[1, 1] = 7;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(grid.tab[i][j] + " ");
                }
                Console.WriteLine();
            }

            int[] rowdata = grid[1];
            for (int i = 0; i < 4; i++)
                Console.Write(rowdata[i] + " ");


            Console.WriteLine('\n' + "---------------------------");

            int[] rowdata2 = grid[3];
            for (int i = 0; i < 4; i++)
                Console.Write(rowdata2[i] + " ");

        }

    }
}
