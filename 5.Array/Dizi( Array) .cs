using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace dizi ( array ) 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Herkese merhaba bugün Dizileri çalışıcaz . 

            // DİZİ NEDİR ? : 
            // dizilerde her eleman data , her elemanın konumu ise index olarak adlandırılır. dizi ram bellekte tutulur.
            // Diziler, C# dilinde aynı türdeki birden fazla veriyi bir arada tutmak için kullanılan veri yapılarıdır.
            // Dizilerde her bir eleman belli bir sıraya sahiptir ve bu sıraya indeks denir. İndeksler genellikle sıfırdan başlar.


            /// Dizi Tanımlama ve İnisiyalizasyonu
            // Dizi oluşturmak için önce dizinin veri tipi belirtilir,
            // ardından köşeli parantezler kullanılır.Daha sonra dizi boyutunu belirleyebilir,
            // veya doğrudan elemanlarla inisiyalize edebilirsiniz.

            
            int[] sayilar = new int[5]; // 5 elemanlı bir tamsayı dizisi

            // Bu dizinin her bir elemanı varsayılan olarak 0 ile başlatılır.

            int[] sayilar = { 10, 20, 30, 40, 50 };

            // Bu şekilde dizi, belirtilen elemanlarla inisiyalize edilir.


            // Dizi elemanlarına erişmek için indeks kullanılır. İndeksler 0'dan başlar.
            
            int[] sayilar = { 10, 20, 30, 40, 50 };
            Console.WriteLine(sayilar[0]); // 10
            sayilar[2] = 35; // 3. eleman (index 2) 35 olur.


            /// C# Dizi Metotları
            //  C#'ta diziler üzerinde çalışmak için birçok hazır metot bulunmaktadır. İşte en yaygın dizi metotları:


            // 1. Array.Sort()
            // Diziyi küçükten büyüğe sıralar.

            int[] sayilar = { 5, 2, 8, 1, 4 };
            Array.Sort(sayilar); // Sonuç: { 1, 2, 4, 5, 8 }

            
            // 2.Array.Reverse()
            // Diziyi tersine çevirir.

            int[] sayilar = { 1, 2, 3, 4, 5 };
            Array.Reverse(sayilar); // Sonuç: { 5, 4, 3, 2, 1 }


            // 3. Array.IndexOf()
            // Belirtilen değerin dizideki ilk indeksini döndürür. Eğer eleman dizide yoksa -1 döner.

            int[] sayilar = { 10, 20, 30, 40, 50 };
            int index = Array.IndexOf(sayilar, 30); // Sonuç: 2


            // 4. Array.Max()
            // Dizideki en büyük elemanı verir(Bu metot için System.Linq kütüphanesi gereklidir).

            int[] sayilar = { 5, 2, 8, 1, 4 };
            int max = sayilar.Max(); // Sonuç: 8

            // 5. Array.Min()
            // Dizideki en küçük elemanı verir(Bu metot için System.Linq kütüphanesi gereklidir).

            int[] sayilar = { 5, 2, 8, 1, 4 };
            int min = sayilar.Min(); // Sonuç: 1


            // 6. Array.Length
            // Dizinin boyutunu verir, yani dizide kaç eleman olduğunu döndürür.

            int[] sayilar = { 5, 2, 8, 1, 4 };
            int uzunluk = sayilar.Length; // Sonuç: 5


            // 7. Array.Clear()
            // Dizinin belirtilen bölümündeki tüm elemanları sıfırlar.4
            int[] sayilar = { 5, 2, 8, 1, 4 };
            Array.Clear(sayilar, 0, sayilar.Length); // Tüm diziyi sıfırlar.



            // 9. Array.Exists()
            // Belirli bir koşulu sağlayan bir elemanın olup olmadığını kontrol eder.

            int[] sayilar = { 5, 2, 8, 1, 4 };
            bool varMi = Array.Exists(sayilar, eleman => eleman > 5); // Sonuç: true (Dizide 5'ten büyük bir eleman var)


            // Çok Boyutlu Diziler
            // Diziler sadece tek boyutlu olmak zorunda değildir. C# dilinde iki boyutlu veya daha fazla boyutlu diziler de tanımlanabilir. Bu dizilere matris veya tablo gibi de bakılabilir.

            /// İki Boyutlu Diziler(Matris):

            int[,] matris = new int[3, 2] {
                  { 1, 2 },
                  { 3, 4 },
                  { 5, 6 }
            };
            Console.WriteLine(matris[0, 1]); // Çıktı: 2 Bu örnekte, matris dizisi 3 satır ve 2 sütundan oluşur.


            // Jagged Arrays (Düzensiz Diziler):
            // Düzensiz dizilerde her bir dizi farklı boyutlara sahip olabilir.Yani, her bir satır farklı sayıda sütun içerebilir:

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };



            //*************** ÖRNEKLER ************\\

            
            // ŞEHİRLER DİZİ YAPMA 


            string[] sehirler = { "adana", "bursa", "ankara ", "istanbul" };
            Console.WriteLine("dizimizin 2.index değeri:" + sehirler[2]);
            Console.WriteLine(sehirler[0]);
            Console.WriteLine(sehirler[1]);
            Console.WriteLine(sehirler[2]);
            Console.WriteLine(sehirler[3]);


            // DİZİLERLE BERABER KARAR YAPISI KULLANMA


            int[] sayılar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, };
            for (int i = 0; i < sayılar.Length; i++)
            {
                if (sayılar[i] % 20 == 0 || sayılar[i] % 30 == 0)
                {
                    Console.WriteLine("sadece bu sayılar 20 'ye ve 30'a tam bölünebiliyor");
                    Console.WriteLine(sayılar[i]);
                }
            }


            // DİZİLERDE OLAN BİRKAÇ METHODU KULLANMA 


            int[] sayılar = { 34, 54, 63, 2, 23, 4, 67, };
            Array.Sort(sayılar);
            for (int i = 0; i < sayılar.Length; i++)
            {
                Console.WriteLine(sayılar[i]);
            }
            Array.Reverse(sayılar);
            for (int i = 0; i < sayılar.Length; i++)
            {
                Console.WriteLine(sayılar[i]);
            }


            string[] kisiler = { "buse", "ali", "kemal", "eylül" };
            int sira;
            Array.Sort(kisiler);
            sira = Array.IndexOf(kisiler, "kemal");
            Console.WriteLine(sira);


            // DİZİLERDE TOPLAMA İŞLEMİ 


            int[] sayılar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, };
            int toplam = 0;
            for (int i = 0; i < sayılar.Length; i++)
            {
                toplam += sayılar[i];
            }
            Console.WriteLine(toplam);
















        }
    }
}
