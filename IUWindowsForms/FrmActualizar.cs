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
    public partial class FrmActualizar : Form
    {
        private String mCedula;

        public FrmActualizar(String cedula)
        {
            InitializeComponent();
            //el parametro cedula se recibe como parametro
            //en el constructor de la clase
            this.mCedula = cedula;
        }

        private void FrmActualizar_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("La cedula es: " + this.mCedula);
            this.txtCedula.Text = mCedula;
            CapaDatos.Persona persona = new CapaDatos.Persona();

            persona = CapaDatos.PersonaDAO.GetPersona(mCedula);
            this.txtApellidos.Text = persona.Apellidos;
            this.txtNombres.Text = persona.Nombres;
            this.cmbSexo.Text = persona.Sexo;
            this.dtFechaNacimiento.Value = persona.FEchaNacimiento;
            this.txtCorreo.Text = persona.Correo;
            this.txtEstatura.Text = persona.Estatura.ToString();
            this.txtPeso.Text = persona.Peso.ToString();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            if(this.mCedula.Length > 0)
            {
                CapaDatos.Persona persona = new CapaDatos.Persona();

                persona.Cedula = mCedula;
                persona.Apellidos = this.txtApellidos.Text;
                persona.Nombres = this.txtNombres.Text;
                persona.Correo = this.txtCorreo.Text;
                persona.Sexo = this.cmbSexo.Text;
                persona.Estatura = int.Parse(this.txtEstatura.Text);
                persona.Peso = Decimal.Parse(this.txtPeso.Text);
                persona.FEchaNacimiento = dtFechaNacimiento.Value;
                
                int x= CapaDatos.PersonaDAO.actualizar(persona);

                if (x > 0)
                    MessageBox.Show("Registro actualizado..");
                
                else
                    MessageBox.Show("No se pudo actualizar el registro");
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
