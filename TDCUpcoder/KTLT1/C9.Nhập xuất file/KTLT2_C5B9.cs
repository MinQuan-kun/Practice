using System;
using System.IO;
namespace Hanghoa
{
    class Programn
    {
        static void Main(string[]args)
        {
            string content = File.ReadAllText("Input.txt");
            string[] lines = content.Split('#');
            string a = lines[0];
            string b = lines[1];
            int SL = int.Parse(lines[2]);
            int Price = int.Parse(lines[3]);
            int sum = SL * Price;
             using (StreamWriter writer = new StreamWriter("Output.txt"))
            {
                writer.Write("{0}, ",a);       
                writer.Write("{0}, ",b);       
                writer.Write("{0}, ",SL);      
                writer.Write("{0}, ",Price);   
                writer.Write(sum);     
            }
        }
    }
}