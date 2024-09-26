using System;
namespace checkSCP
{
    public class Program
    {
        static void Main(string[]args)
        {
            int x = int.Parse(Console.ReadLine());
            if(CheckSCP(x))
                Console.Write("SCP");
            else
                Console.Write("Khong la SCP");
        }
        static bool CheckSCP(int x)
        {
            if(x < 0)
                return false;
            int temp = (int)Math.Sqrt(x);
            return temp * temp == x;
        }
    }
}