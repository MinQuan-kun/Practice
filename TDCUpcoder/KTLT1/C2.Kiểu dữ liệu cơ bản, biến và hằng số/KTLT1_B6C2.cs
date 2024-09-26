using System;
namespace doigiatien
{
    class Program
    {
        static void Main(string[]args)
        {
            int usd;
            const double usdToGbp = 0.8144;  // 1 đô la Mỹ = 0.8144 bảng Anh
            const double usdToJpy = 105.407; // 1 đô la Mỹ = 105.407 yên Nhật
            const double usdToVnd = 23160;   // 1 đô la Mỹ = 23160 Việt Nam đồng
            
            usd = int.Parse(Console.ReadLine());
            Console.WriteLine(usd * usdToGbp);
            Console.WriteLine(usd * usdToJpy);
            Console.WriteLine(usd * usdToVnd);
        }
    }
}