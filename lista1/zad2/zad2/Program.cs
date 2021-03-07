using Microsoft.VisualBasic;
using System;

namespace zad2
{
    class Grid
    {
        public int n, m;
        public int[,] grid;
        public Grid(int a, int b)
        {
            n = a;
            m = b;
            grid = new int[a,b];
        }
        public int[] this [int index]
        {
            get
            {
                int[] rob = new int[m];
                for(int i = 0;i<m;i++)
                {
                    rob[i] = grid[index, i];
                }
                return rob;
            }
        }
        public int this[int l, int p]
        {
            get
            {
                return grid[l, p];
            }
            set
            {
                grid[l, p] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid(4, 4);
            int[] rowdata = grid[1];
            for(int i = 0; i< rowdata.Length;i++)
                Console.WriteLine(rowdata[i]);
            grid[1, 3] = 5;
            int elem = grid[1, 3];
            Console.WriteLine(elem);
        }
    }
}
