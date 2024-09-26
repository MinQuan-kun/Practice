using System;
namespace xuatsodoixung
{
    public class Program
    {
        static void Main(string[]args)
        {
            Print();
        }
        static void Print(){
            for(int i = 1; i <= 500; i ++)
            {
                int temp = i;
                int res = 0;
                int num = i;
                while(num != 0)
                {
                    res = res * 10 + num%10 ;
                    num/=10;
                }
                if(res == temp)
                    Console.Write("{0} ",temp);
            }
                
        }
    }
}