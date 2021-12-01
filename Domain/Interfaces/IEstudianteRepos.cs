using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IEstudianteRepos: IModel<Estudiante>
    {
        List<Estudiante> FindAll(Predicate<Estudiante> predicate);
        Estudiante GetEstudianteById(int id);
        List<Estudiante> MejoresPromedios(List<Estudiante> estudiante);
    }
}
