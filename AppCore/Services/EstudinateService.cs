using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace AppCore.Services
{
    public class EstudinateService : IEstudianteService
    {
        private IEstudianteRepos claseRepository;

        public EstudinateService(IEstudianteRepos claseRepository)
        {
            this.claseRepository = claseRepository;
        }

        public void Add(Estudiante t)
        {
            claseRepository.Add(t);
        }

        public List<Estudiante> FindAll(Predicate<Estudiante> predicate)
        {
            return claseRepository.FindAll(predicate);
        }

        public List<Estudiante> FindAll()
        {
            return claseRepository.FindAll();
        }

        public int GetLastId()
        {
            return claseRepository.GetLastId();
        }
    }
}
