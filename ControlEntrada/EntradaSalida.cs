using DPFP;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEntrada
{
    public partial class EntradaSalida : Form
    {
        public EntradaSalida()
        {
            InitializeComponent();
            Data = new AppData();
        }
        private AppData Data;
        string cedula = string.Empty;

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void personasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.personasBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dataSet1);

        //}

        private void ModuloEntradaSalida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Registros' Puede moverla o quitarla según sea necesario.
            this.registrosTableAdapter.Fill(this.dataSet1.Registros);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Personas' Puede moverla o quitarla según sea necesario.
            //this.personasTableAdapter.Fill(this.dataSet1.Personas);


        }

        private void verificationControl1_OnComplete(object Control, FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            DPFP.Verification.Verification ver = new DPFP.Verification.Verification();
            DPFP.Verification.Verification.Result res = new DPFP.Verification.Verification.Result();
            if (General.conexion.State == ConnectionState.Open)
            {
                General.conexion.Close();
            }
            SqlCommand command = new SqlCommand("Select Cedula, Huella From Personas", General.conexion);
            General.conexion.Open();
            SqlDataReader reader = command.ExecuteReader();
            cedula = string.Empty;
            this.Resultado.Text = string.Empty;
            while (reader.Read())
            {
                byte[] Huella = (byte[])reader["Huella"];
                cedula = reader["Cedula"].ToString();
                MemoryStream memoryStream = new MemoryStream(Huella);
                DPFP.Template tmpObj = new DPFP.Template();
                tmpObj.DeSerialize(memoryStream);
                if (tmpObj != null)
                {
                    //compare el conjunto de funciones con una plantilla en particular
                    ver.Verify(FeatureSet, tmpObj, ref res);
                    Data.IsFeatureSetMatched = res.Verified;
                    Data.FalseAcceptRate = res.FARAchieved;
                    if (res.Verified)
                    {
                        //MessageBox.Show("Bien");
                        this.Resultado.Text = cedula;
                        break;
                    }
                }
            }
            if (!res.Verified)
            {
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure;
                this.personasTableAdapter.BuscarIdPersona(this.dataSet1.Personas, -1);// limpiar data source
                this.Resultado.Text = "error";
                //MessageBox.Show("Mal");
            }
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {
            buscar_registro();
        }

        public void buscar_registro() 
        {
            
            if (!(string.IsNullOrEmpty(this.Resultado.Text)) && (this.Resultado.Text != "error"))
            {
                //traigo los datos de la tabla persona
                this.personasTableAdapter.BuscarPersonaCedula(this.dataSet1.Personas, this.Resultado.Text);
                this.label3.Visible= false;                
                GuardarInsertarRegistro();
            }
            else
            {
                //usuario no registrado en la tabla registro, por que la cedula o nis no existe
                this.label2.Visible = false;
                this.label3.Visible = true;
                this.label3.Text = "Usted no tiene acceso, Debe Registrarse";
            }
        }

        private void GuardarInsertarRegistro()
        {
            this.registrosTableAdapter.BuscarUltimaEntrada(this.dataSet1.Registros, Convert.ToInt32(this.idPersonaTextBox.Text));
            if (string.IsNullOrEmpty(this.idRegistroEntrada.Text))
            {
               this.registrosTableAdapter.GuardarRegistroEntrada(Convert.ToInt32(this.idPersonaTextBox.Text), DateTime.Now, "A", this.Resultado.Text, "Invitado");
                this.label2.Text = DateTime.Now.ToString();
                this.label3.Visible = true;
                this.label2.Visible = true;
                this.label3.Text = "Usted acaba de Ingresar";
                return;

            } else
            {
                this.registrosTableAdapter.ActualizarSalida (DateTime.Now, "I", Convert.ToInt32(this.idRegistroEntrada.Text));
                this.label2.Text = DateTime.Now.ToString();
                this.label3.Visible = true;
                this.label2.Visible = true;
                this.label3.Text = "Usted acaba de Salir";
                return;
            }
        }

    }
}
