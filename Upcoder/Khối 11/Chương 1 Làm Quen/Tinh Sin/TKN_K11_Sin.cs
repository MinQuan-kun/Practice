using System;
namespace tinhSin
{
    public class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            float a = float.Parse(inputs[0]);
            float x = float.Parse(inputs[1]);
            if (x < -Math.PI || x > Math.PI)
            {
                return;  // Kết thúc chương trình với mã lỗi
            }
            // Tính giá trị biểu thức S
            float S = (a + (float)Math.Sin(x)) / (float)Math.Sqrt(a * a + x * x + 1);
            Console.Write("{0:0.000000}", S);
        }
    }
}