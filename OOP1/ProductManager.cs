using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }

        //program.cs de topla metodu üzerinden işlemler yapılamaz returnde ne döndüyse onu verir bu yüzden metot oluştururken public void kullanırız.
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1+ sayi2;
        }

        //program.cs de topla2 üzerinden işlemler yapılabilir
         public void Topla2(int sayi1,int sayi2)
        {
           Console.WriteLine(sayi2 + sayi1);
        }
    }
}
