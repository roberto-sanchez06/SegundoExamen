using AppCore.Interfaces;
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
    public partial class FrmPrincipal : Form
    {
        private IEstudianteService estudiante;
        public FrmPrincipal(IEstudianteService estudiante)
        {
            this.estudiante= estudiante;
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            FrmEstudiante frm = new FrmEstudiante();
            frm.estudianteService = estudiante;
            frm.ShowDialog();
            dataGridView1.DataSource = estudiante.FindAll();
        }
    }
}
