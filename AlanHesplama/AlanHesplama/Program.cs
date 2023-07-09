using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dıktorkenını  ksıa  kenanrını  gırın");
            string gırdı = Console.ReadLine();
            int kısa_kenar = Convert.ToInt32(gırdı);






            Console.WriteLine("dıktorkenını   uzun kenanrını gırın gırın");
            string gırdı2 = Console.ReadLine();
            int uzun_kenar = Convert.ToInt32(gırdı2);


            int alan = (kısa_kenar * uzun_kenar);
            Console.WriteLine("dıktrkenını alnanı" + " " +alan);




            Console.WriteLine("------------------------------------------------------------------------");


            Console.WriteLine("diktorkenını 1.  kenarı");

            string kenar_girdi1=Console.ReadLine();
            int kenar1=Convert.ToInt32(kenar_girdi1);



            Console.WriteLine("diktorkenını 2.  kenarı");

            string kenar_girdi2 = Console.ReadLine();
            int kenar2 = Convert.ToInt32(kenar_girdi2);



            Console.WriteLine("diktorkenını 3.  kenarı");

            string kenar_girdi3 = Console.ReadLine();
            int kenar3 = Convert.ToInt32(kenar_girdi3);





            Console.WriteLine("diktorkenını 4.  kenarı");

            string kenar_girdi4 = Console.ReadLine();
            int kenar4 = Convert.ToInt32(kenar_girdi4);


            int cevre = (kenar1 + kenar2 + kenar3 + kenar4);
            Console.WriteLine("diktorkenını  cevresi"  + " "  +cevre);








            Console.ReadLine();
        }
    }
}
