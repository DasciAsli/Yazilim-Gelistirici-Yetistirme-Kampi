using OOP2;

internal class Program
{
    private static void Main(string[] args)
    {
        //TERİMLER
        //Bug Free:Hatasız bir kodlama
        //SOLID :Yazılım geliştirme prensipleri
        //Implemantation :Uygulama
        //Inheritance : Kalıtım
        //Base Class :Temel Sınıf
        //Polymorphism : Çok biçimlilik

        //KONU ANLATIMI

        //Engin Demiroğ
        GercekMusteri musteri1 = new GercekMusteri();
        musteri1.MusteriNo = "12345";
        musteri1.Adi = "Engin";
        musteri1.Soyadi = "Demiroğ";
        musteri1.TcNo = "1234567891";
        musteri1.Id = 1;

        //Kodlama.io
        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.Id = 2;
        musteri2.MusteriNo = "12346";
        musteri2.SirketAdi = "Kodlama.io";
        musteri2.VergiNo = "1234567890";


        //Gerçek müşteri - Tüzel müşteri
        //Bunların ikisi de müşteri ama bunlar farklı müşteri tipleri.
        //O yüzden birbirleri yerine kullanılamazlar

        Musteri musteri3 = new GercekMusteri();
        Musteri musteri4 = new TuzelMusteri();

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Ekle(musteri1);
        musteriManager.Ekle(musteri2);


    }
}