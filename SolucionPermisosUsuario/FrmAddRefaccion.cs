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
<<<<<<< HEAD

            txtCodigoBarras.Text = FrmProducto.codigoBarras.ToString();
            txtNombreProducto.Text = FrmProducto.nombre.ToString();
            txtDescripcionProducto.Text = FrmProducto.descripcion.ToString();
            txtMarcaProducto.Text = FrmProducto.marca.ToString();

=======
>>>>>>> fb581d2 (LOS FORMULARIOS YA FUNCIONANgit checkout main!)
        }

        private void FrmAddRefaccion_Load(object sender, EventArgs e)
        {

<<<<<<< HEAD

=======
>>>>>>> fb581d2 (LOS FORMULARIOS YA FUNCIONANgit checkout main!)
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

            if (FrmHerramienta.codigoHerramienta > 0)

            if (FrmProducto.codigoBarras > 0)

=======
            if (FrmProducto.codigoBarras > 0)
>>>>>>> fb581d2 (LOS FORMULARIOS YA FUNCIONANgit checkout main!)
                cr.Modificar(txtCodigoBarras, txtNombreProducto, txtDescripcionProducto, txtMarcaProducto);
            else
                cr.Guardar(txtCodigoBarras, txtNombreProducto, txtDescripcionProducto, txtMarcaProducto);
            Close();
<<<<<<< HEAD


=======
>>>>>>> fb581d2 (LOS FORMULARIOS YA FUNCIONANgit checkout main!)
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
<<<<<<< HEAD

=======
>>>>>>> fb581d2 (LOS FORMULARIOS YA FUNCIONANgit checkout main!)
        }
    }
}
