namespace ControlEntrada
{
    partial class EditarPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label primerApellidoLabel;
            System.Windows.Forms.Label segundoApellidoLabel;
            System.Windows.Forms.Label fichaLabel;
            System.Windows.Forms.Label idPersonaLabel1;
            System.Windows.Forms.Label huellaLabel1;
            System.Windows.Forms.Label noDedoLabel1;
            System.Windows.Forms.Label fotoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPersona));
            this.BEliminar = new System.Windows.Forms.PictureBox();
            this.BFoto = new System.Windows.Forms.PictureBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dataSet1 = new ControlEntrada.DataSet1();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personasTableAdapter = new ControlEntrada.DataSet1TableAdapters.PersonasTableAdapter();
            this.tableAdapterManager = new ControlEntrada.DataSet1TableAdapters.TableAdapterManager();
            this.idPersonaTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.fichaTextBox = new System.Windows.Forms.TextBox();
            this.huellaPictureBox = new System.Windows.Forms.PictureBox();
            this.noDedoTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enrollmentControl1 = new DPFP.Gui.Enrollment.EnrollmentControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            cedulaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            primerApellidoLabel = new System.Windows.Forms.Label();
            segundoApellidoLabel = new System.Windows.Forms.Label();
            fichaLabel = new System.Windows.Forms.Label();
            idPersonaLabel1 = new System.Windows.Forms.Label();
            huellaLabel1 = new System.Windows.Forms.Label();
            noDedoLabel1 = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huellaPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(47, 340);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(43, 13);
            cedulaLabel.TabIndex = 27;
            cedulaLabel.Text = "Cedula:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(200, 340);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 29;
            nombreLabel.Text = "Nombre:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Location = new System.Drawing.Point(353, 340);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(79, 13);
            primerApellidoLabel.TabIndex = 31;
            primerApellidoLabel.Text = "Primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Location = new System.Drawing.Point(506, 340);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(93, 13);
            segundoApellidoLabel.TabIndex = 33;
            segundoApellidoLabel.Text = "Segundo Apellido:";
            // 
            // fichaLabel
            // 
            fichaLabel.AutoSize = true;
            fichaLabel.Location = new System.Drawing.Point(659, 340);
            fichaLabel.Name = "fichaLabel";
            fichaLabel.Size = new System.Drawing.Size(36, 13);
            fichaLabel.TabIndex = 35;
            fichaLabel.Text = "Ficha:";
            // 
            // idPersonaLabel1
            // 
            idPersonaLabel1.AutoSize = true;
            idPersonaLabel1.Location = new System.Drawing.Point(23, 4);
            idPersonaLabel1.Name = "idPersonaLabel1";
            idPersonaLabel1.Size = new System.Drawing.Size(61, 13);
            idPersonaLabel1.TabIndex = 41;
            idPersonaLabel1.Text = "Id Persona:";
            // 
            // huellaLabel1
            // 
            huellaLabel1.AutoSize = true;
            huellaLabel1.Location = new System.Drawing.Point(23, 21);
            huellaLabel1.Name = "huellaLabel1";
            huellaLabel1.Size = new System.Drawing.Size(40, 13);
            huellaLabel1.TabIndex = 55;
            huellaLabel1.Text = "Huella:";
            // 
            // noDedoLabel1
            // 
            noDedoLabel1.AutoSize = true;
            noDedoLabel1.Location = new System.Drawing.Point(23, 80);
            noDedoLabel1.Name = "noDedoLabel1";
            noDedoLabel1.Size = new System.Drawing.Size(53, 13);
            noDedoLabel1.TabIndex = 57;
            noDedoLabel1.Text = "No Dedo:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(511, 49);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 25;
            fotoLabel.Text = "Foto:";
            // 
            // BEliminar
            // 
            this.BEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BEliminar.Image")));
            this.BEliminar.Location = new System.Drawing.Point(735, 162);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(51, 52);
            this.BEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BEliminar.TabIndex = 41;
            this.BEliminar.TabStop = false;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BFoto
            // 
            this.BFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BFoto.Image = ((System.Drawing.Image)(resources.GetObject("BFoto.Image")));
            this.BFoto.Location = new System.Drawing.Point(736, 89);
            this.BFoto.Name = "BFoto";
            this.BFoto.Size = new System.Drawing.Size(51, 50);
            this.BFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BFoto.TabIndex = 40;
            this.BFoto.TabStop = false;
            this.BFoto.Click += new System.EventHandler(this.BFoto_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(426, 412);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(86, 28);
            this.buttonCancelar.TabIndex = 39;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(294, 412);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(86, 28);
            this.BtnAgregar.TabIndex = 38;
            this.BtnAgregar.Text = "Guardar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "Personas";
            this.personasBindingSource.DataSource = this.dataSet1;
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonasTableAdapter = this.personasTableAdapter;
            this.tableAdapterManager.RegistrosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ControlEntrada.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // idPersonaTextBox
            // 
            this.idPersonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "IdPersona", true));
            this.idPersonaTextBox.Location = new System.Drawing.Point(122, 1);
            this.idPersonaTextBox.Name = "idPersonaTextBox";
            this.idPersonaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idPersonaTextBox.TabIndex = 42;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.personasBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(514, 65);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(204, 184);
            this.fotoPictureBox.TabIndex = 44;
            this.fotoPictureBox.TabStop = false;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Cedula", true));
            this.cedulaTextBox.Location = new System.Drawing.Point(34, 364);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(147, 20);
            this.cedulaTextBox.TabIndex = 46;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(187, 364);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(147, 20);
            this.nombreTextBox.TabIndex = 48;
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "PrimerApellido", true));
            this.primerApellidoTextBox.Location = new System.Drawing.Point(340, 364);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(145, 20);
            this.primerApellidoTextBox.TabIndex = 50;
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "SegundoApellido", true));
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(493, 364);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(147, 20);
            this.segundoApellidoTextBox.TabIndex = 52;
            // 
            // fichaTextBox
            // 
            this.fichaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Ficha", true));
            this.fichaTextBox.Location = new System.Drawing.Point(647, 364);
            this.fichaTextBox.Name = "fichaTextBox";
            this.fichaTextBox.Size = new System.Drawing.Size(131, 20);
            this.fichaTextBox.TabIndex = 54;
            // 
            // huellaPictureBox
            // 
            this.huellaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.personasBindingSource, "Huella", true));
            this.huellaPictureBox.Location = new System.Drawing.Point(122, 21);
            this.huellaPictureBox.Name = "huellaPictureBox";
            this.huellaPictureBox.Size = new System.Drawing.Size(100, 50);
            this.huellaPictureBox.TabIndex = 56;
            this.huellaPictureBox.TabStop = false;
            // 
            // noDedoTextBox
            // 
            this.noDedoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "NoDedo", true));
            this.noDedoTextBox.Location = new System.Drawing.Point(122, 77);
            this.noDedoTextBox.Name = "noDedoTextBox";
            this.noDedoTextBox.Size = new System.Drawing.Size(100, 20);
            this.noDedoTextBox.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(idPersonaLabel1);
            this.panel2.Controls.Add(this.idPersonaTextBox);
            this.panel2.Controls.Add(huellaLabel1);
            this.panel2.Controls.Add(this.huellaPictureBox);
            this.panel2.Controls.Add(noDedoLabel1);
            this.panel2.Controls.Add(this.noDedoTextBox);
            this.panel2.Location = new System.Drawing.Point(514, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 16);
            this.panel2.TabIndex = 59;
            // 
            // enrollmentControl1
            // 
            this.enrollmentControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enrollmentControl1.EnrolledFingerMask = 0;
            this.enrollmentControl1.Location = new System.Drawing.Point(-1, 0);
            this.enrollmentControl1.MaxEnrollFingerCount = 10;
            this.enrollmentControl1.Name = "enrollmentControl1";
            this.enrollmentControl1.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.enrollmentControl1.Size = new System.Drawing.Size(492, 314);
            this.enrollmentControl1.TabIndex = 60;
            this.enrollmentControl1.OnDelete += new DPFP.Gui.Enrollment.EnrollmentControl._OnDelete(this.enrollmentControl1_OnDelete);
            this.enrollmentControl1.OnEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnEnroll(this.enrollmentControl1_OnEnroll);
            this.enrollmentControl1.OnStartEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnStartEnroll(this.enrollmentControl1_OnStartEnroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ModuloEditarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.enrollmentControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.primerApellidoTextBox);
            this.Controls.Add(this.segundoApellidoTextBox);
            this.Controls.Add(this.fichaTextBox);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BFoto);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(primerApellidoLabel);
            this.Controls.Add(segundoApellidoLabel);
            this.Controls.Add(fichaLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModuloEditarPersona";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModuloEditarPersona";
            this.Load += new System.EventHandler(this.ModuloEditarPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huellaPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BEliminar;
        private System.Windows.Forms.PictureBox BFoto;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button BtnAgregar;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox fotoPictureBox;
        public System.Windows.Forms.TextBox cedulaTextBox;
        public System.Windows.Forms.TextBox nombreTextBox;
        public System.Windows.Forms.TextBox primerApellidoTextBox;
        public System.Windows.Forms.TextBox segundoApellidoTextBox;
        public System.Windows.Forms.TextBox fichaTextBox;
        private DPFP.Gui.Enrollment.EnrollmentControl enrollmentControl1;
        public System.Windows.Forms.TextBox idPersonaTextBox;
        public System.Windows.Forms.PictureBox huellaPictureBox;
        public System.Windows.Forms.TextBox noDedoTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public DataSet1TableAdapters.PersonasTableAdapter personasTableAdapter;
    }
}