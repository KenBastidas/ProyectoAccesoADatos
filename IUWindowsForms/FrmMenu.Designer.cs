
namespace IUWindowsForms
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnFrmAgregarEstudiantes = new System.Windows.Forms.Button();
            this.btnFrmListadoEstudiante = new System.Windows.Forms.Button();
            this.btnFrmBuscar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnFrmAgregarEstudiantes
            // 
            this.btnFrmAgregarEstudiantes.Location = new System.Drawing.Point(43, 84);
            this.btnFrmAgregarEstudiantes.Name = "btnFrmAgregarEstudiantes";
            this.btnFrmAgregarEstudiantes.Size = new System.Drawing.Size(132, 23);
            this.btnFrmAgregarEstudiantes.TabIndex = 1;
            this.btnFrmAgregarEstudiantes.Text = "AgregarEstudiantes";
            this.btnFrmAgregarEstudiantes.UseVisualStyleBackColor = true;
            this.btnFrmAgregarEstudiantes.Click += new System.EventHandler(this.btnFrmAgregarEstudiantes_Click);
            // 
            // btnFrmListadoEstudiante
            // 
            this.btnFrmListadoEstudiante.Location = new System.Drawing.Point(43, 140);
            this.btnFrmListadoEstudiante.Name = "btnFrmListadoEstudiante";
            this.btnFrmListadoEstudiante.Size = new System.Drawing.Size(132, 23);
            this.btnFrmListadoEstudiante.TabIndex = 2;
            this.btnFrmListadoEstudiante.Text = "ListadoEstudiante";
            this.btnFrmListadoEstudiante.UseVisualStyleBackColor = true;
            this.btnFrmListadoEstudiante.Click += new System.EventHandler(this.btnFrmListadoEstudiante_Click);
            // 
            // btnFrmBuscar
            // 
            this.btnFrmBuscar.Location = new System.Drawing.Point(43, 183);
            this.btnFrmBuscar.Name = "btnFrmBuscar";
            this.btnFrmBuscar.Size = new System.Drawing.Size(132, 23);
            this.btnFrmBuscar.TabIndex = 3;
            this.btnFrmBuscar.Text = "Buscar Estudiantes";
            this.btnFrmBuscar.UseVisualStyleBackColor = true;
            this.btnFrmBuscar.Click += new System.EventHandler(this.btnFrmBuscar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(45, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFrmBuscar);
            this.Controls.Add(this.btnFrmListadoEstudiante);
            this.Controls.Add(this.btnFrmAgregarEstudiantes);
            this.Controls.Add(this.label1);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFrmAgregarEstudiantes;
        private System.Windows.Forms.Button btnFrmListadoEstudiante;
        private System.Windows.Forms.Button btnFrmBuscar;
        private System.Windows.Forms.Button btnClose;
    }
}