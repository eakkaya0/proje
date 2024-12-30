using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.vizefinalörnek
{
    class Program
    {
        static void Main(string[] args)
        {
            durum();
            Console.ReadLine();
        }

        private static void durum()
        {
            double v, f,ort;
            Console.WriteLine("vize giriniz");
          v= Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("final giriniz");
          f=Convert.ToDouble(Console.ReadLine());
            ort = v * 0.4 + f * 0.6;
            string cevap = v == 0 ? "kaldin" : ort >= 50 ? "gectin" : ort < 50 ? "kaldiniz":"" ;
            Console.WriteLine(cevap);
        }
    }
}
