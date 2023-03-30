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
    public partial class EditarPersona : Form
    {

        public AppData Data;
        public int i;
        public EditarPersona()
        {
            InitializeComponent();
            Data = new AppData();

        }

        private void ModuloEditarPersona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Personas' Puede moverla o quitarla según sea necesario.
            //this.personasTableAdapter.Fill(this.dataSet1.Personas);
            this.personasTableAdapter.BuscarPersonaCedula(this.dataSet1.Personas, Globales.Ced);

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void enrollmentControl1_OnDelete(object Control, int FingerMask, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            if (Data.IsEventHandlerSucceeds)
            {
                Data.Templates[FingerMask - 1] = null; //clear the finger template
            }
            else
            {
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure;
            }
        }

        private void enrollmentControl1_OnEnroll(object Control, int FingerMask, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            if (Data.IsEventHandlerSucceeds)
            {
                Globales.LimpiarHuellaEditar(this);
                Data.Templates[FingerMask - 1] = Template; //store a finger 
                //ListEvent.Items(0,String.Format("OnEnroll: finger {0}",Finger));
            }
            else
            {
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure; //force a "failure" status
            }
        }

        private void enrollmentControl1_OnStartEnroll(object Control, string ReaderSerialNumber, int Finger)
        {
            this.noDedoTextBox.Text = Finger.ToString();
        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = "Abrir archivo";
            this.openFileDialog1.Filter = "Image File(*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png|All files(*.*)|*.*";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.fotoPictureBox.Image = null;
                this.fotoPictureBox.Load(openFileDialog1.FileName);
                this.fotoPictureBox.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                Bitmap imagen = new Bitmap(new Bitmap(fotoPictureBox.Image), 184, 184);
                this.fotoPictureBox.Image = imagen;
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            this.fotoPictureBox.Image = null;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int cantidadHuellas;
            if (this.fotoPictureBox.Image == null)
            {
                MessageBox.Show("Por favor seleccione una foto");
                this.BFoto.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.cedulaTextBox.Text))
                {
                    MessageBox.Show("Por favor digite el número de cedula");
                    this.cedulaTextBox.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.nombreTextBox.Text))
                    {
                        MessageBox.Show("Por favor digite el nombre");
                        this.nombreTextBox.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.primerApellidoTextBox.Text))
                        {
                            MessageBox.Show("Por favor digite el primer apellido");
                            this.primerApellidoTextBox.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.segundoApellidoTextBox.Text))
                            {
                                MessageBox.Show("Por favor digite el segundo apellido");
                                this.segundoApellidoTextBox.Focus();
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(this.fichaTextBox.Text))
                                {
                                    MessageBox.Show("Por favor digite el número de la ficha");
                                    this.fichaTextBox.Focus();
                                }
                                else
                                {
                                    cantidadHuellas = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        if ((Data.Templates[i] != null))
                                        {
                                            cantidadHuellas++;
                                        }
                                    }
                                    if ((cantidadHuellas == 0) && (this.enrollmentControl1.EnrolledFingerMask == 0))
                                    {
                                        MessageBox.Show("No se puede guardar el registro, debe registrar mínimo una huella dactilar", "Error");
                                        this.cedulaTextBox.Focus();
                                    }
                                    else
                                    {
                                        try
                                        {
                                            cantidadHuellas = 0;
                                            for (int i = 0; i < 10; i++)
                                            {
                                                if ((Data.Templates[i] != null))
                                                {
                                                    cantidadHuellas++;
                                                    this.noDedoTextBox.Text = (i + 1).ToString();
                                                    this.i = i;
                                                    Globales.ModificarPersona(this);
                                                    this.Close();
                                                }
                                            }
                                            if (cantidadHuellas == 0)
                                            {
                                                if (this.enrollmentControl1.EnrolledFingerMask != 0)
                                                {
                                                    Globales.ModificarPersona(this);
                                                    this.Close();
                                                }
                                            }
                                        }
                                        catch (Exception e1)
                                        {
                                            MessageBox.Show("No se puede guardar el registro en la base de datos" + e1.ToString(), "Error");
                                            this.cedulaTextBox.Focus();
                                            //throw;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
