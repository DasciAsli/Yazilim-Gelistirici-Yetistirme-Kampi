using System.Diagnostics;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        //DERS2

        //ODEV1
        //C# dilinde bulunan diğer veri tipleri nelerdir?

        //byte : Uzunluğu 1 byte’tır, 0 ile 255 arasında değer alır.

        //sbyte : Uzunluğu 1 byte’tır, -128 ile 127 arasında değer alır.

        //short : Uzunluğu 2 byte’tır, -32768 ile 32767 arasında değer alır.

        //ushort : Uzunlupu 2 byte’tır, 0 ile 65535 arasında değer alır.

        //int : Uzunluğu 4 byte’tır, -2.147.483.648 ile 2.147.483.648 arasında değer alır.

        //uint : Uzunluğu 4 byte’tır, 0 ile 4.294.967.295 arasında değer alır.

        //long : Uzunluğu 8 byte’tır, -10 üzeri 20 ile 10 üzeri 20 arasında değer alır.

        //ulong : Uzunluğu 8 byte’tır, 0 ile 2 x (10 üzeri 20) arasında değer alır.

        //float : Uzunluğu 4 byte’tır, 1.5 x (10 üzeri - 45) ile 3.4 x (10 üzeri 38)arasında değer alır.

        //double : Uzunluğu 8 byte’tır, 5.0 x (10 üzeri -324) ile 1.7 x (10 üzeri 308) arasında değer alır.

        //decimal : Uzunluğu 12 byte’tır, ±1.0 x( 10 üzeri - 28) ile ±7.9 x (10 üzeri 28) arasında değer alır.

        //char : Uzunluğu 2 byte’tır, Bütün ınicode karakterleri kapsar.

        //string : Tek bir karakter, sözcük veya cümle gibi değerlerin saklanmasında kullanılır.

        //boolean : True – false değer tutan tiptir.

        //Aynı zamanda her sınıf bir veri tipidir.


        //ODEV2
        ////Ternary Operatörü
        ////İf yapısıyla yaptığımız işlemi tek satırda yapmamızı sağlayan,3 işlem alan tek operatör.
        //int a = 10;
        //string durum;
        ////durum değişkenine ternary kullanarak atama yaptık.
        ////a 5den büyük mü(?) "Evet ise bunu yaz" : "Hayır ise bunu yaz" 
        //durum = (a > 5 ? "a 5'den büyüktür" : "a 5den küçüktür");
        //Console.WriteLine(durum);



        //ODEV3
        //Switch yapısı
        //if else yapısı kullanırken kullandığımız durumların her biri casedir.
        //Çok fazla case'in olduğu durumda if else yapısına göre kullanılması daha kolay olan yapıdır.


        //int number = 20;

        //IF KULLANIMI
        //if (number > 10)
        //{
        //    Console.WriteLine("number 10'dan büyüktür");
        //}
        //else if (number < 10)
        //{
        //    Console.WriteLine("number 10'dan küçüktür");
        //}
        //else
        //{
        //    Console.WriteLine("number 10'a eşittir");
        //}

        //SWITCH-CASE KULLANIMI
        //switch (number)
        //{
        //    case > 10: Console.WriteLine("number 10'dan büyüktür");break;
        //    case < 10: Console.WriteLine("number 10'dan küçüktür");break;
        //    default:Console.WriteLine("number 10'a eşittir"); break;
        //}



        //ODEV4
        //While döngüsü
        //for gibi döngü kurmamızı sağlayan bir yapı.
        //int i = 0;
        //while (i<10) //Komut bloğunu koşul sağladığı sürece devam ettirir.
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}



        //ODEV5-Kodlama.io da bulunan kullanıcılardan birinin algoritma sorusunun cevabı

        //While döngüsü ile sıfırdan başlayan bir değişken tanımlayınız,
        //bu değişken sizin yazdığınız rakamlara göre artacak veya azalacak.
        //Yazdığınız rakam çift ise ise bu değişkene o rakamı ekletin,
        //yazdığınız rakam tek ise bu değişkeni o rakamdan çıkartın.
        //Sayı tekrar 0'a eşitlendiğinde ise döngü sona ersin.

        //int i = 0;
        //int x = 0;
        //int rakam;
        //while (x == 0)
        //{
        //    Console.Write("Bir rakam giriniz : ");
        //    rakam =Convert.ToInt32(Console.ReadLine());
        //    if (rakam % 2 == 0)
        //    {
        //        i = i + rakam;
        //        x = i;
        //        if (x == 0)
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            x = 0;
        //        }
        //    }
        //    else
        //    {
        //        i = i - rakam;
        //        x = i;
        //        if (x == 0)
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            x = 0;
        //        }
        //    }

        //}

        //ODEV6
        //Herhangi bir e - ticaret sistemine giriniz.
        //Genellikle bir e - ticaret sistemine girdiğinizde ürünler listelenir.
        //Siz de Urun(Product) isimli bir class oluşturup, oluşturduğunuz bir kaç ürünü bir diziye ekleyiniz.
        //Ürünlerinizi for, foreach ve while döngüleri ile ayrı ayrı listeleyiniz.

        //Product urun1 = new Product();
        //urun1.UrunAdi = "Pantolon";
        //urun1.Fiyat = 230;
        //urun1.Renk = "Siyah";

        //Product urun2 = new Product();
        //urun2.UrunAdi = "Kazak";
        //urun2.Fiyat = 120;
        //urun2.Renk = "Mavi";

        //Product urun3 = new Product();
        //urun3.UrunAdi = "Ayakkabı";
        //urun3.Fiyat = 280;
        //urun3.Renk = "Siyah";

        //Product[] Urunler = new Product[] { urun1,urun2,urun3 };

        //for (int i = 0; i < Urunler.Length; i++)
        //{
        //    Console.WriteLine("***********************");
        //    Console.WriteLine
        //        (
        //        "Urun Adı      :" + Urunler[i].UrunAdi + "\n" +
        //        "Urun Fiyatı   :" + Urunler[i].Fiyat + "\n" +
        //        "Urun Rengi    :" + Urunler[i].Renk
        //        );

        //}

        //foreach (var urun in Urunler)
        //{
        //    Console.WriteLine("***********************");
        //    Console.WriteLine
        //        (
        //        "Urun Adı      :" + urun.UrunAdi + "\n" +
        //        "Urun Fiyatı   :" + urun.Fiyat + "\n" +
        //        "Urun Rengi    :" + urun.Renk
        //        );
        //}


        //int i = 0;
        //while (i<Urunler.Length)
        //{
        //    Console.WriteLine("***********************");
        //    Console.WriteLine
        //        (
        //        "Urun Adı      :" + Urunler[i].UrunAdi + "\n" +
        //        "Urun Fiyatı   :" + Urunler[i].Fiyat + "\n" +
        //        "Urun Rengi    :" + Urunler[i].Renk
        //        );

        //    i++;
        //}

        //DERS3

        //ODEV2
        //Ref ve Out Keywordleri 

        //Ref Keywordü
        //int number1 = 20;
        //int number2 = 100;
        //var result = Add( number1, number2);
        //static int Add(int number1,int number2)
        //{
        //    number1 = 30;
        //    return number1 +number2;

        //}
        //Console.WriteLine(number1);
        //Sonuç 20dir
        //Çünkü biz burada değer tipler ile çalışıyoruz(int olduğu için)
        //Değer tiplerde mevzu tamamen değişkenin değeriyle ilgilidir.
        //int number1 = 20;
        //int number2 = 100;
        //var result = Add(number1, number2);
        //Burada Add metotunun parametresinde number1in değeri gidiyor parametrenin içine
        //Add fonksiyonunun içinde ise yazdığımız int number1 farklı bir değişken tanımlamış oluyoruz
        //İsimleri aynı olsa bile bunların alakası yoktur.
        //20 değerini biz Addin parametresi olan number1'e vermiş olduk
        //Yani fonksiyonun parametresiyle ilgili olan bir işlem dışardaki değişkeni değiştirmez.Çünkü aynı şey değiller.




        //Fakat dışarıda tanımlanan number1 ile fonksiyondaki parametredeki number1in aynı olmasını istiyorsak ref keywordunu kullanıyoruz
        //int number1 = 20;
        //int number2 = 100;
        //var result = Add(ref number1, number2);
        //static int Add(ref int number1, int number2)
        //{
        //    number1 = 30;
        //    return number1 + number2;

        //}
        //Console.WriteLine(number1);
        //Sonuç 30dur


        //Out Keywordü
        //Ref'in bir alternatifi de out keywordüdür.

        //int number1;//Refte burayı kesinlikle set etmiş olmamız gerekiyor ama outta böyle bi zorunluluk yok
        //int number2 = 100;
        //var result = Add(out number1, number2);
        //static int Add(out int number1, int number2)
        //{
        //    number1 = 30; //Outta da kesinlikle burada tanımlama yapılmalı yoksa hata verir.
        //    return number1 + number2;

        //}
        //Console.WriteLine(number1);


        //ODEV3
        //ClassMetotDemo isimli projede

        //DERS4

        //ODEV4
        //Dictionary Koleksiyonu
        //Normalde dizi ve arraylist elemanlarında index numarası ve değer kavramları vardır.
        //index numarası ile o indexe denk gelen değeri buluruz.
        //Ancak dictionary yapısında index,değer kavramlarının yerini key(index numarası) ve value(index numarasıyla belirtilen değer) almıştır.
        //key yani anahtar benzersiz olmak şartıyla int,string,object vb olabilir.

        //Dictionary<int,string> sehirler = new Dictionary<int, string>();

        //sehirler.Add(1, "Adana");
        //sehirler.Add(2, "Adıyaman");
        //sehirler.Add(3, "Afyon");

        //Console.WriteLine(sehirler[1]); //Adana cevap

        //foreach (var sehir in sehirler)
        //{
        //    Console.WriteLine(sehir.Key + " : " + sehir.Value);
        //}

        //ODEV5
        //MyDictionary<int, string> sözlük = new MyDictionary<int, string>();
        //sözlük.Add(1, "Adana");
        //sözlük.Add(2, "Adıyaman");
        //sözlük.Listele();

        //ODEV5
        //Solutionda MyDictionary'nin içinde başka bir yol ile kendi dictionary koleksiyonumu oluşturdum 

    }

}
//class Product
//{
//    public string UrunAdi { get; set; }
//    public double Fiyat { get; set; }
//    public string Renk { get; set; }

//}


//class MyDictionary<T, Y>
//{
//    T[] dizi1;
//    Y[] dizi2;

//    public MyDictionary()
//    {
//        dizi1 = new T[] { };
//        dizi2 = new Y[] { };

//    }
//    public void Add(T item1, Y item2)
//    {
//        T[] tempArray1 = dizi1;
//        Y[] tempArray2 = dizi2;
//        dizi1 = new T[dizi1.Length + 1];
//        dizi2 = new Y[dizi2.Length + 1];
//        for (int i = 0; i < tempArray1.Length; i++)
//        {
//            dizi1[i] = tempArray1[i];
//        }
//        for (int j = 0; j < tempArray2.Length; j++)
//        {
//            dizi2[j] = tempArray2[j];
//        }
//        dizi1[dizi1.Length - 1] = item1;
//        dizi2[dizi2.Length - 1] = item2;

//    }
//    public void Listele()
//    {
//        for (int i = 0; i < dizi1.Length; i++)
//        {
//            Console.WriteLine(dizi1[i] + " : " + dizi2[i]);
//        }
//    }
//}