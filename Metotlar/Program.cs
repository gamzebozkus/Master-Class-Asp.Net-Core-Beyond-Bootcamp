using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();//product sınıfından örnek oluşturuyoruz
            product.Adi = "Elma";
            product.Fiyati = 15;
            product.Aciklama = "Amasya elması";

            Product product1 = new Product();
            product1.Adi = "Karpuz";
            product1.Fiyati = 25;
            product1.Aciklama = "Diyarbakır karpuzu";

            //ENCAPSULATION:Eğerki bir product nesnesine yeniden bir ekleme yapacaksak bunu product sınıfında tek bir kere yaparız ve aşağıdaki satırda yeni eklenen özellik için bizden ekstra bir işlem yapmamızı istemez
            Product[] urunler=new Product[] { product, product1 };
            foreach(Product p in urunler)
            {
                Console.WriteLine(p.Adi); 
                Console.WriteLine(p.Aciklama); 
                Console.WriteLine(p.Fiyati); 
            }

            Console.WriteLine("-------Metotlar-------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product);

            sepetManager.Ekle2("Armut","yeşil armut",12);
            sepetManager.Ekle2("Armut","yeşil armut",12);
            sepetManager.Ekle2("Armut","yeşil armut",12);
        }
    }
}
