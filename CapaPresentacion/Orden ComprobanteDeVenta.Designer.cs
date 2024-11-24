namespace CapaPresentacion
{
    partial class MantenedorComprobanteDeVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorComprobanteDeVenta));
            this.pcbxFondoMadera = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtDireccionComprobante = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxTipoComprobante = new System.Windows.Forms.ComboBox();
            this.btnComprobanteCliente = new System.Windows.Forms.Button();
            this.btnAnularComprobante = new System.Windows.Forms.Button();
            this.btnNuevoComprobante = new System.Windows.Forms.Button();
            this.txtIdComprobante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRucCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkComprobante = new System.Windows.Forms.DateTimePicker();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreClienteComprobante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvComprobante = new System.Windows.Forms.DataGridView();
            this.btnRegresarComprobante = new System.Windows.Forms.Button();
            this.btnCancelarComprobante = new System.Windows.Forms.Button();
            this.btnListoComprobante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvComprobante)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxFondoMadera
            // 
            this.pcbxFondoMadera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbxFondoMadera.Image = ((System.Drawing.Image)(resources.GetObject("pcbxFondoMadera.Image")));
            this.pcbxFondoMadera.Location = new System.Drawing.Point(-11, -5);
            this.pcbxFondoMadera.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pcbxFondoMadera.Name = "pcbxFondoMadera";
            this.pcbxFondoMadera.Size = new System.Drawing.Size(1861, 651);
            this.pcbxFondoMadera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxFondoMadera.TabIndex = 32;
            this.pcbxFondoMadera.TabStop = false;
            this.pcbxFondoMadera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbxFondoMadera_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(696, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 40);
            this.label7.TabIndex = 33;
            this.label7.Text = "Comprobante de venta";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarVenta);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txtDireccionComprobante);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtIDVenta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbxTipoComprobante);
            this.groupBox1.Controls.Add(this.btnComprobanteCliente);
            this.groupBox1.Controls.Add(this.btnAnularComprobante);
            this.groupBox1.Controls.Add(this.btnNuevoComprobante);
            this.groupBox1.Controls.Add(this.txtIdComprobante);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRucCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpkComprobante);
            this.groupBox1.Controls.Add(this.txtDniCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreClienteComprobante);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(820, 389);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar datos";
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnBuscarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVenta.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVenta.Location = new System.Drawing.Point(619, 144);
            this.btnBuscarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(169, 48);
            this.btnBuscarVenta.TabIndex = 21;
            this.btnBuscarVenta.Text = "Buscar";
            this.btnBuscarVenta.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(223, 352);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 30);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Estado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtDireccionComprobante
            // 
            this.txtDireccionComprobante.Location = new System.Drawing.Point(223, 160);
            this.txtDireccionComprobante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccionComprobante.Name = "txtDireccionComprobante";
            this.txtDireccionComprobante.Size = new System.Drawing.Size(271, 30);
            this.txtDireccionComprobante.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 164);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Direccion:";
            // 
            // txtIDVenta
            // 
            this.txtIDVenta.Location = new System.Drawing.Point(223, 84);
            this.txtIDVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDVenta.Name = "txtIDVenta";
            this.txtIDVenta.Size = new System.Drawing.Size(271, 30);
            this.txtIDVenta.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID Venta:";
            // 
            // cbxTipoComprobante
            // 
            this.cbxTipoComprobante.FormattingEnabled = true;
            this.cbxTipoComprobante.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cbxTipoComprobante.Location = new System.Drawing.Point(223, 198);
            this.cbxTipoComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTipoComprobante.Name = "cbxTipoComprobante";
            this.cbxTipoComprobante.Size = new System.Drawing.Size(271, 33);
            this.cbxTipoComprobante.TabIndex = 16;
            // 
            // btnComprobanteCliente
            // 
            this.btnComprobanteCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnComprobanteCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprobanteCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobanteCliente.ForeColor = System.Drawing.Color.White;
            this.btnComprobanteCliente.Location = new System.Drawing.Point(619, 238);
            this.btnComprobanteCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComprobanteCliente.Name = "btnComprobanteCliente";
            this.btnComprobanteCliente.Size = new System.Drawing.Size(169, 48);
            this.btnComprobanteCliente.TabIndex = 15;
            this.btnComprobanteCliente.Text = "Cliente";
            this.btnComprobanteCliente.UseVisualStyleBackColor = false;
            this.btnComprobanteCliente.Click += new System.EventHandler(this.btnComprobanteCliente_Click);
            // 
            // btnAnularComprobante
            // 
            this.btnAnularComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnAnularComprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnularComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularComprobante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnularComprobante.Location = new System.Drawing.Point(619, 87);
            this.btnAnularComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnularComprobante.Name = "btnAnularComprobante";
            this.btnAnularComprobante.Size = new System.Drawing.Size(169, 48);
            this.btnAnularComprobante.TabIndex = 14;
            this.btnAnularComprobante.Text = "Anular";
            this.btnAnularComprobante.UseVisualStyleBackColor = false;
            this.btnAnularComprobante.Click += new System.EventHandler(this.btnAnularComprobante_Click);
            // 
            // btnNuevoComprobante
            // 
            this.btnNuevoComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnNuevoComprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoComprobante.ForeColor = System.Drawing.Color.White;
            this.btnNuevoComprobante.Location = new System.Drawing.Point(619, 34);
            this.btnNuevoComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoComprobante.Name = "btnNuevoComprobante";
            this.btnNuevoComprobante.Size = new System.Drawing.Size(169, 48);
            this.btnNuevoComprobante.TabIndex = 12;
            this.btnNuevoComprobante.Text = "Insertar\r\n";
            this.btnNuevoComprobante.UseVisualStyleBackColor = false;
            this.btnNuevoComprobante.Click += new System.EventHandler(this.btnNuevoComprobante_Click);
            // 
            // txtIdComprobante
            // 
            this.txtIdComprobante.Location = new System.Drawing.Point(223, 42);
            this.txtIdComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdComprobante.Name = "txtIdComprobante";
            this.txtIdComprobante.Size = new System.Drawing.Size(271, 30);
            this.txtIdComprobante.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID:";
            // 
            // txtRucCliente
            // 
            this.txtRucCliente.Location = new System.Drawing.Point(223, 276);
            this.txtRucCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRucCliente.Name = "txtRucCliente";
            this.txtRucCliente.Size = new System.Drawing.Size(271, 30);
            this.txtRucCliente.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "RUC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de emision:";
            // 
            // dtpkComprobante
            // 
            this.dtpkComprobante.Location = new System.Drawing.Point(223, 313);
            this.dtpkComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkComprobante.Name = "dtpkComprobante";
            this.dtpkComprobante.Size = new System.Drawing.Size(271, 30);
            this.dtpkComprobante.TabIndex = 6;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(223, 238);
            this.txtDniCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(271, 30);
            this.txtDniCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de comprobante:";
            // 
            // txtNombreClienteComprobante
            // 
            this.txtNombreClienteComprobante.Location = new System.Drawing.Point(223, 122);
            this.txtNombreClienteComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreClienteComprobante.Name = "txtNombreClienteComprobante";
            this.txtNombreClienteComprobante.Size = new System.Drawing.Size(271, 30);
            this.txtNombreClienteComprobante.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del cliente:";
            // 
            // dtgvComprobante
            // 
            this.dtgvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvComprobante.Location = new System.Drawing.Point(851, 94);
            this.dtgvComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvComprobante.Name = "dtgvComprobante";
            this.dtgvComprobante.RowHeadersWidth = 51;
            this.dtgvComprobante.RowTemplate.Height = 24;
            this.dtgvComprobante.Size = new System.Drawing.Size(976, 389);
            this.dtgvComprobante.TabIndex = 35;
            // 
            // btnRegresarComprobante
            // 
            this.btnRegresarComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnRegresarComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarComprobante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresarComprobante.Location = new System.Drawing.Point(12, 526);
            this.btnRegresarComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresarComprobante.Name = "btnRegresarComprobante";
            this.btnRegresarComprobante.Size = new System.Drawing.Size(124, 46);
            this.btnRegresarComprobante.TabIndex = 47;
            this.btnRegresarComprobante.Text = "Regresar";
            this.btnRegresarComprobante.UseVisualStyleBackColor = false;
            this.btnRegresarComprobante.Click += new System.EventHandler(this.btnRegresarComprobante_Click);
            // 
            // btnCancelarComprobante
            // 
            this.btnCancelarComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnCancelarComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarComprobante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarComprobante.Location = new System.Drawing.Point(1561, 526);
            this.btnCancelarComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarComprobante.Name = "btnCancelarComprobante";
            this.btnCancelarComprobante.Size = new System.Drawing.Size(124, 46);
            this.btnCancelarComprobante.TabIndex = 48;
            this.btnCancelarComprobante.Text = "Cancelar";
            this.btnCancelarComprobante.UseVisualStyleBackColor = false;
            this.btnCancelarComprobante.Click += new System.EventHandler(this.btnCancelarComprobante_Click);
            // 
            // btnListoComprobante
            // 
            this.btnListoComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnListoComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListoComprobante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListoComprobante.Location = new System.Drawing.Point(1703, 526);
            this.btnListoComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListoComprobante.Name = "btnListoComprobante";
            this.btnListoComprobante.Size = new System.Drawing.Size(124, 46);
            this.btnListoComprobante.TabIndex = 49;
            this.btnListoComprobante.Text = "Listo";
            this.btnListoComprobante.UseVisualStyleBackColor = false;
            this.btnListoComprobante.Click += new System.EventHandler(this.btnListoComprobante_Click);
            // 
            // MantenedorComprobanteDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1841, 610);
            this.Controls.Add(this.btnListoComprobante);
            this.Controls.Add(this.btnCancelarComprobante);
            this.Controls.Add(this.btnRegresarComprobante);
            this.Controls.Add(this.dtgvComprobante);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pcbxFondoMadera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MantenedorComprobanteDeVenta";
            this.Text = "MantenedorComprobanteDeVenta";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvComprobante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxFondoMadera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxTipoComprobante;
        private System.Windows.Forms.Button btnComprobanteCliente;
        private System.Windows.Forms.Button btnAnularComprobante;
        private System.Windows.Forms.Button btnNuevoComprobante;
        private System.Windows.Forms.TextBox txtIdComprobante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRucCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkComprobante;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreClienteComprobante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvComprobante;
        private System.Windows.Forms.Button btnRegresarComprobante;
        private System.Windows.Forms.Button btnCancelarComprobante;
        private System.Windows.Forms.Button btnListoComprobante;
        private System.Windows.Forms.TextBox txtIDVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccionComprobante;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnBuscarVenta;
    }
}