using System;
namespace tinhtoan
{
    class Program
    {
        static void Main(string[]args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            char c;
            c = char.Parse(Console.ReadLine());
            switch(c)
            {
                case '+':
                    Console.Write(a+b);
                    break;
                case '-':
                    Console.Write(a-b);
                    break;
                case '*':
                    Console.Write(a*b);
                    break;
                case '/':
                    if(b == 0)
                    Console.Write("Khong chia duoc");
                    else
                    Console.Write($"{a/b:F1}");
                    break;
                default:
                    Console.Write("Phep toan khong hop le");
                    break;
            }
        }
    }
}