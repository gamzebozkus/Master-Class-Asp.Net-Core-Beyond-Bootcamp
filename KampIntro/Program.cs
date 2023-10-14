using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not your self
            string kategoriEtiketi = "kategori"; //değer tutucu,alias
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
