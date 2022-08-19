using ClassMetotDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Musteri musteri1 = new Musteri();
        musteri1.Ad = "Ayşe";
        musteri1.Soyad = "Kara";

        Musteri musteri2 = new Musteri();
        musteri2.Ad = "Fatma";
        musteri2.Soyad = "Yıldız";

        Musteri musteri3 = new Musteri();
        musteri3.Ad = "Ali";
        musteri3.Soyad = "Duran";

        Musteri[] musteriler= new Musteri[] { musteri1, musteri2, musteri3 };

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.MusteriListele(musteriler);

    }
}