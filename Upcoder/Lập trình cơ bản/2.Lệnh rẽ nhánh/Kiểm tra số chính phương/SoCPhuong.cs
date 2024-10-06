using System;
namespace SoCP
{
    public class Program
    {
        static void Main(string[]args)
        {
            int a = int.Parse(Console.ReadLine());
            string temp = "";
            for(int i = 0; i < a; i++)
                if(i * i == a)
                    temp = "true";
            if(temp == "true")
                Console.Write("yes");
            else
                Console.Write("no");
        }
    }
}