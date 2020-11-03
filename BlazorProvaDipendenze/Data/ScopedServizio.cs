using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProvaDipendenze.Data
{
    public class ScopedServizio : IScopedServizio
    {

        public Guid ServiceId { get; set; }
        public IConnessioneServizio DbSing { get; }

        public ScopedServizio(IConnessioneServizio dbSing)
        {
            Console.WriteLine("cotruttore");
            DbSing = dbSing ?? throw new ArgumentNullException(nameof(dbSing));
            Leggo();
        }
        private void Leggo()
        {
            Console.WriteLine("leggo");
            ServiceId = DbSing.ServiceId;
        }
    }
}
