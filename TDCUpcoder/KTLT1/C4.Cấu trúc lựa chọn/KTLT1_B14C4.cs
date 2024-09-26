using System;
namespace keobuabao
{
    class Program
    {
        static void Main(string[]args)
        {
            char p1 = char.Parse(Console.ReadLine());
            char p2 = char.Parse(Console.ReadLine());
            int res1 = (int)p1;
            int res2 = (int)p2;
            if((res1 >= 65 && res1<= 90) && (res2 >=65 && res2 <=90)){
                if(res1 == res2)
                Console.Write("HOA NHAU");
                else if(res1 == 75)
                {
                    if(res2 == 66)
                        Console.Write("NGUOI THU 2 THANG");
                    else
                        Console.Write("NGUOI THU 1 THANG");
                }
                else if(res1 == 71)
                {
                    if(res2 == 75)
                        Console.Write("NGUOI THU 2 THANG");
                    else
                        Console.Write("NGUOI THU 1 THANG");
                }
                else if(res1 == 66)
                {
                    if(res2 == 71)
                        Console.Write("NGUOI THU 2 THANG");
                    else
                        Console.Write("NGUOI THU 1 THANG");
                }
            
            }
            else
                Console.Write("KHONG HOP LE");
           
        }
    }
}