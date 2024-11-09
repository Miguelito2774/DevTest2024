using api.Domain.Entities;

namespace api.Application.Repositories;

public interface IRepository<TEntity> where TEntity: IEntity
{
    Task<string> Create(TEntity entity);
    Task<IList<TEntity>> GetAll();
}
