using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace Controller
{
    public class ControllerUser
    {
        Funciones f = new Funciones();
        
        public void Guardar(TextBox Username, TextBox Contraseña, TextBox Nombre, TextBox ApellidoP, TextBox ApellidoM, DateTimePicker FechaNacimiento, TextBox Rfc)
        {
            MessageBox.Show(f.Guardar($"call p_InsertarUsuarios ('{Username.Text}', 'sha1('{Contraseña.Text}', '{Nombre.Text}', '{ApellidoP.Text}', '{ApellidoM.Text}', '{FechaNacimiento.Text}', '{Rfc.Text}')')"),
                "Atención!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /*public void Borrar(string Username, string dato)
        {
            DialogResult rs = MessageBox.Show($"Estas seguro de borrar {dato}?", "Atención!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                f.Borrar($"call p_EliminarUsuarios('{Username}')");
                MessageBox.Show("Registro eliminado con exito chaparrito", "Atención!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void Modificar(TextBox Contraseña, TextBox Nombre, TextBox ApellidoP, TextBox ApellidoM, )*/
        public void Modificar(TextBox Contraseña, TextBox Nombre, TextBox ApellidoP, TextBox ApellidoM, DateTimePicker FechaNacimiento, TextBox rfc, string Username)
        {
            MessageBox.Show(f.Modificar($"call p_ModificarUsuarios ('{Username}', sha1('{Contraseña.Text}'), '{Nombre.Text}', '{ApellidoP.Text}', '{ApellidoM.Text}', '{FechaNacimiento.Text}', '{rfc.Text}')"),
                "Atención!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}