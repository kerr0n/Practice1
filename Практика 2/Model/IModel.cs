using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public delegate void DataChangedDelegate(IEnumerable<IEnumerable<object>> newData);
    public interface IModel<T> where T : class
    {
        event DataChangedDelegate DataChanged;
        void Delete(int index);
        void Insert(T item); 
    }
}
