using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public abstract class BasePersonManager : IPersonService
    {
        public virtual void Add(Person person)
        {
            Console.WriteLine(person.FirstName + " adlı kullanıcı eklendi");
        }
        public void Delete(Person person)
        {
            Console.WriteLine(person.FirstName + " adlı kullanıcı silindi");
        }
        public void Update(Person person)
        {
            Console.WriteLine(person.FirstName + " adlı kullanıcı güncellendi");
        }
    }
}
