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
    public partial class FrmAddHerramienta : Form
    {
        ControllerHerramienta ch;
        public FrmAddHerramienta()
        {
            InitializeComponent();
            ch = new ControllerHerramienta();
            txtCodigoBarras.Text = FrmHerramienta.codigoHerramienta.ToString();
            txtNombreHerramienta.Text = FrmHerramienta.nombre.ToString();
            txtMedidaHerramienta.Text = FrmHerramienta.medida.ToString();
            txtMarcaHerramienta.Text = FrmHerramienta.marca.ToString();
            txtDescripcionHerramienta.Text = FrmHerramienta.descripcion.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (FrmHerramienta.codigoHerramienta > 0)
                ch.Modificar(txtCodigoBarras, txtNombreHerramienta, txtMedidaHerramienta, txtMarcaHerramienta, txtDescripcionHerramienta);
            else
                ch.Guardar(txtCodigoBarras, txtNombreHerramienta, txtMedidaHerramienta, txtMarcaHerramienta, txtDescripcionHerramienta);
            Close();
        }
    }
}
