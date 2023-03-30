namespace ControlEntrada
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mostrarRol = new System.Windows.Forms.Label();
            this.cerrar = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.AcercaDe = new System.Windows.Forms.PictureBox();
            this.labelMenu2 = new System.Windows.Forms.Label();
            this.btnUsuariosSistema = new System.Windows.Forms.Button();
            this.btnRegistroPersona = new System.Windows.Forms.Button();
            this.btnRegEntradaSalida = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcercaDe)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.mostrarRol);
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Controls.Add(this.labelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 39);
            this.panel1.TabIndex = 0;
            // 
            // mostrarRol
            // 
            this.mostrarRol.AutoSize = true;
            this.mostrarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarRol.ForeColor = System.Drawing.Color.White;
            this.mostrarRol.Location = new System.Drawing.Point(277, 11);
            this.mostrarRol.Name = "mostrarRol";
            this.mostrarRol.Size = new System.Drawing.Size(51, 20);
            this.mostrarRol.TabIndex = 22;
            this.mostrarRol.Text = "label1";
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrar.BackgroundImage")));
            this.cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Location = new System.Drawing.Point(964, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(42, 39);
            this.cerrar.TabIndex = 8;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(6, 7);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(261, 24);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Control de Entrada - Salida";
            // 
            // AcercaDe
            // 
            this.AcercaDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AcercaDe.Image = ((System.Drawing.Image)(resources.GetObject("AcercaDe.Image")));
            this.AcercaDe.Location = new System.Drawing.Point(168, 61);
            this.AcercaDe.Name = "AcercaDe";
            this.AcercaDe.Size = new System.Drawing.Size(166, 172);
            this.AcercaDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AcercaDe.TabIndex = 1;
            this.AcercaDe.TabStop = false;
            this.AcercaDe.Click += new System.EventHandler(this.AcercaDe_Click);
            // 
            // labelMenu2
            // 
            this.labelMenu2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMenu2.AutoSize = true;
            this.labelMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(9)))));
            this.labelMenu2.Location = new System.Drawing.Point(340, 134);
            this.labelMenu2.Name = "labelMenu2";
            this.labelMenu2.Size = new System.Drawing.Size(498, 26);
            this.labelMenu2.TabIndex = 2;
            this.labelMenu2.Text = "CENTRO DE BIOTECNOLOGIA INDUSTRIAL";
            this.labelMenu2.Click += new System.EventHandler(this.labelMenu2_Click);
            // 
            // btnUsuariosSistema
            // 
            this.btnUsuariosSistema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuariosSistema.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsuariosSistema.BackgroundImage")));
            this.btnUsuariosSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUsuariosSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuariosSistema.FlatAppearance.BorderSize = 0;
            this.btnUsuariosSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosSistema.Location = new System.Drawing.Point(39, 90);
            this.btnUsuariosSistema.Name = "btnUsuariosSistema";
            this.btnUsuariosSistema.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUsuariosSistema.Size = new System.Drawing.Size(102, 111);
            this.btnUsuariosSistema.TabIndex = 3;
            this.btnUsuariosSistema.Text = "Usuarios del Sistema";
            this.btnUsuariosSistema.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuariosSistema.UseVisualStyleBackColor = true;
            this.btnUsuariosSistema.Click += new System.EventHandler(this.btnUsuariosSistema_Click);
            // 
            // btnRegistroPersona
            // 
            this.btnRegistroPersona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistroPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistroPersona.BackgroundImage")));
            this.btnRegistroPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegistroPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistroPersona.FlatAppearance.BorderSize = 0;
            this.btnRegistroPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroPersona.Location = new System.Drawing.Point(177, 45);
            this.btnRegistroPersona.Name = "btnRegistroPersona";
            this.btnRegistroPersona.Size = new System.Drawing.Size(130, 156);
            this.btnRegistroPersona.TabIndex = 4;
            this.btnRegistroPersona.Text = "Registro de Personas";
            this.btnRegistroPersona.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistroPersona.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistroPersona.UseVisualStyleBackColor = true;
            this.btnRegistroPersona.Click += new System.EventHandler(this.btnRegistroPersona_Click);
            // 
            // btnRegEntradaSalida
            // 
            this.btnRegEntradaSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegEntradaSalida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegEntradaSalida.BackgroundImage")));
            this.btnRegEntradaSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegEntradaSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegEntradaSalida.FlatAppearance.BorderSize = 0;
            this.btnRegEntradaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegEntradaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEntradaSalida.Location = new System.Drawing.Point(353, 35);
            this.btnRegEntradaSalida.Name = "btnRegEntradaSalida";
            this.btnRegEntradaSalida.Size = new System.Drawing.Size(130, 166);
            this.btnRegEntradaSalida.TabIndex = 5;
            this.btnRegEntradaSalida.Text = "Registro de Entrada/Salida";
            this.btnRegEntradaSalida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegEntradaSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegEntradaSalida.UseVisualStyleBackColor = true;
            this.btnRegEntradaSalida.Click += new System.EventHandler(this.btnRegEntradaSalida_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportes.BackgroundImage")));
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(500, 45);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(130, 132);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.btnRegistroPersona);
            this.panel.Controls.Add(this.btnUsuariosSistema);
            this.panel.Controls.Add(this.btnRegEntradaSalida);
            this.panel.Controls.Add(this.btnReportes);
            this.panel.Location = new System.Drawing.Point(168, 239);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(796, 255);
            this.panel.TabIndex = 7;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrarSesion.AutoSize = true;
            this.BtnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.BtnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrarSesion.Image")));
            this.BtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(726, 178);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(112, 55);
            this.BtnCerrarSesion.TabIndex = 21;
            this.BtnCerrarSesion.Text = "Cerrar Sesión";
            this.BtnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtnCerrarSesion, "Cerrar sesión");
            this.BtnCerrarSesion.UseVisualStyleBackColor = false;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Cerrar Sesión";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(636, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 132);
            this.button1.TabIndex = 7;
            this.button1.Text = "A cerca de";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 506);
            this.Controls.Add(this.BtnCerrarSesion);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.labelMenu2);
            this.Controls.Add(this.AcercaDe);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerrar Sesión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcercaDe)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.PictureBox AcercaDe;
        private System.Windows.Forms.Label labelMenu2;
        private System.Windows.Forms.Button btnUsuariosSistema;
        private System.Windows.Forms.Button btnRegistroPersona;
        private System.Windows.Forms.Button btnRegEntradaSalida;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Label mostrarRol;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}