using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IPersonService
    {
        void Add(Person person);
        void Update(Person person);
        void Delete(Person person);
    }
}
