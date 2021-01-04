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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnFrmAgregarEstudiantes_Click(object sender, EventArgs e)
        {
            FrmAgregarEstudiantes x = new FrmAgregarEstudiantes();
            x.ShowDialog();
        }

        private void btnFrmListadoEstudiante_Click(object sender, EventArgs e)
        {
            FrmListadoEstudiante x = new FrmListadoEstudiante();
            x.ShowDialog();
        }

        private void btnFrmBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscar x = new FrmBuscar();
            x.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
