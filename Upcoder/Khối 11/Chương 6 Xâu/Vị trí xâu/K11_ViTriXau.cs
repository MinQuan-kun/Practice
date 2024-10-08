using System;
namespace Vitrixau
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
    
            int vitri = a.IndexOf(b);
    
            if (vitri != -1)
            {
                Console.WriteLine(vitri);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}


