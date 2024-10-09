using System;
namespace Tinhtien
{
    public class Program
    {
        static void Main(string[]args)
        {
            double S, E, T;
            double gia = 30000;
            double gia2 = 30000 * 0.7;
            while (true)
            {
                try
                {
                    string [] input = Console.ReadLine().Split();
                    S = double.Parse(input[0]); 
                    E = double.Parse(input[1]);  
                    T = E - S;                            

                    if (T <= 3)
                    {
                        T = T * gia;
                        Console.WriteLine(T);
                    }
                    else
                    {
                        T = 3 * gia + (T - 3) * gia2;
                        Console.WriteLine(T);
                    }
                }
                catch
                {
                    break;
                }
            }
        }
    }
}