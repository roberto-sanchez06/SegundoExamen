using AppCore.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDos
{
    public partial class FrmEstudiante : Form
    {
        public IEstudianteService estudianteService { get; set; }
        private List<Asignatura> asignaturas;
        private int contador = 0;
        public FrmEstudiante()
        {
            asignaturas = new List<Asignatura>()
            {
                new Asignatura(){ Id=1, Nombre="Matematica2", Credito=2},
                new Asignatura(){ Id=2, Nombre="ContabiidadDeCostos", Credito=2},
                new Asignatura(){ Id=3, Nombre="AlgebraLineal", Credito=2},
                new Asignatura(){ Id=4, Nombre="Sociologia", Credito=2},
                new Asignatura(){ Id=5, Nombre="Ingles2", Credito=2},
                new Asignatura(){ Id=6, Nombre="Programacion1", Credito=2},

            };
            InitializeComponent();
        }

        private void RegistrarAsignatura_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante()
            {
                Id = estudianteService.GetLastId(),
                Nombre=txtApellidos.Text,
                Apellidos=txtApellidos.Text,
                Carnet=txtCarnet.Text,
                Municipio=txtMunicipio.Text,
                Departamento=txtDepartamento.Text,
            };
        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
