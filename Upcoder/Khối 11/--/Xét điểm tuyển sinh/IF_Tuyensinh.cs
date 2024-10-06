using System;

class Program
{
    static void Main()
    {
        // Nhập điểm chuẩn
        double diemChuan = double.Parse(Console.ReadLine());

        // Nhập điểm thi 3 môn
        string[] diemMon = Console.ReadLine().Split();
        double diemMon1 = double.Parse(diemMon[0]);
        double diemMon2 = double.Parse(diemMon[1]);
        double diemMon3 = double.Parse(diemMon[2]);

        // Nhập khu vực
        char khuVuc = char.Parse(Console.ReadLine());

        // Nhập đối tượng
        int doiTuong = int.Parse(Console.ReadLine());

        // Tính điểm ưu tiên
        double diemUuTien = 0;
        switch (khuVuc)
        {
            case 'A':
                diemUuTien += 2;
                break;
            case 'B':
                diemUuTien += 1;
                break;
            case 'C':
                diemUuTien += 0.5;
                break;
        }

        switch (doiTuong)
        {
            case 1:
                diemUuTien += 2.5;
                break;
            case 2:
                diemUuTien += 1.5;
                break;
            case 3:
                diemUuTien += 1;
                break;
        }

        // Tính điểm tổng kết
        double tongDiem = diemMon1 + diemMon2 + diemMon3 + diemUuTien;

        // Kiểm tra điều kiện đậu
        if (tongDiem >= diemChuan && diemMon1 > 0 && diemMon2 > 0 && diemMon3 > 0)
        {
            Console.WriteL("PASS");
        }
        else
        {
            Console.Write("FAIL");
        }
    }
}
