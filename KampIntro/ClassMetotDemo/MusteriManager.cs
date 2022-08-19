using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler musteri eklendi" + musteri.Ad);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi" + musteri.Ad);
        }
        public void MusteriListele(Musteri[] musterilistesi)
        {
            foreach (var musteri in musterilistesi)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
            }
        }
    }
}
