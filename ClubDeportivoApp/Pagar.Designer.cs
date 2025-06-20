namespace ClubDeportivoApp
{
    partial class Pagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagar));
            btnPagarCuota = new Button();
            lblDni = new Label();
            txtDni = new TextBox();
            lblDatosCliente = new Label();
            lblCodigo = new Label();
            lblApellido = new Label();
            lblCodCliente = new Label();
            lblDatosCuota = new Label();
            label1 = new Label();
            lblTipoPago = new Label();
            lblValorFinal = new Label();
            lblVencimientoCuota = new Label();
            btnBuscarCliente = new Button();
            btnComprobantePago = new Button();
            txtBoxResApellido = new TextBox();
            txtBoxResNombre = new TextBox();
            txtBoxResCod = new TextBox();
            txtBoxResCodCuota = new TextBox();
            txtBoxResValor = new TextBox();
            txtBoxResVencimiento = new TextBox();
            cbResTipoPago = new ComboBox();
            label2 = new Label();
            imgBoxOpc = new PictureBox();
            label3 = new Label();
            pbVolver = new PictureBox();
            cbCuotas = new ComboBox();
            lblCuotas = new Label();
            txtValorCuota = new TextBox();
            lblValorCuota = new Label();
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVolver).BeginInit();
            SuspendLayout();
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.Anchor = AnchorStyles.None;
            btnPagarCuota.BackColor = Color.FromArgb(120, 10, 90);
            btnPagarCuota.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagarCuota.ForeColor = Color.White;
            btnPagarCuota.Image = (Image)resources.GetObject("btnPagarCuota.Image");
            btnPagarCuota.Location = new Point(453, 487);
            btnPagarCuota.Margin = new Padding(3, 2, 3, 2);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(179, 34);
            btnPagarCuota.TabIndex = 13;
            btnPagarCuota.Text = "PAGAR CUOTA";
            btnPagarCuota.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPagarCuota.UseVisualStyleBackColor = false;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(251, 129);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(106, 19);
            lblDni.TabIndex = 3;
            lblDni.Text = "Dni del Cliente";
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.Location = new Point(369, 129);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.MaximumSize = new Size(209, 45);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(209, 23);
            txtDni.TabIndex = 1;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.Anchor = AnchorStyles.None;
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosCliente.Location = new Point(36, 170);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(195, 26);
            lblDatosCliente.TabIndex = 5;
            lblDatosCliente.Text = "Datos del Cliente";
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.None;
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCodigo.Location = new Point(121, 247);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(65, 19);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblApellido.Location = new Point(487, 247);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 19);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido";
            // 
            // lblCodCliente
            // 
            lblCodCliente.Anchor = AnchorStyles.None;
            lblCodCliente.AutoSize = true;
            lblCodCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCodCliente.Location = new Point(77, 211);
            lblCodCliente.Name = "lblCodCliente";
            lblCodCliente.Size = new Size(106, 19);
            lblCodCliente.TabIndex = 8;
            lblCodCliente.Text = "Codigo cliente";
            // 
            // lblDatosCuota
            // 
            lblDatosCuota.Anchor = AnchorStyles.None;
            lblDatosCuota.AutoSize = true;
            lblDatosCuota.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosCuota.Location = new Point(38, 300);
            lblDatosCuota.Name = "lblDatosCuota";
            lblDatosCuota.Size = new Size(198, 26);
            lblDatosCuota.TabIndex = 9;
            lblDatosCuota.Text = "Datos de la cuota";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(85, 343);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 10;
            label1.Text = "Codigo cuota";
            // 
            // lblTipoPago
            // 
            lblTipoPago.Anchor = AnchorStyles.None;
            lblTipoPago.AutoSize = true;
            lblTipoPago.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTipoPago.Location = new Point(450, 377);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(99, 19);
            lblTipoPago.TabIndex = 11;
            lblTipoPago.Text = "Tipo de pago";
            // 
            // lblValorFinal
            // 
            lblValorFinal.Anchor = AnchorStyles.None;
            lblValorFinal.AutoSize = true;
            lblValorFinal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblValorFinal.Location = new Point(83, 380);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(100, 19);
            lblValorFinal.TabIndex = 12;
            lblValorFinal.Text = "Importe Total";
            // 
            // lblVencimientoCuota
            // 
            lblVencimientoCuota.Anchor = AnchorStyles.None;
            lblVencimientoCuota.AutoSize = true;
            lblVencimientoCuota.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblVencimientoCuota.Location = new Point(457, 344);
            lblVencimientoCuota.Name = "lblVencimientoCuota";
            lblVencimientoCuota.Size = new Size(91, 19);
            lblVencimientoCuota.TabIndex = 13;
            lblVencimientoCuota.Text = "Vencimiento";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Anchor = AnchorStyles.None;
            btnBuscarCliente.BackColor = Color.FromArgb(120, 10, 90);
            btnBuscarCliente.Cursor = Cursors.Hand;
            btnBuscarCliente.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnBuscarCliente.ForeColor = Color.White;
            btnBuscarCliente.Image = (Image)resources.GetObject("btnBuscarCliente.Image");
            btnBuscarCliente.Location = new Point(591, 123);
            btnBuscarCliente.Margin = new Padding(3, 2, 3, 2);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(171, 34);
            btnBuscarCliente.TabIndex = 2;
            btnBuscarCliente.Text = "BUSCAR CLIENTE";
            btnBuscarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // btnComprobantePago
            // 
            btnComprobantePago.Anchor = AnchorStyles.None;
            btnComprobantePago.BackColor = Color.DarkGreen;
            btnComprobantePago.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprobantePago.ForeColor = Color.White;
            btnComprobantePago.Image = (Image)resources.GetObject("btnComprobantePago.Image");
            btnComprobantePago.Location = new Point(195, 487);
            btnComprobantePago.Margin = new Padding(3, 2, 3, 2);
            btnComprobantePago.Name = "btnComprobantePago";
            btnComprobantePago.Size = new Size(179, 34);
            btnComprobantePago.TabIndex = 12;
            btnComprobantePago.Text = "LIMPIAR";
            btnComprobantePago.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComprobantePago.UseVisualStyleBackColor = false;
            btnComprobantePago.Click += btnComprobantePago_Click;
            // 
            // txtBoxResApellido
            // 
            txtBoxResApellido.Anchor = AnchorStyles.None;
            txtBoxResApellido.Location = new Point(561, 244);
            txtBoxResApellido.Margin = new Padding(3, 2, 3, 2);
            txtBoxResApellido.Name = "txtBoxResApellido";
            txtBoxResApellido.ReadOnly = true;
            txtBoxResApellido.Size = new Size(204, 23);
            txtBoxResApellido.TabIndex = 5;
            // 
            // txtBoxResNombre
            // 
            txtBoxResNombre.Anchor = AnchorStyles.None;
            txtBoxResNombre.Location = new Point(195, 244);
            txtBoxResNombre.Margin = new Padding(3, 2, 3, 2);
            txtBoxResNombre.Name = "txtBoxResNombre";
            txtBoxResNombre.ReadOnly = true;
            txtBoxResNombre.Size = new Size(209, 23);
            txtBoxResNombre.TabIndex = 4;
            // 
            // txtBoxResCod
            // 
            txtBoxResCod.Anchor = AnchorStyles.None;
            txtBoxResCod.Location = new Point(195, 210);
            txtBoxResCod.Margin = new Padding(3, 2, 3, 2);
            txtBoxResCod.Name = "txtBoxResCod";
            txtBoxResCod.ReadOnly = true;
            txtBoxResCod.Size = new Size(209, 23);
            txtBoxResCod.TabIndex = 3;
            // 
            // txtBoxResCodCuota
            // 
            txtBoxResCodCuota.Anchor = AnchorStyles.None;
            txtBoxResCodCuota.Location = new Point(195, 343);
            txtBoxResCodCuota.Margin = new Padding(3, 2, 3, 2);
            txtBoxResCodCuota.Name = "txtBoxResCodCuota";
            txtBoxResCodCuota.ReadOnly = true;
            txtBoxResCodCuota.Size = new Size(209, 23);
            txtBoxResCodCuota.TabIndex = 6;
            // 
            // txtBoxResValor
            // 
            txtBoxResValor.Anchor = AnchorStyles.None;
            txtBoxResValor.Location = new Point(195, 379);
            txtBoxResValor.Margin = new Padding(3, 2, 3, 2);
            txtBoxResValor.Name = "txtBoxResValor";
            txtBoxResValor.ReadOnly = true;
            txtBoxResValor.Size = new Size(209, 23);
            txtBoxResValor.TabIndex = 8;
            // 
            // txtBoxResVencimiento
            // 
            txtBoxResVencimiento.Anchor = AnchorStyles.None;
            txtBoxResVencimiento.Location = new Point(561, 344);
            txtBoxResVencimiento.Margin = new Padding(3, 2, 3, 2);
            txtBoxResVencimiento.Name = "txtBoxResVencimiento";
            txtBoxResVencimiento.ReadOnly = true;
            txtBoxResVencimiento.Size = new Size(204, 23);
            txtBoxResVencimiento.TabIndex = 7;
            // 
            // cbResTipoPago
            // 
            cbResTipoPago.Anchor = AnchorStyles.None;
            cbResTipoPago.FormattingEnabled = true;
            cbResTipoPago.Items.AddRange(new object[] { "Efectivo", "Transferencia", "QR", "Adelanto", "Tarjeta de débito", "Tarjeta de crédito" });
            cbResTipoPago.Location = new Point(561, 380);
            cbResTipoPago.Margin = new Padding(3, 2, 3, 2);
            cbResTipoPago.Name = "cbResTipoPago";
            cbResTipoPago.Size = new Size(204, 23);
            cbResTipoPago.TabIndex = 9;
            cbResTipoPago.SelectedIndexChanged += cbResTipoPago_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(120, 10, 90);
            label2.Location = new Point(256, 49);
            label2.Name = "label2";
            label2.Size = new Size(322, 44);
            label2.TabIndex = 23;
            label2.Text = "COBRAR CUOTA";
            // 
            // imgBoxOpc
            // 
            imgBoxOpc.Anchor = AnchorStyles.None;
            imgBoxOpc.BackColor = Color.Linen;
            imgBoxOpc.Image = (Image)resources.GetObject("imgBoxOpc.Image");
            imgBoxOpc.Location = new Point(39, 36);
            imgBoxOpc.Margin = new Padding(3, 2, 3, 2);
            imgBoxOpc.Name = "imgBoxOpc";
            imgBoxOpc.Size = new Size(80, 70);
            imgBoxOpc.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxOpc.TabIndex = 24;
            imgBoxOpc.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(564, 244);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 25;
            // 
            // pbVolver
            // 
            pbVolver.Anchor = AnchorStyles.None;
            pbVolver.BackColor = Color.Linen;
            pbVolver.Image = (Image)resources.GetObject("pbVolver.Image");
            pbVolver.Location = new Point(767, 61);
            pbVolver.Margin = new Padding(3, 2, 3, 2);
            pbVolver.Name = "pbVolver";
            pbVolver.Size = new Size(38, 20);
            pbVolver.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVolver.TabIndex = 26;
            pbVolver.TabStop = false;
            pbVolver.Click += pbVolver_Click;
            // 
            // cbCuotas
            // 
            cbCuotas.Anchor = AnchorStyles.None;
            cbCuotas.FormattingEnabled = true;
            cbCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cbCuotas.Location = new Point(325, 424);
            cbCuotas.Margin = new Padding(3, 2, 3, 2);
            cbCuotas.Name = "cbCuotas";
            cbCuotas.Size = new Size(76, 23);
            cbCuotas.TabIndex = 10;
            cbCuotas.DropDown += cbCuotas_DropDown;
            cbCuotas.SelectedIndexChanged += cbCuotas_SelectedIndexChanged;
            // 
            // lblCuotas
            // 
            lblCuotas.Anchor = AnchorStyles.None;
            lblCuotas.AutoSize = true;
            lblCuotas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCuotas.Location = new Point(173, 424);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(139, 19);
            lblCuotas.TabIndex = 28;
            lblCuotas.Text = "Cantidad de Cuotas";
            // 
            // txtValorCuota
            // 
            txtValorCuota.Anchor = AnchorStyles.None;
            txtValorCuota.Location = new Point(561, 422);
            txtValorCuota.Margin = new Padding(3, 2, 3, 2);
            txtValorCuota.Name = "txtValorCuota";
            txtValorCuota.ReadOnly = true;
            txtValorCuota.Size = new Size(201, 23);
            txtValorCuota.TabIndex = 11;
            // 
            // lblValorCuota
            // 
            lblValorCuota.Anchor = AnchorStyles.None;
            lblValorCuota.AutoSize = true;
            lblValorCuota.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblValorCuota.Location = new Point(444, 424);
            lblValorCuota.Name = "lblValorCuota";
            lblValorCuota.Size = new Size(104, 19);
            lblValorCuota.TabIndex = 30;
            lblValorCuota.Text = "Importe cuota";
            // 
            // Pagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(861, 571);
            Controls.Add(lblValorCuota);
            Controls.Add(txtValorCuota);
            Controls.Add(lblCuotas);
            Controls.Add(cbCuotas);
            Controls.Add(pbVolver);
            Controls.Add(label3);
            Controls.Add(imgBoxOpc);
            Controls.Add(label2);
            Controls.Add(cbResTipoPago);
            Controls.Add(txtBoxResVencimiento);
            Controls.Add(txtBoxResValor);
            Controls.Add(txtBoxResCodCuota);
            Controls.Add(txtBoxResCod);
            Controls.Add(txtBoxResNombre);
            Controls.Add(txtBoxResApellido);
            Controls.Add(btnComprobantePago);
            Controls.Add(btnBuscarCliente);
            Controls.Add(lblVencimientoCuota);
            Controls.Add(lblValorFinal);
            Controls.Add(lblTipoPago);
            Controls.Add(label1);
            Controls.Add(lblDatosCuota);
            Controls.Add(lblCodCliente);
            Controls.Add(lblApellido);
            Controls.Add(lblCodigo);
            Controls.Add(lblDatosCliente);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(btnPagarCuota);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(877, 610);
            Name = "Pagar";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor | Sports Club";
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPagarCuota;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblDatosCliente;
        private Label lblCodigo;
        private Label lblApellido;
        private Label lblCodCliente;
        private Label lblDatosCuota;
        private Label label1;
        private Label lblTipoPago;
        private Label lblValorFinal;
        private Label lblVencimientoCuota;
        private Button btnBuscarCliente;
        private Button btnComprobantePago;
        private TextBox txtBoxResApellido;
        private TextBox txtBoxResNombre;
        private TextBox txtBoxResCod;
        private TextBox txtBoxResCodCuota;
        private TextBox txtBoxResValor;
        private TextBox txtBoxResVencimiento;
        private ComboBox cbResTipoPago;
        private Label label2;
        private PictureBox imgBoxOpc;
        private Label label3;
        private PictureBox pbVolver;
        private ComboBox cbCuotas;
        private Label lblCuotas;
        private TextBox txtValorCuota;
        private Label lblValorCuota;
    }
}