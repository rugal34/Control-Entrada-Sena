namespace ControlEntrada
{
    partial class EntradaSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaSalida));
            this.labelMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.idRegistroEntrada = new System.Windows.Forms.Label();
            this.registrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ControlEntrada.DataSet1();
            this.verificationControl1 = new DPFP.Gui.Verification.VerificationControl();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.verificacion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idPersonaTextBox = new System.Windows.Forms.TextBox();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noDedoTextBox = new System.Windows.Forms.TextBox();
            this.huellaPictureBox = new System.Windows.Forms.PictureBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.fichaTextBox = new System.Windows.Forms.TextBox();
            this.personasTableAdapter = new ControlEntrada.DataSet1TableAdapters.PersonasTableAdapter();
            this.tableAdapterManager = new ControlEntrada.DataSet1TableAdapters.TableAdapterManager();
            this.registrosTableAdapter = new ControlEntrada.DataSet1TableAdapters.RegistrosTableAdapter();
            idPersonaLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            primerApellidoLabel = new System.Windows.Forms.Label();
            segundoApellidoLabel = new System.Windows.Forms.Label();
            fichaLabel = new System.Windows.Forms.Label();
            huellaLabel = new System.Windows.Forms.Label();
            noDedoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huellaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idPersonaLabel
            // 
            idPersonaLabel.AutoSize = true;
            idPersonaLabel.Location = new System.Drawing.Point(1, 6);
            idPersonaLabel.Name = "idPersonaLabel";
            idPersonaLabel.Size = new System.Drawing.Size(61, 13);
            idPersonaLabel.TabIndex = 0;
            idPersonaLabel.Text = "Id Persona:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(11, 19);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 2;
            fotoLabel.Text = "Foto:";
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(223, 76);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(43, 13);
            cedulaLabel.TabIndex = 4;
            cedulaLabel.Text = "Cedula:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(223, 102);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Location = new System.Drawing.Point(223, 128);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(79, 13);
            primerApellidoLabel.TabIndex = 8;
            primerApellidoLabel.Text = "Primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Location = new System.Drawing.Point(223, 154);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(93, 13);
            segundoApellidoLabel.TabIndex = 10;
            segundoApellidoLabel.Text = "Segundo Apellido:";
            // 
            // fichaLabel
            // 
            fichaLabel.AutoSize = true;
            fichaLabel.Location = new System.Drawing.Point(223, 48);
            fichaLabel.Name = "fichaLabel";
            fichaLabel.Size = new System.Drawing.Size(36, 13);
            fichaLabel.TabIndex = 12;
            fichaLabel.Text = "Ficha:";
            // 
            // huellaLabel
            // 
            huellaLabel.AutoSize = true;
            huellaLabel.Location = new System.Drawing.Point(1, 29);
            huellaLabel.Name = "huellaLabel";
            huellaLabel.Size = new System.Drawing.Size(40, 13);
            huellaLabel.TabIndex = 14;
            huellaLabel.Text = "Huella:";
            // 
            // noDedoLabel
            // 
            noDedoLabel.AutoSize = true;
            noDedoLabel.Location = new System.Drawing.Point(1, 88);
            noDedoLabel.Name = "noDedoLabel";
            noDedoLabel.Size = new System.Drawing.Size(53, 13);
            noDedoLabel.TabIndex = 16;
            noDedoLabel.Text = "No Dedo:";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(12, 9);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(264, 22);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Registro de Entrada - Salida";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Controls.Add(this.labelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 39);
            this.panel1.TabIndex = 1;
            // 
            // cerrar
            // 
            this.cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrar.BackgroundImage")));
            this.cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Location = new System.Drawing.Point(660, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(42, 39);
            this.cerrar.TabIndex = 3;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.panel3);
            this.groupBox.Controls.Add(this.verificationControl1);
            this.groupBox.Controls.Add(this.Resultado);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.verificacion);
            this.groupBox.Controls.Add(this.panel2);
            this.groupBox.Controls.Add(fotoLabel);
            this.groupBox.Controls.Add(this.fotoPictureBox);
            this.groupBox.Controls.Add(cedulaLabel);
            this.groupBox.Controls.Add(this.cedulaTextBox);
            this.groupBox.Controls.Add(nombreLabel);
            this.groupBox.Controls.Add(this.nombreTextBox);
            this.groupBox.Controls.Add(primerApellidoLabel);
            this.groupBox.Controls.Add(this.primerApellidoTextBox);
            this.groupBox.Controls.Add(segundoApellidoLabel);
            this.groupBox.Controls.Add(this.segundoApellidoTextBox);
            this.groupBox.Controls.Add(fichaLabel);
            this.groupBox.Controls.Add(this.fichaTextBox);
            this.groupBox.Location = new System.Drawing.Point(16, 57);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(668, 427);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.idRegistroEntrada);
            this.panel3.Location = new System.Drawing.Point(390, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 19);
            this.panel3.TabIndex = 25;
            // 
            // idRegistroEntrada
            // 
            this.idRegistroEntrada.AutoSize = true;
            this.idRegistroEntrada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrosBindingSource, "Id_Entrada", true));
            this.idRegistroEntrada.Location = new System.Drawing.Point(12, 12);
            this.idRegistroEntrada.Name = "idRegistroEntrada";
            this.idRegistroEntrada.Size = new System.Drawing.Size(91, 13);
            this.idRegistroEntrada.TabIndex = 24;
            this.idRegistroEntrada.Text = "idRegistroEntrada";
            // 
            // registrosBindingSource
            // 
            this.registrosBindingSource.DataMember = "Registros";
            this.registrosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verificationControl1
            // 
            this.verificationControl1.Active = true;
            this.verificationControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verificationControl1.Location = new System.Drawing.Point(603, 41);
            this.verificationControl1.Name = "verificationControl1";
            this.verificationControl1.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.verificationControl1.Size = new System.Drawing.Size(48, 47);
            this.verificationControl1.TabIndex = 23;
            this.verificationControl1.OnComplete += new DPFP.Gui.Verification.VerificationControl._OnComplete(this.verificationControl1_OnComplete);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(496, 69);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(86, 20);
            this.Resultado.TabIndex = 22;
            this.Resultado.TextChanged += new System.EventHandler(this.Resultado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(51, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(51, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
            this.label2.TabIndex = 20;
            // 
            // verificacion
            // 
            this.verificacion.AutoSize = true;
            this.verificacion.Location = new System.Drawing.Point(493, 48);
            this.verificacion.Name = "verificacion";
            this.verificacion.Size = new System.Drawing.Size(62, 13);
            this.verificacion.TabIndex = 19;
            this.verificacion.Text = "Verificacion";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.idPersonaTextBox);
            this.panel2.Controls.Add(idPersonaLabel);
            this.panel2.Controls.Add(this.noDedoTextBox);
            this.panel2.Controls.Add(noDedoLabel);
            this.panel2.Controls.Add(this.huellaPictureBox);
            this.panel2.Controls.Add(huellaLabel);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(640, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 10);
            this.panel2.TabIndex = 18;
            // 
            // idPersonaTextBox
            // 
            this.idPersonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "IdPersona", true));
            this.idPersonaTextBox.Location = new System.Drawing.Point(100, 3);
            this.idPersonaTextBox.Name = "idPersonaTextBox";
            this.idPersonaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idPersonaTextBox.TabIndex = 1;
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "Personas";
            this.personasBindingSource.DataSource = this.dataSet1;
            // 
            // noDedoTextBox
            // 
            this.noDedoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "NoDedo", true));
            this.noDedoTextBox.Location = new System.Drawing.Point(100, 85);
            this.noDedoTextBox.Name = "noDedoTextBox";
            this.noDedoTextBox.Size = new System.Drawing.Size(100, 20);
            this.noDedoTextBox.TabIndex = 17;
            // 
            // huellaPictureBox
            // 
            this.huellaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.personasBindingSource, "Huella", true));
            this.huellaPictureBox.Location = new System.Drawing.Point(100, 29);
            this.huellaPictureBox.Name = "huellaPictureBox";
            this.huellaPictureBox.Size = new System.Drawing.Size(100, 50);
            this.huellaPictureBox.TabIndex = 15;
            this.huellaPictureBox.TabStop = false;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.personasBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(39, 35);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(173, 142);
            this.fotoPictureBox.TabIndex = 3;
            this.fotoPictureBox.TabStop = false;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Cedula", true));
            this.cedulaTextBox.Location = new System.Drawing.Point(322, 73);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(157, 20);
            this.cedulaTextBox.TabIndex = 5;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(322, 99);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(329, 20);
            this.nombreTextBox.TabIndex = 7;
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "PrimerApellido", true));
            this.primerApellidoTextBox.Location = new System.Drawing.Point(322, 125);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(329, 20);
            this.primerApellidoTextBox.TabIndex = 9;
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "SegundoApellido", true));
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(322, 151);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(329, 20);
            this.segundoApellidoTextBox.TabIndex = 11;
            // 
            // fichaTextBox
            // 
            this.fichaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Ficha", true));
            this.fichaTextBox.Location = new System.Drawing.Point(322, 45);
            this.fichaTextBox.Name = "fichaTextBox";
            this.fichaTextBox.Size = new System.Drawing.Size(157, 20);
            this.fichaTextBox.TabIndex = 13;
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
            // registrosTableAdapter
            // 
            this.registrosTableAdapter.ClearBeforeFill = true;
            // 
            // ModuloEntradaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 498);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModuloEntradaSalida";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModuloEntradaSalida";
            this.Load += new System.EventHandler(this.ModuloEntradaSalida_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huellaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button cerrar;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private DataSet1TableAdapters.PersonasTableAdapter personasTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label verificacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox idPersonaTextBox;
        private System.Windows.Forms.TextBox noDedoTextBox;
        private System.Windows.Forms.PictureBox huellaPictureBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox primerApellidoTextBox;
        private System.Windows.Forms.TextBox segundoApellidoTextBox;
        private System.Windows.Forms.TextBox fichaTextBox;
        private DPFP.Gui.Verification.VerificationControl verificationControl1;
        public System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.BindingSource registrosBindingSource;
        private DataSet1TableAdapters.RegistrosTableAdapter registrosTableAdapter;
        private System.Windows.Forms.Label idRegistroEntrada;
        private System.Windows.Forms.Panel panel3;
    }
}