using OOP1;

internal class Program
{
    private static void Main(string[] args)
    {
        //TERİMLER
        //CRUD OPERASYONLARI :Create,Read,Update,Delete işlemleri
        //Case Sensitive :Küçük büyük harf duyarlılığı

        //KONU ANLATIMI
        Product product1 = new Product();
        product1.Id = 1;
        product1.CategoryId = 2;
        product1.ProductName = "Masa";
        product1.UnitPrice = 500;
        product1.UnitsInStock = 3;


        Product product2 = new Product{Id=2,CategoryId=5,ProductName= "Dolap",UnitPrice= 600,UnitsInStock= 2 };

        ProductManager productManager = new ProductManager();
        productManager.Add(product1);

        int toplamSonucu = productManager.Topla(10, 15);
        Console.WriteLine(toplamSonucu*2);
        
    }
}