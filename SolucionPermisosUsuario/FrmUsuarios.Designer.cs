namespace SolucionPermisosUsuario
{
    partial class FrmUsuarios
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
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "BUSCAR USUARIOS";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(18, 38);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(888, 22);
            this.txtBuscarUsuario.TabIndex = 17;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.txtBuscarUsuario_TextChanged);
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Location = new System.Drawing.Point(18, 77);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.RowHeadersWidth = 51;
            this.dtgvUsuarios.RowTemplate.Height = 24;
            this.dtgvUsuarios.Size = new System.Drawing.Size(887, 413);
            this.dtgvUsuarios.TabIndex = 18;
            this.dtgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 496);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(225, 52);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(364, 496);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(225, 52);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "MODIFICAR";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(680, 496);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(225, 52);
            this.btnDel.TabIndex = 31;
            this.btnDel.Text = "ELIMINAR";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 560);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvUsuarios);
            this.Controls.Add(this.txtBuscarUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
    }
}