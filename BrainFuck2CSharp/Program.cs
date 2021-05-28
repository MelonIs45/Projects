 using System;

namespace BF2CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string bf = "++++++++++[>+++++++>++++++++++>+++++++++++>+++>+++++++++>++++++++++<<<<<<-]>++.>+.>--..+++.>++.>---.<<.+++.------.>>>.<<+.";

            int[] tape = new int[10];
            int ptr = 0;
            int currentPos = 0;

            translate(ref tape, ref ptr, bf, ref currentPos, 0, 0);

        }

        static void translate(ref int[] tape, ref int ptr, string bf, ref int currentPos, int bracketPos, int loopCount)
        {
            int start = currentPos;

            if (bracketPos != 0)
                start = bracketPos;

            foreach (char c in bf.Substring(start))
            {
                Console.WriteLine(ptr + " | " + c + " | " + String.Join(", ", tape));
                switch (c)
                {
                    case '+':
                        tape[ptr]++;
                        currentPos++;
                        break;
                    case '-':
                        tape[ptr]--;
                        currentPos++;
                        break;
                    case '>':
                        ptr++;
                        currentPos++;
                        break;
                    case '<':
                        ptr--;
                        currentPos++;
                        break;
                    case '.':
                        //Console.Write(tape[ptr] + " ");
                        currentPos++;
                        break;
                    case ']':
                        if (loopCount > 0)
                        {
                            translate(ref tape, ref ptr, bf, ref currentPos, bracketPos, loopCount);
                        }
                        break;
                    case '[':
                        
                        for (int v = tape[ptr]; v > 0; v--)
                        {
                            Console.WriteLine($"TAPE PTR HERE IS {v}");
                            translate(ref tape, ref ptr, bf, ref currentPos, currentPos+1, v);
                        }
                        break;
                }
            }
        }
    }
}
