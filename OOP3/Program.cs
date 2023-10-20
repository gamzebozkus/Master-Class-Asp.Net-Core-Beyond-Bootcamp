using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IhtıyacKrediManager ihtiyacKrediManager=new IhtıyacKrediManager();
          

            TasitKrediManager tasitKrediManager= new TasitKrediManager();

            //hem interfaceden üretilebilir hem de sınıftan üretilebilir!!

            IKrediManager konutKrediManager = new KonutKrediManager();
           // KonutKrediManager konutKrediManager = new KonutKrediManager();
            
            ILoggerService databaseLoggerService = new DatabaseLoggerServices();
            ILoggerService fileLoggerService = new FileLoggerServices();    

            BasvuruManager basvuruManager= new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,databaseLoggerService);
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),new SmsLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
          //  basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
