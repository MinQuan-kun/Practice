using System;
namespace Kinhnghiemcoder
{
    public class Program
    {
        static void Main(string[]args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = input.Length;
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
                a[i] = int.Parse(input[i]);
            int Basic = a[0];
            int Medium = a[1];
            int Extra = a[2];
            int Hard = a[3];
            int Point = Basic * 10 + Medium * 20 + Extra * 30 + Hard * 40;
            Console.WriteLine(Point);
            if (Point >= 7000)
                Console.Write("Coder Giao Su");
            else if (Point >= 5500)
                Console.Write("Coder Tien Si");
            else if (Point >= 4200)
                Console.Write("Coder Thac Si");
            else if (Point >= 3500)
                Console.Write("Coder Dai Hoc");
            else if (Point >= 2500)
                Console.Write("Coder Cao Dang");
            else if (Point >= 2000)
                Console.Write("Coder Trung Cap");
            else if (Point >= 1500)
                Console.Write("Coder THPT");
            else if (Point >= 1000)
                Console.Write("Coder THCS");
            else if (Point >= 500)
                Console.Write("Coder Tieu Hoc");
            else if (Point >= 100)
                Console.Write("Coder Lop La");
            else if (Point >= 50)
                Console.Write("Coder Lop Choi");
            else if (Point >= 1)
                Console.Write("Coder Lop Mam");
            else
                Console.Write("Coder So Sinh");
        }
    }
}