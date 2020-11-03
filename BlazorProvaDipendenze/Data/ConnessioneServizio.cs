using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProvaDipendenze.Data
{
    public class ConnessioneServizio : IConnessioneServizio
    {
        public Guid ServiceId { get; set; }

        public ConnessioneServizio()
        {
            Console.WriteLine("singleton");
            ServiceId = Guid.NewGuid();
        }
    }
}
