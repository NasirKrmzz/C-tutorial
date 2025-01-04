using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__NOTLAR
{
    internal class program 
    {
        static void Main(string[] args)
        {
            /// KISAAYOLLAR : 
            /// ctrl K+ D : kodu düzenler . 
            /// // KOYUP O SATIRI YORUM SATIRI YAPARSIN .
            ///  
            /// /*
            ///  
            ///  */ BÖYLE KULLANIP DA BİRDEN FAZLA YORUM SATIRI YAPABİLİRSİN .
            /// 
            /// visual studio da ekranın en soluna tıklar kodun nasıl çalıştığını merak ediyorasan eğer oraya basıp sonra f11' e basıp koda adım adım ilerler nasıl çalıştığını ve nerede hata yaptığını anlarsın .
            /// 
            /// 
            /// 
            /// {} PARANTEZİN İÇİNDE YAZILAN SAYI İNT DEĞERDEKİ SAYIYI EKRANA YAZDIRIR .
            /// 
            ///
            ///  VALUE TYPE : DEĞER TİPİ Kendi değerlerini kendi içlereinde tutarlar . 
            ///  --> Nümerik tipler , bool ,char ,struct , enum .
            ///  İNT İ = 5   burada i değeri içinde 5 değerini tutar 
            ///  long / float /char / bool / byte / short 
            ///  decimal( finansal hesaplamalarda ) /  10 lu tabanda 
            ///  double ( Bilimsel hesaplamalarda . kordinat hesaplamalrında ) / 2 li tabanda ( float da 2 li tabanda ) 
            ///  burada bunlar birbirine eşit değil haa  double değerler tabi çğnkü bilgisayar mesela diyelim 0.5 den sonraki değerleride hesaplıyo diyelim belki 0.50000000002 olabilir yani   Console.WriteLine(0.1+0.2==0.3); 
            ///  (Signed (imzalı), unsigned(imzasız) kavramları değişken türünün negatif sayıları da kapsayıp kapsamadığı konusunda bildirimde bulunur örneğin signed char -127 ile +127 arası değerler alabilirken unsigned char 0 ile +255 arası değerleri alabilir. Bu bildirim sonucunda türün tutabildiği maksimum değerin değişmesinin sebebi binary modda negatifi ifade edebilmemiz için bir basamağı feda ediyor oluşumuz, bu nedenle değişken negatifleri de kapsadığında tutabileceği maks değer azalıyor. Diğer long vs. zaten int gibi bir type def )
            ///  real (gerçek sayılar : double .float .decimal ) 
            ///  logic (bool) 
            ///  char 
            /// 
            /// 
            /// --> ​​Eğer bir veri tipinin value type mı ref type mı olduğunu öğrenmek istiyorsak veri tipine ctrl+click yapıp Struct class ise value typetır. Class/object ise ref type --< 
            /// --> eğer bir veri tipini direkt yazmak istemyorsan eğer onun mesela int diyelim onun sayı olarak karşılık gelen kodunuda yazıp aynı sayıyı yazdırabilrisin mesela char larda hexdecimal tipini yazıp' da tutturabilirsin . 
            /// 
            /// 
            /// REFERENCE TYPE : REFERANS TİPİ buradaki referans isim memoryde bir yer referans tutup bize onu söylüyor . Refereans tiplerinde bir refersans vardır birde referansın gösterdiği bit obje yani refreans numarası vardır gibi düşün.
            /// string isim = nasır 
            /// -->  object , class , interface , arry , delegate , pointer .
            /// 
            /// Nümerik literaller 
            /// 
            /// Nümerik suffix : bir değişkenin veya sabitin veri türünü belirlemek için kullanılan ek bir karakter veya karakter dizisidir. 
            /// expression belli bir işi yapan ve bellirli bir sonuç döndüren kısımlardır 
            /// 
            /// Nümerik Conversations ( Çevirmeler ) : değişken ataması yani : tamsayı tipler için atanacak tip , atanan tipin değerlerini kapsıyorsa açıkca atama yapılabilir.ama eğer kapsamıyorsa atama gerçekleşmez . ve de büyük tipteki veriyi küçük tipteki veriye aktarırsan data kaybı yaşarsın .
            /// 
            /// Float double tipine direk dönüşür .ama float doubleye dönüşemiyor(data kaybı yaşayıp atıyabilirsin ama ). ; tüm tam sayı tipleri otomatik olarak noktalı sayılara çevrilebiliryor .
            ///
            /// Decimal çevrileri : tüm tam sayı tipleri açıkca decimal tipine çevrilebilir. 
            /// 
            /// 2' ye ayrılırlar :: operand ve öperatörler 
            ///  
            /// farz edelimki elimizde şöyle bir şey var . 1 + 2 * 3 
            /// 
            /// operandlar : buradaki 1 2 3 
            /// öperatörler: 
            ///  ise buradaki + * ve çarpma işaretleridir . 
            ///  = atama öperatörü 
            ///  == : eşit mi öperatorü 
            ///  > : büyükdür öperatorü 
            ///  > : küçükdür öperatorü 
            ///  ! : eşit değil öperatorü  
            ///  & : ve öperatorü 
            ///  | : veya öperatorü 
            ///  % : mod öperatorü 
            ///  
            /// Aritmetik öperatötler: + , - , * , / ,%  ; byte ve short ( yani 8 ve 16 bit tiplrinde ) tipleri hariç diğer tüm sayı tiplerinde bunları kullanabiliyorsunuz.
            /// Integer division : iki tane tam sayıyı birbirine böldüğünüzde kalan hiç farketmez yine bir tam sayı vericekdir . 
            /// Overflow mantığı : bir kodu çalıştırdığında aritmetik öperatorler bir overflow olabilir yani alabileceği değerin en yukarsınada çıkabilir ya da en altinada inebilir . 
            /// 
            /// Const :: Sabit ifade, derleme zamanında tam olarak değerlendirilebilen bir ifadedir.
            /// 
            /// 
            /// post increment ve pree increment  : 
            ///  int i = 2 ; 
            ///  i++ ; İ'yi geriye döndür , sonra 1 arttır . (yani i yi yazddırır önce sonra i nin değerini 1 arttır.
            ///  ++i ; İ'yi i 1 arttır , ve o arttırılmış değeri geri döndür . ( burada artık i nin değeri 3 oldu onu 1 arttırırp sonra onu geri döndürür. 
            ///
            /// 
            /// karar yapıları : 
            /// if -else 
            /// 
            /// 
            ///      DÖNGÜLER ::: 
            /// 
            /// FOR: Belli bir ardışık bir şey istiyorsan kullanırsın 
            /// 
            /// while : önce bir ture'luk durumuna baktırırsın doğru ise döngü çalışır 
            /// 
            /// do while : bu dongü ise bir defa çalışır sonra truluk durumuna bakılır eğer true ise devam eder değil ise durur yani bir defa kesin çalışır ondan sonrası bir karara bağlıdır .
            /// 
            /// foreach : dizilerle beraber kullanılan bir döngü türüdür
            /// 
            /// break :: breakden önce yazılan statmıntları çalıştırır breakdend sonrasına geldi mi çalıştırmaz yani break kullanıcasan breakden sonrası kullanmak istemiyorsundur .
            /// 
            /// continue :: ise sadece o case i atlamamızı sağlıyor yani atlamak istediğimiz yeri atlıyoruz continue ile .
            /// 
            ///      METOT :  belirli bir işlevi yerine getirmek için kullanılan bir kod bloğudur. Metotlar, bir veya daha fazla parametre alabilir, bir değer döndürebilir veya belirli bir işi gerçekleştirebilir.
            /// Erişim belirteci: Metodun kimlerin erişebileceğini belirler. public (herkese açık) , private (sadece içerisinde bulunduğu sınıfdan erişim sağlanır.), protected (tanımlandığı sınıf ve miras alınan sınıflardan erişim sağlanır ) vb. erişim belirteçleri kullanılabilir.
            /// Dönüş değeri: Metot bir değer döndürebilir veya void olabilir(herhangi bir değer döndürmez).
            /// Adı: Metoda benzersiz bir isim verilir.
            /// Parametreler: Metot, işlevini yerine getirmek için veri alabilen parametrelere sahip olabilir.
            /// Gövde: Metodun işlevini gerçekleştiren kod bloğudur.
            /// * Metotlar 2'ye ayrılır geriye değer döndürren metotlar ve geriye değer döndürmeyen metotlar () sembolü ile tanımlanırlar . 
            /// -- Geriye değer döndüren metotlar --
            /// 
            ///  Geriye değer döndüren metotlar ise int , string , veya class ait ilgili değerin türü yazılır.
            ///  geriye döndürülünecek değer return ifadesi ile belirlenir.
            ///  
            /// -- Geriye değer döndürmeyen metotlar --
            ///  Geriye değer döndürmeyen metotlar'da void tanımlaması yapıplır.
            ///  
            /// METOTLARA AŞIRI YÜKLEME (OVER LOAD) : 
            /// Görevleri farklı olmak şartıyla aynı isimden birden fazla metot bulunmasıdır.
            /// 
            /// 
            /// C#'da 4 adet parametre tipi var : Değer parametreleri , Referans parametreleri , Altput parametreleri , Parametreyi evreleri. 
            /// 
            ///      DİZİ::  dizilerde her eleman data , her elemanın konumu ise index olarak adlandırılır. dizi ram bellekte tutulur.
            /// 
            /// dizi metotları:
            /// sort:diziyi küçükden büyüğe göre sıralar.
            /// reverse:diziyi tersten yazdırır..
            /// Index of : arana index sırasını döndürür.
            /// max: dizinin en büyük elemanın verir.
            /// mim : dizini en küçük elemanın verir.
            /// length: dizinin boyutunu verir.
            /// 
            /// Jagged arry : arry of arry diizilerin dizisiymiş .
            ///    int[][] arry = new int[3][];
            ///   arry[0] = new int[5]; // 5 elemandan oluşana bir dizi oluştuuyuyor 
            ///   arry[1] = new int[2]; // 2 elemandan oluşana bir dizi oluştuuyuyor 
            ///   arry[2] = new int[3];// 3 elemandan oluşana bir dizi oluştuuyuyor 
            /// 
            /// 
            ///    ANAHTAR SÖZCÜKLER VE KULLANIMI :: 
            /// 
            /// anahtar sözcükleri bir değişken atamasında kullanamıyoruz mesela void diye bir değişken oluşturamazsın . 
            /// ama bir istisna yapıp değişken önüne @ koyup yazabilrsin . 
            /// 
            /// 
            /// 
            ///   
            /// 
            /// 
            ///    TEMEL TİPLER :: değişkenler zamanla farklı değerler alabilirler . 
            /// 
            /// bir değişken oluşturup bir daha o değişkenin değiştrilmesini istemyorsam const kulllanarak yapabilirim. mesela (const int x = 12*30;)
            /// 
            /// 
            /// 
            /// 
            /// 
            /// ************************     STATİC KAVRAMI    *****************************
            /// 
            /// 
            /// * içerisinde bulunana sınıfdan nesne oluşturmadan kullanılan yapılardır . 
            /// 
            /// 
            /// **********************  TANIMLI TİPLER     ************************
            /// 
            /// ******************* Conversation ( Çevrimler ) ********************
            ///
            ///   // implicit ( açıkca yapılan çevrimler otomatik yapılabilendir ) = eğer sol tarraftaki değerin büyüklügü sağdan büyük ise bu çeviri otomatik yapılıyor.Data kaybı yaşatmaz 
            ///   // explict ( bir test aşaması içeriyor ) kullanımı ise eğer yetmiyorsa büyüklükler birbirine burada ( short )diyip kullanabilirim. çevrimin her zaman doğru olacağının bir garantisi yokdur Data kaybı olabilir.
            ///
            /// c# kendi içerisindeki tipler arasında çevrim yapılmasına olanak sağlıyor . 
            /// 
            /// 
            /// 
            ///                    *********************** CLASS ***************************
            /// 
            /// CLASS : Niteliklerimiz barındıran , kod bloklarını bir arada tutan yapılardır . 
            /// nesne : sınıfların niteliklerine ulaşabilmesi için gereken komutlardır. 
            /// 
            /// KAPSÜLLEME : Nesnelerin niteliklerini bilinçsiz kullanımını önlemek, İlgili özelliklerin istenilen değer ya da aralıkta olmasınıs sağlamak , Arka planda kodları gizlemek gibi işlevlerer sahip OOP terimidir. 
            /// 
            /// 
            /// KALITIM : Projelerimizi gerçekleştiriken bir sınııfa ait değişkenlerin birkaçını ya da tamamını bir başka sınıf içinde kullanmakdır . 
            /// 
            /// POLYMOR PHİSM ( ÇOK BİÇİMLİLİK ) : Miras alma işleminden sonra herhangi bir alanda bulunan değerleri miras alınan sınıftaki haliyle değil de bizim istediğimiz formata kullanım sağlamasıdır . 
            /// Virtual : kalıtım alınan sınıflarda içeriğin değiştirilebilmesi için kullanılan komutlardır .
            /// Override : geçersiz  kılma anlamına gelen bu komut değiştirlecek metot yazılmadan önce metodun başına eklenir.
            /// 
            /// 
            ///                          ********************  FONKSİYONLAR   *************************
            ///                          
            /// C# tarafından bize hazır ollaraka sunulan bazı fonksiyonlar ve metotlardır . ( matematiksel fonk. / metinsel fonk. / tarihseler date fonk. ) 
            ///
            /// matematiksel fonk. : Abs = mutlak aldırır . celling = üs tabana yuvarlama . floor = alt tabana yuvarlama . Sgrt = karkök aldırıyor . Pow = üs alma . Pi = pi aldırır .
            /// string fonk. : Contact = Birleştirme . Lenght = Uzunluk . Indexof = Metin arama . Starwith = İlgili parametre ile mi başlıyor . Trim = Metnin başındaki ve sonundaki boşlukları kaldırma . Toupper = Büyük harf . Tolower = Küçük harf . Remove = İstenilen karakterden itibaren siler . Replace =  Değiştirme . Substring = İstenilen karakterden itibaren işlem yapar.
            /// Tarih fonksiyonları : Anahtar kelime = Datetime / Tİmespan = 2 tarih arasındaki farkı hesaplar . 
            ///                          *********************   CHECKED - UNCHECKED   ******************
            /// Kullandığın projeye göre checked ya unchecked uyarlıyabilirsin . Yavaş yyavaş kullandıkça öğreniceksin .   
            /// 
            /// 
            /// ÖZEL OLAN FLOAT VE DOUBLE DEĞERLERİ 
            ///
            /// ( NAN ( NOT A NUMBER ) , -∞ , +∞ , -0 ; bunlar için özel değerler mevcut default yani . bir float ya da double da herhangi bir sayı falan tutlulduğunuda yine IsNAn yazarak kullanıp öğrenebillirsin. 
            ///
            /// double Nan değerleri her zmanan  birbirinden farklıdır. ama bunları object.Equals içine alırsan eşitliyebilirsin . 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            ///           
        }
    }
}
