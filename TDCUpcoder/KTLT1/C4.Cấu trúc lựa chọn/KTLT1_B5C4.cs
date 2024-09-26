using System;

namespace Tinhgio
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int sAdd = int.Parse(Console.ReadLine());
            h = sAdd/3600 + h;
            sAdd %= 3600;
            m = sAdd/60 + m;
            sAdd %=60;
            if(m >= 60){
                h +=1;
                m -=60;
            }
            s +=sAdd;
            if(s>=60){
                m+=1;
                s-=60;
                if(m >= 60){
                    h +=1;
                    m -=60;
                }
            }
            if (h < 10)
                Console.Write("0{0}:", h);
            else
                Console.Write("{0}:", h);

           
            if (m < 10)
                Console.Write("0{0}:", m);
            else
                Console.Write("{0}:", m);

            
            if (s < 10)
                Console.Write("0{0}", s);
            else
                Console.Write("{0}", s);
        }
                
    }
}