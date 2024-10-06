using System;
namespace HelloWorld
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if(i != n)
                    Console.WriteLine("Hello World");
                else
                    Console.Write("Hello World");
            }
        }
    }
}