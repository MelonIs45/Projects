using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primes (Brainfuck Derivative) is a 2D esoteric programming language that uses the amount
            // of prime factors in each number in a consecutive list to decide what operation to complete.

            // NOTE: The values below aren't the exact values that are needed, they are just the simplist
            //       to understand, being just powers of 2.

            // Exit         0
            // >            2
            // <            4
            // ^            8
            // v            16
            // Val +        32
            // Val -        64
            // Start Loop   128
            // End Loop     256
            // Print        512
            // Input        1024
            // Reset        2048

            // Hello World Program
            string input = "32 32 32 32 32 32 32 32 32 32 128 16 32 32 32 32 32 32 32 16 32 32 32 32 32 32 32 32 32 32 16 "
            + "32 32 32 32 32 32 32 32 32 32 32 16 32 32 32 16 32 32 32 32 32 32 32 32 32 16 "
            + "32 32 32 32 32 32 32 32 32 32 8 8 8 8 8 8 64 256 16 32 32 512 16 32 512 16 64 64 512 512 32 32 32 "
            + "512 16 32 32 512 16 64 64 64 512 8 8 512 32 32 32 512 64 64 64 64 64 64 512 16 16 16 512 8 8 32 512 0";

            // NNBOB Program
            string bf = @">++++++++++[<++++++++++>-]<->>>>>+++[>+++>+++<<-]<<<<+<[>[>+
                        >+<<-]>>[-<<+>>]++++>+<[-<->]<[[-]>>-<<]>>[[-]<<+>>]<<[[-]>>
                        >>>>[[-]<++++++++++<->>]<-[>+>+<<-]>[<+>-]+>[[-]<->]<<<<<<<<
                        <->>]<[>+>+<<-]>>[-<<+>>]+>+<[-<->]<[[-]>>-<<]>>[[-]<<+>>]<<
                        <[>>+>+<<<-]>>>[-<<<+>>>]++>+<[-<->]<[[-]>>-<<]>>[[-]<<+>>]<
                        <[>+<[-]]<[>>+<<[-]]>>[<<+>>[-]]<<<[>>+>+<<<-]>>>[-<<<+>>>]+
                        +++>+<[-<->]<[[-]>>-<<]>>[[-]<<+>>]<<[>+<[-]]<[>>+<<[-]]>>[<
                        <+>>[-]]<<[[-]>>>++++++++[>>++++++<<-]>[<++++++++[>++++++<-]
                        >.<++++++++[>------<-]>[<<+>>-]]>.<<++++++++[>>------<<-]<[-
                        >>+<<]<++++++++[<++++>-]<.>+++++++[>+++++++++<-]>+++.<+++++[
                        >+++++++++<-]>.+++++..--------.-------.++++++++++++++>>[>>>+
                        >+<<<<-]>>>>[-<<<<+>>>>]>+<[-<->]<[[-]>>-<<]>>[[-]<<+>>]<<<<
                        [>>>+>+<<<<-]>>>>[-<<<<+>>>>]+>+<[-<->]<[[-]>>-<<]>>[[-]<<+>
                        >]<<<[>>+<<[-]]>[>+<[-]]++>>+<[-<->]<[[-]>>-<<]>>[[-]<<+>>]<
                        +<[[-]>-<]>[<<<<<<<.>>>>>>>[-]]<<<<<<<<<.>>----.---------.<<
                        .>>----.+++..+++++++++++++.[-]<<[-]]<[>+>+<<-]>>[-<<+>>]+>+<
                        [-<->]<[[-]>>-<<]>>[[-]<<+>>]<<<[>>+>+<<<-]>>>[-<<<+>>>]++++
                        >+<[-<->]<[[-]>>-<<]>>[[-]<<+>>]<<[>+<[-]]<[>>+<<[-]]>>[<<+>
                        >[-]]<<[[-]>++++++++[<++++>-]<.>++++++++++[>+++++++++++<-]>+
                        .-.<<.>>++++++.------------.---.<<.>++++++[>+++<-]>.<++++++[
                        >----<-]>++.+++++++++++..[-]<<[-]++++++++++.[-]]<[>+>+<<-]>>
                        [-<<+>>]+++>+<[-<->]<[[-]>>-<<]>>[[-]<<+>>]<<[[-]++++++++++.
                        >+++++++++[>+++++++++<-]>+++.+++++++++++++.++++++++++.------
                        .<++++++++[>>++++<<-]>>.<++++++++++.-.---------.>.<-.+++++++
                        ++++.++++++++.---------.>.<-------------.+++++++++++++.-----
                        -----.>.<++++++++++++.---------------.<+++[>++++++<-]>..>.<-
                        ---------.+++++++++++.>.<<+++[>------<-]>-.+++++++++++++++++
                        .---.++++++.-------.----------.[-]>[-]<<<.[-]]<[>+>+<<-]>>[-
                        <<+>>]++++>+<[-<->]<[[-]>>-<<]>>[[-]<<+>>]<<[[-]++++++++++.[
                        -]<[-]>]<+<]";

            string formattedBf = Regex.Replace(bf.Replace("\t", " "), @"[ ]{2,}", " ").Replace("\r\n", "");
            string primes = BF2Primes(formattedBf);

            if (args.Length > 0)
                input = File.ReadAllText(args[0]);

            // To change to the brainfuck code, simply change the `input` variable to `bf`.
            string[] splitInput = primes.Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToArray();
            int[] amountOfFactors = new int[splitInput.Length];

            byte[,] tape = new byte[30000, 30000];
            int bracketCount = 0;
            (int, int) pointer = (0, 0);

            for (int i = 0; i < splitInput.Length; i++)
                amountOfFactors[i] = GetFactors(Convert.ToDouble(splitInput[i])).Length;

            for (int i = 0; i < amountOfFactors.Length; i++)
            {
                // Console.WriteLine($"{pointer} = {tape[pointer.Item1, pointer.Item2]} | {splitInput[i]} | {amountOfFactors[i]}");
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
                        pointer.Item2--;
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
                        ///Console.Write((char)tape[pointer.Item1, pointer.Item2]);
                        break;
                    case 10:
                        tape[pointer.Item1, pointer.Item2] = (byte)Console.ReadKey().KeyChar;
                        break;
                    case 11:
                        tape[pointer.Item1, pointer.Item2] = 0;
                        break;
                    default:
                        Console.WriteLine("FAILED");
                        break;
                }
            }

            Console.ReadLine();
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

        static string BF2Primes(string bfCode)
        {
            string res = "";

            foreach (char c in bfCode)
            {
                res += $"{c} ";
            }

            res = res.Replace(">", "2");
            res = res.Replace("<", "4");
            res = res.Replace("+", "32");
            res = res.Replace("-", "64");
            res = res.Replace("[", "128");
            res = res.Replace("]", "256");
            res = res.Replace(".", "512");
            res = res.Replace(",", "1024");

            res += "0";

            Console.WriteLine(res);

            return res;
        }
    }
}