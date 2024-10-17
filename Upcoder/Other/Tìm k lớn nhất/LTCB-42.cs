using System;
namespace Timmaxk
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp = 0;
            int res = 0;
            for(int i = 1; temp < n; i++)
            {
                temp += i;
                if(temp < n)
                    res = i;
            }
            Console.Write(res);
        }
    }
}