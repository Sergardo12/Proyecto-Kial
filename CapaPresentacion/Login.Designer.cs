﻿namespace CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pcboxPortada = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.pcbxContraseña = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pcbxUsuario = new System.Windows.Forms.PictureBox();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxPortada)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pcboxPortada
            // 
            this.pcboxPortada.Dock = System.Windows.Forms.DockStyle.Right;
            this.pcboxPortada.Image = ((System.Drawing.Image)(resources.GetObject("pcboxPortada.Image")));
            this.pcboxPortada.Location = new System.Drawing.Point(285, 0);
            this.pcboxPortada.Name = "pcboxPortada";
            this.pcboxPortada.Size = new System.Drawing.Size(532, 430);
            this.pcboxPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxPortada.TabIndex = 3;
            this.pcboxPortada.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnIniciarSesion);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.pcbxContraseña);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.pcbxUsuario);
            this.panel1.Controls.Add(this.lblIniciarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 430);
            this.panel1.TabIndex = 2;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(65, 314);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnIniciarSesion.Size = new System.Drawing.Size(167, 39);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(65, 242);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(167, 20);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // pcbxContraseña
            // 
            this.pcbxContraseña.BackColor = System.Drawing.Color.Transparent;
            this.pcbxContraseña.Image = ((System.Drawing.Image)(resources.GetObject("pcbxContraseña.Image")));
            this.pcbxContraseña.Location = new System.Drawing.Point(24, 242);
            this.pcbxContraseña.Name = "pcbxContraseña";
            this.pcbxContraseña.Size = new System.Drawing.Size(25, 25);
            this.pcbxContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxContraseña.TabIndex = 3;
            this.pcbxContraseña.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(65, 188);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(167, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // pcbxUsuario
            // 
            this.pcbxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pcbxUsuario.Image")));
            this.pcbxUsuario.Location = new System.Drawing.Point(24, 188);
            this.pcbxUsuario.Name = "pcbxUsuario";
            this.pcbxUsuario.Size = new System.Drawing.Size(25, 25);
            this.pcbxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxUsuario.TabIndex = 1;
            this.pcbxUsuario.TabStop = false;
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.lblIniciarSesion.Location = new System.Drawing.Point(30, 88);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(182, 32);
            this.lblIniciarSesion.TabIndex = 0;
            this.lblIniciarSesion.Text = "Iniciar sesión";
            this.lblIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 430);
            this.Controls.Add(this.pcboxPortada);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pcboxPortada)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcboxPortada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.PictureBox pcbxContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pcbxUsuario;
        private System.Windows.Forms.Label lblIniciarSesion;
    }
}