using OOP3;

internal class Program
{
    private static void Main(string[] args)
    {
        //TERİMLER
        //Interface :Şablon görevi görür.
        //Bir interface kullanılırsa içindeki metotları içermek zorundadır
        //Dependency Injection : Bir sınıfın/nesnenin bağımlılıklarından kurtulmasını amaçlayan programlama tekniği
    
        
        
        //KONU ANLATIMI
        //Interfaceler de o interface'i implemente eden classın referans numarasını tutabilir.
        //Interfaceler şablon ve referans tutucu görevi görür.
        //Birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
        //Bu yaptığımız örnekte kredi türlerinin hepsinde hesaplama vardır.
        //Ancak kodları farklıdır.Kredinin türüne göre hesaplama işlemi farklılık gösterir.
        //Reverse Engineering :Tersine mühendislik
         
        IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
        IKrediManager tasitKrediManager = new TasitKrediManager();
        IKrediManager konutKrediManager = new KonutKrediManager();

        ILoggerService databaseloggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();


        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(ıhtiyacKrediManager,databaseloggerService);

        List<IKrediManager> krediler = new List<IKrediManager>() { };
        krediler.Add(ıhtiyacKrediManager);
        krediler.Add(tasitKrediManager);
        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        

    }
}