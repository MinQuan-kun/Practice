using System;
namespace MaASCII
{
    public class Program
    {
        static void Main(string[]args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            char inputChar1 = input1[0];
            char inputChar2 = input2[0];
            int asciiValue1 = (int)inputChar1;
            int asciiValue2 = (int)inputChar2;
            Console.Write(asciiValue1 + asciiValue2);
        }
    }
}

