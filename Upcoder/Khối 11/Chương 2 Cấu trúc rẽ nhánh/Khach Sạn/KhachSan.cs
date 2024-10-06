using System;
namespace Khachsan
{
    public class Program
    {
        static void Main()
        {
            // Nhập ngày đến và ngày đi
            string[] input = Console.ReadLine().Split(' ');
            int arrival = int.Parse(input[0]);
            int departure = int.Parse(input[1]);
    
            // Kiểm tra tính hợp lệ của ngày đến và ngày đi
            if (arrival < 1 || arrival > 7 || departure < 1 || departure > 7)
            {
                Console.Write("NHAP SAI");
                return;
            }
    
            // Tính số đêm
            int totalNights = 0;
            if (departure >= arrival)
            {
                totalNights = departure - arrival;
            }
            else
            {
                totalNights = (7 - arrival) + departure; // Tính toán qua cuối tuần
            }
    
            // Tính tiền
            int totalCost = 0;
            for (int i = 0; i < totalNights; i++)
            {
                int currentDay = (arrival + i - 1) % 7 + 1; // Lấy ngày hiện tại
                if (currentDay == 1) // Chủ Nhật
                {
                    totalCost += 400000;
                }
                else
                {
                    totalCost += 300000;
                }
            }
            Console.Write(totalCost);
        }
    }
}
