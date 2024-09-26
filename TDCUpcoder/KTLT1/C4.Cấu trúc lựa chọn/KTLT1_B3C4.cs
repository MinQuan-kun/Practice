using System;
namespace GiaiPTB1
{
    class Programn
    {
        static void Main(string[]args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double res = (-1)*b/a;
            if(a == 0){
                if(b == 0)
                    Console.Write("VSN");
                else
                    Console.Write("VN");
            }
            else
                Console.Write("{0:F2}",res);
        }
    }
}