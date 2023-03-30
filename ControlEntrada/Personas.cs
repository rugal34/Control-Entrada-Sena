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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
            this.cedulaTextBox.Enabled = false;
            this.nombreTextBox.Enabled = false;
            this.primerApellidoTextBox.Enabled = false;
            this.segundoApellidoTextBox.Enabled = false;
            this.fichaTextBox.Enabled = false;
            this.fotoPictureBox.Enabled = false;
            this.personasTableAdapter.Fill(this.dataSet1.Personas);

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        //private void personasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.personasBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dataSet1);

        //}

        private void Personal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.dataSet1.Personas);

        }

        private void cedulaTextBox_TextChanged(object sender, EventArgs e)
        {
            Globales.SeleccionarDedo(this);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AgregarPersona agregarPersona = new AgregarPersona();
           
            DialogResult result = agregarPersona.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                this.personasTableAdapter.Fill(this.dataSet1.Personas);
            }
       
        }

        private void editarPersona_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Globales.Ced))
            {
                MessageBox.Show("Por favor seleccione el registro a editar", "Notificacion");
            }
            else
            {
                EditarPersona editarPersona = new EditarPersona();
                DialogResult result = editarPersona.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    this.personasTableAdapter.Fill(this.dataSet1.Personas);
                }
            }
            Globales.Ced = string.Empty;           
        }

        private void EliminarPersona_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Globales.Ced))
            {
                MessageBox.Show("Por favor seleccione el registro a eliminar", "Notificacion");
            }
            else if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar registro",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                try
                {
                    this.personasTableAdapter.EliminarPersonasByDocumento(Globales.Ced);
                    MessageBox.Show("El registro se ha eliminado con exito", "Notificación");
                    Globales.Ced = string.Empty;
                    this.personasTableAdapter.Fill(this.dataSet1.Personas);
                }
                catch (Exception)
                {

                    MessageBox.Show("No se puede borrar el usuario por que tiene entradas y saliidas", "Notificación");
                }
                
            }
       
        }

        private void personasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                Globales.Ced = (personasDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            this.personasTableAdapter.BusquedaIndexada(this.dataSet1.Personas, this.Buscar.Text, this.Buscar.Text,
               this.Buscar.Text, this.Buscar.Text, this.Buscar.Text);
        }

        private void Personal_Click(object sender, EventArgs e)
        {
            this.personasTableAdapter.Fill(this.dataSet1.Personas);
        }
    }
}
