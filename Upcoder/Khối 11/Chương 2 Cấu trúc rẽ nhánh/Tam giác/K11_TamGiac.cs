using System;
namespace Tamgiac
{
    public class Program
    {
        static void Main(string[]args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = input.Length;
            double []Arr = new double[n];
            for(int i = 0; i < n; i++)
                Arr[i] = double.Parse(input[i]);
            double a = Arr[0];
            double b = Arr[1];
            double C = Arr[2];
            if(C == 180)
            {
                Console.Write("KHONG PHAI TAM GIAC");
            }
            else
            {
                C = C * Math.PI/ 180.0;
                double c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2) -2 * a * b * Math.Cos(C));
                Console.Write(c);
            }
        }
    }
}