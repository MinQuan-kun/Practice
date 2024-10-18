using System;

namespace giophucgiay
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ushort gio, phut, giay;
            string[] input = Console.ReadLine().Split(' ');

            gio = ushort.Parse(input[0]);
            phut = ushort.Parse(input[1]);
            giay = ushort.Parse(input[2]);

            if (gio > 23 || phut > 59 || giay > 59)
            {
                Console.Write("NO");
            }
            else
            {
                Console.Write("YES");
                if (giay == 59)
                {
                    phut++;
                    giay = 0;
                }
                else
                {
                    giay++;
                }

                if (phut > 59)
                {
                    gio++;
                    phut = 0;
                    giay = 0;
                }

                if (gio > 23)
                {
                    gio = 0;
                    phut = 0;
                    giay = 0;
                }

                Console.WriteLine($"{gio}:{phut}:{giay}");
            }
        }
    }
}
