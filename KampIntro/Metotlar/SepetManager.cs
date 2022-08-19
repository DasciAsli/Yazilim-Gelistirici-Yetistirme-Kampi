using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //Bir classın sonunda Manager,Dal vs gibi ifadelerin olması o classta bir operasyon olduğu anlamına gelir.
        //public void Ekle() //Ekle metotu oluşturduk
        //{
        //    Console.WriteLine("Tebrikler sepete eklendi");
        //}

        public void Ekle(Urun urun) //Parametreli bir Ekle metodu
        {
            Console.WriteLine("Tebrikler sepete eklendi : " + urun.Adi);
        }


        //Aşağıdaki şekildeki kullanım mantık açısından doğru bir kullanım değil.
        //Ekle2 metotuna başka bir parametre daha eklemek istersek,Program.csde çağırdığımız tüm ekle2 metotları eklediğimiz parametreyi barındırmadıkları için hata verirler
        //Yani program.csdeki tüm Ekle2 metotlarına yeni bir parametre eklemek gerekir.
        //Büyük çaplı projelerde ekle2 metotunun kullanıldığı her yerde gidip parametre eklemek mantıklı bi çözüm değildir.
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler sepete eklendi : " + urunAdi);

        }
    }
}
