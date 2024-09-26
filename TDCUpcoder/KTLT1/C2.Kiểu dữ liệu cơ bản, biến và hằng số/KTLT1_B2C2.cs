using System;
namespace tinhComission
{
    class Program
    {
        static void Main(string[]args)
        {
            double totalSale, Comission; 
            double sale1 = double.Parse(Console.ReadLine());
            double sale2 = double.Parse(Console.ReadLine());
            double ComissionRate = double.Parse(Console.ReadLine());
            
            totalSale = sale1 + sale2;
            Comission = totalSale * ComissionRate;
            Console.Write(Comission);
        }
    }
}