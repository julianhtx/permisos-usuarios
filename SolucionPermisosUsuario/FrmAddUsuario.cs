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
    public partial class FrmAddUsuario : Form
    {
        ControllerUser Cu;
        string username = "";
        public FrmAddUsuario()
        {
            InitializeComponent();
            Cu = new ControllerUser();
            CargarPermisos();
        }

        private void CargarPermisos()
        {
            // Limpiar cualquier contenido previo
            dtgvPermisos.Rows.Clear();

            // Nombres de los formularios
            string[] formularios = { "Usuarios", "Herramientas", "Productos" }; // Agrega más formularios en caso que se creen mas (obligatorio)

            // Recorrer los formularios y añadir filas con columnas para los permisos
            foreach (string formulario in formularios)
            {
                dtgvPermisos.Rows.Add(formulario, false, false, false, false);
            }

            // Ajustar columnas para que se vean bien
            dtgvPermisos.AutoResizeColumns();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Verifica si el username está vacío
            if (string.IsNullOrEmpty(FrmUsuarios.username))
            {
                // Si no hay username, se guarda un nuevo usuario
                Cu.Guardar(txtUsername, txtPassword, txtNombre, txtApellidoP, txtApellidoM, dtpFechaNac, txtRFC, dtgvPermisos);
                MessageBox.Show("Usuario agregado exitosamente.");
            }
            else
            {
                // Si hay username, se modifica el usuario existente
                Cu.Modificar(txtUsername, txtPassword, txtNombre, txtApellidoP, txtApellidoM, dtpFechaNac, txtRFC, dtgvPermisos);
                MessageBox.Show("Usuario modificado exitosamente.");
            }
            Close(); // Cierra el formulario después de guardar o modificar
        }

        public void SetData(string username, string password, string nombre, string apellidoP, string apellidoM, string fechaNacimiento, string rfc)
        {
            txtUsername.Text = username; // Asigna los valores a los controles
            txtPassword.Text = password;
            txtNombre.Text = nombre;
            txtApellidoP.Text = apellidoP;
            txtApellidoM.Text = apellidoM;
            dtpFechaNac.Value = DateTime.Parse(fechaNacimiento);
            txtRFC.Text = rfc;
        }
    }
}
