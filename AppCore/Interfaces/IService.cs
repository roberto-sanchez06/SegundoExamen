using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IService<T>
    {
        void Add(T t);
        List<T> FindAll();
        int GetLastId();
    }
}
