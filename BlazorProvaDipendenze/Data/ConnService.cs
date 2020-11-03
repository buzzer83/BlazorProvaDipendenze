using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProvaDipendenze.Data
{
    public class ConnService : IConnService
    {
        public Guid ServiceId { get; set; }

        public ConnService()
        {
            Console.WriteLine("singleton");
            ServiceId = Guid.NewGuid();
        }
    }
}
