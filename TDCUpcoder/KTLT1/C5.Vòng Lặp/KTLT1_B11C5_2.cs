using System;
namespace tinhgiatridayso
{
    class Program
    {
        static void Main(string[]args)
        {
            double x = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double sum =1;
            for(int i = 1;i <=n ;i++)
                sum += Math.Pow(-1,i)*Math.Pow(x,i);
            Console.WriteLine(sum);
        }
    }
}