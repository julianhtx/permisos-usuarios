using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace Controller
{
    public class ControllerHerramienta
    {
        Funciones f = new Funciones();
        public void Guardar(TextBox codigoHerramienta, TextBox nombre, TextBox medida, TextBox marca, TextBox descripcion)
        {
            MessageBox.Show(f.Guardar($"insert into Taller (codigoHerramienta, nombre, medida, marca, descripcion) values ({codigoHerramienta.Text}, '{nombre.Text}', '{medida.Text}', '{marca.Text}', '{descripcion.Text}')"),
                "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Borrar(int ID)
        {
            DialogResult rs = MessageBox.Show($"Estas seguro de borrar {ID}?", "Atencion!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"delete from Taller where codigoHerramienta ={ID}");
                MessageBox.Show("Registro eliminado con exito", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Modificar(TextBox codigoHerramienta, TextBox nombre, TextBox medida, TextBox marca, TextBox descripcion)
        {
            MessageBox.Show(f.Modificar($"update Taller set nombre = '{nombre.Text}', medida = '{medida.Text}', marca = '{marca.Text}', descripcion = '{descripcion.Text}' where codigoHerramienta = {codigoHerramienta.Text}"),
                "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DataGridViewButtonColumn Boton(string t, Color fondo)
        {
            DataGridViewButtonColumn b = new DataGridViewButtonColumn();
            b.Text = t;
            b.UseColumnTextForButtonValue = true;
            b.FlatStyle = FlatStyle.Popup;
            b.DefaultCellStyle.BackColor = fondo;
            b.DefaultCellStyle.ForeColor = Color.White;
            return b;
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from Taller where nombre like '%{filtro}%'", "Taller").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
