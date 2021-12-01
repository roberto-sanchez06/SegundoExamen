﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Carnet { get; set; }
        public string Municipio { get; set; }
        public string Departamento { get; set; }
        public List<Nota> Notas { get; set; }
        public decimal Promedio { get; set; }
    }
}
