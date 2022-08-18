internal class Program
{
    private static void Main(string[] args)
    {
        //TERİMLER
        //Snippet : Sık kullanılan kod parçacıklarının kısa yollara bağlanması ve kolay bir şekilde çağrılabilmesi
        //Property : Özellik demek.prop snippet'ı ile kulanılabilir.
        //Comment Line :Yorum satırı


        //KONU ANLATIMI

        //Kurs classından 3 adet nesne oluşturalım
        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engin Demirog";
        kurs1.IzlenmeOrani = 68;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Kerem Varış";
        kurs2.IzlenmeOrani = 64;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Berkay Bilgin";
        kurs3.IzlenmeOrani = 80;

        //Kurs tipinde kurslar adında bir array tanımlayalım
        //Yukarıda tanımladığımız kurs1,kurs2 ve kurs3 nesneleri ile arrayimizi dolduralım

        Kurs[] kurslar = new Kurs[]
        {
            kurs1,
            kurs2,
            kurs3
            
        };

        //kurslar arrayindeki verileri konsola yazdıralım
        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen + " " + kurs.IzlenmeOrani);

        }


    }
}

class Kurs
{
    //Propertyler
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }

}