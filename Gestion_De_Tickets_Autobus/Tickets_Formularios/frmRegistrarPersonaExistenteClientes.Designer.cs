﻿namespace Gestion_De_Tickets_Autobus.Tickets_Formularios
{
    partial class frmRegistrarPersonaExistenteClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarPersonaExistenteClientes));
            this.lblDNI = new System.Windows.Forms.Label();
            this.cbxDNIREG = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDNI.Location = new System.Drawing.Point(322, 36);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(116, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "Seleccione la Persona:";
            // 
            // cbxDNIREG
            // 
            this.cbxDNIREG.FormattingEnabled = true;
            this.cbxDNIREG.Location = new System.Drawing.Point(206, 65);
            this.cbxDNIREG.Name = "cbxDNIREG";
            this.cbxDNIREG.Size = new System.Drawing.Size(337, 21);
            this.cbxDNIREG.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gray;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(206, 113);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(337, 45);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Agregar como Empleado";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmRegistrarPersonaExistenteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(750, 193);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxDNIREG);
            this.Controls.Add(this.lblDNI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarPersonaExistenteClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrarPersonaExistente";
            this.Load += new System.EventHandler(this.frmRegistrarPersonaExistente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.ComboBox cbxDNIREG;
        private System.Windows.Forms.Button btnGuardar;
    }
}