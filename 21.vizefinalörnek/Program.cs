using System;

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
            double v, f, ort;
            Console.WriteLine("Vize giriniz:");
            v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final giriniz:");
            f = Convert.ToDouble(Console.ReadLine());

            // Ortalama hesaplama
            ort = v * 0.4 + f * 0.6;

            // Durum kontrolü
            string cevap = v == 0 ? "Kaldınız" : ort >= 50 ? "Geçtiniz" : "Kaldınız";

            // Sonuçları ekrana yazdırma
            Console.WriteLine($"Ortalamanız: {ort}");
            Console.WriteLine(cevap);
        }
    }
}
