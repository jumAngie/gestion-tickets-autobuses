namespace Gestion_De_Tickets_Autobus
{
    partial class frmAutobuses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutobuses));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtVip = new System.Windows.Forms.RadioButton();
            this.rbtNormal = new System.Windows.Forms.RadioButton();
            this.numAsientos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.pnlMarca = new System.Windows.Forms.Panel();
            this.pnlMatricula = new System.Windows.Forms.Panel();
            this.pnlModelo = new System.Windows.Forms.Panel();
            this.pnlAsientos = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.PicBuses = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAsientos)).BeginInit();
            this.pnlModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(222, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Matricula";
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(23, 51);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(186, 24);
            this.cbxMarca.TabIndex = 2;
            this.cbxMarca.Text = "Selecione...";
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtVip);
            this.groupBox1.Controls.Add(this.rbtNormal);
            this.groupBox1.Controls.Add(this.numAsientos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxMarca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.pnlMarca);
            this.groupBox1.Controls.Add(this.pnlMatricula);
            this.groupBox1.Controls.Add(this.pnlModelo);
            this.groupBox1.Controls.Add(this.pnlAsientos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 261);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información General";
            // 
            // rbtVip
            // 
            this.rbtVip.AutoSize = true;
            this.rbtVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtVip.ForeColor = System.Drawing.Color.White;
            this.rbtVip.Location = new System.Drawing.Point(225, 169);
            this.rbtVip.Name = "rbtVip";
            this.rbtVip.Size = new System.Drawing.Size(46, 20);
            this.rbtVip.TabIndex = 4;
            this.rbtVip.TabStop = true;
            this.rbtVip.Text = "VIP";
            this.rbtVip.UseVisualStyleBackColor = true;
            // 
            // rbtNormal
            // 
            this.rbtNormal.AutoSize = true;
            this.rbtNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNormal.ForeColor = System.Drawing.Color.White;
            this.rbtNormal.Location = new System.Drawing.Point(140, 169);
            this.rbtNormal.Name = "rbtNormal";
            this.rbtNormal.Size = new System.Drawing.Size(69, 20);
            this.rbtNormal.TabIndex = 4;
            this.rbtNormal.TabStop = true;
            this.rbtNormal.Text = "Normal";
            this.rbtNormal.UseVisualStyleBackColor = true;
            // 
            // numAsientos
            // 
            this.numAsientos.Location = new System.Drawing.Point(225, 123);
            this.numAsientos.Name = "numAsientos";
            this.numAsientos.Size = new System.Drawing.Size(175, 22);
            this.numAsientos.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Exclusividad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(222, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero de Asientos";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(225, 51);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(175, 22);
            this.txtMatricula.TabIndex = 5;
            this.txtMatricula.TextChanged += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // pnlMarca
            // 
            this.pnlMarca.BackColor = System.Drawing.Color.DarkRed;
            this.pnlMarca.Location = new System.Drawing.Point(23, 51);
            this.pnlMarca.Name = "pnlMarca";
            this.pnlMarca.Size = new System.Drawing.Size(186, 31);
            this.pnlMarca.TabIndex = 20;
            this.pnlMarca.Visible = false;
            // 
            // pnlMatricula
            // 
            this.pnlMatricula.BackColor = System.Drawing.Color.DarkRed;
            this.pnlMatricula.Location = new System.Drawing.Point(225, 51);
            this.pnlMatricula.Name = "pnlMatricula";
            this.pnlMatricula.Size = new System.Drawing.Size(175, 29);
            this.pnlMatricula.TabIndex = 23;
            this.pnlMatricula.Visible = false;
            // 
            // pnlModelo
            // 
            this.pnlModelo.BackColor = System.Drawing.Color.DarkRed;
            this.pnlModelo.Controls.Add(this.cbxModelo);
            this.pnlModelo.Location = new System.Drawing.Point(23, 123);
            this.pnlModelo.Name = "pnlModelo";
            this.pnlModelo.Size = new System.Drawing.Size(186, 29);
            this.pnlModelo.TabIndex = 22;
            this.pnlModelo.Visible = false;
            // 
            // pnlAsientos
            // 
            this.pnlAsientos.BackColor = System.Drawing.Color.DarkRed;
            this.pnlAsientos.Location = new System.Drawing.Point(225, 123);
            this.pnlAsientos.Name = "pnlAsientos";
            this.pnlAsientos.Size = new System.Drawing.Size(175, 29);
            this.pnlAsientos.TabIndex = 21;
            this.pnlAsientos.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(199, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 31);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(80)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(90, 211);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 31);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // PicBuses
            // 
            this.PicBuses.Image = ((System.Drawing.Image)(resources.GetObject("PicBuses.Image")));
            this.PicBuses.Location = new System.Drawing.Point(25, 42);
            this.PicBuses.Name = "PicBuses";
            this.PicBuses.Size = new System.Drawing.Size(128, 124);
            this.PicBuses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBuses.TabIndex = 12;
            this.PicBuses.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 100);
            this.dataGridView1.TabIndex = 11;
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.BackColor = System.Drawing.Color.DarkRed;
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Snow;
            this.lblAdvertencia.Location = new System.Drawing.Point(565, 12);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(223, 16);
            this.lblAdvertencia.TabIndex = 13;
            this.lblAdvertencia.Text = "¡Debe llenar todos los campos!";
            this.lblAdvertencia.Visible = false;
            this.lblAdvertencia.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.White;
            this.btnImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(80)))));
            this.btnImagen.Location = new System.Drawing.Point(169, 77);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(123, 54);
            this.btnImagen.TabIndex = 26;
            this.btnImagen.Text = "Seleccionar Imagen";
            this.btnImagen.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PicBuses);
            this.groupBox2.Controls.Add(this.btnImagen);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(469, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 261);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicional";
            // 
            // cbxModelo
            // 
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Location = new System.Drawing.Point(0, -1);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(186, 24);
            this.cbxModelo.TabIndex = 28;
            this.cbxModelo.Text = "Selecione...";
            // 
            // frmAutobuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAdvertencia);
            this.Name = "frmAutobuses";
            this.Text = "fmrAutobuses";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAsientos)).EndInit();
            this.pnlModelo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtVip;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAsientos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox PicBuses;
        private System.Windows.Forms.Panel pnlMarca;
        private System.Windows.Forms.Panel pnlMatricula;
        private System.Windows.Forms.Panel pnlModelo;
        private System.Windows.Forms.Panel pnlAsientos;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.RadioButton rbtNormal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxModelo;
    }
}