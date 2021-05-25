using System;
using System.Drawing;

namespace PathFindingAlgo
{
    class Block
    {
        public bool Wall;
        public Block(bool wall)
        {
            Wall = wall;
        }

        public override string ToString()
        {
            return Wall ? "1" : "0";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int x = 10;
            const int y = 10;
            Block[,] blocks = new Block[x, y];

            for (var i = 0; i < x * y; i++)
                blocks[i % x, i / x] = new Block(false);

            for (var i = 0; i < blocks.GetLength(0); i++)
                blocks[i, 5] = new Block(true);

            for (var i = 0; i < blocks.GetLength(0); i++)
            {
                for (var j = 0; j < blocks.GetLength(1); j++)
                {
                    Console.Write(blocks[i, j].ToString() + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
