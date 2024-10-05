using System;
namespace MaASCII
{
    public class Program
    {
        static void Main(string[]args)
        {
            string input = Console.ReadLine();
            char inputChar = input[0];
            int asciiValue = (int)inputChar;
            Console.Write(asciiValue);
        }
    }
}

