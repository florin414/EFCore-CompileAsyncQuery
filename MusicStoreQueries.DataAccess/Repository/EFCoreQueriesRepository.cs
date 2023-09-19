using Microsoft.EntityFrameworkCore;
using MusicStoreQueries.Domain.Helpers;
using MusicStoreQueries.Domain.Interfaces;

namespace MusicStoreQueries.DataAccess.Repository;
public class EFCoreQueriesRepository<TEntity, TId> : IEFCoreQueriesRepository<TEntity, TId> where TEntity : class
{
    private MusicStoreQueriesContext context { get; set; }

    private static readonly Func<MusicStoreQueriesContext, TId, Task<TEntity?>> FindAsync =
        EF.CompileAsyncQuery(
            (MusicStoreQueriesContext context, TId id) => context.Set<TEntity>().Find(id));


    public EFCoreQueriesRepository(MusicStoreQueriesContext context)
    {
        this.context = Guard.ArgumentNotNull(context, nameof(context));
    }

    public async Task<TEntity?> FindAsyncQuery(TId id)
    {
        return await FindAsync(context, id);
    }
}
