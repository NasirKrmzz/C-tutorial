using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İşleçler__Operators_
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            /*   İŞLEÇLER (OPERATORS) OPERANDLAR  */

            // Operatörler,
            // programlama dilinde belirli işlemleri gerçekleştirmek için kullanılan sembollerdir.
            // C# dilinde birçok farklı operatör türü vardır, ve bu operatörler üzerinde işlem yaptıkları değerleri veya değişkenleri kullanarak çalışır.

            // A ) Aritmetik Operatörler
            // Bu operatörler, matematiksel hesaplamalar yapmanı sağlar.

            // + (Toplama Operatörü):
            int x = 5 + 10; // x = 15

            // - (Çıkarma Operatörü)
            int Y = 20 - 5; // Y = 15

            // * (Çarpma Operatörü):
            int Z = 4 * 5; // Z = 20

            //  / (Bölme Operatörü): Birinci operand'ı ikinci operand'a böler.
            //  Eğer bir sayı 0'a bölünürse DivideByZeroException hatası alırsın.

            int K = 20 / 4; // K = 5

            // % (Modulus Operatörü): Birinci operand'ı ikinci operand'a böldüğünde kalan değeri döndürür

            int J = 10 % 3; // J = 1


            // B ) Atama Operatörleri

            // = (Basit Atama Operatörü): Sağdaki değeri soldaki değişkene atar.
            int a = 10; // 'a' değişkenine 10 değeri atanır


            // += (Toplam ve Atama): Sağdaki değeri soldaki değişkene ekleyip sonucu atar.
            
            a += 5; // a = a + 5, yani a = 15


            // -= (Çıkarma ve Atama): Sağdaki değeri soldaki değişkenden çıkarır ve sonucu atar

            a -= 2; // a = a - 2, yani a = 13


            // C ) Karşılaştırma Operatörleri 

            //  == (Eşittir)
            bool result = (5 == 5); // result = true

            // != (Eşit Değildir)
            bool result = (5 != 3); // result = true

            // > (Büyüktür)
            bool result = (10 > 5); // result = true

            // < (Küçüktür)
            bool result = (3 < 7); // result = true

            // >= (Büyük Eşittir)
            bool result = (5 >= 5); // result = true

            // <= (Küçük Eşittir)
            bool result = (3 <= 7); // result = true


            // D ) Mantıksal Operatörler (Logical Operators): 

            
            // && (Mantıksal VE): İki koşul da true ise, sonuç true olur.Aksi takdirde false.
            bool result = (5 > 3 && 10 < 20); // result = true

            // || (Mantıksal VEYA): Herhangi bir koşul true ise, sonuç true olur.İkisi de false ise sonuç false
            bool result = (5 > 3 || 10 > 20); // result = true

            // ! (Mantıksal DEĞİL): Bir koşulun tersini alır. true olanı false, false olanı true yapar.
            bool result = !(5 > 3); // result = false



            // 2. Operandlar (Operands) 
            // Operandlar, operatörler tarafından işlenen verilerdir. Bu veriler sabit, değişken veya bir ifadenin sonucu olabilir.

            // A ) Değişkenler (Variables)

            int x = 5;
            int y = 10;
            int result = x + y; // Burada x ve y operand, + operatördür

            // B ) Sabitler(Constants)

            int result = 5 + 10; // Burada 5 ve 10 operand'lardır

            // C ) İfadeler (Expressions)

            int result = (x + y) * 2; // (x + y) bir ifade olarak operand’dır


            // 1.Pre - increment(++x)
            int x = 5;
            int y = ++x;  // x önce artırılır (6 olur), sonra y'ye atanır
            Console.WriteLine(x); // 6
            Console.WriteLine(y); // 6

            //  2.Post - increment(x++)

            int x = 5;
            int y = x++;  // y'ye x'in eski değeri atanır (5), sonra x artırılır
            Console.WriteLine(x); // 6
            Console.WriteLine(y); // 5



            // Pre-increment (++x): Değişken önce artırılır, ardından yeni değeri kullanılır.
            // Post - increment(x++): Değişken önce mevcut değeriyle kullanılır, sonra artırılır.


            // Pre-decrement (--x): Değişken önce azaltılır, ardından yeni değeri kullanılır.
            // Post - decrement(x--): Değişken önce mevcut değeri kullanılır, sonra azaltılır.
            
            int x = 5;
            int y = --x;  // x önce azaltılır (4 olur), sonra y'ye atanır
            Console.WriteLine(x); // 4
            Console.WriteLine(y); // 4

            int x = 5;
            int y = x--;  // y'ye x'in eski değeri atanır (5), sonra x azaltılır
            Console.WriteLine(x); // 4
            Console.WriteLine(y); // 5


            /// !!!!!!!!!!
            ///
            /// Aritmetik öperatötler: + , - , * , / ,%  ; byte ve short ( yani 8 ve 16 bit tiplrinde ) tipleri hariç diğer tüm sayı tiplerinde bunları kullanabiliyorsunuz.
            /// 
            /// Integer division : iki tane tam sayıyı birbirine böldüğünüzde kalan hiç farketmez yine bir tam sayı vericekdir . 
            /// 
            /// Overflow mantığı : bir kodu çalıştırdığında aritmetik öperatorler bir overflow olabilir yani alabileceği değerin en yukarsınada çıkabilir ya da en altinada inebilir . 
            ///
            ///
        }
    }
}
