using System;

namespace BlazorProvaDipendenze.Data
{
    public interface IConnessioneServizio
    {
        Guid ServiceId { get; set; }
    }
}