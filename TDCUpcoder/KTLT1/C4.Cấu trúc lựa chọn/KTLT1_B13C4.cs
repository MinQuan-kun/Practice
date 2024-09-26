using System;
namespace xacdinhngay
{
    class Program
    {
        static void Main(string[]args)
        {
            int thang = int.Parse(Console.ReadLine());
            int nam = int.Parse(Console.ReadLine());
            if(thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang ==8 || thang == 10 || thang == 12)
                Console.WriteLine("31");
            else
            {
                if(thang == 2)
                {
                    if((nam % 4 ==0 && nam % 100 != 0) || nam % 400 == 0)
                        Console.WriteLine("29");
                    else
                        Console.WriteLine("28");
                }
                else
                    Console.WriteLine("30");
            }
            
        }
    }
}