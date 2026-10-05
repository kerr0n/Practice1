using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DataAccessLayer
{
    internal interface IRepository
    {
        public interface IRepository<T> : IDisposable
            where T : class, IDomaneObject
        {
            void Create(T item);

            List<T> ReadAll();

            T ReadById(int id);

            void Delete(int id);

            void Update(T item);
        }
    }
}
