using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infraestructure
{
    public class EstudianteRepos : IEstudianteRepos
    {
        private List<Estudiante> datos;
        public EstudianteRepos()
        {
            datos = new List<Estudiante>();
        }
        public void Add(Estudiante t)
        {
            if (t is null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            datos.Add(t);
        }

        public List<Estudiante> FindAll(Predicate<Estudiante> predicate)
        {
            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            return datos.FindAll(predicate);
        }

        public List<Estudiante> FindAll()
        {
            return datos;
        }

        public int GetLastId()
        {
            return datos.Count == 0 ? 0 : datos.Last().Id;
        }
        public List<Estudiante> MejoresPromedios()
        {

        }
    }
}
