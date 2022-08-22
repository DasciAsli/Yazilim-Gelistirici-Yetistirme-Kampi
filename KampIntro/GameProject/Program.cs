using GameProject.Concrete;
using GameProject.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person() { Id = 1, FirstName = "Ala", LastName = "Tok", NationalityId = "123456789", DateOfBirth = new DateTime(1993, 09, 20) };
        BasePersonManager basePersonManager = new GamerPersonManager(new CheckPersonManager());
        basePersonManager.Add(person);

        Game game = new Game() { Id = 1, Name = "PUBG" };
        GameManager gameManager = new GameManager();
        gameManager.Add(game);

        Campaign campaign = new Campaign() { Id = 1, Name = " %50 indirimle satın al,savaş ve kazan" };
        CampaignManager campaignManager = new CampaignManager();
        campaignManager.Add(campaign);

        SalesManager salesManager = new SalesManager();
        salesManager.Buy(person, game, campaign);

    }
}