namespace ClubDeportivoApp
{
    partial class Detalle_Comprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalle_Comprobante));
            imgBoxOpc = new PictureBox();
            lblTitulo = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            ImgOptPagado = new PictureBox();
            label3 = new Label();
            txtBoxCodSoc = new TextBox();
            txtBoxNomSoc = new TextBox();
            txtBoxApellSoc = new TextBox();
            lblCodCliente = new Label();
            lblApellido = new Label();
            lblCodigo = new Label();
            lblTituloCliente = new Label();
            label1 = new Label();
            txtBoxDniSoc = new TextBox();
            label2 = new Label();
            txtBoxCodPago = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtBoxNumPago = new TextBox();
            txtBoxVencPago = new TextBox();
            label6 = new Label();
            txtBoxTipoPago = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtBoxMontoPago = new TextBox();
            txtBoxFechaPago = new TextBox();
            label9 = new Label();
            btnDescargarResumen = new Button();
            btnVolver = new Button();
            txtCantidadCuotas = new TextBox();
            lblCantidadCuotas = new Label();
            txtImporteCuotas = new TextBox();
            lblImporteCuotas = new Label();
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImgOptPagado).BeginInit();
            SuspendLayout();
            // 
            // imgBoxOpc
            // 
            imgBoxOpc.Anchor = AnchorStyles.None;
            imgBoxOpc.BackColor = SystemColors.AppWorkspace;
            imgBoxOpc.Image = (Image)resources.GetObject("imgBoxOpc.Image");
            imgBoxOpc.Location = new Point(25, 35);
            imgBoxOpc.Name = "imgBoxOpc";
            imgBoxOpc.Size = new Size(110, 107);
            imgBoxOpc.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxOpc.TabIndex = 20;
            imgBoxOpc.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DarkGreen;
            lblTitulo.Location = new Point(141, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(212, 41);
            lblTitulo.TabIndex = 37;
            lblTitulo.Text = "SPORTS CLUB";
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.None;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(141, 76);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(224, 23);
            lblDireccion.TabIndex = 38;
            lblDireccion.Text = "Direccion: Avenida Falsa 321";
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.None;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(141, 99);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(162, 23);
            lblTelefono.TabIndex = 39;
            lblTelefono.Text = "Telefono: 4677-8833";
            // 
            // ImgOptPagado
            // 
            ImgOptPagado.Anchor = AnchorStyles.None;
            ImgOptPagado.BackColor = Color.Transparent;
            ImgOptPagado.Image = (Image)resources.GetObject("ImgOptPagado.Image");
            ImgOptPagado.Location = new Point(387, 35);
            ImgOptPagado.Name = "ImgOptPagado";
            ImgOptPagado.Size = new Size(261, 163);
            ImgOptPagado.SizeMode = PictureBoxSizeMode.StretchImage;
            ImgOptPagado.TabIndex = 40;
            ImgOptPagado.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(466, 260);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 53;
            // 
            // txtBoxCodSoc
            // 
            txtBoxCodSoc.Anchor = AnchorStyles.None;
            txtBoxCodSoc.Location = new Point(141, 237);
            txtBoxCodSoc.Name = "txtBoxCodSoc";
            txtBoxCodSoc.ReadOnly = true;
            txtBoxCodSoc.Size = new Size(187, 27);
            txtBoxCodSoc.TabIndex = 1;
            // 
            // txtBoxNomSoc
            // 
            txtBoxNomSoc.Anchor = AnchorStyles.None;
            txtBoxNomSoc.Location = new Point(141, 273);
            txtBoxNomSoc.Name = "txtBoxNomSoc";
            txtBoxNomSoc.ReadOnly = true;
            txtBoxNomSoc.Size = new Size(187, 27);
            txtBoxNomSoc.TabIndex = 2;
            // 
            // txtBoxApellSoc
            // 
            txtBoxApellSoc.Anchor = AnchorStyles.None;
            txtBoxApellSoc.Location = new Point(428, 273);
            txtBoxApellSoc.Name = "txtBoxApellSoc";
            txtBoxApellSoc.ReadOnly = true;
            txtBoxApellSoc.Size = new Size(178, 27);
            txtBoxApellSoc.TabIndex = 3;
            // 
            // lblCodCliente
            // 
            lblCodCliente.Anchor = AnchorStyles.None;
            lblCodCliente.AutoSize = true;
            lblCodCliente.Font = new Font("Segoe UI", 9F);
            lblCodCliente.Location = new Point(62, 240);
            lblCodCliente.Name = "lblCodCliente";
            lblCodCliente.Size = new Size(73, 20);
            lblCodCliente.TabIndex = 49;
            lblCodCliente.Text = "SOCIO N°";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F);
            lblApellido.Location = new Point(347, 276);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(75, 20);
            lblApellido.TabIndex = 48;
            lblApellido.Text = "APELLIDO";
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.None;
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9F);
            lblCodigo.Location = new Point(65, 277);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(70, 20);
            lblCodigo.TabIndex = 47;
            lblCodigo.Text = "NOMBRE";
            // 
            // lblTituloCliente
            // 
            lblTituloCliente.Anchor = AnchorStyles.None;
            lblTituloCliente.AutoSize = true;
            lblTituloCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCliente.Location = new Point(40, 183);
            lblTituloCliente.Name = "lblTituloCliente";
            lblTituloCliente.Size = new Size(194, 28);
            lblTituloCliente.TabIndex = 54;
            lblTituloCliente.Text = "DATOS DEL CLIENTE";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(387, 239);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 55;
            label1.Text = "DNI";
            // 
            // txtBoxDniSoc
            // 
            txtBoxDniSoc.Anchor = AnchorStyles.None;
            txtBoxDniSoc.Location = new Point(428, 236);
            txtBoxDniSoc.Name = "txtBoxDniSoc";
            txtBoxDniSoc.ReadOnly = true;
            txtBoxDniSoc.Size = new Size(178, 27);
            txtBoxDniSoc.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 342);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 57;
            label2.Text = "DETALLE DEL PAGO";
            // 
            // txtBoxCodPago
            // 
            txtBoxCodPago.Anchor = AnchorStyles.None;
            txtBoxCodPago.Location = new Point(141, 394);
            txtBoxCodPago.Name = "txtBoxCodPago";
            txtBoxCodPago.ReadOnly = true;
            txtBoxCodPago.Size = new Size(187, 27);
            txtBoxCodPago.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(20, 401);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 58;
            label4.Text = "CODIGO CUOTA";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(395, 397);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 60;
            label5.Text = "NUMERO";
            // 
            // txtBoxNumPago
            // 
            txtBoxNumPago.Anchor = AnchorStyles.None;
            txtBoxNumPago.Location = new Point(466, 394);
            txtBoxNumPago.Name = "txtBoxNumPago";
            txtBoxNumPago.ReadOnly = true;
            txtBoxNumPago.Size = new Size(140, 27);
            txtBoxNumPago.TabIndex = 6;
            // 
            // txtBoxVencPago
            // 
            txtBoxVencPago.Anchor = AnchorStyles.None;
            txtBoxVencPago.Location = new Point(141, 439);
            txtBoxVencPago.Name = "txtBoxVencPago";
            txtBoxVencPago.ReadOnly = true;
            txtBoxVencPago.Size = new Size(187, 27);
            txtBoxVencPago.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(31, 445);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 62;
            label6.Text = "VENCIMIENTO";
            // 
            // txtBoxTipoPago
            // 
            txtBoxTipoPago.Anchor = AnchorStyles.None;
            txtBoxTipoPago.Location = new Point(141, 491);
            txtBoxTipoPago.Name = "txtBoxTipoPago";
            txtBoxTipoPago.ReadOnly = true;
            txtBoxTipoPago.Size = new Size(187, 27);
            txtBoxTipoPago.TabIndex = 9;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(32, 494);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 66;
            label8.Text = "TIPO de PAGO";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(352, 446);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 64;
            label7.Text = "IMPORTE TOTAL";
            // 
            // txtBoxMontoPago
            // 
            txtBoxMontoPago.Anchor = AnchorStyles.None;
            txtBoxMontoPago.Location = new Point(466, 442);
            txtBoxMontoPago.Name = "txtBoxMontoPago";
            txtBoxMontoPago.ReadOnly = true;
            txtBoxMontoPago.Size = new Size(140, 27);
            txtBoxMontoPago.TabIndex = 8;
            // 
            // txtBoxFechaPago
            // 
            txtBoxFechaPago.Anchor = AnchorStyles.None;
            txtBoxFechaPago.Location = new Point(466, 487);
            txtBoxFechaPago.Name = "txtBoxFechaPago";
            txtBoxFechaPago.ReadOnly = true;
            txtBoxFechaPago.Size = new Size(140, 27);
            txtBoxFechaPago.TabIndex = 10;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(342, 494);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 68;
            label9.Text = "FECHA de PAGO";
            // 
            // btnDescargarResumen
            // 
            btnDescargarResumen.Anchor = AnchorStyles.None;
            btnDescargarResumen.BackColor = Color.Navy;
            btnDescargarResumen.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDescargarResumen.ForeColor = Color.Linen;
            btnDescargarResumen.Location = new Point(257, 665);
            btnDescargarResumen.Name = "btnDescargarResumen";
            btnDescargarResumen.Size = new Size(175, 53);
            btnDescargarResumen.TabIndex = 11;
            btnDescargarResumen.Text = "DESCARGAR PDF";
            btnDescargarResumen.UseVisualStyleBackColor = false;
            btnDescargarResumen.Click += btnDescargarResumen_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.BackColor = Color.FromArgb(120, 10, 90);
            btnVolver.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.Linen;
            btnVolver.Location = new Point(454, 665);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(152, 53);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtCantidadCuotas
            // 
            txtCantidadCuotas.Anchor = AnchorStyles.None;
            txtCantidadCuotas.Location = new Point(209, 550);
            txtCantidadCuotas.Name = "txtCantidadCuotas";
            txtCantidadCuotas.ReadOnly = true;
            txtCantidadCuotas.Size = new Size(119, 27);
            txtCantidadCuotas.TabIndex = 69;
            // 
            // lblCantidadCuotas
            // 
            lblCantidadCuotas.Anchor = AnchorStyles.None;
            lblCantidadCuotas.AutoSize = true;
            lblCantidadCuotas.Font = new Font("Segoe UI", 9F);
            lblCantidadCuotas.Location = new Point(125, 557);
            lblCantidadCuotas.Name = "lblCantidadCuotas";
            lblCantidadCuotas.Size = new Size(63, 20);
            lblCantidadCuotas.TabIndex = 70;
            lblCantidadCuotas.Text = "CUOTAS";
            // 
            // txtImporteCuotas
            // 
            txtImporteCuotas.Anchor = AnchorStyles.None;
            txtImporteCuotas.Location = new Point(209, 595);
            txtImporteCuotas.Name = "txtImporteCuotas";
            txtImporteCuotas.ReadOnly = true;
            txtImporteCuotas.Size = new Size(119, 27);
            txtImporteCuotas.TabIndex = 71;
            // 
            // lblImporteCuotas
            // 
            lblImporteCuotas.Anchor = AnchorStyles.None;
            lblImporteCuotas.AutoSize = true;
            lblImporteCuotas.Font = new Font("Segoe UI", 9F);
            lblImporteCuotas.Location = new Point(37, 598);
            lblImporteCuotas.Name = "lblImporteCuotas";
            lblImporteCuotas.Size = new Size(151, 20);
            lblImporteCuotas.TabIndex = 72;
            lblImporteCuotas.Text = "IMPORTE POR CUOTA";
            // 
            // Detalle_Comprobante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(682, 753);
            Controls.Add(txtImporteCuotas);
            Controls.Add(lblImporteCuotas);
            Controls.Add(txtCantidadCuotas);
            Controls.Add(lblCantidadCuotas);
            Controls.Add(btnDescargarResumen);
            Controls.Add(btnVolver);
            Controls.Add(txtBoxFechaPago);
            Controls.Add(label9);
            Controls.Add(txtBoxTipoPago);
            Controls.Add(label8);
            Controls.Add(txtBoxMontoPago);
            Controls.Add(label7);
            Controls.Add(txtBoxVencPago);
            Controls.Add(label6);
            Controls.Add(txtBoxNumPago);
            Controls.Add(label5);
            Controls.Add(txtBoxCodPago);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtBoxDniSoc);
            Controls.Add(label1);
            Controls.Add(lblTituloCliente);
            Controls.Add(label3);
            Controls.Add(txtBoxCodSoc);
            Controls.Add(txtBoxNomSoc);
            Controls.Add(txtBoxApellSoc);
            Controls.Add(lblCodCliente);
            Controls.Add(lblApellido);
            Controls.Add(lblCodigo);
            Controls.Add(ImgOptPagado);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblTitulo);
            Controls.Add(imgBoxOpc);
            MinimumSize = new Size(700, 800);
            Name = "Detalle_Comprobante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante de Pago";
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImgOptPagado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgBoxOpc;
        private Label lblTitulo;
        private Label lblDireccion;
        private Label lblTelefono;
        private PictureBox ImgOptPagado;
        private Label label3;
        private TextBox txtBoxCodSoc;
        private TextBox txtBoxNomSoc;
        private TextBox txtBoxApellSoc;
        private Label lblCodCliente;
        private Label lblApellido;
        private Label lblCodigo;
        private Label lblTituloCliente;
        private Label label1;
        private TextBox txtBoxDniSoc;
        private Label label2;
        private TextBox txtBoxCodPago;
        private Label label4;
        private Label label5;
        private TextBox txtBoxNumPago;
        private TextBox txtBoxVencPago;
        private Label label6;
        private TextBox txtBoxTipoPago;
        private Label label8;
        private Label label7;
        private TextBox txtBoxMontoPago;
        private TextBox txtBoxFechaPago;
        private Label label9;
        private Button btnDescargarResumen;
        private Button btnVolver;
        private TextBox txtCantidadCuotas;
        private Label lblCantidadCuotas;
        private TextBox txtImporteCuotas;
        private Label lblImporteCuotas;
    }
}