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

            for (var i = 0; i < x; i++)
                blocks[i, 5] = new Block(true);

            for (var i = 0; i < x * y; i++)
            {
                if (i % 10 == 0)
                    Console.WriteLine();
                Console.Write(blocks[i / x, i % x]);
            }
        }
    }
}
