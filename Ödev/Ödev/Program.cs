using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adın ne ? ");
             string x = Console.ReadLine();

            Console.Write("Soyadın Ne ? ");
             string c = Console.ReadLine();

            Console.Write("yaşın kaç ?");
             string v = Console.ReadLine();


            Console.Clear();

            string soyad = "Soyad : " ;
            string ad = "Adın : ";
            string yaş = "yaş : ";
            Console.WriteLine(ad + x );
            Console.WriteLine(soyad + c );
            Console.WriteLine(yaş + v);

            Console.ReadLine() ;


            
        }
    }
}
