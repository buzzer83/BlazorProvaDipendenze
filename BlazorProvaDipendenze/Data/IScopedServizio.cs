using System;

namespace BlazorProvaDipendenze.Data
{
    public interface IScopedServizio
    {
        IConnessioneServizio DbSing { get; }
        Guid ServiceId { get; set; }
    }
}