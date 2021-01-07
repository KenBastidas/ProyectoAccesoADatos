
namespace IUWindowsForms
{
    partial class FrmListadoEstudiante
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dataGridViewEstudiantes = new System.Windows.Forms.DataGridView();
            this.linkActualizar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.linkEliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Estudiantes";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(496, 40);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(91, 31);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dataGridViewEstudiantes
            // 
            this.dataGridViewEstudiantes.AllowUserToAddRows = false;
            this.dataGridViewEstudiantes.AllowUserToDeleteRows = false;
            this.dataGridViewEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linkActualizar,
            this.linkEliminar});
            this.dataGridViewEstudiantes.Location = new System.Drawing.Point(12, 91);
            this.dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            this.dataGridViewEstudiantes.ReadOnly = true;
            this.dataGridViewEstudiantes.Size = new System.Drawing.Size(939, 276);
            this.dataGridViewEstudiantes.TabIndex = 2;
            this.dataGridViewEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstudiantes_CellContentClick);
            // 
            // linkActualizar
            // 
            this.linkActualizar.HeaderText = "Accion";
            this.linkActualizar.Name = "linkActualizar";
            this.linkActualizar.ReadOnly = true;
            this.linkActualizar.Text = "Actualizar";
            this.linkActualizar.UseColumnTextForLinkValue = true;
            this.linkActualizar.Width = 46;
            // 
            // linkEliminar
            // 
            this.linkEliminar.HeaderText = "Accion";
            this.linkEliminar.Name = "linkEliminar";
            this.linkEliminar.ReadOnly = true;
            this.linkEliminar.Text = "Eliminar";
            this.linkEliminar.UseColumnTextForLinkValue = true;
            this.linkEliminar.Width = 46;
            // 
            // FrmListadoEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 478);
            this.Controls.Add(this.dataGridViewEstudiantes);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Name = "FrmListadoEstudiante";
            this.Text = "Listado de Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dataGridViewEstudiantes;
        private System.Windows.Forms.DataGridViewLinkColumn linkActualizar;
        private System.Windows.Forms.DataGridViewLinkColumn linkEliminar;
    }
}