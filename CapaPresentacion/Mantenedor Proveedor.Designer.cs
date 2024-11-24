namespace CapaPresentacion
{
    partial class MantenedorProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorProveedor));
            this.pcbxFondoMadera = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEstadoProveedor = new System.Windows.Forms.CheckBox();
            this.dtpProveedor = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRUCProveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnRegresarProveedor = new System.Windows.Forms.Button();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.btnDeshabilitarProveedor = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnListoProveedor = new System.Windows.Forms.Button();
            this.btnCancelarProveedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxFondoMadera
            // 
            this.pcbxFondoMadera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbxFondoMadera.Image = ((System.Drawing.Image)(resources.GetObject("pcbxFondoMadera.Image")));
            this.pcbxFondoMadera.Location = new System.Drawing.Point(-4, -2);
            this.pcbxFondoMadera.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pcbxFondoMadera.Name = "pcbxFondoMadera";
            this.pcbxFondoMadera.Size = new System.Drawing.Size(1568, 694);
            this.pcbxFondoMadera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxFondoMadera.TabIndex = 30;
            this.pcbxFondoMadera.TabStop = false;
            this.pcbxFondoMadera.Click += new System.EventHandler(this.pcbxFondoMadera_Click);
            this.pcbxFondoMadera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbxFondoMadera_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxEstadoProveedor);
            this.groupBox1.Controls.Add(this.dtpProveedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIDProveedor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRUCProveedor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDireccionProveedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreProveedor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(461, 362);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // cbxEstadoProveedor
            // 
            this.cbxEstadoProveedor.AutoSize = true;
            this.cbxEstadoProveedor.Location = new System.Drawing.Point(128, 316);
            this.cbxEstadoProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxEstadoProveedor.Name = "cbxEstadoProveedor";
            this.cbxEstadoProveedor.Size = new System.Drawing.Size(90, 25);
            this.cbxEstadoProveedor.TabIndex = 18;
            this.cbxEstadoProveedor.Text = "Estado";
            this.cbxEstadoProveedor.UseVisualStyleBackColor = true;
            // 
            // dtpProveedor
            // 
            this.dtpProveedor.Location = new System.Drawing.Point(165, 279);
            this.dtpProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpProveedor.Name = "dtpProveedor";
            this.dtpProveedor.Size = new System.Drawing.Size(255, 28);
            this.dtpProveedor.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fecha Registro:";
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.Location = new System.Drawing.Point(165, 95);
            this.txtIDProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.Size = new System.Drawing.Size(255, 28);
            this.txtIDProveedor.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID:";
            // 
            // txtRUCProveedor
            // 
            this.txtRUCProveedor.Location = new System.Drawing.Point(165, 185);
            this.txtRUCProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRUCProveedor.Name = "txtRUCProveedor";
            this.txtRUCProveedor.Size = new System.Drawing.Size(255, 28);
            this.txtRUCProveedor.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "RUC:";
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(165, 229);
            this.txtDireccionProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(255, 28);
            this.txtDireccionProveedor.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Direccion:";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(165, 143);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(255, 28);
            this.txtNombreProveedor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 40);
            this.label1.TabIndex = 34;
            this.label1.Text = "Proveedores";
            // 
            // dtgvProveedores
            // 
            this.dtgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProveedores.Enabled = false;
            this.dtgvProveedores.Location = new System.Drawing.Point(564, 103);
            this.dtgvProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvProveedores.Name = "dtgvProveedores";
            this.dtgvProveedores.RowHeadersWidth = 51;
            this.dtgvProveedores.RowTemplate.Height = 24;
            this.dtgvProveedores.Size = new System.Drawing.Size(981, 362);
            this.dtgvProveedores.TabIndex = 35;
            // 
            // btnRegresarProveedor
            // 
            this.btnRegresarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnRegresarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarProveedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresarProveedor.Location = new System.Drawing.Point(31, 599);
            this.btnRegresarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresarProveedor.Name = "btnRegresarProveedor";
            this.btnRegresarProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnRegresarProveedor.TabIndex = 46;
            this.btnRegresarProveedor.Text = "Regresar";
            this.btnRegresarProveedor.UseVisualStyleBackColor = false;
            this.btnRegresarProveedor.Click += new System.EventHandler(this.btnRegresarProveedor_Click);
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(61)))), ((int)(((byte)(20)))));
            this.btnEditarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProveedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarProveedor.Location = new System.Drawing.Point(207, 473);
            this.btnEditarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnEditarProveedor.TabIndex = 45;
            this.btnEditarProveedor.Text = "Editar";
            this.btnEditarProveedor.UseVisualStyleBackColor = false;
            this.btnEditarProveedor.Click += new System.EventHandler(this.btnEditarProveedor_Click);
            // 
            // btnDeshabilitarProveedor
            // 
            this.btnDeshabilitarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(61)))), ((int)(((byte)(20)))));
            this.btnDeshabilitarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitarProveedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeshabilitarProveedor.Location = new System.Drawing.Point(365, 473);
            this.btnDeshabilitarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeshabilitarProveedor.Name = "btnDeshabilitarProveedor";
            this.btnDeshabilitarProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnDeshabilitarProveedor.TabIndex = 44;
            this.btnDeshabilitarProveedor.Text = "Deshabilitar";
            this.btnDeshabilitarProveedor.UseVisualStyleBackColor = false;
            this.btnDeshabilitarProveedor.Click += new System.EventHandler(this.btnDeshabilitarProveedor_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(53, 473);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnAgregarProveedor.TabIndex = 43;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnListoProveedor
            // 
            this.btnListoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnListoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListoProveedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListoProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListoProveedor.Location = new System.Drawing.Point(1421, 599);
            this.btnListoProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListoProveedor.Name = "btnListoProveedor";
            this.btnListoProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnListoProveedor.TabIndex = 48;
            this.btnListoProveedor.Text = "Listo";
            this.btnListoProveedor.UseVisualStyleBackColor = false;
            this.btnListoProveedor.Click += new System.EventHandler(this.btnListoProveedor_Click);
            // 
            // btnCancelarProveedor
            // 
            this.btnCancelarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnCancelarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProveedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarProveedor.Location = new System.Drawing.Point(1271, 599);
            this.btnCancelarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarProveedor.Name = "btnCancelarProveedor";
            this.btnCancelarProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnCancelarProveedor.TabIndex = 47;
            this.btnCancelarProveedor.Text = "Cancelar";
            this.btnCancelarProveedor.UseVisualStyleBackColor = false;
            this.btnCancelarProveedor.Click += new System.EventHandler(this.btnCancelarProveedor_Click);
            // 
            // MantenedorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 688);
            this.Controls.Add(this.btnListoProveedor);
            this.Controls.Add(this.btnCancelarProveedor);
            this.Controls.Add(this.btnRegresarProveedor);
            this.Controls.Add(this.btnEditarProveedor);
            this.Controls.Add(this.btnDeshabilitarProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.dtgvProveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbxFondoMadera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MantenedorProveedor";
            this.Text = "MantenedorProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxFondoMadera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRUCProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvProveedores;
        private System.Windows.Forms.Button btnRegresarProveedor;
        private System.Windows.Forms.Button btnEditarProveedor;
        private System.Windows.Forms.Button btnDeshabilitarProveedor;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnListoProveedor;
        private System.Windows.Forms.Button btnCancelarProveedor;
        private System.Windows.Forms.TextBox txtIDProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxEstadoProveedor;
    }
}