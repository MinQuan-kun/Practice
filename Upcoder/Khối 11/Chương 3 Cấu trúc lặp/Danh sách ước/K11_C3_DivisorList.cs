using System;
using System.Text;

namespace UocNguyenDuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("VO SO UOC");
            }
            else
            {
                StringBuilder uoc = new StringBuilder();
                for (int i = 1; i <= Math.Abs(n); i++)
                {
                    if (n % i == 0)
                    {
                        uoc.Append(i);
                        uoc.Append(" ");
                    }
                }

                if (uoc.Length > 0)
                {
                    Console.Write(uoc.ToString().TrimEnd());
                }
            }
        }
    }
}
