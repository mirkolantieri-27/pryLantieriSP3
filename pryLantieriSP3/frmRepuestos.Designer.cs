namespace pryLantieriSP3
{
    partial class frmRepuestos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstRepuestos = new ListBox();
            lblTitulo = new Label();
            tbCargaDeRepuestos = new TabControl();
            tbpCarga = new TabPage();
            grpOrigen = new GroupBox();
            rdbImportado = new RadioButton();
            rdbNacional = new RadioButton();
            btnSalir = new Button();
            lblOrigen = new Label();
            lblMarca = new Label();
            cmbMarca = new ComboBox();
            lblPrecio = new Label();
            lblDesc = new Label();
            lblNumeroRepuesto = new Label();
            btnRegistrar = new Button();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtNumRepuesto = new TextBox();
            tbpBusqueda = new TabPage();
            grbBuscador = new GroupBox();
            rbNacional = new RadioButton();
            cmbMarca2 = new ComboBox();
            rbImportado = new RadioButton();
            lblSubtitulo = new Label();
            tbCargaDeRepuestos.SuspendLayout();
            tbpCarga.SuspendLayout();
            grpOrigen.SuspendLayout();
            tbpBusqueda.SuspendLayout();
            grbBuscador.SuspendLayout();
            SuspendLayout();
            // 
            // lstRepuestos
            // 
            lstRepuestos.FormattingEnabled = true;
            lstRepuestos.Location = new Point(3, 297);
            lstRepuestos.Name = "lstRepuestos";
            lstRepuestos.Size = new Size(448, 79);
            lstRepuestos.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(78, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(343, 47);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Venta de Repuestos";
            // 
            // tbCargaDeRepuestos
            // 
            tbCargaDeRepuestos.Controls.Add(tbpCarga);
            tbCargaDeRepuestos.Controls.Add(tbpBusqueda);
            tbCargaDeRepuestos.Location = new Point(12, 64);
            tbCargaDeRepuestos.Name = "tbCargaDeRepuestos";
            tbCargaDeRepuestos.SelectedIndex = 0;
            tbCargaDeRepuestos.Size = new Size(462, 410);
            tbCargaDeRepuestos.TabIndex = 18;
            // 
            // tbpCarga
            // 
            tbpCarga.Controls.Add(grpOrigen);
            tbpCarga.Controls.Add(btnSalir);
            tbpCarga.Controls.Add(lblOrigen);
            tbpCarga.Controls.Add(lblMarca);
            tbpCarga.Controls.Add(cmbMarca);
            tbpCarga.Controls.Add(lstRepuestos);
            tbpCarga.Controls.Add(lblPrecio);
            tbpCarga.Controls.Add(lblDesc);
            tbpCarga.Controls.Add(lblNumeroRepuesto);
            tbpCarga.Controls.Add(btnRegistrar);
            tbpCarga.Controls.Add(txtPrecio);
            tbpCarga.Controls.Add(txtDescripcion);
            tbpCarga.Controls.Add(txtNumRepuesto);
            tbpCarga.Location = new Point(4, 24);
            tbpCarga.Name = "tbpCarga";
            tbpCarga.Padding = new Padding(3);
            tbpCarga.Size = new Size(454, 382);
            tbpCarga.TabIndex = 0;
            tbpCarga.Text = "Carga";
            tbpCarga.UseVisualStyleBackColor = true;
            tbpCarga.Click += tbpCarga_Click;
            // 
            // grpOrigen
            // 
            grpOrigen.Controls.Add(rdbImportado);
            grpOrigen.Controls.Add(rdbNacional);
            grpOrigen.Location = new Point(202, 35);
            grpOrigen.Name = "grpOrigen";
            grpOrigen.Size = new Size(218, 51);
            grpOrigen.TabIndex = 36;
            grpOrigen.TabStop = false;
            // 
            // rdbImportado
            // 
            rdbImportado.AutoSize = true;
            rdbImportado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rdbImportado.Location = new Point(118, 22);
            rdbImportado.Name = "rdbImportado";
            rdbImportado.Size = new Size(91, 21);
            rdbImportado.TabIndex = 35;
            rdbImportado.TabStop = true;
            rdbImportado.Text = "Importado";
            rdbImportado.UseVisualStyleBackColor = true;
            rdbImportado.CheckedChanged += rdbImportado_CheckedChanged;
            // 
            // rdbNacional
            // 
            rdbNacional.AutoSize = true;
            rdbNacional.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rdbNacional.Location = new Point(8, 22);
            rdbNacional.Name = "rdbNacional";
            rdbNacional.Size = new Size(78, 21);
            rdbNacional.TabIndex = 34;
            rdbNacional.TabStop = true;
            rdbNacional.Text = "Nacional";
            rdbNacional.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(3, 249);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 42);
            btnSalir.TabIndex = 33;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblOrigen.Location = new Point(112, 44);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(83, 30);
            lblOrigen.TabIndex = 32;
            lblOrigen.Text = "Origen:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblMarca.Location = new Point(118, -3);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(77, 30);
            lblMarca.TabIndex = 31;
            lblMarca.Text = "Marca:";
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "F", "P", "R" });
            cmbMarca.Location = new Point(202, 6);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(121, 23);
            cmbMarca.TabIndex = 29;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblPrecio.Location = new Point(118, 249);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(77, 30);
            lblPrecio.TabIndex = 26;
            lblPrecio.Text = "Precio:";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblDesc.Location = new Point(66, 124);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(129, 30);
            lblDesc.TabIndex = 25;
            lblDesc.Text = "Descripción:";
            // 
            // lblNumeroRepuesto
            // 
            lblNumeroRepuesto.AutoSize = true;
            lblNumeroRepuesto.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblNumeroRepuesto.Location = new Point(28, 85);
            lblNumeroRepuesto.Name = "lblNumeroRepuesto";
            lblNumeroRepuesto.Size = new Size(168, 30);
            lblNumeroRepuesto.TabIndex = 24;
            lblNumeroRepuesto.Text = "Nº de Repuesto:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(320, 249);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(128, 42);
            btnRegistrar.TabIndex = 23;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnGuardar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(202, 258);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 20;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(202, 131);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(203, 99);
            txtDescripcion.TabIndex = 19;
            // 
            // txtNumRepuesto
            // 
            txtNumRepuesto.Location = new Point(202, 92);
            txtNumRepuesto.Name = "txtNumRepuesto";
            txtNumRepuesto.Size = new Size(121, 23);
            txtNumRepuesto.TabIndex = 18;
            // 
            // tbpBusqueda
            // 
            tbpBusqueda.Controls.Add(grbBuscador);
            tbpBusqueda.Controls.Add(lblSubtitulo);
            tbpBusqueda.Location = new Point(4, 24);
            tbpBusqueda.Name = "tbpBusqueda";
            tbpBusqueda.Padding = new Padding(3);
            tbpBusqueda.Size = new Size(454, 382);
            tbpBusqueda.TabIndex = 1;
            tbpBusqueda.Text = "Buscador";
            tbpBusqueda.UseVisualStyleBackColor = true;
            // 
            // grbBuscador
            // 
            grbBuscador.Controls.Add(rbNacional);
            grbBuscador.Controls.Add(cmbMarca2);
            grbBuscador.Controls.Add(rbImportado);
            grbBuscador.Location = new Point(15, 47);
            grbBuscador.Name = "grbBuscador";
            grbBuscador.Size = new Size(240, 70);
            grbBuscador.TabIndex = 12;
            grbBuscador.TabStop = false;
            // 
            // rbNacional
            // 
            rbNacional.AutoSize = true;
            rbNacional.Location = new Point(141, 22);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(34, 19);
            rbNacional.TabIndex = 20;
            rbNacional.TabStop = true;
            rbNacional.Text = "N";
            rbNacional.UseVisualStyleBackColor = true;
            // 
            // cmbMarca2
            // 
            cmbMarca2.FormattingEnabled = true;
            cmbMarca2.Items.AddRange(new object[] { "F", "P", "R" });
            cmbMarca2.Location = new Point(6, 22);
            cmbMarca2.Name = "cmbMarca2";
            cmbMarca2.Size = new Size(121, 23);
            cmbMarca2.TabIndex = 19;
            // 
            // rbImportado
            // 
            rbImportado.AutoSize = true;
            rbImportado.Location = new Point(141, 47);
            rbImportado.Name = "rbImportado";
            rbImportado.Size = new Size(28, 19);
            rbImportado.TabIndex = 21;
            rbImportado.TabStop = true;
            rbImportado.Text = "I";
            rbImportado.UseVisualStyleBackColor = true;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(13, 12);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(203, 32);
            lblSubtitulo.TabIndex = 13;
            lblSubtitulo.Text = "Buscar Repuesto";
            // 
            // VentaRepuestos
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(471, 511);
            Controls.Add(tbCargaDeRepuestos);
            Controls.Add(lblTitulo);
            Name = "VentaRepuestos";
            Text = "SP3 - Repuestos";
            tbCargaDeRepuestos.ResumeLayout(false);
            tbpCarga.ResumeLayout(false);
            tbpCarga.PerformLayout();
            grpOrigen.ResumeLayout(false);
            grpOrigen.PerformLayout();
            tbpBusqueda.ResumeLayout(false);
            tbpBusqueda.PerformLayout();
            grbBuscador.ResumeLayout(false);
            grbBuscador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox lstRepuestos;
        private Label lblTitulo;
        private TabControl tbCargaDeRepuestos;
        private TabPage tbpCarga;
        private Label lblPrecio;
        private Label lblDesc;
        private Label lblNumeroRepuesto;
        private Button btnRegistrar;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtNumRepuesto;
        private TabPage tbpBusqueda;
        private GroupBox grbBuscador;
        private RadioButton rbNacional;
        private ComboBox cmbMarca2;
        private RadioButton rbImportado;
        private Label lblSubtitulo;
        private Label lblOrigen;
        private Label lblMarca;
        private ComboBox cmbMarca;
        private Button btnSalir;
        private GroupBox grpOrigen;
        private RadioButton rdbImportado;
        private RadioButton rdbNacional;
    }
}
