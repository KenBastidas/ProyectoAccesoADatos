using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IUWindowsForms
{
    public partial class FrmAgregarEstudiantes : Form
    {
        public FrmAgregarEstudiantes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                CapaDatos.Persona persona = new CapaDatos.Persona();
                persona.Cedula = this.txtCedula.Text;
                persona.Apellidos = this.txtApellidos.Text;
                persona.Nombres = this.txtNombres.Text;
                persona.Sexo = this.cmbSexo.Text;
                persona.FEchaNacimiento = this.dtFechaNacimiento.Value;
                persona.Correo = this.txtCorreo.Text;
                persona.Estatura = int.Parse(this.txtEstatura.Text);
                persona.Peso = Decimal.Parse(this.txtPeso.Text);

                int x = CapaDatos.PersonaDAO.crear(persona);
                if (x > 0)
                    MessageBox.Show("Registro agregado con exito...");
                else
                    MessageBox.Show("No se peude agregar al registro..."); 
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
            
            //Validaciones
            if (this.txtCedula.Text.Length == 0)
            {
                MessageBox.Show("Please ingrese su cedula");
                this.txtCedula.Focus();
                return;
            }
            if (this.txtApellidos.Text.Length == 0)
            {
                MessageBox.Show("Please ingrese sus apellidos");
                this.txtApellidos.Focus();
                return;
            }
            if (this.txtNombres.Text.Length == 0)
            {
                MessageBox.Show("Please ingrese sus nombres");
                this.txtNombres.Focus();
                return;
            }
            if (this.cmbSexo.Text.Length == 0)
            {
                MessageBox.Show("Please ingrese su sexo");
                this.cmbSexo.Focus();
                return;
            }

            if (this.txtCorreo.Text.Length == 0)
            {
                MessageBox.Show("Please ingrese su correo");
                this.txtCorreo.Focus();
                return;
            }
            if (this.txtEstatura.Text.Length == 0)
            {
                MessageBox.Show("Please ingrese su estatura");
                this.txtEstatura.Focus();
                return;
            }
            if (this.txtPeso.Text.Length == 0)
            {
                MessageBox.Show("Please ingrese su peso");
                this.txtPeso.Focus();
                return;
            }
        }

        public static bool ComprobarEmail(string MailAComprobar)
        {
            String Formato;
            Formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(MailAComprobar, Formato))
            {
                if (Regex.Replace(MailAComprobar, Formato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ComprobarEmail(txtCorreo.Text) == false)
            {
                MessageBox.Show("Dirección no valida");
                txtCorreo.ForeColor = Color.DarkRed;
            }
            else
            {
                MessageBox.Show("Dirección valida");
                txtCorreo.ForeColor = Color.Gold;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
