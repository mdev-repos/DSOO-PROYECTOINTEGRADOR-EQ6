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
            btnVolverPagar = new Button();
            lblDni = new Label();
            txtDni = new TextBox();
            lblDatosCliente = new Label();
            lblCodigo = new Label();
            lblApellido = new Label();
            lblCodCliente = new Label();
            lblDatosCuota = new Label();
            label1 = new Label();
            lblTipoPago = new Label();
            lblValorCuota = new Label();
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
            btnPagarCuota.Location = new Point(405, 651);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(205, 45);
            btnPagarCuota.TabIndex = 0;
            btnPagarCuota.Text = "PAGAR CUOTA";
            btnPagarCuota.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPagarCuota.UseVisualStyleBackColor = false;
            // 
            // btnVolverPagar
            // 
            btnVolverPagar.Anchor = AnchorStyles.None;
            btnVolverPagar.BackColor = Color.DarkGreen;
            btnVolverPagar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverPagar.ForeColor = Color.White;
            btnVolverPagar.Image = (Image)resources.GetObject("btnVolverPagar.Image");
            btnVolverPagar.Location = new Point(723, 651);
            btnVolverPagar.Name = "btnVolverPagar";
            btnVolverPagar.Size = new Size(205, 45);
            btnVolverPagar.TabIndex = 2;
            btnVolverPagar.Text = "COMPROBANTE";
            btnVolverPagar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVolverPagar.UseVisualStyleBackColor = false;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(53, 194);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(131, 23);
            lblDni.TabIndex = 3;
            lblDni.Text = "Dni del cliente:";
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.Location = new Point(188, 194);
            txtDni.MaximumSize = new Size(238, 45);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(238, 27);
            txtDni.TabIndex = 4;
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.Anchor = AnchorStyles.None;
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatosCliente.Location = new Point(49, 258);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(277, 39);
            lblDatosCliente.TabIndex = 5;
            lblDatosCliente.Text = "Datos del Cliente";
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.None;
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCodigo.Location = new Point(53, 376);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(81, 23);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblApellido.Location = new Point(522, 377);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(83, 23);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido:";
            // 
            // lblCodCliente
            // 
            lblCodCliente.Anchor = AnchorStyles.None;
            lblCodCliente.AutoSize = true;
            lblCodCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCodCliente.Location = new Point(51, 320);
            lblCodCliente.Name = "lblCodCliente";
            lblCodCliente.Size = new Size(131, 23);
            lblCodCliente.TabIndex = 8;
            lblCodCliente.Text = "Codigo cliente:";
            // 
            // lblDatosCuota
            // 
            lblDatosCuota.Anchor = AnchorStyles.None;
            lblDatosCuota.AutoSize = true;
            lblDatosCuota.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatosCuota.Location = new Point(49, 441);
            lblDatosCuota.Name = "lblDatosCuota";
            lblDatosCuota.Size = new Size(281, 39);
            lblDatosCuota.TabIndex = 9;
            lblDatosCuota.Text = "Datos de la cuota";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(53, 501);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 10;
            label1.Text = "Codigo cuota:";
            // 
            // lblTipoPago
            // 
            lblTipoPago.Anchor = AnchorStyles.None;
            lblTipoPago.AutoSize = true;
            lblTipoPago.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTipoPago.Location = new Point(53, 564);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(122, 23);
            lblTipoPago.TabIndex = 11;
            lblTipoPago.Text = "Tipo de pago:";
            // 
            // lblValorCuota
            // 
            lblValorCuota.Anchor = AnchorStyles.None;
            lblValorCuota.AutoSize = true;
            lblValorCuota.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblValorCuota.Location = new Point(522, 501);
            lblValorCuota.Name = "lblValorCuota";
            lblValorCuota.Size = new Size(97, 23);
            lblValorCuota.TabIndex = 12;
            lblValorCuota.Text = "Valor final:";
            // 
            // lblVencimientoCuota
            // 
            lblVencimientoCuota.Anchor = AnchorStyles.None;
            lblVencimientoCuota.AutoSize = true;
            lblVencimientoCuota.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblVencimientoCuota.Location = new Point(522, 563);
            lblVencimientoCuota.Name = "lblVencimientoCuota";
            lblVencimientoCuota.Size = new Size(114, 23);
            lblVencimientoCuota.TabIndex = 13;
            lblVencimientoCuota.Text = "Vencimiento:";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Anchor = AnchorStyles.None;
            btnBuscarCliente.BackColor = Color.FromArgb(120, 10, 90);
            btnBuscarCliente.Cursor = Cursors.Hand;
            btnBuscarCliente.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnBuscarCliente.ForeColor = Color.White;
            btnBuscarCliente.Image = (Image)resources.GetObject("btnBuscarCliente.Image");
            btnBuscarCliente.Location = new Point(441, 183);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(195, 45);
            btnBuscarCliente.TabIndex = 14;
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
            btnComprobantePago.Location = new Point(60, 651);
            btnComprobantePago.Name = "btnComprobantePago";
            btnComprobantePago.Size = new Size(205, 45);
            btnComprobantePago.TabIndex = 15;
            btnComprobantePago.Text = "LIMPIAR";
            btnComprobantePago.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComprobantePago.UseVisualStyleBackColor = false;
            // 
            // txtBoxResApellido
            // 
            txtBoxResApellido.Anchor = AnchorStyles.None;
            txtBoxResApellido.Location = new Point(642, 376);
            txtBoxResApellido.Name = "txtBoxResApellido";
            txtBoxResApellido.ReadOnly = true;
            txtBoxResApellido.Size = new Size(286, 27);
            txtBoxResApellido.TabIndex = 16;
            // 
            // txtBoxResNombre
            // 
            txtBoxResNombre.Anchor = AnchorStyles.None;
            txtBoxResNombre.Location = new Point(188, 372);
            txtBoxResNombre.Name = "txtBoxResNombre";
            txtBoxResNombre.ReadOnly = true;
            txtBoxResNombre.Size = new Size(300, 27);
            txtBoxResNombre.TabIndex = 17;
            // 
            // txtBoxResCod
            // 
            txtBoxResCod.Anchor = AnchorStyles.None;
            txtBoxResCod.Location = new Point(188, 320);
            txtBoxResCod.Name = "txtBoxResCod";
            txtBoxResCod.ReadOnly = true;
            txtBoxResCod.Size = new Size(300, 27);
            txtBoxResCod.TabIndex = 18;
            // 
            // txtBoxResCodCuota
            // 
            txtBoxResCodCuota.Anchor = AnchorStyles.None;
            txtBoxResCodCuota.Location = new Point(188, 498);
            txtBoxResCodCuota.Name = "txtBoxResCodCuota";
            txtBoxResCodCuota.ReadOnly = true;
            txtBoxResCodCuota.Size = new Size(278, 27);
            txtBoxResCodCuota.TabIndex = 19;
            // 
            // txtBoxResValor
            // 
            txtBoxResValor.Anchor = AnchorStyles.None;
            txtBoxResValor.Location = new Point(642, 501);
            txtBoxResValor.Name = "txtBoxResValor";
            txtBoxResValor.ReadOnly = true;
            txtBoxResValor.Size = new Size(286, 27);
            txtBoxResValor.TabIndex = 20;
            // 
            // txtBoxResVencimiento
            // 
            txtBoxResVencimiento.Anchor = AnchorStyles.None;
            txtBoxResVencimiento.Location = new Point(642, 560);
            txtBoxResVencimiento.Name = "txtBoxResVencimiento";
            txtBoxResVencimiento.ReadOnly = true;
            txtBoxResVencimiento.Size = new Size(286, 27);
            txtBoxResVencimiento.TabIndex = 21;
            // 
            // cbResTipoPago
            // 
            cbResTipoPago.Anchor = AnchorStyles.None;
            cbResTipoPago.FormattingEnabled = true;
            cbResTipoPago.Items.AddRange(new object[] { "Efectivo", "Adelanto", "Tarjeta de crédito" });
            cbResTipoPago.Location = new Point(188, 559);
            cbResTipoPago.Name = "cbResTipoPago";
            cbResTipoPago.Size = new Size(278, 28);
            cbResTipoPago.TabIndex = 22;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(120, 10, 90);
            label2.Location = new Point(390, 67);
            label2.Name = "label2";
            label2.Size = new Size(401, 54);
            label2.TabIndex = 23;
            label2.Text = "COBRAR CUOTA";
            // 
            // imgBoxOpc
            // 
            imgBoxOpc.Anchor = AnchorStyles.None;
            imgBoxOpc.BackColor = Color.Linen;
            imgBoxOpc.Image = (Image)resources.GetObject("imgBoxOpc.Image");
            imgBoxOpc.Location = new Point(42, 51);
            imgBoxOpc.Name = "imgBoxOpc";
            imgBoxOpc.Size = new Size(92, 93);
            imgBoxOpc.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxOpc.TabIndex = 24;
            imgBoxOpc.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(610, 354);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 25;
            // 
            // pbVolver
            // 
            pbVolver.Anchor = AnchorStyles.None;
            pbVolver.BackColor = Color.Linen;
            pbVolver.Image = (Image)resources.GetObject("pbVolver.Image");
            pbVolver.Location = new Point(884, 82);
            pbVolver.Name = "pbVolver";
            pbVolver.Size = new Size(44, 26);
            pbVolver.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVolver.TabIndex = 26;
            pbVolver.TabStop = false;
            pbVolver.Click += pbVolver_Click;
            // 
            // Pagar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(982, 753);
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
            Controls.Add(lblValorCuota);
            Controls.Add(lblTipoPago);
            Controls.Add(label1);
            Controls.Add(lblDatosCuota);
            Controls.Add(lblCodCliente);
            Controls.Add(lblApellido);
            Controls.Add(lblCodigo);
            Controls.Add(lblDatosCliente);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(btnVolverPagar);
            Controls.Add(btnPagarCuota);
            MinimumSize = new Size(1000, 800);
            Name = "Pagar";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPagarCuota;
        private Button btnVolverPagar;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblDatosCliente;
        private Label lblCodigo;
        private Label lblApellido;
        private Label lblCodCliente;
        private Label lblDatosCuota;
        private Label label1;
        private Label lblTipoPago;
        private Label lblValorCuota;
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
    }
}