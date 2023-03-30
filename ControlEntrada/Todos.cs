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
    public partial class Todos : Form
    {
        public Todos()
        {
            InitializeComponent();
        }

        //private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.usuariosBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dataSet1);

        //}

        private void ModuloTodos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.TodosUsuarios(this.dataSet1.Usuarios);

        }
    }
}
