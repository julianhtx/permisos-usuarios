using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using System.Windows.Forms;

namespace Controller
{
    public class ControllerUser
    {
        Funciones f = new Funciones();
        
        public void Guardar(TextBox Username, TextBox Contraseña, TextBox Nombre, TextBox ApellidoP, TextBox ApellidoM, DateTimePicker FechaNacimiento, TextBox Rfc, DataGridView permisos)
        {
            string fechaNacimiento = FechaNacimiento.Value.ToString("yyyy-MM-dd");
            // Guardar usuario
            string queryGuardarUsuario = $"call p_insertar_usuarios('{Username.Text}', sha1('{Contraseña.Text}'), '{Nombre.Text}', '{ApellidoP.Text}', '{ApellidoM.Text}', '{fechaNacimiento}', '{Rfc.Text}');";

            string resultado = f.Guardar(queryGuardarUsuario);

            if (resultado != "Correcto") // Cambia 'Success' por 'Correcto'
            {
                MessageBox.Show($"Error al guardar el usuario: {resultado}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si hubo un error
            }

            // Recorre el DataGridView para obtener los permisos y guardarlos
            foreach (DataGridViewRow row in permisos.Rows)
            {
                string nombreFormulario = row.Cells["Formulario"].Value.ToString();
                bool lectura = Convert.ToBoolean(row.Cells["Lectura"].Value);
                bool escritura = Convert.ToBoolean(row.Cells["Escritura"].Value);
                bool actualizacion = Convert.ToBoolean(row.Cells["Actualizar"].Value);
                bool eliminacion = Convert.ToBoolean(row.Cells["Eliminacion"].Value);

                // Insertar permisos en la tabla Permisos
                string queryGuardarPermisos = $"call p_insertar_permisos('{Username.Text}', '{nombreFormulario}', {lectura}, {escritura}, {actualizacion}, {eliminacion});";

                string resultadoPermisos = f.Guardar(queryGuardarPermisos); // Insertar cada permiso

                if (resultadoPermisos != "Correcto") // Cambia 'Success' por 'Correcto'
                {
                    MessageBox.Show($"Error al guardar permisos para {nombreFormulario}: {resultadoPermisos}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si hubo un error
                }
            }

            MessageBox.Show("Usuario y permisos guardados con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void Borrar(string Username)

        /*public void Borrar(string Username, string dato)

        {
            DialogResult rs = MessageBox.Show($"¿Estás seguro de borrar a {Username}?", "Atención!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                // Primero, eliminar permisos asociados al usuario
                string queryEliminarPermisos = $"call p_eliminar_permisos('{Username}');";
                string resultadoPermisos = f.Guardar(queryEliminarPermisos);

                if (resultadoPermisos != "Correcto")
                {
                    MessageBox.Show($"Error al eliminar permisos para {Username}: {resultadoPermisos}, llame a el administrador para revisar el error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir si hay un error al eliminar permisos
                }

                // Luego, eliminar el usuario
                string queryEliminarUsuario = $"call p_EliminarUsuarios('{Username}');";
                string resultadoUsuario = f.Guardar(queryEliminarUsuario);

                if (resultadoUsuario != "Correcto")
                {
                    MessageBox.Show($"Error al eliminar el usuario: {resultadoUsuario}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir si hay un error al eliminar el usuario
                }

                MessageBox.Show("Registro eliminado con éxito", "Atención!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void Modificar(TextBox Username, TextBox Contraseña, TextBox Nombre, TextBox ApellidoP, TextBox ApellidoM, DateTimePicker FechaNacimiento, TextBox Rfc, DataGridView permisos)


        public void Modificar(TextBox Contraseña, TextBox Nombre, TextBox ApellidoP, TextBox ApellidoM, )*/
        public void Modificar(TextBox Contraseña, TextBox Nombre, TextBox ApellidoP, TextBox ApellidoM, DateTimePicker FechaNacimiento, TextBox rfc, string Username)

        {
            string fechaNacimiento = FechaNacimiento.Value.ToString("yyyy-MM-dd");
            // Actualizar usuario
            string queryModificarUsuario = $"call p_ModificarUsuarios('{Username.Text}', sha1('{Contraseña.Text}'), '{Nombre.Text}', '{ApellidoP.Text}', '{ApellidoM.Text}', '{fechaNacimiento}', '{Rfc.Text}');";

            string resultado = f.Guardar(queryModificarUsuario);

            if (resultado != "Correcto") // Cambia 'Success' por 'Correcto'
            {
                MessageBox.Show($"Error al modificar el usuario: {resultado}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si hubo un error
            }

            // Borrar permisos existentes para el usuario (si es necesario)
            string queryBorrarPermisos = $"call p_EliminarPermisosPorUsuario('{Username.Text}');"; // Llama un procedimiento para eliminar permisos
            f.Guardar(queryBorrarPermisos); // Borra permisos existentes

            // Recorre el DataGridView para obtener los nuevos permisos y guardarlos
            foreach (DataGridViewRow row in permisos.Rows)
            {
                string nombreFormulario = row.Cells["Formulario"].Value.ToString();
                bool lectura = Convert.ToBoolean(row.Cells["Lectura"].Value);
                bool escritura = Convert.ToBoolean(row.Cells["Escritura"].Value);
                bool actualizacion = Convert.ToBoolean(row.Cells["Actualizar"].Value);
                bool eliminacion = Convert.ToBoolean(row.Cells["Eliminacion"].Value);

                // Insertar permisos en la tabla Permisos
                string queryGuardarPermisos = $"call p_insertar_permisos('{Username.Text}', '{nombreFormulario}', {lectura}, {escritura}, {actualizacion}, {eliminacion});";

                string resultadoPermisos = f.Guardar(queryGuardarPermisos); // Insertar cada permiso

                if (resultadoPermisos != "Correcto") // Cambia 'Success' por 'Correcto'
                {
                    MessageBox.Show($"Error al guardar permisos para {nombreFormulario}: {resultadoPermisos}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si hubo un error
                }
            }

            MessageBox.Show("Usuario y permisos actualizados con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MostrarGeneral(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from usuarios where nombre like '%{filtro}%'", "Usuarios").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void MostrarUsuario(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from VistaUsuariosPermisos where nombre like '%{filtro}%'", "Usuarios").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public DataTable ObtenerPermisos(string username)
        {
            return f.Mostrar($"SELECT * FROM VistaUsuariosPermisos WHERE fk_Username = '{username}'", "VistaUsuariosPermisos").Tables[0];
        }
    }
}