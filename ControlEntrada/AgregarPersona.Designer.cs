namespace ControlEntrada
{
    partial class AgregarPersona
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
            System.Windows.Forms.Label idPersonaLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label primerApellidoLabel;
            System.Windows.Forms.Label segundoApellidoLabel;
            System.Windows.Forms.Label fichaLabel;
            System.Windows.Forms.Label huellaLabel;
            System.Windows.Forms.Label noDedoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPersona));
            this.enrollmentControl1 = new DPFP.Gui.Enrollment.EnrollmentControl();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.BFoto = new System.Windows.Forms.PictureBox();
            this.BEliminar = new System.Windows.Forms.PictureBox();
            idPersonaLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            primerApellidoLabel = new System.Windows.Forms.Label();
            segundoApellidoLabel = new System.Windows.Forms.Label();
            fichaLabel = new System.Windows.Forms.Label();
            huellaLabel = new System.Windows.Forms.Label();
            noDedoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huellaPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // idPersonaLabel
            // 
            idPersonaLabel.AutoSize = true;
            idPersonaLabel.Location = new System.Drawing.Point(8, 23);
            idPersonaLabel.Name = "idPersonaLabel";
            idPersonaLabel.Size = new System.Drawing.Size(61, 13);
            idPersonaLabel.TabIndex = 1;
            idPersonaLabel.Text = "Id Persona:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(515, 40);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 3;
            fotoLabel.Text = "Foto:";
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(40, 331);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(43, 13);
            cedulaLabel.TabIndex = 5;
            cedulaLabel.Text = "Cedula:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(193, 331);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Location = new System.Drawing.Point(346, 331);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(79, 13);
            primerApellidoLabel.TabIndex = 9;
            primerApellidoLabel.Text = "Primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Location = new System.Drawing.Point(499, 331);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(93, 13);
            segundoApellidoLabel.TabIndex = 11;
            segundoApellidoLabel.Text = "Segundo Apellido:";
            // 
            // fichaLabel
            // 
            fichaLabel.AutoSize = true;
            fichaLabel.Location = new System.Drawing.Point(652, 331);
            fichaLabel.Name = "fichaLabel";
            fichaLabel.Size = new System.Drawing.Size(36, 13);
            fichaLabel.TabIndex = 13;
            fichaLabel.Text = "Ficha:";
            // 
            // huellaLabel
            // 
            huellaLabel.AutoSize = true;
            huellaLabel.Location = new System.Drawing.Point(8, 38);
            huellaLabel.Name = "huellaLabel";
            huellaLabel.Size = new System.Drawing.Size(40, 13);
            huellaLabel.TabIndex = 15;
            huellaLabel.Text = "Huella:";
            // 
            // noDedoLabel
            // 
            noDedoLabel.AutoSize = true;
            noDedoLabel.Location = new System.Drawing.Point(8, 3);
            noDedoLabel.Name = "noDedoLabel";
            noDedoLabel.Size = new System.Drawing.Size(53, 13);
            noDedoLabel.TabIndex = 17;
            noDedoLabel.Text = "No Dedo:";
            // 
            // enrollmentControl1
            // 
            this.enrollmentControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enrollmentControl1.EnrolledFingerMask = 0;
            this.enrollmentControl1.Location = new System.Drawing.Point(2, 2);
            this.enrollmentControl1.MaxEnrollFingerCount = 10;
            this.enrollmentControl1.Name = "enrollmentControl1";
            this.enrollmentControl1.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.enrollmentControl1.Size = new System.Drawing.Size(492, 314);
            this.enrollmentControl1.TabIndex = 0;
            this.enrollmentControl1.OnDelete += new DPFP.Gui.Enrollment.EnrollmentControl._OnDelete(this.enrollmentControl1_OnDelete);
            this.enrollmentControl1.OnEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnEnroll(this.enrollmentControl1_OnEnroll);
            this.enrollmentControl1.OnStartEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnStartEnroll(this.enrollmentControl1_OnStartEnroll);
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
            this.idPersonaTextBox.Location = new System.Drawing.Point(107, 20);
            this.idPersonaTextBox.Name = "idPersonaTextBox";
            this.idPersonaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idPersonaTextBox.TabIndex = 2;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fotoPictureBox.Location = new System.Drawing.Point(518, 56);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(196, 171);
            this.fotoPictureBox.TabIndex = 4;
            this.fotoPictureBox.TabStop = false;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.Location = new System.Drawing.Point(27, 360);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(147, 20);
            this.cedulaTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(180, 360);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(147, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.Location = new System.Drawing.Point(333, 360);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(145, 20);
            this.primerApellidoTextBox.TabIndex = 10;
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(486, 360);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(147, 20);
            this.segundoApellidoTextBox.TabIndex = 12;
            // 
            // fichaTextBox
            // 
            this.fichaTextBox.Location = new System.Drawing.Point(639, 360);
            this.fichaTextBox.Name = "fichaTextBox";
            this.fichaTextBox.Size = new System.Drawing.Size(132, 20);
            this.fichaTextBox.TabIndex = 14;
            // 
            // huellaPictureBox
            // 
            this.huellaPictureBox.Location = new System.Drawing.Point(107, 38);
            this.huellaPictureBox.Name = "huellaPictureBox";
            this.huellaPictureBox.Size = new System.Drawing.Size(100, 50);
            this.huellaPictureBox.TabIndex = 16;
            this.huellaPictureBox.TabStop = false;
            // 
            // noDedoTextBox
            // 
            this.noDedoTextBox.Location = new System.Drawing.Point(107, 0);
            this.noDedoTextBox.Name = "noDedoTextBox";
            this.noDedoTextBox.Size = new System.Drawing.Size(100, 20);
            this.noDedoTextBox.TabIndex = 18;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(idPersonaLabel);
            this.panel1.Controls.Add(this.idPersonaTextBox);
            this.panel1.Controls.Add(huellaLabel);
            this.panel1.Controls.Add(this.huellaPictureBox);
            this.panel1.Controls.Add(noDedoLabel);
            this.panel1.Controls.Add(this.noDedoTextBox);
            this.panel1.Location = new System.Drawing.Point(565, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 19;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(287, 403);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(86, 28);
            this.BtnAgregar.TabIndex = 20;
            this.BtnAgregar.Text = "Guardar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(419, 403);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(86, 28);
            this.buttonCancelar.TabIndex = 21;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // BFoto
            // 
            this.BFoto.Image = ((System.Drawing.Image)(resources.GetObject("BFoto.Image")));
            this.BFoto.Location = new System.Drawing.Point(734, 82);
            this.BFoto.Name = "BFoto";
            this.BFoto.Size = new System.Drawing.Size(51, 52);
            this.BFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BFoto.TabIndex = 22;
            this.BFoto.TabStop = false;
            this.BFoto.Click += new System.EventHandler(this.BFoto_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BEliminar.Image")));
            this.BEliminar.Location = new System.Drawing.Point(734, 153);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(51, 52);
            this.BEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BEliminar.TabIndex = 23;
            this.BEliminar.TabStop = false;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // ModuloAgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BFoto);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(primerApellidoLabel);
            this.Controls.Add(this.primerApellidoTextBox);
            this.Controls.Add(segundoApellidoLabel);
            this.Controls.Add(this.segundoApellidoTextBox);
            this.Controls.Add(fichaLabel);
            this.Controls.Add(this.fichaTextBox);
            this.Controls.Add(this.enrollmentControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModuloAgregarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModuloAgregarPersona";
            this.Load += new System.EventHandler(this.ModuloAgregarPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huellaPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DPFP.Gui.Enrollment.EnrollmentControl enrollmentControl1;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox huellaPictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.PictureBox BFoto;
        private System.Windows.Forms.PictureBox BEliminar;
        public System.Windows.Forms.TextBox noDedoTextBox;
        public DataSet1TableAdapters.PersonasTableAdapter personasTableAdapter;
        public System.Windows.Forms.PictureBox fotoPictureBox;
        public System.Windows.Forms.TextBox cedulaTextBox;
        public System.Windows.Forms.TextBox nombreTextBox;
        public System.Windows.Forms.TextBox primerApellidoTextBox;
        public System.Windows.Forms.TextBox segundoApellidoTextBox;
        public System.Windows.Forms.TextBox fichaTextBox;
        public System.Windows.Forms.TextBox idPersonaTextBox;
        public DataSet1 dataSet1;
    }
}