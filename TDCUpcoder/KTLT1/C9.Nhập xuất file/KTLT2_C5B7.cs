using System;
using System.IO;
namespace GiaiPTB1
{
    class Programn
    {
        static void Main(string[]args)
        {
            string[] lines = File.ReadAllLines("Input.txt");
            double a = double.Parse(lines[0]);
            double b = double.Parse(lines[1]);
            double res = (-1)*b/a;
            if(a == 0){
                if(b == 0)
                    File.WriteAllText("Output.txt", "VSN");
                else
                    File.WriteAllText("Output.txt", "VN");
            }
            else
                File.WriteAllText("Output.txt",res:0.00);
        }
    }
}