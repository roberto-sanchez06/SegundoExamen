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
        public FrmEstudiante()
        {
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
