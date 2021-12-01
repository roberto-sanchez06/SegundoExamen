using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface INotaService : IService<Nota>
    {
        decimal CalculoPromedioNotas(List<Nota> Nota);
    }
}
