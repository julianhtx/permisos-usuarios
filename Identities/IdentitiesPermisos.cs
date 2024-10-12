using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identities
{
    public class IdentitiesPermisos
    {
        public static bool Usuarios_Lectura { get; set; }
        public static bool Usuarios_Escritura { get; set; }
        public static bool Usuarios_Eliminacion { get; set; }
        public static bool Usuarios_Actualizacion { get; set; }

        public static bool Producto_Lectura { get; set; }
        public static bool Producto_Escritura { get; set; }
        public static bool Producto_Eliminacion { get; set; }
        public static bool Producto_Actualizacion { get; set; }

        public static bool Herramientas_Lectura { get; set; }
        public static bool Herramientas_Escritura { get; set; }
        public static bool Herramientas_Eliminacion { get; set; }
        public static bool Herramientas_Actualizacion { get; set; }

        //listo para agregar mas formularios (necesario si o si)

        public static void LimpiarPermisos()
        {
            Usuarios_Lectura = false;
            Usuarios_Escritura = false;
            Usuarios_Eliminacion = false;
            Usuarios_Actualizacion = false;

            Producto_Lectura = false;
            Producto_Escritura = false;
            Producto_Eliminacion = false;
            Producto_Actualizacion = false;

            Herramientas_Lectura = false;
            Herramientas_Escritura = false;
            Herramientas_Eliminacion = false;
            Herramientas_Actualizacion = false;

            //listo para agregar mas formularios (necesario si o si)
        }

        // Método para asignar permisos según el nombre del formulario
        public static void AsignarPermisos(string formulario, bool lectura, bool escritura, bool actualizacion, bool eliminacion)
        {
            switch (formulario)
            {
                case "Usuarios":
                    Usuarios_Lectura = lectura;
                    Usuarios_Escritura = escritura;
                    Usuarios_Actualizacion = actualizacion;
                    Usuarios_Eliminacion = eliminacion;
                    break;
                case "Productos":
                    Producto_Lectura = lectura;
                    Producto_Escritura = escritura;
                    Producto_Actualizacion = actualizacion;
                    Producto_Eliminacion = eliminacion;
                    break;
                case "Herramientas":
                    Herramientas_Lectura = lectura;
                    Herramientas_Escritura = escritura;
                    Herramientas_Actualizacion = actualizacion;
                    Herramientas_Eliminacion = eliminacion;
                    break;

                //listo para agregar mas opciones en dado caso se agreguen mas formularios (necesario si o si)

                default:
                    throw new ArgumentException("Formulario no reconocido: " + formulario + " favor de hablar con el administrador.");
            }
        }
    }
}
