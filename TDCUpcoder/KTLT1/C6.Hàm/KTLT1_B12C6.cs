using System;
namespace Fibonacy2
{
    public class Program
    {
        static void Main(string[]args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.Write(Fibonancy(x));
        }
        static int Fibonancy(int x)
        {
            if(x == 0 || x == 1)
                return 1;
            return (Fibonancy(x - 1)+Fibonancy(x - 2));
        
        }
    }
}