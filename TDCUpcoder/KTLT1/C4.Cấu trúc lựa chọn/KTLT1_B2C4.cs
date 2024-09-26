using System;
namespace DTB
{
    class Programn
    {
        static void Main(string[]args)
        {
            double DTB = double.Parse(Console.ReadLine());
            if(DTB >= 0 && DTB < 3)
            Console.Write("Kem");
            if(DTB >= 3 && DTB < 5)
            Console.Write("Yeu");
            if(DTB >= 5 && DTB < 6.5)
            Console.Write("Trung binh kha");
            if(DTB >= 6.5 && DTB < 8)
            Console.Write("Kha");
            if(DTB >= 8 && DTB < 9)
            Console.Write("Gioi");
            if(DTB >= 9 && DTB <= 10)
            Console.Write("Xuat sac");
        }
    }
}