using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace SolucionPermisosUsuario
{
    public partial class FrmAddRefaccion : Form
    {
        ControllerRefaccion cr;
        public FrmAddRefaccion()
        {
            InitializeComponent();
            cr = new ControllerRefaccion();
            txtCodigoBarras.Text = FrmProducto.codigoBarras.ToString();
            txtNombreProducto.Text = FrmProducto.nombre.ToString();
            txtDescripcionProducto.Text = FrmProducto.descripcion.ToString();
            txtMarcaProducto.Text = FrmProducto.marca.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (FrmHerramienta.codigoHerramienta > 0)
                cr.Modificar(txtCodigoBarras, txtNombreProducto, txtDescripcionProducto, txtMarcaProducto);
            else
                cr.Guardar(txtCodigoBarras, txtNombreProducto, txtDescripcionProducto, txtMarcaProducto);
            Close();
        }
    }
}
