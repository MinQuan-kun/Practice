using System;
namespace Sohoanhao
{
    public class Program
    {
        static void Main(string[]args)
        {
            SoHoanHao();
        }
        static void SoHoanHao(){
            
            for(int i = 1; i <= 1000; i++)
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