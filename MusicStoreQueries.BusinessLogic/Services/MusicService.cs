using MusicStoreQueries.Domain.Entities;
using MusicStoreQueries.Domain.Helpers;
using MusicStoreQueries.Domain.Interfaces;

namespace MusicStoreQueries.BusinessLogic.Services;
public class MusicService
{
    private readonly IEFCoreQueriesRepository<Instrument, int> instrumentRepository;

    public MusicService(IEFCoreQueriesRepository<Instrument, int> instrumentRepository)
    {
        this.instrumentRepository = Guard.ArgumentNotNull(instrumentRepository, nameof(instrumentRepository));
    }

    public async Task<Instrument?> GetAvailableMusicInstrument(int id)
    {
       return await this.instrumentRepository.FindAsyncQuery(id); 
    }

}
