using System;
using System.IO;
namespace Sum
{
    public class Program
    {
        static void Main(string[]args)
        {
            string[] lines = File.ReadAllLines("Input.txt");
            int n = int.Parse(lines[0]);
           
            int sum = 0;
            for(int i = 1; i <= n; i++)
                sum += int.Parse(lines[i]);
            
            File.WriteAllText("Output.txt", sum.ToString());
            
        }
    }
}