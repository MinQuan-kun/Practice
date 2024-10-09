using System;
using System.Collections.Generic;
namespace LTCB
{
    public class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
    
            if (n < 2)
                Console.WriteLine(-1);
            else
            {
                List<string> primes = new List<string>();
                for (int i = 1; i <= n; i++)
                {
                    if (IsPrime(i))
                    {
                        primes.Add(i.ToString());
                    }
                }
                Console.Write(string.Join(" ", primes));
            }
        }
    }   
}
    
