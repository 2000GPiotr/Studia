using System;

namespace Zadanie2
{
    class Grid
    {
        public int[][] tab;
        private int x, y;

        public int this[int a, int b]
        {
            get
            {
               return this.tab[a][b];
            }
            set
            {
                this.tab[a][b] = value;
            }
        }

        public int[] this[int a]
        {
            get
            {
                int[] res = new int[this.y];
                for (int i = 0; i < y; i++)
                    res[i] = this.tab[a][i];
                return res;
            }
        }

        public Grid(int a,int b)
        {
            this.x = a;
            this.y = b;
            this.tab = new int[a][];
            for(int i=0; i<a; i++)
            {
                this.tab[i] = new int[b];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid(5, 4);
            
            for(int i = 0; i<5; i++)
                for(int j=0; j<4; j++)
                    grid.tab[i][j] = 2*i +j;
            
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
            for(int i=0; i<4; i++)
                Console.Write(rowdata[i] + " ");
            
            Console.WriteLine();
            
            int[] rowdata2 = grid[3];
            for (int i = 0; i < 4; i++)
                Console.Write(rowdata2[i] + " ");
        }

    }
}
