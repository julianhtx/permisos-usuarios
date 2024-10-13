using Identities;
using System;
﻿using System;
﻿using Controller;
using Identities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace SolucionPermisosUsuario
{
    public partial class FrmProducto : Form
    {
        ControllerRefaccion cr;
        static int fila = 0, columna = 0;
        public static int codigoBarras;
        public static string nombre, marca, descripcion;


        private void dtgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)

        /*private void dtgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)

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


        }*/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddRefaccion far = new FrmAddRefaccion();
            far.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(codigoBarras.ToString()))
            {
                /*codigoBarras = int.Parse(dtgvProductos.Rows[fila].Cells[0].Value.ToString());
                nombre = dtgvProductos.Rows[fila].Cells[1].Value.ToString();
                marca = dtgvProductos.Rows[fila].Cells[2].Value.ToString();
                descripcion = dtgvProductos.Rows[fila].Cells[3].Value.ToString();*/
                FrmAddRefaccion formulario = new FrmAddRefaccion();
                formulario.SetData(codigoBarras, nombre, marca, descripcion); // Método que debes crear en el formulario
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dtgvProductos.SelectedRows.Count > 0)
            {
                // Obtén el username de la fila seleccionada (ajusta el índice según tu DataGridView)
                codigoBarras = int.Parse(dtgvProductos.SelectedRows[0].Cells["codigoBarras"].Value.ToString());

                // Llama al método Borrar del manejador
                cr.Borrar(codigoBarras);
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que la fila es válida
            {
                DataGridViewRow row = dtgvProductos.Rows[e.RowIndex];

                // Almacena los datos de la fila seleccionada en las variables
                codigoBarras = int.Parse(row.Cells["CodigoBarras"].Value.ToString()); // Asegúrate de que este valor sea seguro
                nombre = row.Cells["nombre"].Value.ToString();
                descripcion = row.Cells["descripcion"].Value.ToString();
                marca = row.Cells["marca"].Value.ToString();

                // Cambia el color de la fila seleccionada (opcional)
                row.Selected = true; // Esto selecciona la fila visualmente
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


        private void VerificarPermisos()
        {
            if (!IdentitiesPermisos.Producto_Escritura)
            {
                btnAdd.Visible = false;
                //falta lo de las posiciones de botones
            }

            btnEditar.Visible = IdentitiesPermisos.Producto_Actualizacion;

            if (!IdentitiesPermisos.Producto_Eliminacion)
            {
                btnDel.Visible = false;
                //falta lo de las posiciones de botones
            }
        }
    }
}
