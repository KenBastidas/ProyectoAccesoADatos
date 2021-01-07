using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUWindowsForms
{
    public partial class FrmListadoEstudiante : Form
    {
        public FrmListadoEstudiante()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
        }

        private void cargarGrid()
        {
            this.dataGridViewEstudiantes.DataSource = CapaDatos.PersonaDAO.getAll();
        }

        private void dataGridViewEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificar si se hizo clic en el link eliminar
            if(this.dataGridViewEstudiantes.Columns[e.ColumnIndex].Name=="linkEliminar")
            {
                //MessageBox.Show("clic Eliminar");
                //recuperar la cedula de la fila actual
                int fila = e.RowIndex;
                String cedula = dataGridViewEstudiantes["Cédula", fila].Value.ToString();
                String estudiante = dataGridViewEstudiantes["Estudiante", fila].Value.ToString();
                //MessageBox.Show("cedula actual: " + cedula);

                

                DialogResult dr = MessageBox.Show("Esta seguro que desea eliminar al estudiante " + estudiante + "?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;// ABANDONDAR
                }

                int x = CapaDatos.PersonaDAO.eliminar(cedula);
                
                if (x > 0)
                {
                    this.cargarGrid();
                    MessageBox.Show("Registro borrado con exito!!");
                }
                else
                {
                    MessageBox.Show("No se pudo borrar el registro");
                }
            }
            else if (this.dataGridViewEstudiantes.Columns[e.ColumnIndex].Name == "linkActualizar")
            {
                // MessageBox.Show("clic actualizar");
                int fila = e.RowIndex;
                String cedula = dataGridViewEstudiantes["Cédula", fila].Value.ToString();

                //open formulario actualizar
                FrmActualizar frm1 = new FrmActualizar(cedula);
                frm1.ShowDialog();

            }
        }
    }
}
