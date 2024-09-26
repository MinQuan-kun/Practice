using System;
namespace TimUCLNvaBCNN
{
    public class Program
    {
        static void Main(string[]args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(UCLN(x, y));
            Console.WriteLine(BCNN(x, y));
        }
        static int UCLN(int x, int y)
        {
            if(y == 0)
            return x;
            else
            return UCLN(y,x%y);
        }
        static int BCNN(int x, int y)
        {
            int c= UCLN(x, y);
            return ((x*y)/c);
        }
    }
}