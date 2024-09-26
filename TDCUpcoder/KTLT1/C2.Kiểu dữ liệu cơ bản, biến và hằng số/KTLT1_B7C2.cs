using System;
namespace inmaAscii
{
    class Program
    {
        static void Main(string[]args)
        {
            char sinput;
            sinput = char.Parse(Console.ReadLine());
            int Asciicode = (int)sinput;
            char _nextAscii = (char)(Asciicode + 1);
            Console.Write(Asciicode);
            Console.Write(" {0}", _nextAscii);
        }
    }
}