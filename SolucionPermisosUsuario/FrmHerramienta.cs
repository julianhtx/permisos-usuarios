using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SolucionPermisosUsuario
{
    public partial class FrmHerramienta : Form
    {
        ControllerHerramienta ch;
        static int fila = 0, columna = 0;
        public static int codigoHerramienta;
        public static string nombre, medida, marca, descripcion;

        private void dtgvHerramientas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 5:
                    {
                        codigoHerramienta = int.Parse(dtgvHerramientas.Rows[fila].Cells[0].Value.ToString());
                        ch.Borrar(codigoHerramienta, dtgvHerramientas.Rows[fila].Cells[1].Value.ToString());
                        dtgvHerramientas.Visible = false;
                    }
                    break;
                case 6:
                    {
                        codigoHerramienta = int.Parse(dtgvHerramientas.Rows[fila].Cells[0].Value.ToString());
                        nombre = dtgvHerramientas.Rows[fila].Cells[1].Value.ToString();
                        medida = dtgvHerramientas.Rows[fila].Cells[2].Value.ToString();
                        marca = dtgvHerramientas.Rows[fila].Cells[3].Value.ToString();
                        descripcion = dtgvHerramientas.Rows[fila].Cells[4].Value.ToString();
                        FrmAddHerramienta Add = new FrmAddHerramienta();
                        Add.ShowDialog();
                        dtgvHerramientas.Visible = false;
                    }
                    break;
            }
        }

        public FrmHerramienta()
        {
            InitializeComponent();
            ch = new ControllerHerramienta();
        }

        private void txtBuscarHerramienta_TextChanged(object sender, EventArgs e)
        {
            ch.Mostrar(dtgvHerramientas, txtBuscarHerramienta.Text);
        }

    }
}
