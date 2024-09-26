using System;
namespace xethocluc
{
    class Program
    {
        static void Main(string[]args)
        {
            double Toan = double.Parse(Console.ReadLine());
            double Ly = double.Parse(Console.ReadLine());
            double Hoa = double.Parse(Console.ReadLine());
            if((Toan + Ly + Hoa) >= 15 && Toan >=4 && Ly >= 4 && Hoa >= 4){
                if(Toan >= 5 && Ly >=5 && Hoa >=5)
                    Console.Write("Hoc deu cac mon");
                else
                    Console.Write("Hoc chua deu cac mon");
            }
            else
                Console.Write("Thi hong");
        }
    }
}