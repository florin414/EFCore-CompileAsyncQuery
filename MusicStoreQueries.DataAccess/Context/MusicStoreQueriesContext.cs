using Microsoft.EntityFrameworkCore;
using MusicStoreQueries.Domain.Entities;

namespace MusicStoreQueries.DataAccess;
public class MusicStoreQueriesContext : DbContext
{
    public DbSet<Instrument> Instruments { get; set; }
    public MusicStoreQueriesContext(DbContextOptions<MusicStoreQueriesContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
