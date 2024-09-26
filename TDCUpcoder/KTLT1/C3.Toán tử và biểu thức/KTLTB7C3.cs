using System;

namespace Tinhgio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int gio = n / 3600;
            n %= 3600;
            int phut = n / 60;
            int giay = n % 60;

            
            if (gio < 10)
                Console.Write("0{0}:", gio);
            else
                Console.Write("{0}:", gio);

           
            if (phut < 10)
                Console.Write("0{0}:", phut);
            else
                Console.Write("{0}:", phut);

            
            if (giay < 10)
                Console.Write("0{0}", giay);
            else
                Console.Write("{0}", giay);
        }
    }
}