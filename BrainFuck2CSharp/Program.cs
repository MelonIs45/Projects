using System;
using System.Collections.Generic;
using System.IO;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            //> = 2
            //< = 4
            //^ = 8
            //v = 16
            //val+ = 32
            //val- = 64
            //sLoop = 128
            //eLoop = 256
            //print = 512
            //input = 1024
            //reset = 2048
            //exit = 0

            string input = "32 32 32 32 32 32 32 32 32 32 128 2 32 32 32 32 32 32 32 2 32 32 32 32 32 32 32 32 32 32 2 "
                        + "32 32 32 32 32 32 32 32 32 32 32 2 32 32 32 2 32 32 32 32 32 32 32 32 32 2 "
                        + "32 32 32 32 32 32 32 32 32 32 4 4 4 4 4 4 64 256 2 32 32 512 2 32 512 2 64 64 512 512 32 32 32 "
                        + "512 2 32 32 512 2 64 64 64 512 4 4 512 32 32 32 512 64 64 64 64 64 64 512 2 2 2 512 4 4 32 512 0";

            if (args.Length > 0)
                input = File.ReadAllText(args[0]);

            string[] splitInput = input.Split(' ');
            int[] amountOfFactors = new int[splitInput.Length];

            byte[,] tape = new byte[10000, 10000];
            int bracketCount = 0;
            (int, int) pointer = (0, 0);

            for (int i = 0; i < splitInput.Length; i++)
            {
                amountOfFactors[i] = GetFactors(Convert.ToDouble(splitInput[i])).Length;
            }

            for (int i = 0; i < amountOfFactors.Length; i++)
            {
                switch (amountOfFactors[i])
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        pointer.Item1++;
                        break;
                    case 2:
                        pointer.Item1--;
                        break;
                    case 3:
                        pointer.Item2++;
                        break;
                    case 4:
                        pointer.Item2++;
                        break;
                    case 5:
                        tape[pointer.Item1, pointer.Item2]++;
                        break;
                    case 6:
                        tape[pointer.Item1, pointer.Item2]--;
                        break;
                    case 7:
                        if (tape[pointer.Item1, pointer.Item2] == 0)
                        {
                            bracketCount++;
                            while (amountOfFactors[i] != 8 || bracketCount != 0)
                            {
                                i++;
                                if (amountOfFactors[i] == 7)
                                    bracketCount++;
                                else if (amountOfFactors[i] == 8)
                                    bracketCount--;
                            }
                        }
                        break;
                    case 8:
                        if (tape[pointer.Item1, pointer.Item2] != 0)
                        {
                            bracketCount++;
                            while (amountOfFactors[i] != 7 || bracketCount != 0)
                            {
                                i--;
                                if (amountOfFactors[i] == 8)
                                    bracketCount++;
                                else if (amountOfFactors[i] == 7)
                                    bracketCount--;
                            }
                        }
                        break;
                    case 9:
                        Console.Write((char)tape[pointer.Item1, pointer.Item2]);
                        break;
                    case 10:
                        tape[pointer.Item1, pointer.Item2] = (byte)Console.ReadKey().KeyChar;
                        break;
                    case 11:
                        tape[pointer.Item1, pointer.Item2] = 0;
                        break;
                    default:
                        Console.WriteLine("FAIL");
                        break;
                }
            }
        }

        static int[] GetFactors(double num)
        {
            if (num == 0)
                return new int[] { };

            List<int> nums = new List<int>();
            double startNum = num;

            for (int div = 2; div < startNum - 1; div++)
            {
                while (num % div == 0)
                {
                    nums.Add(div);
                    num /= div;
                }
            }

            if (nums.Count == 0)
                nums.Add(1);

            return nums.ToArray();
        }
    }
}