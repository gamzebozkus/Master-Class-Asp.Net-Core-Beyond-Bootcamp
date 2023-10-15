using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);//->cevap 30


            int[] sayilar1=new int[] {1,2,3};
            int[] sayilar2 = new int[] { 4, 5, 6 };

            sayilar1 = sayilar2;
            sayilar2[0] = 7;
            Console.WriteLine(sayilar1[0]); //-> cevap 7

            //sayısal veri tipleri(int,decimal,float,double,bool)=değer tip denir.ama array,class,interface ise karşımıza referans tiptir.bellekte  bulunan stack ve heap yapısı içinde değer tip sadece stackte çalışır .referans tip ise önce sayilar1 stack e yazılır new leyince heap içerisine sayilar1 için bir array oluşturur [1,2,3] diye,sonra sayilar2 tanmlanınca ve newlenince heapte array içindekiler kaydedilir ve adresi tutulur daha sonra sayilar1=sayilar2 diyince aslında burada bellekteki adres için atama yapılır ve böylece sayilar2 nin adresinde ne varsa ona gider ve sayialr2 de değişiklik yapınca otomatik sayilar1 de o adresteki elemanları gösterdiği için sayilar1[0]=7 oluyor.
        }
    }
}
