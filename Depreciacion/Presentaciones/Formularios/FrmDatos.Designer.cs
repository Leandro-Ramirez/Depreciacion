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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LvDatos = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.LblVida = new System.Windows.Forms.Label();
            this.TxtVida = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblValor = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.TpDepreciacion = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnSalirR = new System.Windows.Forms.Button();
            this.BtnMostrarR = new System.Windows.Forms.Button();
            this.BtnCancelarR = new System.Windows.Forms.Button();
            this.DgvResultado = new System.Windows.Forms.DataGridView();
            this.CmbDepreciacion = new System.Windows.Forms.ComboBox();
            this.LblMetodo = new System.Windows.Forms.Label();
            this.LblActivo = new System.Windows.Forms.Label();
            this.CmbActivo = new System.Windows.Forms.ComboBox();
            this.LblVidaR = new System.Windows.Forms.Label();
            this.LblDescripcionR = new System.Windows.Forms.Label();
            this.LblValorR = new System.Windows.Forms.Label();
            this.LblNombreR = new System.Windows.Forms.Label();
            this.LblTipoR = new System.Windows.Forms.Label();
            this.TxtVidaR = new System.Windows.Forms.TextBox();
            this.TxtValorR = new System.Windows.Forms.TextBox();
            this.TxtDescripcionR = new System.Windows.Forms.TextBox();
            this.TxtNombreR = new System.Windows.Forms.TextBox();
            this.TxtTipoR = new System.Windows.Forms.TextBox();
            this.TxtValorResidual = new System.Windows.Forms.TextBox();
            this.LblVidaRR = new System.Windows.Forms.Label();
            this.LblTituloR = new System.Windows.Forms.Label();
            this.ChTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChVida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TcInformacion.SuspendLayout();
            this.TpActivo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TpDepreciacion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // TcInformacion
            // 
            this.TcInformacion.Controls.Add(this.TpActivo);
            this.TcInformacion.Controls.Add(this.TpDepreciacion);
            this.TcInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcInformacion.Location = new System.Drawing.Point(12, 12);
            this.TcInformacion.Name = "TcInformacion";
            this.TcInformacion.SelectedIndex = 0;
            this.TcInformacion.Size = new System.Drawing.Size(410, 460);
            this.TcInformacion.TabIndex = 0;
            // 
            // TpActivo
            // 
            this.TpActivo.Controls.Add(this.groupBox1);
            this.TpActivo.Controls.Add(this.LvDatos);
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
            this.TpActivo.Size = new System.Drawing.Size(402, 431);
            this.TpActivo.TabIndex = 0;
            this.TpActivo.Text = "Activo";
            this.TpActivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRegistrar);
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Controls.Add(this.BtnMostrar);
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(269, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 167);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones:";
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
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(6, 58);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(100, 30);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
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
            // LvDatos
            // 
            this.LvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChTipo,
            this.ChNombre,
            this.ChValor,
            this.ChVida,
            this.ChDescripcion});
            this.LvDatos.GridLines = true;
            this.LvDatos.HideSelection = false;
            this.LvDatos.Location = new System.Drawing.Point(6, 201);
            this.LvDatos.Name = "LvDatos";
            this.LvDatos.Size = new System.Drawing.Size(390, 224);
            this.LvDatos.TabIndex = 0;
            this.LvDatos.UseCompatibleStateImageBehavior = false;
            this.LvDatos.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos de los Activos";
            // 
            // LblVida
            // 
            this.LblVida.AutoSize = true;
            this.LblVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVida.Location = new System.Drawing.Point(41, 176);
            this.LblVida.Name = "LblVida";
            this.LblVida.Size = new System.Drawing.Size(71, 16);
            this.LblVida.TabIndex = 5;
            this.LblVida.Text = "Vida Util:";
            // 
            // TxtVida
            // 
            this.TxtVida.Location = new System.Drawing.Point(113, 173);
            this.TxtVida.Name = "TxtVida";
            this.TxtVida.Size = new System.Drawing.Size(150, 22);
            this.TxtVida.TabIndex = 3;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(113, 144);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(150, 22);
            this.TxtValor.TabIndex = 2;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(113, 94);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(150, 44);
            this.TxtDescripcion.TabIndex = 1;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(113, 65);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(150, 22);
            this.TxtNombre.TabIndex = 0;
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
            this.comboBox1.Location = new System.Drawing.Point(113, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(19, 97);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(95, 16);
            this.LblDescripcion.TabIndex = 3;
            this.LblDescripcion.Text = "Descripcion:";
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(59, 147);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(49, 16);
            this.LblValor.TabIndex = 4;
            this.LblValor.Text = "Valor:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(42, 68);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(67, 16);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(63, 37);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(44, 16);
            this.LblTipo.TabIndex = 1;
            this.LblTipo.Text = "Tipo:";
            // 
            // TpDepreciacion
            // 
            this.TpDepreciacion.Controls.Add(this.LblTituloR);
            this.TpDepreciacion.Controls.Add(this.LblVidaRR);
            this.TpDepreciacion.Controls.Add(this.TxtValorResidual);
            this.TpDepreciacion.Controls.Add(this.TxtTipoR);
            this.TpDepreciacion.Controls.Add(this.TxtVidaR);
            this.TpDepreciacion.Controls.Add(this.TxtValorR);
            this.TpDepreciacion.Controls.Add(this.TxtDescripcionR);
            this.TpDepreciacion.Controls.Add(this.TxtNombreR);
            this.TpDepreciacion.Controls.Add(this.LblVidaR);
            this.TpDepreciacion.Controls.Add(this.CmbActivo);
            this.TpDepreciacion.Controls.Add(this.LblDescripcionR);
            this.TpDepreciacion.Controls.Add(this.LblActivo);
            this.TpDepreciacion.Controls.Add(this.LblValorR);
            this.TpDepreciacion.Controls.Add(this.LblMetodo);
            this.TpDepreciacion.Controls.Add(this.LblNombreR);
            this.TpDepreciacion.Controls.Add(this.CmbDepreciacion);
            this.TpDepreciacion.Controls.Add(this.LblTipoR);
            this.TpDepreciacion.Controls.Add(this.DgvResultado);
            this.TpDepreciacion.Controls.Add(this.groupBox2);
            this.TpDepreciacion.Location = new System.Drawing.Point(4, 25);
            this.TpDepreciacion.Name = "TpDepreciacion";
            this.TpDepreciacion.Padding = new System.Windows.Forms.Padding(3);
            this.TpDepreciacion.Size = new System.Drawing.Size(402, 431);
            this.TpDepreciacion.TabIndex = 1;
            this.TpDepreciacion.Text = "Depreciacion";
            this.TpDepreciacion.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCalcular);
            this.groupBox2.Controls.Add(this.BtnSalirR);
            this.groupBox2.Controls.Add(this.BtnMostrarR);
            this.groupBox2.Controls.Add(this.BtnCancelarR);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(278, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 167);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Botones:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(6, 22);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(100, 30);
            this.BtnCalcular.TabIndex = 0;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            // 
            // BtnSalirR
            // 
            this.BtnSalirR.Location = new System.Drawing.Point(6, 130);
            this.BtnSalirR.Name = "BtnSalirR";
            this.BtnSalirR.Size = new System.Drawing.Size(100, 30);
            this.BtnSalirR.TabIndex = 3;
            this.BtnSalirR.Text = "Salir";
            this.BtnSalirR.UseVisualStyleBackColor = true;
            this.BtnSalirR.Click += new System.EventHandler(this.BtnSalirR_Click);
            // 
            // BtnMostrarR
            // 
            this.BtnMostrarR.Location = new System.Drawing.Point(6, 58);
            this.BtnMostrarR.Name = "BtnMostrarR";
            this.BtnMostrarR.Size = new System.Drawing.Size(100, 30);
            this.BtnMostrarR.TabIndex = 1;
            this.BtnMostrarR.Text = "Mostrar";
            this.BtnMostrarR.UseVisualStyleBackColor = true;
            // 
            // BtnCancelarR
            // 
            this.BtnCancelarR.Location = new System.Drawing.Point(6, 94);
            this.BtnCancelarR.Name = "BtnCancelarR";
            this.BtnCancelarR.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelarR.TabIndex = 2;
            this.BtnCancelarR.Text = "Cancelar";
            this.BtnCancelarR.UseVisualStyleBackColor = true;
            // 
            // DgvResultado
            // 
            this.DgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResultado.Location = new System.Drawing.Point(6, 286);
            this.DgvResultado.Name = "DgvResultado";
            this.DgvResultado.Size = new System.Drawing.Size(386, 139);
            this.DgvResultado.TabIndex = 0;
            // 
            // CmbDepreciacion
            // 
            this.CmbDepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDepreciacion.FormattingEnabled = true;
            this.CmbDepreciacion.Items.AddRange(new object[] {
            "LineaRecta",
            "SDAIncremental"});
            this.CmbDepreciacion.Location = new System.Drawing.Point(122, 32);
            this.CmbDepreciacion.Name = "CmbDepreciacion";
            this.CmbDepreciacion.Size = new System.Drawing.Size(149, 24);
            this.CmbDepreciacion.TabIndex = 0;
            // 
            // LblMetodo
            // 
            this.LblMetodo.AutoSize = true;
            this.LblMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMetodo.Location = new System.Drawing.Point(52, 35);
            this.LblMetodo.Name = "LblMetodo";
            this.LblMetodo.Size = new System.Drawing.Size(64, 16);
            this.LblMetodo.TabIndex = 1;
            this.LblMetodo.Text = "Metodo:";
            // 
            // LblActivo
            // 
            this.LblActivo.AutoSize = true;
            this.LblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblActivo.Location = new System.Drawing.Point(61, 66);
            this.LblActivo.Name = "LblActivo";
            this.LblActivo.Size = new System.Drawing.Size(55, 16);
            this.LblActivo.TabIndex = 2;
            this.LblActivo.Text = "Activo:";
            // 
            // CmbActivo
            // 
            this.CmbActivo.FormattingEnabled = true;
            this.CmbActivo.Location = new System.Drawing.Point(122, 63);
            this.CmbActivo.Name = "CmbActivo";
            this.CmbActivo.Size = new System.Drawing.Size(149, 24);
            this.CmbActivo.TabIndex = 1;
            // 
            // LblVidaR
            // 
            this.LblVidaR.AutoSize = true;
            this.LblVidaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVidaR.Location = new System.Drawing.Point(45, 232);
            this.LblVidaR.Name = "LblVidaR";
            this.LblVidaR.Size = new System.Drawing.Size(71, 16);
            this.LblVidaR.TabIndex = 7;
            this.LblVidaR.Text = "Vida Util:";
            // 
            // LblDescripcionR
            // 
            this.LblDescripcionR.AutoSize = true;
            this.LblDescripcionR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcionR.Location = new System.Drawing.Point(21, 153);
            this.LblDescripcionR.Name = "LblDescripcionR";
            this.LblDescripcionR.Size = new System.Drawing.Size(95, 16);
            this.LblDescripcionR.TabIndex = 5;
            this.LblDescripcionR.Text = "Descripcion:";
            // 
            // LblValorR
            // 
            this.LblValorR.AutoSize = true;
            this.LblValorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorR.Location = new System.Drawing.Point(67, 203);
            this.LblValorR.Name = "LblValorR";
            this.LblValorR.Size = new System.Drawing.Size(49, 16);
            this.LblValorR.TabIndex = 6;
            this.LblValorR.Text = "Valor:";
            // 
            // LblNombreR
            // 
            this.LblNombreR.AutoSize = true;
            this.LblNombreR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreR.Location = new System.Drawing.Point(49, 124);
            this.LblNombreR.Name = "LblNombreR";
            this.LblNombreR.Size = new System.Drawing.Size(67, 16);
            this.LblNombreR.TabIndex = 4;
            this.LblNombreR.Text = "Nombre:";
            // 
            // LblTipoR
            // 
            this.LblTipoR.AutoSize = true;
            this.LblTipoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoR.Location = new System.Drawing.Point(72, 96);
            this.LblTipoR.Name = "LblTipoR";
            this.LblTipoR.Size = new System.Drawing.Size(44, 16);
            this.LblTipoR.TabIndex = 3;
            this.LblTipoR.Text = "Tipo:";
            // 
            // TxtVidaR
            // 
            this.TxtVidaR.Location = new System.Drawing.Point(122, 229);
            this.TxtVidaR.Name = "TxtVidaR";
            this.TxtVidaR.ReadOnly = true;
            this.TxtVidaR.Size = new System.Drawing.Size(50, 22);
            this.TxtVidaR.TabIndex = 4;
            // 
            // TxtValorR
            // 
            this.TxtValorR.Location = new System.Drawing.Point(122, 200);
            this.TxtValorR.Name = "TxtValorR";
            this.TxtValorR.ReadOnly = true;
            this.TxtValorR.Size = new System.Drawing.Size(100, 22);
            this.TxtValorR.TabIndex = 3;
            // 
            // TxtDescripcionR
            // 
            this.TxtDescripcionR.Location = new System.Drawing.Point(122, 150);
            this.TxtDescripcionR.Multiline = true;
            this.TxtDescripcionR.Name = "TxtDescripcionR";
            this.TxtDescripcionR.ReadOnly = true;
            this.TxtDescripcionR.Size = new System.Drawing.Size(150, 44);
            this.TxtDescripcionR.TabIndex = 2;
            // 
            // TxtNombreR
            // 
            this.TxtNombreR.Location = new System.Drawing.Point(122, 121);
            this.TxtNombreR.Name = "TxtNombreR";
            this.TxtNombreR.ReadOnly = true;
            this.TxtNombreR.Size = new System.Drawing.Size(150, 22);
            this.TxtNombreR.TabIndex = 1;
            // 
            // TxtTipoR
            // 
            this.TxtTipoR.Location = new System.Drawing.Point(122, 93);
            this.TxtTipoR.Name = "TxtTipoR";
            this.TxtTipoR.ReadOnly = true;
            this.TxtTipoR.Size = new System.Drawing.Size(149, 22);
            this.TxtTipoR.TabIndex = 0;
            // 
            // TxtValorResidual
            // 
            this.TxtValorResidual.Location = new System.Drawing.Point(122, 258);
            this.TxtValorResidual.Name = "TxtValorResidual";
            this.TxtValorResidual.Size = new System.Drawing.Size(100, 22);
            this.TxtValorResidual.TabIndex = 5;
            // 
            // LblVidaRR
            // 
            this.LblVidaRR.AutoSize = true;
            this.LblVidaRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVidaRR.Location = new System.Drawing.Point(6, 261);
            this.LblVidaRR.Name = "LblVidaRR";
            this.LblVidaRR.Size = new System.Drawing.Size(110, 16);
            this.LblVidaRR.TabIndex = 8;
            this.LblVidaRR.Text = "Vida Residual:";
            // 
            // LblTituloR
            // 
            this.LblTituloR.AutoSize = true;
            this.LblTituloR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloR.Location = new System.Drawing.Point(71, 3);
            this.LblTituloR.Name = "LblTituloR";
            this.LblTituloR.Size = new System.Drawing.Size(262, 24);
            this.LblTituloR.TabIndex = 0;
            this.LblTituloR.Text = "Calculo de la Depreciacion";
            // 
            // ChTipo
            // 
            this.ChTipo.Text = "Tipo";
            this.ChTipo.Width = 69;
            // 
            // ChNombre
            // 
            this.ChNombre.Text = "Nombre";
            this.ChNombre.Width = 88;
            // 
            // ChValor
            // 
            this.ChValor.Text = "Valor";
            this.ChValor.Width = 76;
            // 
            // ChVida
            // 
            this.ChVida.Text = "Vida Util";
            this.ChVida.Width = 67;
            // 
            // ChDescripcion
            // 
            this.ChDescripcion.Text = "Descripcion";
            this.ChDescripcion.Width = 86;
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 514);
            this.Controls.Add(this.TcInformacion);
            this.Name = "FrmDatos";
            this.Text = "Datos";
            this.TcInformacion.ResumeLayout(false);
            this.TpActivo.ResumeLayout(false);
            this.TpActivo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.TpDepreciacion.ResumeLayout(false);
            this.TpDepreciacion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultado)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ListView LvDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblVida;
        private System.Windows.Forms.TextBox TxtVida;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnSalirR;
        private System.Windows.Forms.Button BtnMostrarR;
        private System.Windows.Forms.Button BtnCancelarR;
        private System.Windows.Forms.Label LblVidaRR;
        private System.Windows.Forms.TextBox TxtValorResidual;
        private System.Windows.Forms.TextBox TxtTipoR;
        private System.Windows.Forms.TextBox TxtVidaR;
        private System.Windows.Forms.TextBox TxtValorR;
        private System.Windows.Forms.TextBox TxtDescripcionR;
        private System.Windows.Forms.TextBox TxtNombreR;
        private System.Windows.Forms.Label LblVidaR;
        private System.Windows.Forms.ComboBox CmbActivo;
        private System.Windows.Forms.Label LblDescripcionR;
        private System.Windows.Forms.Label LblActivo;
        private System.Windows.Forms.Label LblValorR;
        private System.Windows.Forms.Label LblMetodo;
        private System.Windows.Forms.Label LblNombreR;
        private System.Windows.Forms.ComboBox CmbDepreciacion;
        private System.Windows.Forms.Label LblTipoR;
        private System.Windows.Forms.DataGridView DgvResultado;
        private System.Windows.Forms.ColumnHeader ChTipo;
        private System.Windows.Forms.ColumnHeader ChNombre;
        private System.Windows.Forms.ColumnHeader ChValor;
        private System.Windows.Forms.ColumnHeader ChVida;
        private System.Windows.Forms.ColumnHeader ChDescripcion;
        private System.Windows.Forms.Label LblTituloR;
    }
}

