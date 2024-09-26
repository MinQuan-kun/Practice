using System;
namespace checktoigian
{
    public class Program
    {
        static void Main(string[]args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(check(a, b))
                Console.Write("Toi gian");
            else
                Console.Write("Chua toi gian");
        }
        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if(b == 0)
                return a;
            else
                return UCLN(b, a % b);
        }
        static bool check(int a,int b)
        {
            int c = UCLN(a, b);
            int tu = a;
            int mau = b;
            tu /=c;
            mau /=c;
            return (tu == a && mau == b);
        }
    }
}