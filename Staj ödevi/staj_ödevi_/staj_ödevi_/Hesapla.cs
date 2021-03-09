using System;
using System.Collections.Generic;
using System.Text;

namespace staj_ödevi_
{
    class Hesapla
    {
        public void Hesaplama ()

        {
            start:
            string islem_sec;
            Console.Write("Birinci sayıyı giriniz.");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz.");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Sayıların Toplamı (1)");
            Console.WriteLine("Sayıların Farkı   (2)");
            Console.WriteLine("Sayıların Çarpımı (3)");
            Console.WriteLine("Sayıların Bölümü  (4)");
            Console.WriteLine("--------------------------------------");
            Console.Write("Seçiminizi Yapınız: ");
            islem_sec = Console.ReadLine();
           

            switch (islem_sec)
            {
                case "1":
                    double toplam = sayi1 + sayi2;
                    Console.WriteLine("İki sayının toplamı=" + toplam);
                    break;
                case "2":
                  double cikarma = sayi1 - sayi2;
                    Console.WriteLine("İki sayının farkı=" + cikarma);
                    break;
                case "3":
                  double carpma = sayi1 * sayi2;
                    Console.WriteLine("İki sayının çarpımı=" + carpma);
                    break;
                case "4":
                    if(sayi2 !=0)
                    {
                       double bolme = sayi1 / sayi2;
                        Console.WriteLine("İki sayının bölümü=" + bolme);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı İşlem!");

                    }
                    
                    break;

                default:
                    Console.WriteLine("1-4 arasında bir sayı giriniz");
                    break;
                    
            }
           
            while (true)

            {

                Console.WriteLine("İşlemi sonlandırmak için S tuşuna basınız Devam etmek için herhangi bir tuşa basınız");
                string deger = Console.ReadLine();
                if (deger.ToLower() == "s")
                    break;
                else
                {
                    Console.Clear();
                    goto start;
                }
            }
             
           

        }
    }
}
