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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SolucionPermisosUsuario
{
    public partial class FrmAddHerramienta : Form
    {
        ControllerHerramienta ch;
        public FrmAddHerramienta()
        {
            InitializeComponent();
            ch = new ControllerHerramienta();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (FrmHerramienta.codigoHerramienta > 0)
            {
                ch.Modificar(txtCodigoBarras, txtNombreHerramienta, txtMedidaHerramienta, txtMarcaHerramienta, txtDescripcionHerramienta);
                MessageBox.Show("Herramienta modificada exitosamente.");
            }
            else
            {
                ch.Guardar(txtCodigoBarras, txtNombreHerramienta, txtMedidaHerramienta, txtMarcaHerramienta, txtDescripcionHerramienta);
                MessageBox.Show("Herramienta agregada exitosamente.");
            }
            Close();
        }
        public void SetData(int codigoHerramienta, string nombre, double medida, string marca, string descripcion)
        {
            txtCodigoBarras.Text = codigoHerramienta.ToString();
            txtNombreHerramienta.Text = nombre;
            txtMedidaHerramienta.Text = medida.ToString();
            txtMarcaHerramienta.Text = marca;
            txtDescripcionHerramienta.Text = descripcion;
        }
    }
}
