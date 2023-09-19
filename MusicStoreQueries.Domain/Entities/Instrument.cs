using MusicStoreQueries.Domain.Enums;

namespace MusicStoreQueries.Domain.Entities;
public class Instrument
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public InstrumentType Type { get; set; }
}
