using CapaService.Types;

namespace CapaService.Behaviors
{
    public interface ICommonOperationEntity1<TEntity> where TEntity : class
    {
        TEntity Delete(TEntity entity);
        TEntity Get(TEntity entity);
        PagedListResult<TEntity> GetAll(TEntity entity = null, Paginate paginate = null);
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
    }
}