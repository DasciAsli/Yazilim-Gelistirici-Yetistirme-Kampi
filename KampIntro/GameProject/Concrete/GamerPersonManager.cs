using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerPersonManager:BasePersonManager
    {
        ICheckPersonService _checkPersonService;
        public GamerPersonManager(ICheckPersonService checkPersonService)
        {
            _checkPersonService = checkPersonService;
        }

        public override void Add(Person person)
        {
            if (_checkPersonService.CheckIfRealPerson(person))
            {
                base.Add(person);
            }
            else
            {
                Console.WriteLine("Girilen bilgiler ile geçerli bir kullanıcı bulunamadı.Kayıt başarısız");
            }
            
        }
    }
}
