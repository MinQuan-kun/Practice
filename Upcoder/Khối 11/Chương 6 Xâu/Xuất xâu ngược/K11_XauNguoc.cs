using System;
namespace XauNguoc
{
    class Program
    {
        static void Main(string[]args)
        {
            // Nhập chuỗi a
            string a = Console.ReadLine();

            // Đảo ngược chuỗi a
            char[] charArray = a.ToCharArray(); // Chuyển chuỗi thành mảng ký tự
            Array.Reverse(charArray); // Đảo ngược mảng ký tự

            // Chuyển mảng ký tự lại thành chuỗi
            string reversedString = new string(charArray);

            // In ra chuỗi đã đảo ngược
            Console.Write(reversedString);
        }
    }
}