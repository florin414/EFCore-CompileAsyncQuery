namespace MusicStoreQueries.Domain.Interfaces;

public interface IEFCoreQueriesRepository<TEntity, TId> where TEntity : class
{
    Task<TEntity?> FindAsyncQuery(TId id);
}