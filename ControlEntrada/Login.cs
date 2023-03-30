using Logica;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void salirLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entrarLogin_Click(object sender, EventArgs e)
        {
            //General.VerificarConexion();
            if (string.IsNullOrEmpty(this.tbUsuarioLogin.Text))
            {
                MessageBox.Show("Por favor digite el usuario", "Notificación");
                this.tbUsuarioLogin.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.tbContraseñaLogin.Text))
                {
                    MessageBox.Show("Por favor digite la contraseña", "Notificación");
                    this.tbContraseñaLogin.Focus();
                }
                else
                {
                    Globales.rol_usuario = (string)usuariosTableAdapter.BuscarRol(this.tbUsuarioLogin.Text,Encriptar.Encriptar1(this.tbContraseñaLogin.Text));
                    if (string.IsNullOrEmpty(Globales.rol_usuario))
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta", "Notificación");
                        this.tbContraseñaLogin.Focus();
                    }
                    else
                    {

                        Globales.usuario_usuario = (string)this.usuariosTableAdapter.BuscarUsuario(this.tbUsuarioLogin.Text, Encriptar.Encriptar1(this.tbContraseñaLogin.Text));
                        Menu menu = new Menu();
                        menu.ShowDialog();
                    }                                      
                }
            }

        }

        //private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.usuariosBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dataSet1);

        //}

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.TodosUsuarios(this.dataSet1.Usuarios);

        }
    }
}
