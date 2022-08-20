using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] isimler = new string[] {"Engin","Murat","Kerem","Halil"};
        //Console.WriteLine(isimler[0]);
        //Console.WriteLine(isimler[1]);
        //Console.WriteLine(isimler[2]);
        //Console.WriteLine(isimler[3]);

        //Dizilere sonradan eleman ekleyemediğimiz için koleksiyonları kullanıyoruz.

        //List<string> isimler2 = new List<string>();
        //isimler2.Add("Engin");

        //ya da

        List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
        Console.WriteLine(isimler2[0]);
        Console.WriteLine(isimler2[1]);
        Console.WriteLine(isimler2[2]);
        Console.WriteLine(isimler2[3]);
        isimler2.Add("İlker");
        Console.WriteLine(isimler2[4]); 

    }
}