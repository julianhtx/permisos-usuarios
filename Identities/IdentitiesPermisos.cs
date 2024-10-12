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
    }
}
