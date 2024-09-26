using System;
namespace xacdinhquy
{
    class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n >= 1 && n <= 12){
                if(n >= 1 && n <= 3)
                    Console.Write("Quy 1");
                if(n >= 4 && n <= 6)
                    Console.Write("Quy 2");
                if(n >= 7 && n <= 9)
                    Console.Write("Quy 3");
                if(n >= 10 && n <= 12)
                    Console.Write("Quy 4");
            }
            else
                Console.Write("Khong hop le");
            }
        }
    }
