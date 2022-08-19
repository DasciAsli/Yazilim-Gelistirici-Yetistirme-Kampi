using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslemManager
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuc : " + toplam);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int fark = sayi1 + sayi2;
            Console.WriteLine("Sonuc : " + fark);
            
        }
        public void Carp(int sayi1, int sayi2)
        {
            int carpim = sayi1 * sayi2;
            Console.WriteLine("Sonuc : " + carpim);
        }
        public void Böl(int sayi1, int sayi2)
        {
            int bölüm = sayi1 / sayi2;
            Console.WriteLine("Sonuc : " + bölüm);
        }
    }
}
