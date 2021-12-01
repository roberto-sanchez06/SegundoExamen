using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infraestructure
{
    public class NotaRepos : INotasRepos
    {
        private List<Nota> datos;
        public NotaRepos()
        {
            datos = new List<Nota>();
        }
        public void Add(Nota t)
        {
            datos.Add(t);
        }

        public decimal CalculoPromedioNotas(List<Nota> Nota)
        {
            decimal a = Nota.Sum(x => x.NotaFinal);
            return a / 6;
        }

        public List<Nota> FindAll()
        {
            return datos;
        }

        public int GetLastId()
        {
            return 0;
        }
    }
}
