using System;
namespace insonguyento
{
    class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 2; i<= n ; i ++){
                if(KTSNT(i))
                    Console.Write("{0} ",i);
            }
        }
        static bool KTSNT(int x)
        {
            if(x<2)
		        return false;
	       for(int i=2; i<=x/2; i++)
		      if(x%i==0)
			     return false;
	       return true;
        }
    }
}
