using System;

namespace OOP3
{
    internal class FileLoggerServices : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
