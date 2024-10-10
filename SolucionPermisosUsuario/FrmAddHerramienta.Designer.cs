namespace SolucionPermisosUsuario
{
    partial class FrmAddHerramienta
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtMedidaHerramienta = new System.Windows.Forms.TextBox();
            this.txtDescripcionHerramienta = new System.Windows.Forms.TextBox();
            this.txtNombreHerramienta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarcaHerramienta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(429, 357);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(225, 63);
            this.btnAceptar.TabIndex = 44;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(33, 357);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(225, 63);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtMedidaHerramienta
            // 
            this.txtMedidaHerramienta.Location = new System.Drawing.Point(13, 184);
            this.txtMedidaHerramienta.Name = "txtMedidaHerramienta";
            this.txtMedidaHerramienta.Size = new System.Drawing.Size(308, 22);
            this.txtMedidaHerramienta.TabIndex = 39;
            // 
            // txtDescripcionHerramienta
            // 
            this.txtDescripcionHerramienta.Location = new System.Drawing.Point(371, 116);
            this.txtDescripcionHerramienta.Multiline = true;
            this.txtDescripcionHerramienta.Name = "txtDescripcionHerramienta";
            this.txtDescripcionHerramienta.Size = new System.Drawing.Size(308, 174);
            this.txtDescripcionHerramienta.TabIndex = 38;
            // 
            // txtNombreHerramienta
            // 
            this.txtNombreHerramienta.Location = new System.Drawing.Point(13, 116);
            this.txtNombreHerramienta.Name = "txtNombreHerramienta";
            this.txtNombreHerramienta.Size = new System.Drawing.Size(308, 22);
            this.txtNombreHerramienta.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Medida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "AGREGAR / MODIFICAR HERRAMIENTAS";
            // 
            // txtMarcaHerramienta
            // 
            this.txtMarcaHerramienta.Location = new System.Drawing.Point(13, 257);
            this.txtMarcaHerramienta.Name = "txtMarcaHerramienta";
            this.txtMarcaHerramienta.Size = new System.Drawing.Size(308, 22);
            this.txtMarcaHerramienta.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Marca";
            // 
            // FrmAddHerramienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 469);
            this.Controls.Add(this.txtMarcaHerramienta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtMedidaHerramienta);
            this.Controls.Add(this.txtDescripcionHerramienta);
            this.Controls.Add(this.txtNombreHerramienta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddHerramienta";
            this.Text = "FrmAddHerramienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtMedidaHerramienta;
        private System.Windows.Forms.TextBox txtDescripcionHerramienta;
        private System.Windows.Forms.TextBox txtNombreHerramienta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarcaHerramienta;
        private System.Windows.Forms.Label label5;
    }
}