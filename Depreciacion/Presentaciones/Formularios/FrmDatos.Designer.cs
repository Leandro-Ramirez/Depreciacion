namespace Presentaciones
{
    partial class FrmDatos
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
            this.TcInformacion = new System.Windows.Forms.TabControl();
            this.TpActivo = new System.Windows.Forms.TabPage();
            this.TpDepreciacion = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblValor = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtVida = new System.Windows.Forms.TextBox();
            this.LblVida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TcInformacion.SuspendLayout();
            this.TpActivo.SuspendLayout();
            this.TpDepreciacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TcInformacion
            // 
            this.TcInformacion.Controls.Add(this.TpActivo);
            this.TcInformacion.Controls.Add(this.TpDepreciacion);
            this.TcInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcInformacion.Location = new System.Drawing.Point(82, 58);
            this.TcInformacion.Name = "TcInformacion";
            this.TcInformacion.SelectedIndex = 0;
            this.TcInformacion.Size = new System.Drawing.Size(391, 350);
            this.TcInformacion.TabIndex = 0;
            // 
            // TpActivo
            // 
            this.TpActivo.Controls.Add(this.groupBox1);
            this.TpActivo.Controls.Add(this.listView1);
            this.TpActivo.Controls.Add(this.label2);
            this.TpActivo.Controls.Add(this.LblVida);
            this.TpActivo.Controls.Add(this.TxtVida);
            this.TpActivo.Controls.Add(this.TxtValor);
            this.TpActivo.Controls.Add(this.TxtDescripcion);
            this.TpActivo.Controls.Add(this.TxtNombre);
            this.TpActivo.Controls.Add(this.comboBox1);
            this.TpActivo.Controls.Add(this.LblDescripcion);
            this.TpActivo.Controls.Add(this.LblValor);
            this.TpActivo.Controls.Add(this.LblNombre);
            this.TpActivo.Controls.Add(this.LblTipo);
            this.TpActivo.Location = new System.Drawing.Point(4, 25);
            this.TpActivo.Name = "TpActivo";
            this.TpActivo.Padding = new System.Windows.Forms.Padding(3);
            this.TpActivo.Size = new System.Drawing.Size(383, 321);
            this.TpActivo.TabIndex = 0;
            this.TpActivo.Text = "Activo";
            this.TpActivo.UseVisualStyleBackColor = true;
            // 
            // TpDepreciacion
            // 
            this.TpDepreciacion.Controls.Add(this.label1);
            this.TpDepreciacion.Location = new System.Drawing.Point(4, 25);
            this.TpDepreciacion.Name = "TpDepreciacion";
            this.TpDepreciacion.Padding = new System.Windows.Forms.Padding(3);
            this.TpDepreciacion.Size = new System.Drawing.Size(542, 321);
            this.TpDepreciacion.TabIndex = 1;
            this.TpDepreciacion.Text = "Depreciacion";
            this.TpDepreciacion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(51, 40);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(44, 16);
            this.LblTipo.TabIndex = 1;
            this.LblTipo.Text = "Tipo:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(30, 71);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(67, 16);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(47, 150);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(49, 16);
            this.LblValor.TabIndex = 4;
            this.LblValor.Text = "Valor:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(7, 100);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(95, 16);
            this.LblDescripcion.TabIndex = 3;
            this.LblDescripcion.Text = "Descripcion:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Edificio",
            "EquipoDeComputo",
            "Inmobiliario",
            "Maquinaria"});
            this.comboBox1.Location = new System.Drawing.Point(101, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(101, 68);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(150, 22);
            this.TxtNombre.TabIndex = 0;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(101, 97);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(150, 44);
            this.TxtDescripcion.TabIndex = 1;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(101, 147);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(150, 22);
            this.TxtValor.TabIndex = 2;
            // 
            // TxtVida
            // 
            this.TxtVida.Location = new System.Drawing.Point(101, 176);
            this.TxtVida.Name = "TxtVida";
            this.TxtVida.Size = new System.Drawing.Size(150, 22);
            this.TxtVida.TabIndex = 3;
            // 
            // LblVida
            // 
            this.LblVida.AutoSize = true;
            this.LblVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVida.Location = new System.Drawing.Point(29, 179);
            this.LblVida.Name = "LblVida";
            this.LblVida.Size = new System.Drawing.Size(71, 16);
            this.LblVida.TabIndex = 5;
            this.LblVida.Text = "Vida Util:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos de los Activos";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 204);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(365, 111);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(6, 22);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.BtnRegistrar.TabIndex = 0;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(6, 58);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(100, 30);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(6, 130);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 30);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(6, 94);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRegistrar);
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Controls.Add(this.BtnMostrar);
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(257, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 167);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones:";
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TcInformacion);
            this.Name = "FrmDatos";
            this.Text = "Datos";
            this.TcInformacion.ResumeLayout(false);
            this.TpActivo.ResumeLayout(false);
            this.TpActivo.PerformLayout();
            this.TpDepreciacion.ResumeLayout(false);
            this.TpDepreciacion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TcInformacion;
        private System.Windows.Forms.TabPage TpActivo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.TabPage TpDepreciacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblVida;
        private System.Windows.Forms.TextBox TxtVida;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
    }
}

