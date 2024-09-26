using System;
using System.IO;
namespace Hanghoa
{
    class Programn
    {
        static void Main(string[]args)
        {
            string[] lines = File.ReadAllLines("Input.txt");
            string a = lines[0];
            string b = lines[1];
            int SL = int.Parse(lines[2]);
            int Price = int.Parse(lines[3]);
            int sum = SL * Price;
             using (StreamWriter writer = new StreamWriter("Output.txt"))
            {
                writer.WriteLine(a);       
                writer.WriteLine(b);       
                writer.WriteLine(SL);      
                writer.WriteLine(Price);   
                writer.WriteLine(sum);     
            }
        }
    }
}