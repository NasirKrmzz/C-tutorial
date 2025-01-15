using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_tutorial_dosyalar.Erişim_belirleyiciler
{
    internal class acssesModifiers
    {
        
        /* ------------------------------<<<<<<<<<< [Erişim Belirleyiciler]>>>>>>>>>>--------------------------------

         * Sırasıyla Local Veriables ve Class Members hakkında bahsedicez:

         * 1-) [Local Veriables]
         a. Yerel değişkenlerin erişimi, bulunduğu kapsam (scope) ile sınırlıdır. Bu nedenle, ek bir erişim belirleyicisine ihtiyaç duyulmaz.
         b. Yerel değişkenlerin erişim belirleyicisi yoktur çünkü:
             b.a Yerel değişkenler yalnızca tanımlandıkları kapsamda (method, döngü, if/else bloğu gibi) vâr olurlar.
             b.b Bu değişkenler, scope'un dışına çıktığında otomatik olarak bellekten temizlenir*/
           
            if(true)
                {
                int yaş = 25; // Bu değişken sadece bu blokta kullanılabilir.
                }
           
        /*
        c. Varsayılan Değer Almaz. (Yerel değişkenler başlatılmadan kullanılamaz.)
        */
        int yaş; // Hata: Değişken başlatılmadı.Bu nedenle, bu değişkeni kullanmaya çalıştığınızda bir hata alırsınız.
        /*
        d. Shadowing (Gölgelenme): Yerel değişkenler, sınıfın field değişkenlerini gölgeleyebilir.
        e. Eğer bir değişkenin erişim düzeyini kontrol etmek istiyorsanız, onu "sınıf düzeyinde [class members]" tanımlamalısınız.
             */

                int yas = 2; // Bu değişken sınıf düzeyinde tanımlanmıştır.
              public void Test()
              {
                  int yas = 25; // Bu değişken, sınıf düzeyinde tanımlanan "yas" değişkenini gölgeleyecektir.
              }
         
          /*
          2-) [Class Members (Type Members)]
          a. Sınıfın tamamına erişebilir ve belirli bir erişim belirleyicisiyle diğer sınıflara açılabilir veya sınırlandırılabilir.
          b. Yerel değişkenler'den (local veriables) en büyük farkı işlevsellik noktası. Yerel değişkenler bulunduğu kod bloğu içerisinde işlevsellik
          gerçekleştirirken, sınıf üyeleri, sınıfın işlevselliğini sağlar.
              c. Class Members Türleri:
              c.a Field (Alan)
              c.a.a: Bir sınıfın verilerini saklar.
              c.a.b: Alanlar genellikle private tanımlanır ve veri saklama için kullanılır.
        */

                    static int _yas; // Bu bir alan (field) örneğidir.
                    static string isim "Ali";
                        static void Main(string[] args)
                    {
                        _yas = 25; // Alanlara erişim, sınıfın herhangi bir yerinden sağlanabilir.
                        deneme();
                        Console.ReadKey();
                    }
                    static deneme()
                    {
                        if (isim == "Ali")
                        {
                            Console.WriteLine("isminiz ahmet"); // Bu değişken sadece bu blokta kullanılabilir.
                        }

            /*
            c.b Property (Özellik)
                c.b.a: Field'lara kontrollü erişim sağlar (kapsülleme - encapsulation).
                c.b.b: Get ve Set yöntemleri ile değerlerin okunması ve yazılması kontrol edilebilir.
            */

                    int yas = 25; // Bu bir alan (field) örneğidir.
                    Public int Yas
                    {
                        get { return yas; }
                        set { yas = value; }
                    } // Bu bir özellik (property) örneğidir.

            /*
            c.c Method (Yontem) | | Function (Fonksiyon)
                c.c.a: Bir sınıfın davranışını veya işlevselliğini tanımlar.
                c.c.b: Parametre alabilir, bir değer döndürebilir veya yalnızca işlem yapabilir.
            c.d Events (Olaylar)
                c.d.a: Bir sınıfın belirli bir olay gerçekleştiğinde başka bir sınıfı bilgilendirmesini sağlar.
                c.d.b: Delegelerle birlikte kullanılır.
            c.e Constructor (Yapıcı)
                c.e.a: Sınıfın bir örneği (instance) oluşturulurken çalışan özel bir yöntemdir.
                c.e.b: Sınıf üyelerini başlatmak için kullanılır.
            c.f Destructor (Yıkıcı)
                c.f.a: Sınıf örneği bellekten kaldırılmadan önce çalışan bir yöntemdir.
                c.f.b: Çöp toplama (Garbage Collection) sürecine destek olur.
            c.g Static Member (Statik Üye):
                c.g.a: Sınıfın örneklerinden bağımsızdır, sınıfın kendisine bağlıdır.
                c.g.b: Tüm sınıf[ üyeleri tarafından paylaşılır.
            c.h Nested Type (İç Tür):
                c.h.a: Sınıfın içinde tanımlanmış başka sınıf, yapı, arabirim veya enum'lardır.


            d. Erişim Belirleyicileri: public, private, protected, internal, protected internal, private protected erişim belirleyicilerle sınıf üyelerinin
            erişim düzeyi kontrol edilir.
            e. Class Members ile Local Variables Arasındaki Temel Farklar:
                e.a Tanımlama Yeri: Class Members; sınıf içinde, sınıfa aitken; Local Veriables; Method, blok veya constructor içindedir.
                e.b Erişim Kapsamı: Class Members; sınıfın tamamında erişilebilirken; Local Veriables, sadece tanımlandığı blokta geçerlidir.
                e.c Yaşam Süresi: Class Members; sınıf örneği süresince veya statikse program boyunca yaşarken; Local Veriables, sadece tanımlandığı blokta
                geçerlidir.
                e.d Varsayılan Değerler: Class Members; Otomatik olarak başlatılırken (null, e, vb.); Local Veriables, Başlatılmadan kullanılamaz.
           
                                   ---------------------------------------------------------------------------------------
            
             * [Bu kavramların temeli atıldığına göre, erişim belirleyiciler kavramına değinebiliriz]

            * Tanım: Erişim belirleyiciler, bir class, method, field, property, delegate, event vb. yapıların, hangi kod parçaları tarafından
            erişilebileceğini kontrol eder.
            * Amaç: Verileri korumak, gereksiz yere dış dünyaya açılmasını engellemek, kodu daha güvenli ve okunabilir hale getirmek.
            *
            * 6 adet erişim belirleyici vardır, bunlar; public, private, protected, internal, protected internal, private protected
            a. public (Genel)
                a.a: Bir sınıf üyesinin veya sınıfın herkes tarafından erişilebilir olmasını sağlar.
                a.b: Kodun bulunduğu assembly (proje) veya diğer assembly'lerdeki tüm kodlar tarafından erişilebilir.*/
                                        public class PublicClass
                    {
                        public void PublicMethod()
                        {
                            Console.WriteLine("Bu method her yerden erişilebilir.");
                        }
                    }


    /*

            b. private (Özel)
            b.a: Yalnızca tanımlandığı sınıf içinde erişilebilir.
            b.b: Varsayılan erişim belirleyicidir (hiçbir erişim belirleyici verilmezse private kabul edilir).
            */
                class PrivateClass
                {
                    private void PrivateMethod()
                    {
                        Console.WriteLine("Bu method sadece bu sınıf içinde kullanılabilir.");
                    }

                    public void AccessPrivateMethod()
                    {
                        PrivateMethod(); // Bu şekilde sınıf içinde erişilebilir.
                    }
                }

            /*

            c. protected (Korunan)
            c.a: Tanımlandığı sınıf içinde ve o sınıkı miras alan (türetilen) sınıflar içinde erişilebilir.
            */
                protected class ProtectedClass
                {
                    protected void ProtectedMethod()
                    {
                        Console.WriteLine("Bu method yalnızca tanımlandığı sınıf ve türetilen sınıflar içinde erişilebilir.");
                    }
                }
           /*
            d. internal (Dahili)
                    d.a: Yalnızca aynı assembly (proje) içinde erişilebilir.
                    d.b: Farklı bir projeden erişim mümkün değildir.
            */
                internal class InternalClass
                {
                    internal void InternalMethod()
                    {
                        Console.WriteLine("Bu method aynı assembly içinde kullanılabilir.");
                    }
                }


                /* 
            e. protected internal (Korunan ve Dahili)
            e.a: Aynı assembly içinde veya başka bir assembly'deki türetilen sınıflar tarafından erişilebilir.

            f. private protected (Özel ve Korunan)
            f.a: yalnızca aynı sınıf içinde veya aynı assembly içindeki türetilen sınıflar tarafından erişilebilir.*/

                class BaseClass
                {
                    private protected void PrivateProtectedMethod()
                    {
                        Console.WriteLine("Aynı sınıfta veya aynı assembly içindeki türetilen sınıflarda kullanılabilir.");
                    }
                }

                class DerivedClass : BaseClass
                {
                    public void AccessPrivateProtected()
                    {
                        PrivateProtectedMethod(); // Erişim mümkün (aynı assembly içinde türetilen sınıf).
                    }
                }

                /*
            Önemli:
            protected internal veya private protected yalnızca özel gereksinim durumlarında kullanın.
            üye, yalnızca türetilen sınıflar için gerektiğinde, protected kullanın.
            Verilerinizi ve methodlarınızı private yaparak başlayın ve gerektiğinde erişim genişletin.
                      */

            }
   }
