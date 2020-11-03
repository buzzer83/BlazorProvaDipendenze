using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProvaDipendenze.Data
{
    public class ScopedService : IScopedServie
    {

        public Guid ServiceId { get; set; }
        public IConnService DbSing { get; }

        public ScopedService(IConnService dbSing)
        {
            Console.WriteLine("scoped 1");
            DbSing = dbSing ?? throw new ArgumentNullException(nameof(dbSing));
            ServiceId = DbSing.ServiceId;
        }
    }
}
