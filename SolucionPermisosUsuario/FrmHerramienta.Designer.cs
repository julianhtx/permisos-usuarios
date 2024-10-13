namespace SolucionPermisosUsuario
{
    partial class FrmHerramienta
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
            this.dtgvHerramientas = new System.Windows.Forms.DataGridView();
            this.txtBuscarHerramienta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvHerramientas
            // 
            this.dtgvHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHerramientas.Location = new System.Drawing.Point(12, 79);
            this.dtgvHerramientas.Name = "dtgvHerramientas";
            this.dtgvHerramientas.RowHeadersWidth = 51;
            this.dtgvHerramientas.RowTemplate.Height = 24;
            this.dtgvHerramientas.Size = new System.Drawing.Size(887, 353);
            this.dtgvHerramientas.TabIndex = 21;
            this.dtgvHerramientas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHerramientas_CellClick);
            // 
            // txtBuscarHerramienta
            // 
            this.txtBuscarHerramienta.Location = new System.Drawing.Point(12, 40);
            this.txtBuscarHerramienta.Name = "txtBuscarHerramienta";
            this.txtBuscarHerramienta.Size = new System.Drawing.Size(888, 22);
            this.txtBuscarHerramienta.TabIndex = 20;
            this.txtBuscarHerramienta.TextChanged += new System.EventHandler(this.txtBuscarHerramienta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "BUSCAR HERRAMIENTAS";
            // 
<<<<<<< HEAD





=======
<<<<<<< HEAD
=======
>>>>>>> fb581d2 (LOS FORMULARIOS YA FUNCIONANgit checkout main!)
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(61, 456);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 36);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Agregar Herramientas";
            this.btnAdd.UseVisualStyleBackColor = true;
<<<<<<< HEAD


            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

=======
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
>>>>>>> fb581d2 (LOS FORMULARIOS YA FUNCIONANgit checkout main!)
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(367, 456);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(182, 36);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Modificar Herramienta";
            this.btnEditar.UseVisualStyleBackColor = true;
<<<<<<< HEAD


            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

=======
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
>>>>>>> fb581d2 (LOS FORMULARIOS YA FUNCIONANgit checkout main!)
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(677, 456);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(182, 36);
            this.btnDel.TabIndex = 24;
            this.btnDel.Text = "Eliminar Herramienta";
            this.btnDel.UseVisualStyleBackColor = true;
<<<<<<< HEAD

            // 

            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
>>>>>>> f753cee (LOS FORMULARIOS YA FUNCIONANgit checkout main!)

=======
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
>>>>>>> f753cee (LOS FORMULARIOS YA FUNCIONANgit checkout main!)
>>>>>>> fb581d2 (LOS FORMULARIOS YA FUNCIONANgit checkout main!)
            // FrmHerramienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 504);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvHerramientas);
            this.Controls.Add(this.txtBuscarHerramienta);
            this.Controls.Add(this.label1);
            this.Name = "FrmHerramienta";
            this.Text = "FrmHerramienta";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHerramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHerramientas;
        private System.Windows.Forms.TextBox txtBuscarHerramienta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDel;
    }
}