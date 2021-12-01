using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class NotaService : INotaService
    {
        private INotasRepos claseRepository;

        public NotaService(INotasRepos claseRepository)
        {
            this.claseRepository = claseRepository;
        }

        public void Add(Nota t)
        {
            claseRepository.Add(t);
        }

        public decimal CalculoPromedioNotas(List<Nota> Nota)
        {
            return claseRepository.CalculoPromedioNotas(Nota);
        }

        public List<Nota> FindAll()
        {
            return claseRepository.FindAll();
        }

        public int GetLastId()
        {
            return claseRepository.GetLastId();
        }

        public void Limpiar()
        {
            claseRepository.Limpiar();
        }
    }
}
