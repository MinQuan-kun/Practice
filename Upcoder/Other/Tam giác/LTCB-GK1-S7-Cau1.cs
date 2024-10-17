using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Đọc vào 3 số nguyên a, b, c
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                break;

            string[] parts = input.Split(' ');
            if (parts.Length < 3)
                break;

            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            int c = int.Parse(parts[2]);

            // Kiểm tra tính hợp lệ của 3 cạnh
            if (a > 0 && b > 0 && c > 0 && (a + b > c) && (a + c > b) && (b + c > a))
            {
                int perimeter = a + b + c;
                Console.WriteLine(perimeter);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
