namespace ControlEntrada
{
    partial class Personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.enrollmentControl1 = new DPFP.Gui.Enrollment.EnrollmentControl();
            this.personasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ControlEntrada.DataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editarPersona = new System.Windows.Forms.ToolStripButton();
            this.EliminarPersona = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Buscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Imprimir = new System.Windows.Forms.ToolStripButton();
            this.idPersonaTextBox = new System.Windows.Forms.TextBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.fichaTextBox = new System.Windows.Forms.TextBox();
            this.noDedoTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.huellaPictureBox = new System.Windows.Forms.PictureBox();
            this.personasDataGridView = new System.Windows.Forms.DataGridView();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.personasTableAdapter = new ControlEntrada.DataSet1TableAdapters.PersonasTableAdapter();
            this.tableAdapterManager = new ControlEntrada.DataSet1TableAdapters.TableAdapterManager();
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
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingNavigator)).BeginInit();
            this.personasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.huellaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idPersonaLabel
            // 
            idPersonaLabel.AutoSize = true;
            idPersonaLabel.Location = new System.Drawing.Point(14, 29);
            idPersonaLabel.Name = "idPersonaLabel";
            idPersonaLabel.Size = new System.Drawing.Size(61, 13);
            idPersonaLabel.TabIndex = 12;
            idPersonaLabel.Text = "Id Persona:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(511, 108);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 14;
            fotoLabel.Text = "Foto:";
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(4, 390);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(43, 13);
            cedulaLabel.TabIndex = 16;
            cedulaLabel.Text = "Cedula:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(166, 390);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 18;
            nombreLabel.Text = "Nombre:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Location = new System.Drawing.Point(322, 390);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(79, 13);
            primerApellidoLabel.TabIndex = 20;
            primerApellidoLabel.Text = "Primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Location = new System.Drawing.Point(481, 390);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(93, 13);
            segundoApellidoLabel.TabIndex = 22;
            segundoApellidoLabel.Text = "Segundo Apellido:";
            // 
            // fichaLabel
            // 
            fichaLabel.AutoSize = true;
            fichaLabel.Location = new System.Drawing.Point(640, 390);
            fichaLabel.Name = "fichaLabel";
            fichaLabel.Size = new System.Drawing.Size(36, 13);
            fichaLabel.TabIndex = 24;
            fichaLabel.Text = "Ficha:";
            // 
            // huellaLabel
            // 
            huellaLabel.AutoSize = true;
            huellaLabel.Location = new System.Drawing.Point(14, 52);
            huellaLabel.Name = "huellaLabel";
            huellaLabel.Size = new System.Drawing.Size(40, 13);
            huellaLabel.TabIndex = 26;
            huellaLabel.Text = "Huella:";
            // 
            // noDedoLabel
            // 
            noDedoLabel.AutoSize = true;
            noDedoLabel.Location = new System.Drawing.Point(14, 111);
            noDedoLabel.Name = "noDedoLabel";
            noDedoLabel.Size = new System.Drawing.Size(53, 13);
            noDedoLabel.TabIndex = 28;
            noDedoLabel.Text = "No Dedo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Controls.Add(this.labelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 39);
            this.panel1.TabIndex = 10;
            // 
            // cerrar
            // 
            this.cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrar.BackgroundImage")));
            this.cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Location = new System.Drawing.Point(752, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(42, 39);
            this.cerrar.TabIndex = 2;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(12, 9);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(201, 22);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Registro de personas";
            // 
            // enrollmentControl1
            // 
            this.enrollmentControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enrollmentControl1.EnrolledFingerMask = 0;
            this.enrollmentControl1.Location = new System.Drawing.Point(0, 66);
            this.enrollmentControl1.MaxEnrollFingerCount = 10;
            this.enrollmentControl1.Name = "enrollmentControl1";
            this.enrollmentControl1.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.enrollmentControl1.Size = new System.Drawing.Size(492, 314);
            this.enrollmentControl1.TabIndex = 11;
            // 
            // personasBindingNavigator
            // 
            this.personasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personasBindingNavigator.BindingSource = this.personasBindingSource;
            this.personasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personasBindingNavigator.DeleteItem = null;
            this.personasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.editarPersona,
            this.EliminarPersona,
            this.toolStripSeparator1,
            this.Buscar,
            this.toolStripSeparator2,
            this.Imprimir});
            this.personasBindingNavigator.Location = new System.Drawing.Point(0, 39);
            this.personasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personasBindingNavigator.Name = "personasBindingNavigator";
            this.personasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personasBindingNavigator.Size = new System.Drawing.Size(797, 25);
            this.personasBindingNavigator.TabIndex = 12;
            this.personasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "Personas";
            this.personasBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // editarPersona
            // 
            this.editarPersona.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editarPersona.Image = ((System.Drawing.Image)(resources.GetObject("editarPersona.Image")));
            this.editarPersona.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editarPersona.Name = "editarPersona";
            this.editarPersona.Size = new System.Drawing.Size(23, 22);
            this.editarPersona.Text = "toolStripButton1";
            this.editarPersona.ToolTipText = "Editar";
            this.editarPersona.Click += new System.EventHandler(this.editarPersona_Click);
            // 
            // EliminarPersona
            // 
            this.EliminarPersona.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EliminarPersona.Image = ((System.Drawing.Image)(resources.GetObject("EliminarPersona.Image")));
            this.EliminarPersona.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EliminarPersona.Name = "EliminarPersona";
            this.EliminarPersona.Size = new System.Drawing.Size(23, 22);
            this.EliminarPersona.Text = "toolStripButton2";
            this.EliminarPersona.ToolTipText = "Eliminar";
            this.EliminarPersona.Click += new System.EventHandler(this.EliminarPersona_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(100, 25);
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Imprimir
            // 
            this.Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Imprimir.Image")));
            this.Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(23, 22);
            this.Imprimir.ToolTipText = "Imprimir";
            // 
            // idPersonaTextBox
            // 
            this.idPersonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "IdPersona", true));
            this.idPersonaTextBox.Location = new System.Drawing.Point(113, 26);
            this.idPersonaTextBox.Name = "idPersonaTextBox";
            this.idPersonaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idPersonaTextBox.TabIndex = 13;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Cedula", true));
            this.cedulaTextBox.Location = new System.Drawing.Point(7, 406);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(147, 20);
            this.cedulaTextBox.TabIndex = 17;
            this.cedulaTextBox.TextChanged += new System.EventHandler(this.cedulaTextBox_TextChanged);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(166, 406);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(147, 20);
            this.nombreTextBox.TabIndex = 19;
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "PrimerApellido", true));
            this.primerApellidoTextBox.Location = new System.Drawing.Point(325, 406);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(147, 20);
            this.primerApellidoTextBox.TabIndex = 21;
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "SegundoApellido", true));
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(484, 406);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(147, 20);
            this.segundoApellidoTextBox.TabIndex = 23;
            // 
            // fichaTextBox
            // 
            this.fichaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Ficha", true));
            this.fichaTextBox.Location = new System.Drawing.Point(643, 406);
            this.fichaTextBox.Name = "fichaTextBox";
            this.fichaTextBox.Size = new System.Drawing.Size(147, 20);
            this.fichaTextBox.TabIndex = 25;
            // 
            // noDedoTextBox
            // 
            this.noDedoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "NoDedo", true));
            this.noDedoTextBox.Location = new System.Drawing.Point(113, 108);
            this.noDedoTextBox.Name = "noDedoTextBox";
            this.noDedoTextBox.Size = new System.Drawing.Size(100, 20);
            this.noDedoTextBox.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(idPersonaLabel);
            this.panel2.Controls.Add(this.idPersonaTextBox);
            this.panel2.Controls.Add(huellaLabel);
            this.panel2.Controls.Add(this.huellaPictureBox);
            this.panel2.Controls.Add(noDedoLabel);
            this.panel2.Controls.Add(this.noDedoTextBox);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(514, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(23, 21);
            this.panel2.TabIndex = 30;
            // 
            // huellaPictureBox
            // 
            this.huellaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.personasBindingSource, "Huella", true));
            this.huellaPictureBox.Location = new System.Drawing.Point(113, 52);
            this.huellaPictureBox.Name = "huellaPictureBox";
            this.huellaPictureBox.Size = new System.Drawing.Size(100, 50);
            this.huellaPictureBox.TabIndex = 27;
            this.huellaPictureBox.TabStop = false;
            // 
            // personasDataGridView
            // 
            this.personasDataGridView.AllowUserToAddRows = false;
            this.personasDataGridView.AllowUserToDeleteRows = false;
            this.personasDataGridView.AutoGenerateColumns = false;
            this.personasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personasDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.personasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Foto,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.personasDataGridView.DataSource = this.personasBindingSource;
            this.personasDataGridView.Location = new System.Drawing.Point(7, 432);
            this.personasDataGridView.Name = "personasDataGridView";
            this.personasDataGridView.ReadOnly = true;
            this.personasDataGridView.Size = new System.Drawing.Size(783, 118);
            this.personasDataGridView.TabIndex = 30;
            this.personasDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personasDataGridView_CellClick);
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cedula";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cedula";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrimerApellido";
            this.dataGridViewTextBoxColumn4.HeaderText = "PrimerApellido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SegundoApellido";
            this.dataGridViewTextBoxColumn5.HeaderText = "SegundoApellido";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ficha";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ficha";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NoDedo";
            this.dataGridViewTextBoxColumn7.HeaderText = "NoDedo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.personasBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(531, 134);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(204, 194);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPictureBox.TabIndex = 15;
            this.fotoPictureBox.TabStop = false;
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
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 562);
            this.Controls.Add(this.personasDataGridView);
            this.Controls.Add(this.panel2);
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
            this.Controls.Add(this.personasBindingNavigator);
            this.Controls.Add(this.enrollmentControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Personal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModuloPersonas";
            this.Load += new System.EventHandler(this.Personal_Load);
            this.Click += new System.EventHandler(this.Personal_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingNavigator)).EndInit();
            this.personasBindingNavigator.ResumeLayout(false);
            this.personasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.huellaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button cerrar;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox idPersonaTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox primerApellidoTextBox;
        private System.Windows.Forms.TextBox segundoApellidoTextBox;
        private System.Windows.Forms.TextBox fichaTextBox;
        private System.Windows.Forms.PictureBox huellaPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView personasDataGridView;
        public System.Windows.Forms.TextBox noDedoTextBox;
        public DPFP.Gui.Enrollment.EnrollmentControl enrollmentControl1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox Buscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton editarPersona;
        private System.Windows.Forms.ToolStripButton EliminarPersona;
        private System.Windows.Forms.ToolStripButton Imprimir;
        public DataSet1TableAdapters.PersonasTableAdapter personasTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}