using System;

namespace BlazorProvaDipendenze.Data
{
    public interface IScopedServie
    {
        IConnService DbSing { get; }
        Guid ServiceId { get; set; }
    }
}