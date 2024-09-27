using System;
namespace Xếphang
{
    public class Program
    {
        static void Main(string[]args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = input.Length;
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
                a[i] = int.Parse(input[i]);
            int numchoice = int.Parse(Console.ReadLine());
            int VN1 = a[0];
            int VN2 = a[1];
            int VN3 = a[2];
            int TL1 = a[3];
            int TL2 = a[4];
            int TL3 = a[5];
            int sumVN = VN1 + VN2 + VN3;
            int sumTL = TL1 + TL2 + TL3;
            if(numchoice == 1)
            {
                if(sumVN > sumTL)
                    Console.Write("VN");
                else if(sumVN < sumTL)
                    Console.Write("TL");
            else 
                Console.Write("TIE");
            }
            else if(numchoice == 2)
            {
                if(sumVN != sumTL)
                {
                    if(VN1 != TL1)
                    {
                        if(VN1 > TL1)
                            Console.Write("VN");
                        else
                            Console.Write("TL");
                    }
                    else if(VN2 != TL2)
                    {
                        if(VN2 > TL2)
                            Console.Write("VN");
                        else
                            Console.Write("TL");
                    }
                    else
                    {
                        if(VN3 > TL3)
                            Console.Write("VN");
                        else
                            Console.Write("TL");
                    }
                }
                else
                    Console.Write("TIE");
            }
    
        }
    }
}