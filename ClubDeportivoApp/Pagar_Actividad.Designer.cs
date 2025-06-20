namespace ClubDeportivoApp
{
    partial class Pagar_Actividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagar_Actividad));
            pbVolver = new PictureBox();
            imgBoxOpc = new PictureBox();
            lblTitulo = new Label();
            lblValorCuota = new Label();
            txtValorCuota = new TextBox();
            lblCuotas = new Label();
            cbCuotas = new ComboBox();
            label3 = new Label();
            cbTipoDePago = new ComboBox();
            txtImporteFinal = new TextBox();
            txtCodCuotaDiaria = new TextBox();
            txtCodigoNoSocio = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblValorFinal = new Label();
            lblTipoPago = new Label();
            label1 = new Label();
            lblDatosCuota = new Label();
            lblCodCliente = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblDatosCliente = new Label();
            btnPagarActividad = new Button();
            txtActividad = new TextBox();
            lblActividad = new Label();
            ((System.ComponentModel.ISupportInitialize)pbVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).BeginInit();
            SuspendLayout();
            // 
            // pbVolver
            // 
            pbVolver.Anchor = AnchorStyles.None;
            pbVolver.BackColor = Color.Linen;
            pbVolver.Image = (Image)resources.GetObject("pbVolver.Image");
            pbVolver.Location = new Point(869, 78);
            pbVolver.Name = "pbVolver";
            pbVolver.Size = new Size(43, 27);
            pbVolver.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVolver.TabIndex = 29;
            pbVolver.TabStop = false;
            // 
            // imgBoxOpc
            // 
            imgBoxOpc.Anchor = AnchorStyles.None;
            imgBoxOpc.BackColor = Color.Linen;
            imgBoxOpc.Image = (Image)resources.GetObject("imgBoxOpc.Image");
            imgBoxOpc.Location = new Point(37, 45);
            imgBoxOpc.Name = "imgBoxOpc";
            imgBoxOpc.Size = new Size(91, 93);
            imgBoxOpc.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxOpc.TabIndex = 28;
            imgBoxOpc.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(120, 10, 90);
            lblTitulo.Location = new Point(259, 62);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(486, 54);
            lblTitulo.TabIndex = 27;
            lblTitulo.Text = "COBRAR ACTIVIDAD";
            // 
            // lblValorCuota
            // 
            lblValorCuota.Anchor = AnchorStyles.None;
            lblValorCuota.AutoSize = true;
            lblValorCuota.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblValorCuota.Location = new Point(521, 567);
            lblValorCuota.Name = "lblValorCuota";
            lblValorCuota.Size = new Size(124, 23);
            lblValorCuota.TabIndex = 52;
            lblValorCuota.Text = "Importe cuota";
            // 
            // txtValorCuota
            // 
            txtValorCuota.Anchor = AnchorStyles.None;
            txtValorCuota.Location = new Point(655, 563);
            txtValorCuota.Name = "txtValorCuota";
            txtValorCuota.ReadOnly = true;
            txtValorCuota.Size = new Size(233, 27);
            txtValorCuota.TabIndex = 44;
            // 
            // lblCuotas
            // 
            lblCuotas.Anchor = AnchorStyles.None;
            lblCuotas.AutoSize = true;
            lblCuotas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCuotas.Location = new Point(216, 562);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(167, 23);
            lblCuotas.TabIndex = 51;
            lblCuotas.Text = "Cantidad de Cuotas";
            // 
            // cbCuotas
            // 
            cbCuotas.Anchor = AnchorStyles.None;
            cbCuotas.FormattingEnabled = true;
            cbCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cbCuotas.Location = new Point(389, 562);
            cbCuotas.Name = "cbCuotas";
            cbCuotas.Size = new Size(86, 28);
            cbCuotas.TabIndex = 32;
            cbCuotas.SelectedIndexChanged += cbCuotas_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(244, 330);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 50;
            // 
            // cbTipoDePago
            // 
            cbTipoDePago.Anchor = AnchorStyles.None;
            cbTipoDePago.FormattingEnabled = true;
            cbTipoDePago.Items.AddRange(new object[] { "Efectivo", "Transferencia", "QR", "Adelanto", "Tarjeta de débito", "Tarjeta de crédito" });
            cbTipoDePago.Location = new Point(655, 511);
            cbTipoDePago.Name = "cbTipoDePago";
            cbTipoDePago.Size = new Size(233, 28);
            cbTipoDePago.TabIndex = 31;
            cbTipoDePago.SelectedIndexChanged += cbTipoDePago_SelectedIndexChanged_1;
            // 
            // txtImporteFinal
            // 
            txtImporteFinal.Anchor = AnchorStyles.None;
            txtImporteFinal.Location = new Point(655, 461);
            txtImporteFinal.Name = "txtImporteFinal";
            txtImporteFinal.ReadOnly = true;
            txtImporteFinal.Size = new Size(233, 27);
            txtImporteFinal.TabIndex = 42;
            // 
            // txtCodCuotaDiaria
            // 
            txtCodCuotaDiaria.Anchor = AnchorStyles.None;
            txtCodCuotaDiaria.Location = new Point(237, 462);
            txtCodCuotaDiaria.Name = "txtCodCuotaDiaria";
            txtCodCuotaDiaria.ReadOnly = true;
            txtCodCuotaDiaria.Size = new Size(238, 27);
            txtCodCuotaDiaria.TabIndex = 41;
            // 
            // txtCodigoNoSocio
            // 
            txtCodigoNoSocio.Anchor = AnchorStyles.None;
            txtCodigoNoSocio.Location = new Point(240, 231);
            txtCodigoNoSocio.Name = "txtCodigoNoSocio";
            txtCodigoNoSocio.ReadOnly = true;
            txtCodigoNoSocio.Size = new Size(238, 27);
            txtCodigoNoSocio.TabIndex = 45;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(240, 276);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(238, 27);
            txtNombre.TabIndex = 40;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Location = new Point(240, 330);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(238, 27);
            txtApellido.TabIndex = 39;
            // 
            // lblValorFinal
            // 
            lblValorFinal.Anchor = AnchorStyles.None;
            lblValorFinal.AutoSize = true;
            lblValorFinal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblValorFinal.Location = new Point(527, 462);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(119, 23);
            lblValorFinal.TabIndex = 48;
            lblValorFinal.Text = "Importe Total";
            // 
            // lblTipoPago
            // 
            lblTipoPago.Anchor = AnchorStyles.None;
            lblTipoPago.AutoSize = true;
            lblTipoPago.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTipoPago.Location = new Point(528, 508);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(117, 23);
            lblTipoPago.TabIndex = 47;
            lblTipoPago.Text = "Tipo de pago";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(111, 462);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 46;
            label1.Text = "Codigo cuota";
            // 
            // lblDatosCuota
            // 
            lblDatosCuota.Anchor = AnchorStyles.None;
            lblDatosCuota.AutoSize = true;
            lblDatosCuota.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblDatosCuota.Location = new Point(58, 405);
            lblDatosCuota.Name = "lblDatosCuota";
            lblDatosCuota.Size = new Size(215, 29);
            lblDatosCuota.TabIndex = 38;
            lblDatosCuota.Text = "Datos de la cuota";
            // 
            // lblCodCliente
            // 
            lblCodCliente.Anchor = AnchorStyles.None;
            lblCodCliente.AutoSize = true;
            lblCodCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCodCliente.Location = new Point(105, 232);
            lblCodCliente.Name = "lblCodCliente";
            lblCodCliente.Size = new Size(126, 23);
            lblCodCliente.TabIndex = 37;
            lblCodCliente.Text = "Codigo cliente";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblApellido.Location = new Point(156, 334);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 23);
            lblApellido.TabIndex = 36;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblNombre.Location = new Point(155, 280);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(76, 23);
            lblNombre.TabIndex = 35;
            lblNombre.Text = "Nombre";
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.Anchor = AnchorStyles.None;
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblDatosCliente.Location = new Point(58, 177);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(214, 29);
            lblDatosCliente.TabIndex = 34;
            lblDatosCliente.Text = "Datos del Cliente";
            // 
            // btnPagarActividad
            // 
            btnPagarActividad.Anchor = AnchorStyles.None;
            btnPagarActividad.BackColor = Color.FromArgb(120, 10, 90);
            btnPagarActividad.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagarActividad.ForeColor = Color.White;
            btnPagarActividad.Image = (Image)resources.GetObject("btnPagarActividad.Image");
            btnPagarActividad.Location = new Point(369, 661);
            btnPagarActividad.Name = "btnPagarActividad";
            btnPagarActividad.Size = new Size(238, 45);
            btnPagarActividad.TabIndex = 33;
            btnPagarActividad.Text = "PAGAR ACTIVIDAD";
            btnPagarActividad.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPagarActividad.UseVisualStyleBackColor = false;
            btnPagarActividad.Click += btnPagarActividad_Click;
            // 
            // txtActividad
            // 
            txtActividad.Anchor = AnchorStyles.None;
            txtActividad.Location = new Point(650, 232);
            txtActividad.Name = "txtActividad";
            txtActividad.ReadOnly = true;
            txtActividad.Size = new Size(238, 27);
            txtActividad.TabIndex = 53;
            // 
            // lblActividad
            // 
            lblActividad.Anchor = AnchorStyles.None;
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblActividad.Location = new Point(551, 233);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(87, 23);
            lblActividad.TabIndex = 54;
            lblActividad.Text = "Actividad";
            // 
            // Pagar_Actividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(982, 753);
            Controls.Add(lblActividad);
            Controls.Add(txtActividad);
            Controls.Add(lblValorCuota);
            Controls.Add(txtValorCuota);
            Controls.Add(lblCuotas);
            Controls.Add(cbCuotas);
            Controls.Add(label3);
            Controls.Add(cbTipoDePago);
            Controls.Add(txtImporteFinal);
            Controls.Add(txtCodCuotaDiaria);
            Controls.Add(txtCodigoNoSocio);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(lblValorFinal);
            Controls.Add(lblTipoPago);
            Controls.Add(label1);
            Controls.Add(lblDatosCuota);
            Controls.Add(lblCodCliente);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDatosCliente);
            Controls.Add(btnPagarActividad);
            Controls.Add(pbVolver);
            Controls.Add(imgBoxOpc);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 800);
            Name = "Pagar_Actividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor | Sports Club";
            ((System.ComponentModel.ISupportInitialize)pbVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbVolver;
        private PictureBox imgBoxOpc;
        private Label lblTitulo;
        private Label lblValorCuota;
        private TextBox txtValorCuota;
        private Label lblCuotas;
        private ComboBox cbCuotas;
        private Label label3;
        private ComboBox cbTipoDePago;
        private TextBox txtImporteFinal;
        private TextBox txtCodCuotaDiaria;
        private TextBox txtCodigoNoSocio;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblValorFinal;
        private Label lblTipoPago;
        private Label label1;
        private Label lblDatosCuota;
        private Label lblCodCliente;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblDatosCliente;
        private Button btnPagarActividad;
        private TextBox txtActividad;
        private Label lblActividad;
    }
}