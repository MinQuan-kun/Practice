using System;
using System.IO;
namespace Docsothuc
{
    public class Program
    {
        static void Main(string[]args)
        {
            string[] lines = File.ReadAllLines("Input.txt");
            double num1 = double.Parse(lines[0]);
            double num2 = double.Parse(lines[1]);
            double sum = num1 + num2;
            File.WriteAllText("Output.txt", sum.ToString());
        }
    }
}