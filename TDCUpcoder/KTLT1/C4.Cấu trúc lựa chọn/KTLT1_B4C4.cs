using System;
namespace Kiemtrachiahet
{
    class Programn
    {
        static void Main(string[]args)
        {
            int a = int.Parse(Console.ReadLine());
            if(a >=1 && a <= 100 && a %2 == 0){
                if(a % 3 == 0)
                    Console.Write("La so chan chia het cho 3");
                else
                Console.Write("Khong thoa dieu kien");
            }
            else
                Console.Write("Khong thoa dieu kien");
        }
    }
}