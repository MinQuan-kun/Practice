using System;
namespace daoso
{
    public class Program
    {
        static void Main(string[]args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(input.Split(' ')[0]);
            int b = int.Parse(input.Split(' ')[1]);
            Console.Write("{0} {1}", b, a);
        }
    }
}