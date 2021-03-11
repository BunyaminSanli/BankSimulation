using System;

namespace BankSimulation
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("dosyaya loglandı");
        }
    }
}
