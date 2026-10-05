using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DataAccessLayer
{
    public interface IRepository<T> : IDisposable
        where T : class, IDomainObject
    {
        void Create(T item);

        IEnumerable<T> ReadAll();

        T? ReadById(int id);

        void Delete(int id);

        void Update(T item);
    }
}
