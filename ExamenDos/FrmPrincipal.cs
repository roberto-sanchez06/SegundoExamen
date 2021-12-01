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
    public partial class FrmPrincipal : Form
    {
        private IEstudianteService estudiante;
        private INotaService NotaService;
        public FrmPrincipal(IEstudianteService estudiante, INotaService notaService)
        {
            this.NotaService = notaService;
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
            frm.Nota = NotaService;
            frm.ShowDialog();
            dataGridView1.DataSource = estudiante.FindAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n >= 0)
            {
                int id = (int)dataGridView1.Rows[n].Cells[0].Value;
                Estudiante est = estudiante.GetEstudianteById(id);
                if (est == null)
                {
                    return;
                }
                FrmVisualizarEstudiante frm = new FrmVisualizarEstudiante();
                frm.notas = est.Notas;
                frm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = estudiante.MejoresPromedios(estudiante.FindAll());
        }
    }
}
