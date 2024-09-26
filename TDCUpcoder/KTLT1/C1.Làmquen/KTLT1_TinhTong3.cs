using System;
namespace TinhTong3
{
    class Program
    {
        static void Main(string[]args){
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.Write(a);
            Console.Write("+{0}={1}",b, a + b);
        }
    }
}
