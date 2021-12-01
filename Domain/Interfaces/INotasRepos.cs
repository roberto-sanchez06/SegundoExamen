using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface INotasRepos : IModel<Nota>
    {
        decimal CalculoPromedioNotas(List<Nota> Nota);
    }
}
