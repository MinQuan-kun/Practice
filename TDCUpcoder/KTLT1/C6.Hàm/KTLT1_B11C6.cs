using System;
namespace checkSCP
{
    public class Program
    {
        static void Main(string[]args)
        {
            int x = int.Parse(Console.ReadLine());
            int count = 1;
            for(int i = 1; i <= 1000; i++)
            {
                if(count <= x)
                {
                    if(CheckSCP(i))
                    {
                        Console.Write("{0} ",i);
                        count++;
                    }
                }
            }
        }
        static bool CheckSCP(int x)
        {
            if(x <= 0)
                return false;
            int temp = (int)Math.Sqrt(x);
            return temp * temp == x;
        }
    }
}