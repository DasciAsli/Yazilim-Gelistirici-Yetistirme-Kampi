using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Genellikle operasyonel metotlarda interface kullanılır
    interface IKrediManager //Interface şablon görevi görmekte.Okunurluğu artırmak için I harfi ile başlatılır
    {
        void Hesapla();
        void BiseyYap();
    }
}
