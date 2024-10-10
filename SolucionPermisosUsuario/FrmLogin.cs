using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace SolucionPermisosUsuario
{
    public partial class FrmLogin : Form
    {
        ControllerLogin CL;
        public FrmLogin()
        {
            InitializeComponent();
            CL = new ControllerLogin();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] r = CL.Validar(txtUsername.Text, txtPassword.Text);
            if (r[0].Equals("Correcto"))
            {
                this.Hide();
                int nivelUsuario = int.Parse(r[1]);

                FrmPrincipal principal = new FrmPrincipal(//permisosUsuario
                                                          );
                principal.Show();
            }
            else
            {
                MessageBox.Show("Nombre o contraseña incorrectos, favor de consultar con el administrador", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
