using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DEĞİŞKENLER 
            // C# dilinde değişkenler, bir programın çalışması sırasında veri saklamak için kullanılan isimlendirilmiş alanlardır.
            
            //* Değişkenler 2'ye ayrılır
            
            // 1) Value types (değer tipleri)      2) Reference types (referans tipleri)
            // Değişken isimleri harf veya alt çizgi (_) ile başlamalıdır. Özel karakterler ve boşluklar kullanılamaz.
            // C# büyük/küçük harfe duyarlıdır (myVar ile myvar farklıdır).
            
            // var anahtar kelimesi kullanarak derleyicinin türü otomatik olarak belirlemesini sağlayabilirsin.
                var age = 30;       // int
                var salary = 50000.0; // double
                var name = "Ahmet";  // string

            // Bir değişkenin değerinin sabit kalması istenirse const anahtar kelimesi kullanılır.Sabitler tanımlandıktan sonra değeri değiştirilemez
                const double Pi = 3.14159;
                const int DaysInWeek = 7;

            /* 
             * Valu types( değer tipleri ) : Value types, değişkenin bellekte tuttuğu değeri doğrudan saklar. Bellekte stack alanında saklanırlar.
             * Valu typlar bellekte daha hızlı işlem yapılır çünkü küçük veri tipleri için kullanılır.
             * 
             * int (4 byte): Tam sayıları tutar.
             * long (8 byte): Daha büyük tam sayılar için kullanılır.
             * short (2 byte): Küçük tam sayılar için. 
             * byte (1 byte): 0-255 arası tam sayılar için.
             * float (4 byte): Düşük hassasiyetli ondalıklı sayılar.
             * double (8 byte): Daha hassas ondalıklı sayılar.
             * decimal (16 byte): Yüksek hassasiyet gerektiren finansal ve bilimsel hesaplamalar için.
             * bool (1 byte): True/False değerleri tutar.
             * char (2 byte): Tek bir Unicode karakteri tutar.
             */
                int number = 10;     // Bir tam sayı
                double pi = 3.14159; // Ondalıklı bir sayı
                char grade = 'A';    // Tek bir karakter
                bool isPassed = true; // Doğru/yanlış değeri
                short smallNumber = 32000;
                long population = 7500000000;
                byte number1 = 255; 
                decimal price = 99.99m;
                float pi1 = 3.14f;


            /* Reference types, bellekte bir verinin saklandığı yerin (adresin) referansını tutar. Bu tipler heap belleğinde saklanır. 
             * Refereans tiplerinde bir refersans vardır birde referansın gösterdiği bit obje yani refreans numarası vardır
             * 
             * Class: C#’ta en yaygın kullanılan referans tipidir.
             * string: Karakter dizisi tutar.,
             * Array: Bir veri türündeki sabit boyutlu veri koleksiyonlarıdır.
             */

                    // Person person1 = new Person(); // Reference type
                    // erson1.Name = "John";
                    // Person person2 = person1;      // person2, person1 ile aynı adresi gösterir.
                    // person1.Name = "Doe";          // person2.Name de artık "Doe" olur.
                    string name1 = "Alice";

            
            ///--> ​​Eğer bir veri tipinin value type mı ref type mı olduğunu öğrenmek istiyorsak veri tipine ctrl+click yapıp Struct class ise value typetır.Class/object ise ref type --< 
            ///--> eğer bir veri tipini direkt yazmak istemyorsan eğer onun mesela int diyelim onun sayı olarak karşılık gelen kodunuda yazıp aynı sayıyı yazdırabilrisin mesela char larda hexdecimal tipini yazıp' da tutturabilirsin . 
            /// Nümerik suffix : bir değişkenin veya sabitin veri türünü belirlemek için kullanılan ek bir karakter veya karakter dizisidir.
            /// expression belli bir işi yapan ve bellirli bir sonuç döndüren kısımlardır.
            /// Nümerik Conversations ( Çevirmeler ) : değişken ataması yani: tamsayı tipler için atanacak tip ,atanan tipin değerlerini kapsıyorsa açıkca atama yapılabilir.ama eğer kapsamıyorsa atama gerçekleşmez . ve de büyük tipteki veriyi küçük tipteki veriye aktarırsan data kaybı yaşarsın .
            
            /// Bir değişkenin signed (imzalı) ya da unsigned (imzasız) olma durumu, o değişkenin negatif sayıları kapsayıp kapsamadığını belirler.
                // signed char: -128 ile +127 arasında değer alır.
                // signed int: -2 ^ 31 ile + 2 ^ 31 - 1 arasında değer alabilir.
                // Unsigned: İmzasızdır, sadece pozitif sayılar ve sıfır içerir. Örneğin:
                // unsigned char: 0 ile + 255 arasında değer alır.
                // unsigned int: 0 ile + 2 ^ 32 - 1 arasında değer alabilir.
            
        }
    }
}
