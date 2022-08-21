using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {

        //Method Injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //

            //Bu şekilde tüm başvuruları konut kredisine bağımlı hale getirmiş olursun .O yüzden bu kullanım doğru değil
            //KonutKrediManager konutKrediManager= new KonutKrediManager();
            //konutKrediManager.Hesapla();



            //interface olan IKrediManager tüm kredileri referans edebildiği için parametre olarak bunu kullandık
            krediManager.Hesapla();
            loggerService.Log();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
