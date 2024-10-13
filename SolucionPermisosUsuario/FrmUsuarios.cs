using Controller;
using Identities;
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
    public partial class FrmUsuarios : Form
    {
        public static string username, password, nombre, apellidoP, apellidoM, fechaNac, rfc = "";
        ControllerUser Cu;

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            Cu.MostrarGeneral(dtgvUsuarios, txtBuscarUsuario.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Verifica que se haya seleccionado una fila
            if (!string.IsNullOrEmpty(username))
            {
                FrmAddUsuario formulario = new FrmAddUsuario();
                formulario.SetData(username, password, nombre, apellidoP, apellidoM, fechaNac, rfc); // Método que debes crear en el formulario
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public FrmUsuarios()
        {
            InitializeComponent();
            VerificarPermisos();
            Cu = new ControllerUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddUsuario btn = new FrmAddUsuario();
            btn.Show();
        }

        public void VerificarPermisos()
        {
            btnAdd.Visible = IdentitiesPermisos.Usuarios_Escritura;
            btnDel.Visible = IdentitiesPermisos.Usuarios_Eliminacion;
            btnEdit.Visible = IdentitiesPermisos.Usuarios_Actualizacion;
        }

        private void dtgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que la fila es válida
            {
                DataGridViewRow row = dtgvUsuarios.Rows[e.RowIndex];

                // Almacena los datos de la fila seleccionada en las variables
                username = row.Cells["Username"].Value.ToString();
                password = row.Cells["password"].Value.ToString(); // Asegúrate de que este valor sea seguro
                nombre = row.Cells["nombre"].Value.ToString();
                apellidoP = row.Cells["apellidoP"].Value.ToString();
                apellidoM = row.Cells["apellidoM"].Value.ToString();
                fechaNac = Convert.ToDateTime(row.Cells["fechanacimiento"].Value).ToString("yyyy-MM-dd");
                rfc = row.Cells["rfc"].Value.ToString();

                // Cambia el color de la fila seleccionada (opcional)
                row.Selected = true; // Esto selecciona la fila visualmente
            }
        }
    }
}
