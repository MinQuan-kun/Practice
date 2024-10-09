using System;
using System.Collections.Generic;
namespace HSR
{
    public class NV
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<NV> v = new List<NV>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                NV a = new NV { Name = input[0], Speed = int.Parse(input[1]) };
                v.Add(a);
            }

            v.Sort((a, b) => b.Speed.CompareTo(a.Speed)); // Sắp xếp theo tốc độ giảm dần

            foreach (NV c in v)
            {
                Console.WriteLine(c);
            }
        }
    }
}
