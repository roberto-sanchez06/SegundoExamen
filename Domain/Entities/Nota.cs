using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Nota
    {
        public Asignatura Asignatura { get; set; }
        public Estudiante Estudiante { get; set; }
        public int SIstematico { get; set; }
        public int PrimerParcial { get; set; }
        public int SegundoParcial { get; set; }
        public int NotaFinal => SIstematico + PrimerParcial + SegundoParcial;
    }
}
