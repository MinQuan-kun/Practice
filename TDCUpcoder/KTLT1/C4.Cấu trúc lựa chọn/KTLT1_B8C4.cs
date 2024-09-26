using System;
namespace Inmau
{
    class Program
    {
        static void Main(string[]args)
        {
            char k = char.Parse(Console.ReadLine());
            k = char.ToUpper(k); 
            switch(k)
            {
                case 'R':
                    Console.Write("RED");
                    break;
                case 'G':
                    Console.Write("GREEN");
                    break;
                case 'B':
                    Console.Write("BLUE");
                    break;
                default:
                    Console.Write("BLACK");
                    break;
            }
        }
    }
}