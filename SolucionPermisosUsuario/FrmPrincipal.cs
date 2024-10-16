﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Identities;

namespace SolucionPermisosUsuario
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            VerificarPermisos();
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios fu = new FrmUsuarios();
            fu.MdiParent = this;
            fu.Show();
        }

        private void tsRefacciones_Click(object sender, EventArgs e)
        {
            FrmProducto fp = new FrmProducto();
            fp.MdiParent = this;
            fp.Show();
        }

        private void tsTaller_Click(object sender, EventArgs e)
        {
            FrmHerramienta fh = new FrmHerramienta();
            fh.MdiParent = this;    
            fh.Show();
        }

        public void VerificarPermisos()
        {
            tsUsuario.Visible = IdentitiesPermisos.Usuarios_Lectura;
            tsRefacciones.Visible = IdentitiesPermisos.Producto_Lectura;
            tsTaller.Visible = IdentitiesPermisos.Herramientas_Lectura;
        }
    }
}
