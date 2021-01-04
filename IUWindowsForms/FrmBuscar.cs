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
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            //Evento laod: Se ejeuta la primera vez que se carga el formulario
            this.cargarComboEstudiantes();
        }
        private void cargarComboEstudiantes()
        {
            this.cmbCedula.DataSource = CapaDatos.PersonaDAO.getAll();
            this.cmbCedula.DisplayMember = "estudiante";
            this.cmbCedula.ValueMember = "Cédula";
            
        }

        private void btnBucar_Click(object sender, EventArgs e)
        {
            String cedula = this.cmbCedula.SelectedValue.ToString();

            CapaDatos.Persona p = new CapaDatos.Persona();
            p = CapaDatos.PersonaDAO.GetPersona(cedula);

            //cargarndatos en los cuadros de texto
            this.txtCedula.Text = p.Cedula;
            this.txtApellidos.Text = p.Apellidos;
            this.txtNombres.Text = p.Nombres;
            this.cmbSexo.Text = p.Sexo;
            this.dtmFechaNacimiento.Enabled = false;
            this.dtmFechaNacimiento.Value = p.FEchaNacimiento;
            this.txtCorreo.Text = p.Correo;
            this.txtEstatura.Text = p.Estatura.ToString();
            this.txtPeso.Text = p.Peso.ToString();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(this.txtCedula.Text.Length== 0)// si la cedula esta avcia
            {
                MessageBox.Show("no hay cerdula selecionada...");
                return; //abandonar
            }
            CapaDatos.Persona persona = new CapaDatos.Persona();
            persona.Cedula = this.txtCedula.Text;

            persona.Apellidos = this.txtApellidos.Text;
            persona.Nombres = this.txtNombres.Text;
            persona.Sexo = this.cmbSexo.Text;
            persona.FEchaNacimiento = dtmFechaNacimiento.Value;
            persona.Correo = this.txtCorreo.Text;
            persona.Estatura = int.Parse(this.txtEstatura.Text);
            persona.Peso = Decimal.Parse(this.txtPeso.Text);

            int x= CapaDatos.PersonaDAO.actualizar(persona);
            if (x > 0)
            {
                this.cargarComboEstudiantes();//actulizar cuadro estudiantes
                MessageBox.Show("Registro actualizado con exito!!");
            }
            else
                MessageBox.Show("Nose pudo actualizar el registro!!!!!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea eliminar este registro?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.No)
            {
                return;// ABANDONDAR
            }
            int x = CapaDatos.PersonaDAO.eliminar(this.txtCedula.Text);
            if(x>0)
            {
                this.encerar();
                this.cargarComboEstudiantes();
                MessageBox.Show("Registro elimiando con exito!!");
            }
            else
            {
                MessageBox.Show("No se pudo borrar el registro");
            }
        }
        private void encerar()
        {
            this.txtCedula.Text = "";
            this.txtApellidos.Text="";
            this.txtNombres.Text="";
            this.cmbSexo.Text="M";
            this.txtCorreo.Text="";
            this.txtEstatura.Text="0";
            this.txtPeso.Text="0";
        }
    }
}
