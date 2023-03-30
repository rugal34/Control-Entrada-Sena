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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            Globales.TipoCrud = 1;//insertar
            this.groupBox2.Enabled = true;
            this.MoveFirstItem.Enabled = false;
            this.MovePreviousItem.Enabled = false;
            this.bindingNavigatorPositionItem.Enabled = false;
            this.bindingNavigatorCountItem.Enabled = false;
            this.MoveNextItem.Enabled = false;  
            this.MoveLastItem.Enabled = false;
            this.BNuevo.Enabled = false;
            this.BGuardar.Enabled = true;
            this.BCancelar.Enabled = true;
            this.BEliminar.Enabled = false;
            this.BEditar.Enabled = false;
            this.Buscar.Enabled = false;
            this.BBuscar.Enabled = false;
            this.BTodosRegistros.Enabled = false;
            //copia de los datos
            //si decide cancelar la insercion            
            Globales.Id_usuario = this.id_UsuarioTextBox.Text;
            if (this.fotoPictureBox.Image != null)
            {
                Globales.Foto_usuario = Globales.imageToByteArray(this.fotoPictureBox.Image);
            }            
            Globales.cedula_usuario = this.cedulaTextBox.Text;
            Globales.Nombre_usuario = this.nombreTextEdit.Text;
            Globales.correo_usuario = this.correoTextBox.Text;
            Globales.usuario_usuario = this.usuarioTtextBox.Text;
            Globales.contrasena_usuario = this.contrasenaTextEdit.Text;
            Globales.rol_usuario = this.rolComboBox.Text;
            //
            this.id_UsuarioTextBox.Text = null;
            this.fotoPictureBox.Image = null;
            this.cedulaTextBox.Text = null;
            this.nombreTextEdit.Text = null;
            this.correoTextBox.Text = null;
            this.usuarioTtextBox.Text = null;
            this.contrasenaTextEdit.Text = null;
            this.rolComboBox.Text = null;
            this.cedulaTextBox.Focus();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (this.fotoPictureBox.Image == null)
            {
                MessageBox.Show("Falta la foto", "Error");
            }
            else
            {
                if (string.IsNullOrEmpty(this.cedulaTextBox.Text))
                {
                    MessageBox.Show("Digite el documento", "Error");
                    this.cedulaTextBox.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.nombreTextEdit.Text))
                    {
                        MessageBox.Show("Digite el nombre", "Error");
                        this.nombreTextEdit.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.correoTextBox.Text))
                        {
                            MessageBox.Show("Digite el correo", "Error");
                            this.correoTextBox.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.usuarioTtextBox.Text))
                            {
                                MessageBox.Show("Digite el usuario", "Error");
                                this.usuarioTtextBox.Focus();
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(this.contrasenaTextEdit.Text))
                                {
                                    MessageBox.Show("Digite la contraseña", "Error");
                                    this.contrasenaTextEdit.Focus();
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(this.rolComboBox.Text))
                                    {
                                        MessageBox.Show("Seleccione el rol", "Error");
                                        this.rolComboBox.Focus();
                                    }
                                    else
                                    {
                                        this.contrasenaTextEdit.Text = Encriptar.Encriptar1(this.contrasenaTextEdit.Text);
                                        //para uicarse en la misma posicion
                                        Globales.GuardarUsuario(this);
                                        if (Globales.TipoCrud==1)
                                        {
                                            //se desplaza a el ultimo registro si es inserter
                                            this.MoveLastItem.PerformClick();
                                        }
                                        if (Globales.TipoCrud == 2)
                                        {
                                            //para que el binding navigator se ubique bien
                                            this.Buscar.Text = null;
                                            this.bindingNavigatorPositionItem.Focus();
                                            this.Buscar.Focus();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            Globales.TipoCrud = 2;//actualizar
            this.Buscar.Text = this.cedulaTextBox.Text;
            this.contrasenaTextEdit.Text = Encriptar.Descencriptar1(this.contrasenaTextEdit.Text);
            this.contrasenaTextEdit.PasswordChar = '\0';
            this.groupBox2.Enabled = true;
            this.MoveFirstItem.Enabled = false;
            this.MovePreviousItem.Enabled = false;
            this.bindingNavigatorPositionItem.Enabled = false;
            this.bindingNavigatorCountItem.Enabled = false;
            this.MoveNextItem.Enabled = false;
            this.MoveLastItem.Enabled = false;
            this.BNuevo.Enabled = false;
            this.BGuardar.Enabled = true;
            this.BCancelar.Enabled = true;
            this.BEliminar.Enabled = false;
            this.BEditar.Enabled = false;
            this.Buscar.Enabled = false;
            this.BBuscar.Enabled = false;
            this.BTodosRegistros.Enabled = false;
            this.BFoto.Enabled = true;
            this.BEliminarFoto.Enabled = true;
            this.cedulaTextBox.Focus();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            //queda en el mismo registro
            this.Buscar.Text = this.cedulaTextBox.Text;
            this.groupBox2.Enabled = false;
            this.MoveFirstItem.Enabled = true;
            this.MovePreviousItem.Enabled = true;
            this.bindingNavigatorPositionItem.Enabled = true;
            this.bindingNavigatorCountItem.Enabled = true;
            this.MoveNextItem.Enabled = true;
            this.MoveLastItem.Enabled = true;
            this.BNuevo.Enabled = true;
            this.BGuardar.Enabled = false;
            this.BCancelar.Enabled = false;
            this.BEditar.Enabled = true;
            this.Buscar.Enabled = true;
            this.BEliminar.Enabled = true;
            this.BBuscar.Enabled = true;
            this.BTodosRegistros.Enabled = true;
            if (!(string.IsNullOrEmpty(this.contrasenaTextEdit.Text)))
            {
                this.contrasenaTextEdit.Text = Encriptar.Encriptar1(this.contrasenaTextEdit.Text);
            }
            else
            {
                return;
            }
            //devuelve los datos originales         
            if (Globales.TipoCrud == 1)
            {
                this.id_UsuarioTextBox.Text = Globales.Id_usuario;
                this.fotoPictureBox.Image = Globales.byteArrayToImage(Globales.Foto_usuario);
                this.cedulaTextBox.Text = Globales.cedula_usuario;
                this.nombreTextEdit.Text = Globales.Nombre_usuario;
                this.correoTextBox.Text = Globales.correo_usuario;
                this.usuarioTtextBox.Text = Globales.usuario_usuario;
                this.contrasenaTextEdit.Text = Globales.contrasena_usuario;
                this.rolComboBox.Text = Globales.rol_usuario;
                //para la posicion del registro
                this.Buscar.Text = this.cedulaTextBox.Text;
            }
            //se ubica en la posicion del registro modificado
            this.usuariosBindingSource.Position = this.usuariosBindingSource.Find("Cedula", this.Buscar.Text);
            //para que el binding navigator se ubique bien
            this.Buscar.Text = null;
            this.bindingNavigatorPositionItem.Focus();
            this.Buscar.Focus();
        }

        private void ModuloUsuarios_Load(object sender, EventArgs e)
        {
          
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.TodosUsuarios(this.dataSet1.Usuarios);
            //Verificar si existe registro
            Globales.VerificarRegisstros(this);
            if (this.usuariosBindingSource.Count > 0)
            {
                //integrar los componentes con los binding si existen registros
                this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usuariosBindingSource, "Foto", true));
                this.id_UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "IdUsuario", true));
                this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Cedula", true));
                this.nombreTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Nombre", true));
                this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Correo", true));
                this.usuarioTtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Usuario", true));
                this.contrasenaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Contrasena", true));
                this.rolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Rol", true));
                this.MoveFirstItem.PerformClick();
            }
        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = "Abrir archivo";
            this.openFileDialog1.Filter = "Image Files(*.png;*.jpg;*.jpge)|*.png;*.jpg;*.jpge";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.fotoPictureBox.Image = null;
                this.fotoPictureBox.Load(openFileDialog1.FileName);
                this.fotoPictureBox.Image =
                    System.Drawing.Image.FromFile(openFileDialog1.FileName);
                Bitmap imagen = new Bitmap(new Bitmap(fotoPictureBox.Image), 196, 240);
                this.fotoPictureBox.Image = imagen;
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar este registro?", "Eliminar registro",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)==DialogResult.Yes) 
            {
                if (string.IsNullOrEmpty(this.cedulaTextBox.Text))
                {
                    MessageBox.Show("Este registro no tiene numero de documento", "Error");
                }
                else
                {
                    General.VerificaExistenRegistros("Select * From Usuarios Where Cedula = " + "'" + this.cedulaTextBox.Text + "'");
                    if (!(string.IsNullOrEmpty(General.cadena)))
                    {
                        General.BuscarRegistros("Delete from Usuarios Where Cedula = " + "'" + this.cedulaTextBox.Text + "'");
                        Globales.VerificarRegisstros(this);
                        //Se desplaza a el ultimo registro
                        this.MoveLastItem.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("El numero de documento no existe", "Error");
                        this.Buscar.Focus();
                    }
                }
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Buscar.Text))
            {
                MessageBox.Show("Digite el numero de documento", "Error");
                this.Buscar.Focus();
            }
            else
            {
                General.BuscarRegistros("Select * From Usuarios Where Cedula = " + "'" + this.Buscar.Text + "'");
                if (General.temporal.Rows.Count > 0)
                {
                    Globales.LeerRegistrosUsuarios(this);
                }
                else
                {
                    this.BTodosRegistros.PerformClick();
                    MessageBox.Show("El numero de documento no existe", "Error");
                    this.Buscar.Focus();
                }
            }
        }

        private void BTodosRegistros_Click(object sender, EventArgs e)
        {
            Globales.VerificarRegisstros(this);
            Todos todos = new Todos();
            todos.ShowDialog();
        }

        private void BEliminarFoto_Click(object sender, EventArgs e)
        {
            this.fotoPictureBox.Image = null;

        }

        //private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.usuariosBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dataSet1);

        //}     
    }
}
