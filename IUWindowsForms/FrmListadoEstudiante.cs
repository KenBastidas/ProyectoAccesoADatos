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
            this.dataGridViewEstudiantes.DataSource = CapaDatos.PersonaDAO.getAll();
        }
    }
}
