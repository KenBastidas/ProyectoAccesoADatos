using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUWindowsForms.Informes
{
    public partial class FrmInformeEstudiantes : Form
    {
        public FrmInformeEstudiantes()
        {
            InitializeComponent();
        }

        private void FrmInformeEstudiantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsEstudiantes.Personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.dsEstudiantes.Personas);

            this.reportViewer1.RefreshReport();
        }
    }
}
