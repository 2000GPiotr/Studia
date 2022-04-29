using System;

namespace Grid_Class
{
    /// <summary>
    /// Klasa implementujaca siatke n na m
    /// </summary>
    public class Grid
    {
        public int[][] tab;
        private int x, y;

        /// <summary>
        /// Indekser dwuwymiarowy
        /// </summary>
        /// <param name="a"> Dlugosc </param>
        /// <param name="b"> Szerokosc </param>
        /// <returns> Wartosc z pola a,b </returns>
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

        /// <summary>
        /// Indekser jednowymiarowy
        /// </summary>
        /// <param name="a"> Numer zwracanego wiersza</param>
        /// <returns> Tablice wartosci wiersza a </returns>
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

        /// <summary>
        /// Konstruktor siatki
        /// </summary>
        /// <param name="a">Dlugosc</param>
        /// <param name="b">Szerokosc</param>
        public Grid(int a, int b)
        {
            this.x = a;
            this.y = b;
            this.tab = new int[a][];
            for (int i = 0; i < a; i++)
            {
                this.tab[i] = new int[b];
            }
        }
    }
}
