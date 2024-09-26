using System;
namespace bangnhan
{
    class Program
    {
      static void Main(string[]agrs)
    {
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        while( i!= 11)
        {
            Console.Write(n*i);
            Console.Write(" ");
            i++;
        }
    }  
    }
    
}