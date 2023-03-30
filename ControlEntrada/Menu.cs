using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEntrada
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (Globales.rol_usuario == "Administrador")
            {
                this.mostrarRol.Text = Globales.rol_usuario;
            }
            else
            {
                this.mostrarRol.Visible= false;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerrar el programa?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
                {
                    frm.Close();
                }
            }
        }

        private void btnUsuariosSistema_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            panel.Left = (Width - panel.Width) / 2;
            panel.Top = (Width - panel.Height) / 2;
        }

        private void AcercaDe_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.ShowDialog();
        }

        private void btnRegistroPersona_Click(object sender, EventArgs e)
        {
            Personal personas = new Personal();
            personas.ShowDialog();
        }

        private void btnRegEntradaSalida_Click(object sender, EventArgs e)
        {
            EntradaSalida entradaSalida = new EntradaSalida();
            entradaSalida.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.ShowDialog();
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            // NOTA: En el formulario en la propiedad Keypreview = true
            // Evitar salir con la tecla f4
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerrar Sesión?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
                {
                    frm.Close();
                }
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                //Login login = new Login();
                //login.ShowDialog();
                //this.Close();
            }
        }

        private void labelMenu2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.ShowDialog();
        }
    }
}
