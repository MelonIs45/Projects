﻿ using System;

namespace BF2CS
{
    class Program
    {
        static void Main(string[] args)
        {
            // 99 bottles of beer unit test
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

            byte[] tape = new byte[10000];
            char[] data = bf.ToCharArray();

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
                        tape[ptr] = (byte)Console.ReadKey().KeyChar; // Sets the value in the cell to a user input
                        break;
                    case '[':
                        if (tape[ptr] == 0)
                        {
                            bracketCount++;
                            while (data[i] != ']' || bracketCount != 0)
                            {
                                i++; // Goes to the end of the data
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
                                i--; // Goes back to the start of the first bracket
                                if (data[i] == ']')
                                    bracketCount++;
                                else if (data[i] == '[')
                                    bracketCount--;
                            }
                        }
                        break;
                }
            }
        }
    }
}
