using System;
using System.Collections.Generic;
using System.Text;
using Model;    
namespace DataAccessLayer
{
    public class EntityFrameworkRepository<T> : IRepository<T> where T : class, IDomainObject, new()
    {
        public Context context;
        public EntityFrameworkRepository(Context context)
        {
            this.context = context;
        }
        public IEnumerable<T> ReadAll()
        {
            return context.Set<T>();
        }
        public T? ReadById(int id)
        {
            return context.Set<T>().Find(id);
        }
        public void Create(T item)
        {
            context.Set<T>().Add(item);
            context.SaveChanges();
        }
        public void Update(T item)
        {
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var item = ReadById(id);
            if (item != null)
            {
                context.Set<T>().Remove(item);
                context.SaveChanges();
            }
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
