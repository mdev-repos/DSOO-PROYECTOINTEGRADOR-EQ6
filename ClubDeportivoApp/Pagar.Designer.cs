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
            lblResNombre = new Label();
            lblResApellido = new Label();
            lblResCod = new Label();
            lblResCodCuota = new Label();
            lblResTipoPago = new Label();
            lblResValor = new Label();
            lblResVencimiento = new Label();
            SuspendLayout();
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.Location = new Point(338, 409);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(144, 29);
            btnPagarCuota.TabIndex = 0;
            btnPagarCuota.Text = "PAGAR";
            btnPagarCuota.UseVisualStyleBackColor = true;
            // 
            // btnVolverPagar
            // 
            btnVolverPagar.Location = new Point(41, 409);
            btnVolverPagar.Name = "btnVolverPagar";
            btnVolverPagar.Size = new Size(144, 29);
            btnVolverPagar.TabIndex = 2;
            btnVolverPagar.Text = "VOLVER";
            btnVolverPagar.UseVisualStyleBackColor = true;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(31, 28);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(173, 20);
            lblDni.TabIndex = 3;
            lblDni.Text = "Ingrese el Dni del cliente";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(210, 25);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(380, 27);
            txtDni.TabIndex = 4;
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.Location = new Point(291, 87);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(123, 20);
            lblDatosCliente.TabIndex = 5;
            lblDatosCliente.Text = "Datos del Cliente";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(41, 157);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(67, 20);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(424, 157);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido:";
            // 
            // lblCodCliente
            // 
            lblCodCliente.AutoSize = true;
            lblCodCliente.Location = new Point(41, 124);
            lblCodCliente.Name = "lblCodCliente";
            lblCodCliente.Size = new Size(61, 20);
            lblCodCliente.TabIndex = 8;
            lblCodCliente.Text = "Codigo:";
            // 
            // lblDatosCuota
            // 
            lblDatosCuota.AutoSize = true;
            lblDatosCuota.Location = new Point(288, 190);
            lblDatosCuota.Name = "lblDatosCuota";
            lblDatosCuota.Size = new Size(126, 20);
            lblDatosCuota.TabIndex = 9;
            lblDatosCuota.Text = "Datos de la cuota";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 239);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 10;
            label1.Text = "Codigo:";
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Location = new Point(41, 280);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(102, 20);
            lblTipoPago.TabIndex = 11;
            lblTipoPago.Text = "Tipo de pago:";
            // 
            // lblValorCuota
            // 
            lblValorCuota.AutoSize = true;
            lblValorCuota.Location = new Point(41, 322);
            lblValorCuota.Name = "lblValorCuota";
            lblValorCuota.Size = new Size(46, 20);
            lblValorCuota.TabIndex = 12;
            lblValorCuota.Text = "Valor:";
            // 
            // lblVencimientoCuota
            // 
            lblVencimientoCuota.AutoSize = true;
            lblVencimientoCuota.Location = new Point(41, 354);
            lblVencimientoCuota.Name = "lblVencimientoCuota";
            lblVencimientoCuota.Size = new Size(172, 20);
            lblVencimientoCuota.TabIndex = 13;
            lblVencimientoCuota.Text = "Vencimiento de la cuota:";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(621, 25);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(144, 29);
            btnBuscarCliente.TabIndex = 14;
            btnBuscarCliente.Text = "BUSCAR";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // btnComprobantePago
            // 
            btnComprobantePago.Location = new Point(621, 409);
            btnComprobantePago.Name = "btnComprobantePago";
            btnComprobantePago.Size = new Size(144, 29);
            btnComprobantePago.TabIndex = 15;
            btnComprobantePago.Text = "COMPROBANTE";
            btnComprobantePago.UseVisualStyleBackColor = true;
            // 
            // lblResNombre
            // 
            lblResNombre.AutoSize = true;
            lblResNombre.Location = new Point(118, 157);
            lblResNombre.Name = "lblResNombre";
            lblResNombre.Size = new Size(0, 20);
            lblResNombre.TabIndex = 16;
            // 
            // lblResApellido
            // 
            lblResApellido.AutoSize = true;
            lblResApellido.Location = new Point(521, 157);
            lblResApellido.Name = "lblResApellido";
            lblResApellido.Size = new Size(0, 20);
            lblResApellido.TabIndex = 17;
            // 
            // lblResCod
            // 
            lblResCod.AutoSize = true;
            lblResCod.Location = new Point(118, 124);
            lblResCod.Name = "lblResCod";
            lblResCod.Size = new Size(0, 20);
            lblResCod.TabIndex = 18;
            // 
            // lblResCodCuota
            // 
            lblResCodCuota.AutoSize = true;
            lblResCodCuota.Location = new Point(231, 239);
            lblResCodCuota.Name = "lblResCodCuota";
            lblResCodCuota.Size = new Size(0, 20);
            lblResCodCuota.TabIndex = 19;
            // 
            // lblResTipoPago
            // 
            lblResTipoPago.AutoSize = true;
            lblResTipoPago.Location = new Point(231, 280);
            lblResTipoPago.Name = "lblResTipoPago";
            lblResTipoPago.Size = new Size(0, 20);
            lblResTipoPago.TabIndex = 20;
            // 
            // lblResValor
            // 
            lblResValor.AutoSize = true;
            lblResValor.Location = new Point(231, 322);
            lblResValor.Name = "lblResValor";
            lblResValor.Size = new Size(0, 20);
            lblResValor.TabIndex = 21;
            // 
            // lblResVencimiento
            // 
            lblResVencimiento.AutoSize = true;
            lblResVencimiento.Location = new Point(231, 354);
            lblResVencimiento.Name = "lblResVencimiento";
            lblResVencimiento.Size = new Size(0, 20);
            lblResVencimiento.TabIndex = 22;
            // 
            // Pagar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResVencimiento);
            Controls.Add(lblResValor);
            Controls.Add(lblResTipoPago);
            Controls.Add(lblResCodCuota);
            Controls.Add(lblResCod);
            Controls.Add(lblResApellido);
            Controls.Add(lblResNombre);
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
            Name = "Pagar";
            Text = "Pagar";
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
        private Label lblResNombre;
        private Label lblResApellido;
        private Label lblResCod;
        private Label lblResCodCuota;
        private Label lblResTipoPago;
        private Label lblResValor;
        private Label lblResVencimiento;
    }
}