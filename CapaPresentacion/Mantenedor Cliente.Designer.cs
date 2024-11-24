namespace CapaPresentacion
{
    partial class MantenedorCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorCliente));
            this.pcbxFondoMadera = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkEstadoCliente = new System.Windows.Forms.CheckBox();
            this.dtpkFechaCliente = new System.Windows.Forms.DateTimePicker();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnInhabilitarCliente = new System.Windows.Forms.Button();
            this.btnRegresarCliente = new System.Windows.Forms.Button();
            this.btnCancelarCliente = new System.Windows.Forms.Button();
            this.btnListoCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxFondoMadera
            // 
            this.pcbxFondoMadera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbxFondoMadera.Image = ((System.Drawing.Image)(resources.GetObject("pcbxFondoMadera.Image")));
            this.pcbxFondoMadera.Location = new System.Drawing.Point(-5, -18);
            this.pcbxFondoMadera.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pcbxFondoMadera.Name = "pcbxFondoMadera";
            this.pcbxFondoMadera.Size = new System.Drawing.Size(1596, 638);
            this.pcbxFondoMadera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxFondoMadera.TabIndex = 31;
            this.pcbxFondoMadera.TabStop = false;
            this.pcbxFondoMadera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbxFondoMadera_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumeroCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chkEstadoCliente);
            this.groupBox1.Controls.Add(this.dtpkFechaCliente);
            this.groupBox1.Controls.Add(this.txtCorreoCliente);
            this.groupBox1.Controls.Add(this.txtDniCliente);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(589, 407);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(245, 217);
            this.txtNumeroCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(243, 30);
            this.txtNumeroCliente.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "Número:";
            // 
            // chkEstadoCliente
            // 
            this.chkEstadoCliente.AutoSize = true;
            this.chkEstadoCliente.Location = new System.Drawing.Point(185, 351);
            this.chkEstadoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEstadoCliente.Name = "chkEstadoCliente";
            this.chkEstadoCliente.Size = new System.Drawing.Size(95, 29);
            this.chkEstadoCliente.TabIndex = 56;
            this.chkEstadoCliente.Text = "Estado";
            this.chkEstadoCliente.UseVisualStyleBackColor = true;
            // 
            // dtpkFechaCliente
            // 
            this.dtpkFechaCliente.Location = new System.Drawing.Point(245, 313);
            this.dtpkFechaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkFechaCliente.Name = "dtpkFechaCliente";
            this.dtpkFechaCliente.Size = new System.Drawing.Size(243, 30);
            this.dtpkFechaCliente.TabIndex = 9;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(245, 262);
            this.txtCorreoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(243, 30);
            this.txtCorreoCliente.TabIndex = 8;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(245, 169);
            this.txtDniCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(243, 30);
            this.txtDniCliente.TabIndex = 7;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(245, 113);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(243, 30);
            this.txtNombreCliente.TabIndex = 6;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(245, 62);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(243, 30);
            this.txtIdCliente.TabIndex = 5;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dni:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre del cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 40);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nuevo Cliente";
            // 
            // dtgvClientes
            // 
            this.dtgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClientes.Enabled = false;
            this.dtgvClientes.Location = new System.Drawing.Point(660, 75);
            this.dtgvClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvClientes.Name = "dtgvClientes";
            this.dtgvClientes.RowHeadersWidth = 51;
            this.dtgvClientes.RowTemplate.Height = 24;
            this.dtgvClientes.Size = new System.Drawing.Size(868, 368);
            this.dtgvClientes.TabIndex = 34;
            this.dtgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvClientes_CellContentClick);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(61)))), ((int)(((byte)(20)))));
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarCliente.Location = new System.Drawing.Point(79, 487);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(120, 49);
            this.btnAgregarCliente.TabIndex = 35;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(61)))), ((int)(((byte)(20)))));
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarCliente.Location = new System.Drawing.Point(204, 487);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(120, 49);
            this.btnEditarCliente.TabIndex = 36;
            this.btnEditarCliente.Text = "Modificar";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnInhabilitarCliente
            // 
            this.btnInhabilitarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(61)))), ((int)(((byte)(20)))));
            this.btnInhabilitarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInhabilitarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInhabilitarCliente.Location = new System.Drawing.Point(329, 487);
            this.btnInhabilitarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInhabilitarCliente.Name = "btnInhabilitarCliente";
            this.btnInhabilitarCliente.Size = new System.Drawing.Size(120, 49);
            this.btnInhabilitarCliente.TabIndex = 37;
            this.btnInhabilitarCliente.Text = "Inhabilitar";
            this.btnInhabilitarCliente.UseVisualStyleBackColor = false;
            this.btnInhabilitarCliente.Click += new System.EventHandler(this.btnInhabilitarCliente_Click);
            // 
            // btnRegresarCliente
            // 
            this.btnRegresarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnRegresarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresarCliente.Location = new System.Drawing.Point(45, 562);
            this.btnRegresarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresarCliente.Name = "btnRegresarCliente";
            this.btnRegresarCliente.Size = new System.Drawing.Size(124, 46);
            this.btnRegresarCliente.TabIndex = 45;
            this.btnRegresarCliente.Text = "Regresar";
            this.btnRegresarCliente.UseVisualStyleBackColor = false;
            this.btnRegresarCliente.Click += new System.EventHandler(this.btnRegresarCliente_Click);
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnCancelarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarCliente.Location = new System.Drawing.Point(1281, 551);
            this.btnCancelarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(124, 46);
            this.btnCancelarCliente.TabIndex = 48;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.UseVisualStyleBackColor = false;
            this.btnCancelarCliente.Click += new System.EventHandler(this.btnCancelarCliente_Click);
            // 
            // btnListoCliente
            // 
            this.btnListoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnListoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListoCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListoCliente.Location = new System.Drawing.Point(1451, 551);
            this.btnListoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListoCliente.Name = "btnListoCliente";
            this.btnListoCliente.Size = new System.Drawing.Size(124, 46);
            this.btnListoCliente.TabIndex = 49;
            this.btnListoCliente.Text = "Listo";
            this.btnListoCliente.UseVisualStyleBackColor = false;
            this.btnListoCliente.Click += new System.EventHandler(this.btnListoCliente_Click);
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 617);
            this.Controls.Add(this.btnListoCliente);
            this.Controls.Add(this.btnCancelarCliente);
            this.Controls.Add(this.btnRegresarCliente);
            this.Controls.Add(this.btnInhabilitarCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.dtgvClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbxFondoMadera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MantenedorCliente";
            this.Text = "MantenedorCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxFondoMadera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpkFechaCliente;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvClientes;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnInhabilitarCliente;
        private System.Windows.Forms.Button btnRegresarCliente;
        private System.Windows.Forms.Button btnCancelarCliente;
        private System.Windows.Forms.Button btnListoCliente;
        private System.Windows.Forms.CheckBox chkEstadoCliente;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.Label label7;
    }
}