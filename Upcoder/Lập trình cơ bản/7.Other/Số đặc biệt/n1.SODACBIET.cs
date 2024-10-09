using System;
using System.Collections.Generic;
using System.IO;
namespace Sodacbiet
{
    public class Program
    {
        // Hàm tính UCLN của 2 số
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int t = a % b;
                a = b;
                b = t;
            }
            return a;
        }
    
        // Hàm kiểm tra nếu M là số đặc biệt
        static bool IsSpecial(List<int> arr, int M)
        {
            int mod = arr[0] % M;
            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] % M != mod)
                {
                    return false;
                }
            }
            return true;
        }
    
        static void Main()
        {
            // Đọc dữ liệu từ file
            string[] lines = File.ReadAllLines("dacbiet.inp");
            int N = int.Parse(lines[0]);
            List<int> arr = new List<int>();
    
            for (int i = 1; i <= N; i++)
            {
                arr.Add(int.Parse(lines[i]));
            }
    
            // Tìm UCLN của tất cả hiệu các cặp phần tử
            int diffGCD = Math.Abs(arr[1] - arr[0]);
            for (int i = 2; i < N; i++)
            {
                diffGCD = GCD(diffGCD, Math.Abs(arr[i] - arr[0]));
            }
    
            // Tìm tất cả các ước của UCLN này
            List<int> specialNumbers = new List<int>();
            for (int i = 2; i <= Math.Sqrt(diffGCD); i++)
            {
                if (diffGCD % i == 0)
                {
                    if (IsSpecial(arr, i))
                    {
                        specialNumbers.Add(i);
                    }
                    if (i != diffGCD / i && IsSpecial(arr, diffGCD / i))
                    {
                        specialNumbers.Add(diffGCD / i);
                    }
                }
            }
    
            // Nếu diffGCD cũng là số đặc biệt thì thêm nó vào
            if (IsSpecial(arr, diffGCD))
            {
                specialNumbers.Add(diffGCD);
            }
    
            // Sắp xếp và in kết quả
            specialNumbers.Sort();
            File.WriteAllText("dacbiet.out", string.Join(" ", specialNumbers));
        }
    }

}

   