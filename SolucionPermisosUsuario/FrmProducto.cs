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
    public partial class FrmProducto : Form
    {
        ControllerRefaccion cr;
        static int fila = 0, columna = 0;
        public static int codigoBarras;
        public static string nombre, marca, descripcion;

        private void dtgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 4:
                    {
                        codigoBarras = int.Parse(dtgvProductos.Rows[fila].Cells[0].Value.ToString());
                        cr.Borrar(codigoBarras, dtgvProductos.Rows[fila].Cells[1].Value.ToString());
                        dtgvProductos.Visible = false;
                    }
                    break;
                case 5:
                    {
                        codigoBarras = int.Parse(dtgvProductos.Rows[fila].Cells[0].Value.ToString());
                        nombre = dtgvProductos.Rows[fila].Cells[1].Value.ToString();
                        descripcion = dtgvProductos.Rows[fila].Cells[2].Value.ToString();
                        marca = dtgvProductos.Rows[fila].Cells[3].Value.ToString();
                        FrmAddHerramienta Add = new FrmAddHerramienta();
                        Add.ShowDialog();
                        dtgvProductos.Visible = false;
                    }
                    break;
            }
        }

        public FrmProducto()
        {
            InitializeComponent();
            cr = new ControllerRefaccion();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            cr.Mostrar(dtgvProductos, txtBuscarProducto.Text);
        }
    }
}
