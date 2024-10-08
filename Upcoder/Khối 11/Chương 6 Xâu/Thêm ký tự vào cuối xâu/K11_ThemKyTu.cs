using System;
namespace Themkitucuoichuoi
{
    public class Program
    {
        static void Main(string[]args)
        {
            // Nhập chuỗi a
            string a = Console.ReadLine();
    
            // Nhập ký tự kt
            char kt = Console.ReadLine()[0]; // Đọc ký tự từ bàn phím
            string b = a + kt;
    
            // In ra chuỗi b
            Console.Write(b);
        }
    }    
}
    
