using System;
namespace LTCB
{
    public class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int a = int.Parse(input.Substring(0, 2));
            char op = input[2];
            int b = int.Parse(input.Substring(3, 2));
            int result = 0;
            switch (op)
            {
                case '+':
                    result = a + b;
                    Console.Write("{0}+{1}={2}", a, b, result);
                    break;
                case '-':
                    result = a - b;
                    Console.Write("{0}-{1}={2}", a, b, result);
                    break;
                default:
                    return;
            }
        }
    }
}
    