using System;
using System.Collections.Generic;
using System.Text;

namespace BankSimulation
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("veritabanına loglandı");
        }
    }
}
