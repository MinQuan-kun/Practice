using System;
namespace XuatSohoanhao
{
    public class Program
    {
        static void Main(string[]args)
        {
            int x = int.Parse(Console.ReadLine());
            SoHoanHao(x);
        }
        static void SoHoanHao(int x){
            
            for(int i = 1; i <=x; i++)
            {
                int sum = 0;
                for(int j = 1; j <= i/2; j++ )
                {
                    if(i % j == 0)
                        sum+=j;
                }
                if (sum == i)
                    Console.WriteLine(i);
            }
        }
    }
}