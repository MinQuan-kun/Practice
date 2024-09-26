using System;
namespace soamstrong
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            if(amstrong(n))
                Console.Write("YES");
            else
                Console.Write("NO");
        }
        static bool amstrong(int n){
            int sum = 0;
            int count = 0;
            int temp = n;
            while(temp != 0){
                temp /=10;
                count++;
            }
            temp = n;
            while(temp != 0){
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, count);
                temp/=10;
            }
            return n == sum;
        }
    }
}