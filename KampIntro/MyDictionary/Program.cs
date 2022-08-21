using MyDictionary;

internal class Program
{
    private static void Main(string[] args)
    {
        DictionaryManager<int,string> dm = new DictionaryManager<int, string>();
        dm.Add(1,"Adana");
        dm.Add(2,"Adıyaman");
        dm.Add(3,"Afyon");
        dm.Add(4,"Ağrı");
        dm.Listele();
    }
}