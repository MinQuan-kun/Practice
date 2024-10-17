using System;
namespace ĐêmSNT
{
    public class Program
    {
        static void Main(string[]args)
        {
            int count = 0;
            string [] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int []A = new int[n];
            for (int i = 0; i < n; i++) 
            {
                A[i] = int.Parse(input[i + 1]); 
                if (CheckSNT(A[i]) && A[i] < 100)
                    count++;
            }
            Console.Write(count);            
        }
        static bool CheckSNT(int n)
        {
            if(n < 2)
                return false;
            for(int i = 2; i * i <= n; i++)
                if(n % i == 0)
                    return false;
            return true;
        }
    }
}