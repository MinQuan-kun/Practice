using System;
namespace Inhoa
    {
    public class Program
    {
        static void Main(string[]args)
        {
            string a;
            
            // Nhập từ liên tục cho đến khi kết thúc input
            while ((a = Console.ReadLine()) != null)
            {
                // Duyệt từng ký tự và chuyển các ký tự thường thành chữ hoa
                for (int i = 0; i < a.Length; i++)
                {
                    if (char.IsLower(a[i]))
                    {
                        // Chuyển chữ thường thành chữ hoa
                        a = a.Substring(0, i) + char.ToUpper(a[i]) + a.Substring(i + 1);
                    }
                }
                
                // Xuất chuỗi đã chuyển đổi ra màn hình
                Console.Write(a);
            }
        }
    }
}

