using System;
namespace chanle{
    class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n%2 == 0)
                Console.Write("So chan");
            else
                Console.Write("So le");
        }
    }
}