using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DÖNGÜLER__loops_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Herkese merhaba bugün döngüleri çalışıcaz . 

            // 1. FOR DÖNGÜSÜ
            // for döngüsü, belirli bir sayıda yineleme yapmak için kullanılır.Döngü başlangıcı, koşulu ve artışı tek bir ifadede belirtilir.


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // Çalışma Biçimi:

            /* Başlangıç kısmı bir kez çalışır(int i = 0;).
             * Koşul kontrol edilir(i < 5).Doğruysa, kod bloğu çalışır.
             * Artış kısmı çalışır(i++), ardından koşul tekrar kontrol edilir.
             * Koşul yanlış olana kadar döngü devam eder.
             */
            
            

            // KLAVYEDEN GİRİLEN SAYINI TEK Mİ ÇİFT Mİ OLDUĞUNU VERENE PROGRAM 

            int sayı;
            Console.WriteLine("lütfen bilmek istediğiniz sayıyı giriniz");
            sayı = Convert.ToInt32(Console.ReadLine());
            if (sayı % 2 == 0)
            {
                Console.WriteLine("sayınız çift'dir ");
            }
            else
            {
                Console.WriteLine("sayınız tekdir");
            }

            
            // KLAVYEDENE GİRİLEN SAYININ FAKTÖRİYELİNİ HESAPLAMA

            Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine(sayi + "! = " + faktoriyel);

            Console.ReadLine();


            // SAATE 1 2 'KATINA ÇIKAN BAKTERİ 24 SAATİN SONUND SAYIYI KAÇ ADET OLUR 

            int bakteri = 1;
            for (int i = 1; i <= 24; i++)
            {
                bakteri = bakteri * 2;
            }
            Console.WriteLine(bakteri);



            // 2. WHİLE DÖNGÜSÜ

            // while sözcüğü ile koşulun içine yazıldığı parantezler zorunludur. Koşulsağlandığı sürece while bloğunun içindeki kod kesimi işletilecektir.

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // Çalışma Biçimi:

            // Koşul kontrol edilir(i < 5).Doğruysa, kod bloğu çalışır.
            // Koşul yanlış olana kadar döngü devam eder.



            //  Kullanıcı Girişiyle Çıkış Yapma
            string input = "";
                while (input != "çıkış")
                {
                    Console.WriteLine("Bir komut girin (çıkmak için 'çıkış' yazın):");
                    input = Console.ReadLine();
                }
                Console.WriteLine("Program sonlandı.");


            // Rastgele Sayıyı Tahmin Etme Oyunu


            Random random = new Random();
            int tutulan_sayı = random.Next(1, 11); // 1 ile 10 arasında rastgele bir sayı
            int kullanıcı_sayısı = 0;

            while (kullanıcı_sayısı != tutulan_sayı)
            {
                Console.WriteLine("Bir sayı tahmin edin (1-10):");
                kullanıcı_sayısı = int.Parse(Console.ReadLine());

                if (kullanıcı_sayısı < tutulan_sayı)
                {
                    Console.WriteLine("Daha büyük bir sayı tahmin edin.");
                }
                else if (kullanıcı_sayısı > tutulan_sayı)
                {
                    Console.WriteLine("Daha küçük bir sayı tahmin edin.");
                }
            }
            Console.WriteLine("Tebrikler, doğru tahmin!");



            // 3. DO-WHİLE DÖNGÜSÜ

            // do-while döngüsü, while döngüsüne benzer, ancak döngü koşuldan bağımsız olarak en az bir kez çalışır. Koşul döngünün sonunda kontrol edilir.
           
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

            // Çalışma biçimi:

            /*
             * Döngü koşul kontrol edilmeden bir kez çalışır.
             * Daha sonra koşul kontrol edilir(i < 5), doğruysa döngü devam eder.
            */



            // 4. foreach Döngüsü
            // foreach döngüsü, özellikle koleksiyonlar(diziler, listeler, vb.) üzerinde gezinmek için kullanılır. Döngü, her elemanı sırasıyla işler.

            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Çalışma biçimi:

            /*
             * Koleksiyonun her bir elemanı sırasıyla alınır(number).
             * Kod bloğu her eleman için bir kez çalışır.
            */

           // foreach örnek
            string[] sehirler = { "bursa", "van", "istanbul", "kars" };
            foreach (string s in sehirler)
            {
                Console.WriteLine(s);
            }

        }
    }   
}
