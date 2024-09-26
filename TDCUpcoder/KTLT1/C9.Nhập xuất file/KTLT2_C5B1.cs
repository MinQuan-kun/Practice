using System;
using System.IO;

namespace SumFromFile
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            string[] lines = File.ReadAllLines("Input.txt");

            int number1 = int.Parse(lines[0]);
            int number2 = int.Parse(lines[1]);

            
            int sum = number1 + number2;

  
            Console.WriteLine(sum);
        }
    }
}
