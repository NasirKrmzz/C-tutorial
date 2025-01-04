using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrol_Yapıları__Control_Structures_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HELLO EVERYONE BUGÜN  * Kontrol Yapılarından (Control Structures) * İF-ELSE VE SWİTCH İFADELERİNİ ÖĞRENİCEZ.
            //
            // A ) if-else Yapısı
            // if-else yapısı, programın belirli bir koşula bağlı olarak farklı kod bloklarını çalıştırmasına olanak tanır.

            /*
            * if: Koşulun doğru olup olmadığını kontrol eder. Doğruysa, ilgili kod bloğu çalışır.
            * else: Eğer if bloğundaki koşul yanlışsa, else bloğu çalışır.
            * else if: Birden fazla koşulu kontrol etmek gerektiğinde kullanılır.
            */

            
            // BİR 3 SORUDAN OLUŞAN OYUN TASARLAMA PROGRAMI

            Console.WriteLine("BİLGİ YARIŞMASINA HOŞ GELDİNİZ");
            Console.WriteLine();
            Console.WriteLine("-----------------");
            int soru = 1;
            string cevap;
            if (soru == 1)
            {
                Console.WriteLine("Bursa ili hangi bölgemizde bulunur ? ");
                Console.WriteLine();
                Console.WriteLine("(A) MARMARA");
                Console.WriteLine("(B) DOĞU ANADOLU");
                Console.WriteLine("(C) EGE ");
                Console.WriteLine("(D) KARADENİZ");
                Console.WriteLine("(E) İÇ ANADOLU");
                Console.WriteLine();
                Console.WriteLine("CEVABINIZ");
                cevap = Console.ReadLine();

                if (cevap == "A" || cevap == "a")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış toplam puanınız = 0 ' dır ");
                }
            }
            if (soru == 2)
            {
                Console.WriteLine("SORU 2 ");
                Console.WriteLine("Bursa ilinin kaç ilçesi vardır ");
                Console.WriteLine();
                Console.WriteLine("(A) 3");
                Console.WriteLine("(B) 12 ");
                Console.WriteLine("(C) 9 ");
                Console.WriteLine("(D) 15");
                Console.WriteLine("(E) 14");
                Console.WriteLine();
                Console.WriteLine("CEVABINIZ");
                cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    soru += 1;
                }
                else { Console.WriteLine("Cevabınız Yanlış yarışma bitti sizin için puanınz :10 "); }
            }
            if (soru == 3)
            {
                Console.WriteLine("SORU 3 ");
                Console.WriteLine("Bursa Yıldırım ilçesinin kaç mahallesi vardır ");
                Console.WriteLine();
                Console.WriteLine("(A) 23");
                Console.WriteLine("(B) 34 ");
                Console.WriteLine("(C) 14 ");
                Console.WriteLine("(D) 39");
                Console.WriteLine("(E) 25");
                Console.WriteLine();
                Console.WriteLine("CEVABINIZ");
                cevap = Console.ReadLine();
                if (cevap == "e" || cevap == "E")
                {
                    Console.WriteLine("TEBRİKLER YARIŞMA BİTTİ BÜTÜN SORULARA DOĞRU CEVAP VERDİNİZ 30 TAM PUAN ALDINIZ AQ NASIL YAPTINIZ ");
                }
                else { Console.WriteLine("Cevabınız Yanlış yarışma bitti sizin için puanınz :20 "); }
            }

            // SAYI KONTROL PROGRAMI  

            Console.WriteLine("bir sayı giriniz lütfen");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Sayı pozitiftir.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Sayı negatiftir.");
            }
            else
            {
                Console.WriteLine("Sayı sıfırdır.");
            }

            // KULLANICI ADI ŞİFRE KONTROLÜ YAPAN PROGRAM

            string kullanıcı_adı, sifre;
            Console.WriteLine("lütfen kullanıcı adınız girinzi");
            kullanıcı_adı = Console.ReadLine();
            
            Console.WriteLine("lütfen şifernizi giriniz");
            sifre = Console.ReadLine();

            if (kullanıcı_adı == "admin" & sifre == "123456")
            { 
                Console.WriteLine("hoşgeldiniz"); 
            }
            else 
            { 
                Console.WriteLine("hatalı giriş yaptınız");
            }

            //  B ) switch Yapısı
            //  switch yapısı, bir değişkenin belirli değerlerine göre farklı kod bloklarını çalıştırır.
            //  Birden fazla durumu kontrol etmek gerektiğinde daha düzenli bir yapı sağlar.

            /* 
            * switch: Kontrol edilecek değişkeni içerir.
            * case: Değişkenin belirli bir değeriyle eşleşirse, ilgili kod bloğu çalışır.
            * default: Hiçbir case bloğuyla eşleşme olmazsa, default bloğu çalışır (isteğe bağlıdır).
            */


            // MEVSİM GİRDİĞİMİZDE BİZE AYLARI VEREN PROGRAM 
           
            string mevsim;
            Console.WriteLine("lütfen aratmak istediğinzi mevsim giriniz ? ");
            mevsim = Console.ReadLine();
            switch (mevsim)
            {
                case "kış": Console.WriteLine("ARALIK , OCAK , ŞUBAT"); break;
                case "bahar": Console.WriteLine("MART , NİSAN , MAYIS"); break;
                case "yaz": Console.WriteLine("HAZİRAN , TEMMUZ , AGUSTOS"); break;
                case "SONBAHAR": Console.WriteLine("EYLÜL , EKİM , KASIM "); break;
                default:
                    Console.WriteLine("HATALI MEVSİM GİRİŞİ YAPTINIZ");
                    break;
            }
            
            
            // Switch case örnek 
            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                default:
                    Console.WriteLine("Geçersiz gün");
                    break;
            }
            Console.ReadLine();

            
            // PLAKASI GİRİLEN ŞEHRİN ADINI VEREN PROGRAM 

            byte plaka;
            Console.WriteLine("lütfen plaka numrasını giriniz");
            plaka = byte.Parse(Console.ReadLine());
            switch (plaka)
            {
                case 1: Console.WriteLine("burası adana"); break;
                case 2: Console.WriteLine("burası adıyaman"); break;
                case 4: Console.WriteLine("burası ağrı "); break;
                default: Console.WriteLine("henüz bu şehri eklemedik haritaya"); break;
            }


        }
    }
}
