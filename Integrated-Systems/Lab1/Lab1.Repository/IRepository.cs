using Lab1.Domain;

namespace Lab1.Repository;

public interface IRepository<T> where T : BaseEntity
{
    IEnumerable<T> GetAll();
    T Get(Guid? id);
    T Insert(T entity);
    T Update(T entity);
    T Delete(T entity);
}