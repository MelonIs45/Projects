using System;
using System.IO;

namespace BF2CS
{
    class Program
    {
        static void Main(string[] args)
        {
            // 99 bottles of beer unit test, Code written by Jim Crawford.
            string bfExample = @">++++++++++[<++++++++++>-]<->>>>>+++[>+++>+++<<-]<<<<+<[>[>+
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

            byte[] tape = new byte[10000];
            char[] data = bfExample.ToCharArray();

            if (args.Length > 0)
                data = File.ReadAllText(args[0]).ToCharArray(); // Uses bf code from file if passed in

            int bracketCount = 0;
            int ptr = 0;

            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case '>':
                        ptr++; // Increments the value of the tape pointer
                        break;
                    case '<':
                        ptr--; // Decrements the value of the tape pointer
                        break;
                    case '+':
                        tape[ptr]++; // Increments the value of the cell at the pointers position
                        break;
                    case '-':
                        tape[ptr]--; // Decrements the value of the cell at the pointers position
                        break;
                    case '.':
                        Console.Write((char)tape[ptr]); // Writes the ASCII character for the value in the cell
                        break;
                    case ',':
                        tape[ptr] = (byte)Console.ReadKey().KeyChar; // Sets the value in the cell to the user input
                        break;
                    case '[':
                        if (tape[ptr] == 0)
                        {
                            bracketCount++;
                            while (data[i] != ']' || bracketCount != 0)
                            {
                                i++; // Goes to the end of the bracket
                                if (data[i] == '[')
                                    bracketCount++;
                                else if (data[i] == ']')
                                    bracketCount--;
                            }
                        }
                        break;
                    case ']':
                        if (tape[ptr] != 0)
                        {
                            bracketCount++;
                            while (data[i] != '[' || bracketCount != 0)
                            {
                                i--; // Goes back to the start of the bracket
                                if (data[i] == ']')
                                    bracketCount++;
                                else if (data[i] == '[')
                                    bracketCount--;
                            }
                        }
                        break;
                }
            }
            Console.WriteLine("\nPress any character to exit. ");
            Console.ReadLine();
        }
    }
}
