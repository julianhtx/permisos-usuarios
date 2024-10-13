using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionPermisosUsuario
{
    public partial class FrmAddRefaccion : Form
    {
        ControllerRefaccion cr;
        public FrmAddRefaccion()
        {
            InitializeComponent();
            cr = new ControllerRefaccion();
        }

        private void FrmAddRefaccion_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (FrmProducto.codigoBarras > 0)
                cr.Modificar(txtCodigoBarras, txtNombreProducto, txtDescripcionProducto, txtMarcaProducto);
            else
                cr.Guardar(txtCodigoBarras, txtNombreProducto, txtDescripcionProducto, txtMarcaProducto);
            Close();
        }
        public void SetData(int codigoBarras, string nombre, string marca, string descripcion)
        {
            txtCodigoBarras.Text = codigoBarras.ToString();
            txtNombreProducto.Text = nombre;
            txtMarcaProducto.Text = marca;
            txtDescripcionProducto.Text = descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
