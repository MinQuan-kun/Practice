using System;
namespace Ngaythangnam
{
    public class Program
    {
        static void Main(string[]args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int d = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int y = int.Parse(input[2]);
            if((y >= 1900) && ((y % 400 == 0) || (y % 4 == 0)) && (y % 100 != 0) && m == 2 && d <= 29)
                Console.Write("YES");
            else  if((y >= 1900) && ((y % 400 != 0) || (y % 4 == 0)) && (y % 100!= 0)&& m==2 && d<=28)
                Console.Write("YES");
            else if((y >= 1900) && (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) && d <= 31)
                Console.Write("YES");
            else if((y >= 1900) && (m == 4 || m == 6 || m == 9 || m == 11) && d <= 30)
                Console.Write("YES");
            else 
                Console.Write("NO");
        }
    }
}