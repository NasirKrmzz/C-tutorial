using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_tutorial_dosyalar
{
    internal class Methods
    {
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.BackgroundColor = ConsoleColor.Black;
        //Console.WriteLine("Lütfen Merhaba diyiniz. : )");
        //string name = Console.ReadLine();


        // ----------------- Methodlar -----------------\\

        /* Nedir ?: Bir sınıf ya da nesneye ait olan ve belirli bir işlevi yerine getiren kod bloklarıdır.
        * Her metot, tanımlandığı isim ile çağrılır.
        * İşlemleri parametreler aracılığıyla özelleştirilebilir.
        * Bir değer döndürebilir ya da sadece işlem yapabilir (void).
        *

        * Avantajlar:
        * 1-) Kod Tekrarını Azaltır
               a. Aynı kodu birden fazla yerde yazmak yerine bir metot oluşturulur ve gerektiğinde çağrılır.
               b. Bu, kodun bakımını ve yönetimini kolaylaştırır.

        * 2-) okunabilirliği Artırır
               a. Kod bloklarını işlevlerine göre böler ve her birini kolay anlaşılabilir hale getirir.
               b. Örneğin, "Toplama işlemi" için ayrı bir metot olması, kodun amacını daha net gösterir.

        * 3-) Yeniden Kullanılabilirlik Sağlar
               a. Bir kez yazılan bir metot, farklı yerlerde tekrar tekrar kullanılabilir.
               b. Parametreler aracılığıyla farklı durumlara uyarlanabilir.

        * 4-) Modülerlik Sağlar
               a. Büyük bir program, küçük işlevsel parçalara (metotlara) bölünerek daha modüler hale gelir.
               b. Bu yaklaşım, hataları izlemeyi ve çözmeyi kolaylaştırır.

        * 5-) Bakım ve Güncelleme Kolaylığı
              a. Bir işlemi değiştirmek gerektiğinde, sadece ilgili metotta değişiklik yapmak yeterlidir .
              b. Tüm kodu gözden geçirmek yerine, metotları kontrol etmek yeterlidir.

        * 6-) Hata Ayıklamayı Kolaylaştırır
              a. Her bir metot belirli bir işlevi gerçekleştirdiğinden, bir sorun çıktığında ilgili metot kolayca incelenebilir.

        * 7-) Performans ve Verimlilik
              a. Kod daha az karmaşık hale gelir ve programın işleyişi hızlanır.
              b. Gereksiz kod çalıştırılmasının önüne geçer.

        * 8-) Ekip Çalışmasında Kolaylık
             a. Birden fazla geliştirici bir projede çalışırken, metotlar sayesinde iş paylaşımı kolaylaşır.
             b. Her geliştirici farklı metotlar üzerinde çalışabilir.

        * 9-) Genişletilebilirlik
             a. Yeni işlevler eklemek gerektiğinde, mevcut metotlara dokunmadan yeni metotlar tanımlanabilir.

        * 10-) Anlamlı ve Tek İşlevli Yapı
             a. Her metot bir işi gerçekleştirmek üzere tasarlandığından, programın işlevselliği net bir şekilde anlaşılır.


       * ------------> [TEMEL YAPISI] <-------------------

              * [Erişim Belirleyici] [Dönüş Türü] [Metot Adı] [Parametre Değer/Değerleri] { [Gövde (Kod Bloğu)] }
              * Erişim Belirleyicisi: public, private, protected, internal gibi.
              * Dönüş Türü: Metot ne tür bir değer döndürecek? (örn. int, string, void).
              * Metot Adı: Tanımlayıcı bir isim (örn. Topla, Hesapla). I
              * Parametre Listesi: Parantez içindeki giriş değerleri.
              * Gövde: Metotun işlevselliğini içeren kod bloğu.
              * Örnek bir metot oluşumu: public int Topla(int x, int y) { //kodlar .. } 
              * Önemli: static tanımlanmış bir metotda çağrılan metotlarda static olmalıdır. Bu video özelinde static keywordu anlatılmayacak fakat main
              * metotu static olduğundan dolayı bizim tanımlayacağımız metotlarda static olmak zorundadır.
              * 

              [Geriye Değer Döndüren Metotlar}
              * Bir işlem sonucunda bir değer üreten ve bu değeri çağrıldığı yere döndüren metotlardır.
              * İşlem sonuçlarını başka işlemler için kullanılabilir hale getirir.
              * Daha dinamik ve esnek uygulamalar geliştirmenizi sağlar.

              [Geriye Deger Dondurmeyen (Void) Metotlar]
              * Herhangi bir değer döndürmeyen, yalnızca belirli bir işlemi gerçekleştiren metotlardır.
              * İşlem sonuçlarını başka işlemler için kullanılabilir hale getirir.
              * Daha dinamik ve esnek uygulamalar geliştirmenizi sağlar.

              > [Parametreli Metotlar]
              * İşlem gerçekleştirmek için dışarıdan veri alan metotlardır.
              * Daha dinamik ve özelleştirilebilir işlemler yapılmasını sağlar.

             [Parametresiz Metotlar]
             * Herhangi bir veri almadan işlem gerçekleştiren metotlardır.
             * Sabit bir işlemi gerçekleştirmek için kullanılır.
             */

        static void Main(string[] args)
        {
            Console.WriteLine("Geriye değer döndüren: " + topla(50, 60));
            topla(5, 10, 15);
            topla(10);
            Console.WriteLine("parametresiz " + topla());
            Console.ReadKey();
        }
        public static int topla(int x, int y)
        {
            return x + y;
        }
        public static void topla(int x, int y, int z)
        {
            Console.WriteLine("Geriye değer döndürmeyen. " + (x, y, z));
        }
        public static void topla(int x)
        {
            Console.WriteLine("parametreli" + (x, x));
        }
        public static float topla()
        {
            return 0.5f + 1.0f;
        }
    }
}
