using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IModel<T> 
    {
        void Add(T t);
        List<T> FindAll();
        int GetLastId();
    }
}
