using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Identities;

namespace Controller
{
    public class ControllerLogin
    {
        Funciones f = new Funciones();


        public string[] Validar(string _user, string _pass)
        {
            string[] resultado = new string[2];
            DataSet r = f.Mostrar($"call p_validar('{_user}', '{Sha1(_pass)}')", "Usuarios");
            DataTable dt = r.Tables[0];
            resultado[0] = dt.Rows[0]["rs"].ToString();
            resultado[1] = dt.Rows[0]["Username"].ToString();
            
            // Asignar valores a los permisos desde la tabla de datos
            IdentitiesPermisos.Usuarios_Lectura = Convert.ToBoolean(dt.Rows[0]["FrmUsuarios_Lectura"]);
            IdentitiesPermisos.Usuarios_Escritura = Convert.ToBoolean(dt.Rows[0]["FrmUsuarios_Escritura"]);
            IdentitiesPermisos.Usuarios_Eliminacion = Convert.ToBoolean(dt.Rows[0]["FrmUsuarios_Eliminacion"]);
            IdentitiesPermisos.Usuarios_Actualizacion = Convert.ToBoolean(dt.Rows[0]["FrmUsuarios_Actualizacion"]);

            IdentitiesPermisos.Producto_Lectura = Convert.ToBoolean(dt.Rows[0]["FrmProducto_Lectura"]);
            IdentitiesPermisos.Producto_Escritura = Convert.ToBoolean(dt.Rows[0]["FrmProducto_Escritura"]);
            IdentitiesPermisos.Producto_Eliminacion = Convert.ToBoolean(dt.Rows[0]["FrmProducto_Eliminacion"]);
            IdentitiesPermisos.Producto_Actualizacion = Convert.ToBoolean(dt.Rows[0]["FrmProducto_Actualizacion"]);

            IdentitiesPermisos.Herramientas_Lectura = Convert.ToBoolean(dt.Rows[0]["FrmHerramientas_Lectura"]);
            IdentitiesPermisos.Herramientas_Escritura = Convert.ToBoolean(dt.Rows[0]["FrmHerramientas_Escritura"]);
            IdentitiesPermisos.Herramientas_Eliminacion = Convert.ToBoolean(dt.Rows[0]["FrmHerramientas_Eliminacion"]);
            IdentitiesPermisos.Herramientas_Actualizacion = Convert.ToBoolean(dt.Rows[0]["FrmHerramientas_Actualizacion"]);
            
            /*
            string permisos = $"Usuarios_Lectura: {dt.Rows[0]["FrmUsuarios_Lectura"]}\n" +
                      $"Usuarios_Escritura: {dt.Rows[0]["FrmUsuarios_Escritura"]}\n" +
                      $"Usuarios_Eliminacion: {dt.Rows[0]["FrmUsuarios_Eliminacion"]}\n" +
                      $"Usuarios_Actualizacion: {dt.Rows[0]["FrmUsuarios_Actualizacion"]}\n" +
                      $"Producto_Lectura: {dt.Rows[0]["FrmProducto_Lectura"]}\n" +
                      $"Producto_Escritura: {dt.Rows[0]["FrmProducto_Escritura"]}\n" +
                      $"Producto_Eliminacion: {dt.Rows[0]["FrmProducto_Eliminacion"]}\n" +
                      $"Producto_Actualizacion: {dt.Rows[0]["FrmProducto_Actualizacion"]}\n" +
                      $"Herramientas_Lectura: {dt.Rows[0]["FrmHerramientas_Lectura"]}\n" +
                      $"Herramientas_Escritura: {dt.Rows[0]["FrmHerramientas_Escritura"]}\n" +
                      $"Herramientas_Eliminacion: {dt.Rows[0]["FrmHerramientas_Eliminacion"]}\n" +
                      $"Herramientas_Actualizacion: {dt.Rows[0]["FrmHerramientas_Actualizacion"]}";

            MessageBox.Show(permisos, "Permisos del Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
            return resultado; 
        }

        public static string Sha1(string texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
