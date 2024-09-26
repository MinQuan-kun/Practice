using System;
namespace Fibonacy2
{
    public class Program
    {
        static void Main(string[]args)
        {
            int x = int.Parse(Console.ReadLine());
            int temp = 0;
            int count = 0;
            while(count != x)
            {
                int res = Fibonancy(temp);
                Console.Write("{0} ",res);
                count++;
                temp++;
            }
            
        }
        static int Fibonancy(int x)
        {
            if(x == 0 || x == 1)
                return 1;
            return (Fibonancy(x - 1)+Fibonancy(x - 2));
        
        }
    }
}