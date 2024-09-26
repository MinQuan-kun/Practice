using System;
using System.IO;
namespace Timmax
{
    public class Program
    {
        static void Main(string[]args)
        {
            string[] line = File.ReadAllLines("Input.txt");
            int num1 = int.Parse(line[0]);
            int num2 = int.Parse(line[1]);
            int num3 = int.Parse(line[2]);
            int num4 = int.Parse(line[3]);
            int max = num1;
            if(max < num2)
                max = num2;
            if(max < num3)
                max = num3;
            if(max < num4)
                max = num4;
            File.WriteAllText("Output.txt", max.ToString());
        }
    }
}