using EShop.Data;
using Lab1.Domain;
using Microsoft.EntityFrameworkCore;

namespace Lab1.Repository;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly ApplicationDbContext _context;
    private DbSet<T> entities;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
        entities = _context.Set<T>();
    }

    public T Delete(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException("entity");
        }
        entities.Remove(entity);
        _context.SaveChanges();

        return entity;
    }

    public T Get(Guid? id)
    {
        if (id == null)
        {
            throw new ArgumentNullException("id");
        }
        return entities.FirstOrDefault(z => z.Id == id);
    }

    public IEnumerable<T> GetAll()
    {
        return entities.AsEnumerable();
    }

    public T Insert(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException("entity");
        }
        entities.Add(entity);
        _context.SaveChanges();

        return entity;
    }

    public T Update(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException("entity");
        }
        entities.Update(entity);
        _context.SaveChanges();
        return entity;
    }
}