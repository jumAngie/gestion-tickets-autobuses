﻿namespace Gestion_De_Tickets_Autobus
{
    partial class frmCliente
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
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.gbDNI = new System.Windows.Forms.GroupBox();
            this.txtDNIE = new System.Windows.Forms.TextBox();
            this.lblDNIE = new System.Windows.Forms.Label();
            this.mtxtidentidad = new System.Windows.Forms.MaskedTextBox();
            this.lblidentidad = new System.Windows.Forms.Label();
            this.rbE = new System.Windows.Forms.RadioButton();
            this.rbH = new System.Windows.Forms.RadioButton();
            this.lblDNI = new System.Windows.Forms.Label();
            this.pnlDNI = new System.Windows.Forms.Panel();
            this.pnlDNIE = new System.Windows.Forms.Panel();
            this.gbDatosdeContacto = new System.Windows.Forms.GroupBox();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.txtDirE = new System.Windows.Forms.TextBox();
            this.lblDirE = new System.Windows.Forms.Label();
            this.cbxciudad = new System.Windows.Forms.ComboBox();
            this.cbxdepto = new System.Windows.Forms.ComboBox();
            this.cbxpais = new System.Windows.Forms.ComboBox();
            this.lblciudad = new System.Windows.Forms.Label();
            this.lbldepto = new System.Windows.Forms.Label();
            this.lblpais = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.pnlciudad = new System.Windows.Forms.Panel();
            this.pnlDIRE = new System.Windows.Forms.Panel();
            this.pnlTel = new System.Windows.Forms.Panel();
            this.pnlcorreo = new System.Windows.Forms.Panel();
            this.pnldepto = new System.Windows.Forms.Panel();
            this.pnlpais = new System.Windows.Forms.Panel();
            this.gbDatospersonales = new System.Windows.Forms.GroupBox();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechanacimiento = new System.Windows.Forms.Label();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.lblsexo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlnombre = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPersonaExistente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.gbDNI.SuspendLayout();
            this.gbDatosdeContacto.SuspendLayout();
            this.gbDatospersonales.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(25, 421);
            this.dgClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.Size = new System.Drawing.Size(1048, 268);
            this.dgClientes.TabIndex = 16;
            this.dgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellClick);
            // 
            // gbDNI
            // 
            this.gbDNI.Controls.Add(this.txtDNIE);
            this.gbDNI.Controls.Add(this.lblDNIE);
            this.gbDNI.Controls.Add(this.mtxtidentidad);
            this.gbDNI.Controls.Add(this.lblidentidad);
            this.gbDNI.Controls.Add(this.rbE);
            this.gbDNI.Controls.Add(this.rbH);
            this.gbDNI.Controls.Add(this.lblDNI);
            this.gbDNI.Controls.Add(this.pnlDNI);
            this.gbDNI.Controls.Add(this.pnlDNIE);
            this.gbDNI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbDNI.Location = new System.Drawing.Point(17, 191);
            this.gbDNI.Margin = new System.Windows.Forms.Padding(4);
            this.gbDNI.Name = "gbDNI";
            this.gbDNI.Padding = new System.Windows.Forms.Padding(4);
            this.gbDNI.Size = new System.Drawing.Size(512, 167);
            this.gbDNI.TabIndex = 12;
            this.gbDNI.TabStop = false;
            this.gbDNI.Text = "Datos de Identificación:";
            // 
            // txtDNIE
            // 
            this.txtDNIE.Location = new System.Drawing.Point(228, 95);
            this.txtDNIE.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNIE.Name = "txtDNIE";
            this.txtDNIE.Size = new System.Drawing.Size(213, 22);
            this.txtDNIE.TabIndex = 8;
            this.txtDNIE.Visible = false;
            this.txtDNIE.Leave += new System.EventHandler(this.txtDNIE_Leave);
            // 
            // lblDNIE
            // 
            this.lblDNIE.AutoSize = true;
            this.lblDNIE.Location = new System.Drawing.Point(224, 73);
            this.lblDNIE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNIE.Name = "lblDNIE";
            this.lblDNIE.Size = new System.Drawing.Size(206, 16);
            this.lblDNIE.TabIndex = 7;
            this.lblDNIE.Text = "Número de Identidad Extranjeros:";
            this.lblDNIE.Visible = false;
            // 
            // mtxtidentidad
            // 
            this.mtxtidentidad.Location = new System.Drawing.Point(33, 96);
            this.mtxtidentidad.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtidentidad.Mask = "0000-0000-00000";
            this.mtxtidentidad.Name = "mtxtidentidad";
            this.mtxtidentidad.Size = new System.Drawing.Size(159, 22);
            this.mtxtidentidad.TabIndex = 6;
            this.mtxtidentidad.Visible = false;
            this.mtxtidentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtidentidad_KeyPress);
            this.mtxtidentidad.Leave += new System.EventHandler(this.mtxtidentidad_Leave);
            // 
            // lblidentidad
            // 
            this.lblidentidad.AutoSize = true;
            this.lblidentidad.Location = new System.Drawing.Point(29, 73);
            this.lblidentidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidentidad.Name = "lblidentidad";
            this.lblidentidad.Size = new System.Drawing.Size(136, 16);
            this.lblidentidad.TabIndex = 5;
            this.lblidentidad.Text = "Número de Identidad:";
            this.lblidentidad.Visible = false;
            // 
            // rbE
            // 
            this.rbE.AutoSize = true;
            this.rbE.Location = new System.Drawing.Point(228, 43);
            this.rbE.Margin = new System.Windows.Forms.Padding(4);
            this.rbE.Name = "rbE";
            this.rbE.Size = new System.Drawing.Size(88, 20);
            this.rbE.TabIndex = 4;
            this.rbE.TabStop = true;
            this.rbE.Text = "Extranjero";
            this.rbE.UseVisualStyleBackColor = true;
            this.rbE.CheckedChanged += new System.EventHandler(this.rbE_CheckedChanged);
            // 
            // rbH
            // 
            this.rbH.AutoSize = true;
            this.rbH.Location = new System.Drawing.Point(29, 43);
            this.rbH.Margin = new System.Windows.Forms.Padding(4);
            this.rbH.Name = "rbH";
            this.rbH.Size = new System.Drawing.Size(95, 20);
            this.rbH.TabIndex = 3;
            this.rbH.TabStop = true;
            this.rbH.Text = "Hondureño";
            this.rbH.UseVisualStyleBackColor = true;
            this.rbH.CheckedChanged += new System.EventHandler(this.rbH_CheckedChanged);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(29, 22);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(91, 16);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "Nacionalidad:";
            // 
            // pnlDNI
            // 
            this.pnlDNI.BackColor = System.Drawing.Color.DarkRed;
            this.pnlDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDNI.Location = new System.Drawing.Point(33, 96);
            this.pnlDNI.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDNI.Name = "pnlDNI";
            this.pnlDNI.Size = new System.Drawing.Size(159, 29);
            this.pnlDNI.TabIndex = 13;
            this.pnlDNI.Visible = false;
            // 
            // pnlDNIE
            // 
            this.pnlDNIE.BackColor = System.Drawing.Color.DarkRed;
            this.pnlDNIE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDNIE.Location = new System.Drawing.Point(228, 96);
            this.pnlDNIE.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDNIE.Name = "pnlDNIE";
            this.pnlDNIE.Size = new System.Drawing.Size(214, 29);
            this.pnlDNIE.TabIndex = 14;
            this.pnlDNIE.Visible = false;
            // 
            // gbDatosdeContacto
            // 
            this.gbDatosdeContacto.Controls.Add(this.lblAdvertencia);
            this.gbDatosdeContacto.Controls.Add(this.txtDirE);
            this.gbDatosdeContacto.Controls.Add(this.lblDirE);
            this.gbDatosdeContacto.Controls.Add(this.cbxciudad);
            this.gbDatosdeContacto.Controls.Add(this.cbxdepto);
            this.gbDatosdeContacto.Controls.Add(this.cbxpais);
            this.gbDatosdeContacto.Controls.Add(this.lblciudad);
            this.gbDatosdeContacto.Controls.Add(this.lbldepto);
            this.gbDatosdeContacto.Controls.Add(this.lblpais);
            this.gbDatosdeContacto.Controls.Add(this.txtEmail);
            this.gbDatosdeContacto.Controls.Add(this.lblEmail);
            this.gbDatosdeContacto.Controls.Add(this.txtTelefono);
            this.gbDatosdeContacto.Controls.Add(this.lblTel);
            this.gbDatosdeContacto.Controls.Add(this.pnlciudad);
            this.gbDatosdeContacto.Controls.Add(this.pnlDIRE);
            this.gbDatosdeContacto.Controls.Add(this.pnlTel);
            this.gbDatosdeContacto.Controls.Add(this.pnlcorreo);
            this.gbDatosdeContacto.Controls.Add(this.pnldepto);
            this.gbDatosdeContacto.Controls.Add(this.pnlpais);
            this.gbDatosdeContacto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbDatosdeContacto.Location = new System.Drawing.Point(537, 15);
            this.gbDatosdeContacto.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosdeContacto.Name = "gbDatosdeContacto";
            this.gbDatosdeContacto.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosdeContacto.Size = new System.Drawing.Size(536, 343);
            this.gbDatosdeContacto.TabIndex = 13;
            this.gbDatosdeContacto.TabStop = false;
            this.gbDatosdeContacto.Text = "Datos de Contacto";
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.BackColor = System.Drawing.Color.DarkRed;
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Snow;
            this.lblAdvertencia.Location = new System.Drawing.Point(208, 0);
            this.lblAdvertencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(273, 20);
            this.lblAdvertencia.TabIndex = 12;
            this.lblAdvertencia.Text = "¡Debe llenar todos los campos!";
            this.lblAdvertencia.Visible = false;
            // 
            // txtDirE
            // 
            this.txtDirE.Location = new System.Drawing.Point(31, 272);
            this.txtDirE.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirE.Multiline = true;
            this.txtDirE.Name = "txtDirE";
            this.txtDirE.Size = new System.Drawing.Size(455, 46);
            this.txtDirE.TabIndex = 11;
            // 
            // lblDirE
            // 
            this.lblDirE.AutoSize = true;
            this.lblDirE.Location = new System.Drawing.Point(27, 249);
            this.lblDirE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirE.Name = "lblDirE";
            this.lblDirE.Size = new System.Drawing.Size(111, 16);
            this.lblDirE.TabIndex = 10;
            this.lblDirE.Text = "Dirección Exacta:";
            // 
            // cbxciudad
            // 
            this.cbxciudad.FormattingEnabled = true;
            this.cbxciudad.Location = new System.Drawing.Point(31, 188);
            this.cbxciudad.Margin = new System.Windows.Forms.Padding(4);
            this.cbxciudad.Name = "cbxciudad";
            this.cbxciudad.Size = new System.Drawing.Size(455, 24);
            this.cbxciudad.TabIndex = 9;
            // 
            // cbxdepto
            // 
            this.cbxdepto.FormattingEnabled = true;
            this.cbxdepto.Location = new System.Drawing.Point(256, 127);
            this.cbxdepto.Margin = new System.Windows.Forms.Padding(4);
            this.cbxdepto.Name = "cbxdepto";
            this.cbxdepto.Size = new System.Drawing.Size(233, 24);
            this.cbxdepto.TabIndex = 8;
            this.cbxdepto.SelectedIndexChanged += new System.EventHandler(this.cbxDepto_SelectedIndexChanged);
            // 
            // cbxpais
            // 
            this.cbxpais.FormattingEnabled = true;
            this.cbxpais.Location = new System.Drawing.Point(31, 127);
            this.cbxpais.Margin = new System.Windows.Forms.Padding(4);
            this.cbxpais.Name = "cbxpais";
            this.cbxpais.Size = new System.Drawing.Size(191, 24);
            this.cbxpais.TabIndex = 7;
            this.cbxpais.SelectedIndexChanged += new System.EventHandler(this.cbxPais_SelectedIndexChanged);
            // 
            // lblciudad
            // 
            this.lblciudad.AutoSize = true;
            this.lblciudad.Location = new System.Drawing.Point(27, 169);
            this.lblciudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblciudad.Name = "lblciudad";
            this.lblciudad.Size = new System.Drawing.Size(53, 16);
            this.lblciudad.TabIndex = 6;
            this.lblciudad.Text = "Ciudad:";
            // 
            // lbldepto
            // 
            this.lbldepto.AutoSize = true;
            this.lbldepto.Location = new System.Drawing.Point(256, 103);
            this.lbldepto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldepto.Name = "lbldepto";
            this.lbldepto.Size = new System.Drawing.Size(96, 16);
            this.lbldepto.TabIndex = 5;
            this.lbldepto.Text = "Departamento:";
            // 
            // lblpais
            // 
            this.lblpais.AutoSize = true;
            this.lblpais.Location = new System.Drawing.Point(27, 103);
            this.lblpais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(37, 16);
            this.lblpais.TabIndex = 4;
            this.lblpais.Text = "País:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(260, 44);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(256, 25);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(31, 46);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(195, 22);
            this.txtTelefono.TabIndex = 1;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(27, 25);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(64, 16);
            this.lblTel.TabIndex = 0;
            this.lblTel.Text = "Teléfono:";
            // 
            // pnlciudad
            // 
            this.pnlciudad.BackColor = System.Drawing.Color.DarkRed;
            this.pnlciudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlciudad.Location = new System.Drawing.Point(31, 191);
            this.pnlciudad.Margin = new System.Windows.Forms.Padding(4);
            this.pnlciudad.Name = "pnlciudad";
            this.pnlciudad.Size = new System.Drawing.Size(455, 28);
            this.pnlciudad.TabIndex = 8;
            this.pnlciudad.Visible = false;
            // 
            // pnlDIRE
            // 
            this.pnlDIRE.BackColor = System.Drawing.Color.DarkRed;
            this.pnlDIRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDIRE.Location = new System.Drawing.Point(31, 290);
            this.pnlDIRE.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDIRE.Name = "pnlDIRE";
            this.pnlDIRE.Size = new System.Drawing.Size(455, 33);
            this.pnlDIRE.TabIndex = 9;
            this.pnlDIRE.Visible = false;
            // 
            // pnlTel
            // 
            this.pnlTel.BackColor = System.Drawing.Color.DarkRed;
            this.pnlTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTel.Location = new System.Drawing.Point(31, 47);
            this.pnlTel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTel.Name = "pnlTel";
            this.pnlTel.Size = new System.Drawing.Size(195, 28);
            this.pnlTel.TabIndex = 9;
            this.pnlTel.Visible = false;
            // 
            // pnlcorreo
            // 
            this.pnlcorreo.BackColor = System.Drawing.Color.DarkRed;
            this.pnlcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlcorreo.Location = new System.Drawing.Point(260, 47);
            this.pnlcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlcorreo.Name = "pnlcorreo";
            this.pnlcorreo.Size = new System.Drawing.Size(230, 28);
            this.pnlcorreo.TabIndex = 10;
            this.pnlcorreo.Visible = false;
            // 
            // pnldepto
            // 
            this.pnldepto.BackColor = System.Drawing.Color.DarkRed;
            this.pnldepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnldepto.Location = new System.Drawing.Point(256, 127);
            this.pnldepto.Margin = new System.Windows.Forms.Padding(4);
            this.pnldepto.Name = "pnldepto";
            this.pnldepto.Size = new System.Drawing.Size(234, 30);
            this.pnldepto.TabIndex = 11;
            this.pnldepto.Visible = false;
            // 
            // pnlpais
            // 
            this.pnlpais.BackColor = System.Drawing.Color.DarkRed;
            this.pnlpais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlpais.Location = new System.Drawing.Point(31, 129);
            this.pnlpais.Margin = new System.Windows.Forms.Padding(4);
            this.pnlpais.Name = "pnlpais";
            this.pnlpais.Size = new System.Drawing.Size(191, 28);
            this.pnlpais.TabIndex = 12;
            this.pnlpais.Visible = false;
            // 
            // gbDatospersonales
            // 
            this.gbDatospersonales.Controls.Add(this.dtFechaNacimiento);
            this.gbDatospersonales.Controls.Add(this.lblFechanacimiento);
            this.gbDatospersonales.Controls.Add(this.rbF);
            this.gbDatospersonales.Controls.Add(this.rbM);
            this.gbDatospersonales.Controls.Add(this.lblsexo);
            this.gbDatospersonales.Controls.Add(this.txtNombre);
            this.gbDatospersonales.Controls.Add(this.lblNombre);
            this.gbDatospersonales.Controls.Add(this.pnlnombre);
            this.gbDatospersonales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbDatospersonales.Location = new System.Drawing.Point(16, 15);
            this.gbDatospersonales.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatospersonales.Name = "gbDatospersonales";
            this.gbDatospersonales.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatospersonales.Size = new System.Drawing.Size(513, 167);
            this.gbDatospersonales.TabIndex = 11;
            this.gbDatospersonales.TabStop = false;
            this.gbDatospersonales.Text = "Datos Personales";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(284, 123);
            this.dtFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(159, 22);
            this.dtFechaNacimiento.TabIndex = 6;
            // 
            // lblFechanacimiento
            // 
            this.lblFechanacimiento.AutoSize = true;
            this.lblFechanacimiento.Location = new System.Drawing.Point(280, 103);
            this.lblFechanacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechanacimiento.Name = "lblFechanacimiento";
            this.lblFechanacimiento.Size = new System.Drawing.Size(138, 16);
            this.lblFechanacimiento.TabIndex = 5;
            this.lblFechanacimiento.Text = "Fecha de Nacimiento:";
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(152, 123);
            this.rbF.Margin = new System.Windows.Forms.Padding(4);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(88, 20);
            this.rbF.TabIndex = 4;
            this.rbF.TabStop = true;
            this.rbF.Text = "Femenino";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(31, 123);
            this.rbM.Margin = new System.Windows.Forms.Padding(4);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(89, 20);
            this.rbM.TabIndex = 3;
            this.rbM.TabStop = true;
            this.rbM.Text = "Masculino";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(31, 102);
            this.lblsexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(41, 16);
            this.lblsexo.TabIndex = 2;
            this.lblsexo.Text = "Sexo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(31, 46);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(412, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 25);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Completo:";
            // 
            // pnlnombre
            // 
            this.pnlnombre.BackColor = System.Drawing.Color.DarkRed;
            this.pnlnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlnombre.Location = new System.Drawing.Point(31, 47);
            this.pnlnombre.Margin = new System.Windows.Forms.Padding(4);
            this.pnlnombre.Name = "pnlnombre";
            this.pnlnombre.Size = new System.Drawing.Size(413, 28);
            this.pnlnombre.TabIndex = 7;
            this.pnlnombre.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(936, 377);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 38);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(80)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(791, 377);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 38);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(4, 4);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(329, 26);
            this.txtBuscar.TabIndex = 31;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(25, 377);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 36);
            this.panel1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_De_Tickets_Autobus.Properties.Resources.buscarcolorizado;
            this.pictureBox1.Location = new System.Drawing.Point(343, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(80)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(791, 377);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(137, 38);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPersonaExistente
            // 
            this.btnPersonaExistente.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonaExistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonaExistente.ForeColor = System.Drawing.Color.White;
            this.btnPersonaExistente.Location = new System.Drawing.Point(429, 378);
            this.btnPersonaExistente.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonaExistente.Name = "btnPersonaExistente";
            this.btnPersonaExistente.Size = new System.Drawing.Size(204, 37);
            this.btnPersonaExistente.TabIndex = 35;
            this.btnPersonaExistente.Text = "Registrar Persona Existente";
            this.btnPersonaExistente.UseVisualStyleBackColor = false;
            this.btnPersonaExistente.Click += new System.EventHandler(this.btnPersonaExistente_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1096, 702);
            this.Controls.Add(this.btnPersonaExistente);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.gbDNI);
            this.Controls.Add(this.gbDatosdeContacto);
            this.Controls.Add(this.gbDatospersonales);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.gbDNI.ResumeLayout(false);
            this.gbDNI.PerformLayout();
            this.gbDatosdeContacto.ResumeLayout(false);
            this.gbDatosdeContacto.PerformLayout();
            this.gbDatospersonales.ResumeLayout(false);
            this.gbDatospersonales.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.GroupBox gbDNI;
        private System.Windows.Forms.TextBox txtDNIE;
        private System.Windows.Forms.Label lblDNIE;
        private System.Windows.Forms.MaskedTextBox mtxtidentidad;
        private System.Windows.Forms.Label lblidentidad;
        private System.Windows.Forms.RadioButton rbE;
        private System.Windows.Forms.RadioButton rbH;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Panel pnlDNI;
        private System.Windows.Forms.Panel pnlDNIE;
        private System.Windows.Forms.GroupBox gbDatosdeContacto;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.TextBox txtDirE;
        private System.Windows.Forms.Label lblDirE;
        private System.Windows.Forms.ComboBox cbxciudad;
        private System.Windows.Forms.ComboBox cbxdepto;
        private System.Windows.Forms.ComboBox cbxpais;
        private System.Windows.Forms.Label lblciudad;
        private System.Windows.Forms.Label lbldepto;
        private System.Windows.Forms.Label lblpais;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Panel pnlciudad;
        private System.Windows.Forms.Panel pnlDIRE;
        private System.Windows.Forms.Panel pnlTel;
        private System.Windows.Forms.Panel pnlcorreo;
        private System.Windows.Forms.Panel pnldepto;
        private System.Windows.Forms.Panel pnlpais;
        private System.Windows.Forms.GroupBox gbDatospersonales;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Label lblFechanacimiento;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlnombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPersonaExistente;
    }
}