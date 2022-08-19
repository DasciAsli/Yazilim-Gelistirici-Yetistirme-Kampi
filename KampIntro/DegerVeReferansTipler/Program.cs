internal class Program
{
    private static void Main(string[] args)
    {

        //!!!Bu konu çok önemli bir konu


        //TERİMLER
        //Pointer(Gösterici) : değişkenlerin ve nesnelerin bellekteki adreslerini tutan değişken tipleridir.
        //Garbage collector (Çöp Toplayıcısı)


        //KONU ANLATIMI
        //int sayi1 = 10;
        //int sayi2 = 30;
        //sayi1 = sayi2;
        //sayi2 = 65;
        ////sayi1 ?? 


        //int[] sayilar1 = new int[] { 10, 20, 30 };
        //int[] sayilar2 = new int[] { 100, 200, 300 };
        //sayilar1 = sayilar2;
        //sayilar2[0] = 999;
        ////sayilar1[0] ?? 


        //Sayısal veri tipleri int,decimal,float,double,bool bunlar değer tip
        //array,class,interface.. bunlar ise referans tip
        //Bellekte stack ve heap diye 2 adet alan var.Değer tipli olanlar stackde gerçekleşiyor.

        //DEĞER TİP
        int sayi1 = 10;
        int sayi2 = 30;
        sayi1 = sayi2;
        sayi2 = 65;
        //sayi1 ?? 
        //STACK                                       //HEAP
        //sayi1=10(sayi1=sayi2 ile sayi1 =30 oldu)
        //sayi2=30(sayi2 = 65 ile sayi2 = 65 oldu)


        //REFERANS TİP
        //int[] sayilar1 = new int[] { 10, 20, 30 };
        //Referans tipte ise (örneğin yukarıda bir array tanımlanmış bu array üzerinden anlatılırsa)
        //Stackde sayilar1 isimli bir değişken tanımlamış olduk.
        //new dediğimiz anda sayilar1 için heapde bir alan oluşturmuş olduk
        //STACK          //HEAP
        //sayilar1 ------>//[10,20,30](Referans Numarası :101)
        //Yani sayilar1'in karşılığı bellekte heapdeki adreste tutuluyor

        int[] sayilar1 = new int[] { 10, 20, 30 };
        int[] sayilar2 = new int[] { 100, 200, 300 };
        sayilar1 = sayilar2;
        sayilar2[0] = 999;
        //sayilar1[0] ??  


        //STACK          //HEAP
        //sayilar1 ------>//[10,20,30] (Referans Numarası :101)
        //sayilar2 ------>//[100,200,300](Referans Numarası : 102)


        //sayilar1 = sayilar2 demekle biz sadece sayilar1in referans numarası,sayilar2nin referans numarasına eşittir demiş olduk
        //STACK          //HEAP
        //(101 iken 102 oldu)sayilar1 ------>//Aşağıdakini gösteriyor artık
        //(102)sayilar2 ------>//[100,200,300](Referans Numarası : 102)


        // sayilar2[0] = 999;
        //STACK          //HEAP
        //(101 iken 102 oldu)sayilar1 ------>//Aşağıdakini tutuyor artık
        //(102)sayilar2 ------>//[999,200,300](Referans Numarası : 102)
        

        //sayilar1 değişkeni de artık 102 referans numaralı yeri gösterdiği için
        //sayilar1[0]=999 olur.

        //Bu örnekte heapteki 101 numaralı alan artık boşta kalıyor onu gösteren bir değişken olmadığı için
        //Garbage collector seni tutan kimse yok der ve bellekten siler bir zaman sonra





    }
}