namespace pryLantieriSP3
{
    partial class VentaRepuestos
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
            txtNumRepuesto = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            lstRepuestos = new ListBox();
            btnGuardar = new Button();
            cmbOrigen = new ComboBox();
            cmbMarca = new ComboBox();
            lblNumeroRepuesto = new Label();
            lblDesc = new Label();
            lblPrecio = new Label();
            lblTitulo = new Label();
            lblMarca = new Label();
            lblOrigen = new Label();
            lblSubtitulo = new Label();
            cmbMarca2 = new ComboBox();
            rbNacional = new RadioButton();
            rbImportado = new RadioButton();
            grbBuscador = new GroupBox();
            grbBuscador.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumRepuesto
            // 
            txtNumRepuesto.Location = new Point(218, 81);
            txtNumRepuesto.Name = "txtNumRepuesto";
            txtNumRepuesto.Size = new Size(100, 23);
            txtNumRepuesto.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(218, 119);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(218, 166);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 3;
            // 
            // lstRepuestos
            // 
            lstRepuestos.FormattingEnabled = true;
            lstRepuestos.Location = new Point(44, 335);
            lstRepuestos.Name = "lstRepuestos";
            lstRepuestos.Size = new Size(402, 49);
            lstRepuestos.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(330, 287);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 42);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "N", "I" });
            cmbOrigen.Location = new Point(218, 258);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(121, 23);
            cmbOrigen.TabIndex = 5;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "F", "P", "R" });
            cmbMarca.Location = new Point(218, 211);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(121, 23);
            cmbMarca.TabIndex = 4;
            cmbMarca.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // lblNumeroRepuesto
            // 
            lblNumeroRepuesto.AutoSize = true;
            lblNumeroRepuesto.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblNumeroRepuesto.Location = new Point(44, 74);
            lblNumeroRepuesto.Name = "lblNumeroRepuesto";
            lblNumeroRepuesto.Size = new Size(168, 30);
            lblNumeroRepuesto.TabIndex = 12;
            lblNumeroRepuesto.Text = "Nº de Repuesto:";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblDesc.Location = new Point(82, 112);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(129, 30);
            lblDesc.TabIndex = 13;
            lblDesc.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblPrecio.Location = new Point(134, 157);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(77, 30);
            lblPrecio.TabIndex = 14;
            lblPrecio.Text = "Precio:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(99, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(343, 47);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Venta de Repuestos";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblMarca.Location = new Point(134, 202);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(77, 30);
            lblMarca.TabIndex = 16;
            lblMarca.Text = "Marca:";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblOrigen.Location = new Point(128, 249);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(83, 30);
            lblOrigen.TabIndex = 17;
            lblOrigen.Text = "Origen:";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(44, 387);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(203, 32);
            lblSubtitulo.TabIndex = 11;
            lblSubtitulo.Text = "Buscar Repuesto";
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
            // grbBuscador
            // 
            grbBuscador.Controls.Add(rbNacional);
            grbBuscador.Controls.Add(cmbMarca2);
            grbBuscador.Controls.Add(rbImportado);
            grbBuscador.Location = new Point(46, 422);
            grbBuscador.Name = "grbBuscador";
            grbBuscador.Size = new Size(240, 70);
            grbBuscador.TabIndex = 7;
            grbBuscador.TabStop = false;
            // 
            // VentaRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 529);
            Controls.Add(grbBuscador);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblOrigen);
            Controls.Add(lblMarca);
            Controls.Add(lblTitulo);
            Controls.Add(lblPrecio);
            Controls.Add(lblDesc);
            Controls.Add(lblNumeroRepuesto);
            Controls.Add(cmbMarca);
            Controls.Add(cmbOrigen);
            Controls.Add(btnGuardar);
            Controls.Add(lstRepuestos);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNumRepuesto);
            Name = "VentaRepuestos";
            Text = "SP3 - Repuestos";
            grbBuscador.ResumeLayout(false);
            grbBuscador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumRepuesto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private ListBox lstRepuestos;
        private Button btnGuardar;
        private ComboBox cmbOrigen;
        private ComboBox cmbMarca;
        private Label lblNumeroRepuesto;
        private Label lblDesc;
        private Label lblPrecio;
        private Label lblTitulo;
        private Label lblMarca;
        private Label lblOrigen;
        private Label lblSubtitulo;
        private ComboBox cmbMarca2;
        private RadioButton rbNacional;
        private RadioButton rbImportado;
        private GroupBox grbBuscador;
    }
}
