using System;
namespace tinhtiendien
{
    class Program
    {
        static void Main(string[]args)
        {
            int chisocu = int.Parse(Console.ReadLine());
            int chisomoi = int.Parse(Console.ReadLine());
           
            int muctieuthu = chisomoi - chisocu;
            Console.WriteLine(muctieuthu);
            
            const int dinhmuc = 50;
            const int giadinhmuc = 1000;
            const int giavuot1 = 1500;
            const int giavuot2 = 1800;
            const int giavuot3 = 2500;
            
            int tientrongdinhmuc = dinhmuc * giadinhmuc;
            Console.WriteLine(tientrongdinhmuc);
            
            int tienvuot = 0;
            int mucvuottieuthu = muctieuthu - dinhmuc;
            
            if(mucvuottieuthu > 0){

                if(mucvuottieuthu > 100)
                    tienvuot = 50 * giavuot1 + 50 * giavuot2 +(mucvuottieuthu - 100) * giavuot3;
                else if(mucvuottieuthu >50 && mucvuottieuthu <=100)
                    tienvuot = 50 * giavuot1 + (mucvuottieuthu - 50) * giavuot2;
                else 
                    tienvuot = mucvuottieuthu * giavuot1;
            }
            Console.WriteLine(tienvuot);
            
            int tongtien = tienvuot + tientrongdinhmuc;
            Console.WriteLine(tongtien);
        }
    }
}