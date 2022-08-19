using Metotlar;

internal class Program
{
    private static void Main(string[] args)
    {
        //TERİMLER
        //Clean Code :Temiz kod yazma tekniği
        //Best Practice :Doğru uygulama tekniği
        //Convention : Yazılım kuralı.PascalCase bunlardan biridir
        //PascalCase : İsimlerndirme yaparken her kelimenin baş harfini büyük yazmak
        //Syntax : Yazım şekilleri
        //Instance : Class örneği oluşturmak
        //Encapsulation : Kapsülleme



        //KONU ANLATIMI
        Urun urun1 = new Urun(); //Instance oluşturduk
        urun1.Adi = "Elma";
        urun1.Fiyati = 15 ;
        urun1.Aciklama ="Amasya Elması";

        Urun urun2 = new Urun(); //Instance oluşturduk
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 80 ;
        urun2.Aciklama = "Diyarbakır Karpuzu";

        Urun[] urunler = new Urun[]
        {
            urun1,
            urun2
        };

        //!!!
        //normal bir foreach döngüsünde
        //int[] sayilar = new int[] { 10, 15, 20 };
        //foreach (int sayi in sayilar)//sayilar dizisinden integer tipindeki her bir sayiyi getir demek.
        //{
        //    Console.WriteLine(sayi);
        //}

        foreach (Urun urun in urunler) //urunler dizisinden Urun tipindeki her bir urunu getir demek istedik.type safe yani veri güvenliği için var yerine Urun yazmak daha doğru
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            
        }


        Console.WriteLine("----------------METOTLAR----------------");

        SepetManager sepetManager = new SepetManager(); //Instance oluşturduk
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);
        sepetManager.Ekle2("Armut", "Yeşil armut", 12);
        
    }
}