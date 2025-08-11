using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Değişken tanımlama
            string mesaj = "";

            Console.WriteLine("Hello, World!");
            mesaj = Console.ReadLine() ?? "";
            Console.WriteLine("Merhaba! " + mesaj);

            string isim = "Alper";
            int yas = 25;
            double pi = 3.14;
            bool aktifMi = true;

            Console.WriteLine($"Ad: {isim}, Yaş: {yas}, Pi: {pi}, Aktif Mi: {aktifMi}");

            Yazdir();
            GizliMetot();
            int a = Topla(5, 10);
            Console.WriteLine($"Toplama sonucu: {a}");
            //If else

            if (pi > 3)
            {
                Console.WriteLine("Pi sayısı 3'ten büyüktür.");
            }
            else if (pi == 3)
            {
                Console.WriteLine("Pi sayısı 3'e eşittir.");
            }
            else
            {
                Console.WriteLine("Pi sayısı 3'ten küçüktür.");
            }
            // Switch case
            switch (yas)
            {
                case 18:
                    Console.WriteLine("Reşit oldunuz.");
                    break;
                case 25:
                    Console.WriteLine("25 yaşındasınız.");
                    break;
                default:
                    Console.WriteLine("Farklı bir yaş.");
                    break;
            }
            // Döngüler
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"For döngüsü: {i}");
            }

        }
        // Metotlar Fonksiyonlar
        public static void Yazdir()
        {
            Console.WriteLine("Yazdırma işlemi yapıldı.");
        }

        private static void GizliMetot()
        {
            Console.WriteLine("Bu metot private");
        }
        
        public static int Topla(int a, int b)
        {
            return a + b;
        }
    }
}