using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Buy(Person person, Game game, Campaign campaign)
        {
            Console.WriteLine(person.FirstName + " " + game.Name + " oyununu" + (campaign.Name).ToUpper() + " kampanyası ile satın aldınız");
        }
    }
}
