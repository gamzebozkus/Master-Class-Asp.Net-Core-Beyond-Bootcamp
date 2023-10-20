using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //eğerki bir başka sınıf bu interface i kullanmak isterse içindeki tüm methodları içermek zorunda
    interface IKrediManager
    {
       void Hesapla();
       void BiseyYap();
    }
}
