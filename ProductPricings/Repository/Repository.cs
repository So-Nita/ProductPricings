using System;
using ProductPricings.DataConfiguration;
using ProductPricings.Model.Product;

namespace ProductPricings.Repository;

public class Repository<TE> where TE : class
{
    private readonly ProductContext _context;
    public Repository(ProductContext context)
    {
        _context = context;
    }

    public IQueryable<TE>? GetAll()
    {
        return _context.Set<TE>().AsQueryable();
    }

    public TE? GetById(string id)
    {
        return _context.Set<TE>().Find(id);
    }

    public void Add(TE entity)
    {
        _context.Set<TE>().Add(entity);
    }
    public void AddRange(IEnumerable<TE> entities)
    {
        _context.Set<TE>().AddRange(entities);
    }
    public void Update(TE entity)
    {
        _context.Set<TE>().Update(entity);
    }
    public void Delete(TE entity)
    {
        _context.Set<TE>().Remove(entity);
    }
    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}


