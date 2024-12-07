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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PicBuses = new System.Windows.Forms.PictureBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.numAsientos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtVip = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.pnlMarca = new System.Windows.Forms.Panel();
            this.pnlMatricula = new System.Windows.Forms.Panel();
            this.pnlModelo = new System.Windows.Forms.Panel();
            this.pnlAsientos = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsientos)).BeginInit();
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
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtVip);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.radioButton1);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(199, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 31);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(80)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(90, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(23, 123);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(186, 22);
            this.txtModelo.TabIndex = 12;
            this.txtModelo.TextChanged += new System.EventHandler(this.BtnGuardar_Click);
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(80)))));
            this.button3.Location = new System.Drawing.Point(169, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 54);
            this.button3.TabIndex = 26;
            this.button3.Text = "Seleccionar Imagen";
            this.button3.UseVisualStyleBackColor = false;
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(140, 169);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Normal";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PicBuses);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(469, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 261);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicional";
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
            ((System.ComponentModel.ISupportInitialize)(this.PicBuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsientos)).EndInit();
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
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox PicBuses;
        private System.Windows.Forms.Panel pnlMarca;
        private System.Windows.Forms.Panel pnlMatricula;
        private System.Windows.Forms.Panel pnlModelo;
        private System.Windows.Forms.Panel pnlAsientos;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}