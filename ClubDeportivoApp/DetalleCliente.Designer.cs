namespace ClubDeportivoApp
{
    partial class DetalleCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleCliente));
            pbVolver = new PictureBox();
            imgBoxOpc = new PictureBox();
            lblCliente = new Label();
            txtBoxResNombre = new TextBox();
            lblApellido = new Label();
            lblCodigo = new Label();
            txtBoxResApellido = new TextBox();
            txtBoxResDni = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBoxResTelefono = new TextBox();
            txtBoxResDireccion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtBoxResFichaMed = new TextBox();
            txtBoxResEmail = new TextBox();
            label5 = new Label();
            label6 = new Label();
            lblDatosCliente = new Label();
            label8 = new Label();
            btnActualizarDatos = new Button();
            txtBoxResMoroso = new TextBox();
            txtBoxResCarnet = new TextBox();
            lblMoroso = new Label();
            lblCarnet = new Label();
            cBoxTipoCliente = new ComboBox();
            lblFechaInscr = new Label();
            dtpResFechaInscr = new DateTimePicker();
            dtpResFechaNac = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pbVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).BeginInit();
            SuspendLayout();
            // 
            // pbVolver
            // 
            pbVolver.Anchor = AnchorStyles.None;
            pbVolver.BackColor = Color.Linen;
            pbVolver.Image = (Image)resources.GetObject("pbVolver.Image");
            pbVolver.Location = new Point(1000, 42);
            pbVolver.Name = "pbVolver";
            pbVolver.Size = new Size(44, 26);
            pbVolver.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVolver.TabIndex = 35;
            pbVolver.TabStop = false;
            pbVolver.Click += pbVolver_Click;
            // 
            // imgBoxOpc
            // 
            imgBoxOpc.Anchor = AnchorStyles.None;
            imgBoxOpc.BackColor = Color.Linen;
            imgBoxOpc.Image = (Image)resources.GetObject("imgBoxOpc.Image");
            imgBoxOpc.Location = new Point(49, 12);
            imgBoxOpc.Name = "imgBoxOpc";
            imgBoxOpc.Size = new Size(92, 93);
            imgBoxOpc.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxOpc.TabIndex = 34;
            imgBoxOpc.TabStop = false;
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.None;
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.FromArgb(120, 10, 90);
            lblCliente.Location = new Point(414, 30);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(0, 54);
            lblCliente.TabIndex = 33;
            // 
            // txtBoxResNombre
            // 
            txtBoxResNombre.Anchor = AnchorStyles.None;
            txtBoxResNombre.Location = new Point(212, 204);
            txtBoxResNombre.Name = "txtBoxResNombre";
            txtBoxResNombre.Size = new Size(300, 27);
            txtBoxResNombre.TabIndex = 39;
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblApellido.Location = new Point(587, 205);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(83, 23);
            lblApellido.TabIndex = 37;
            lblApellido.Text = "Apellido:";
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.None;
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCodigo.Location = new Point(49, 205);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(81, 23);
            lblCodigo.TabIndex = 36;
            lblCodigo.Text = "Nombre:";
            // 
            // txtBoxResApellido
            // 
            txtBoxResApellido.Anchor = AnchorStyles.None;
            txtBoxResApellido.Location = new Point(744, 203);
            txtBoxResApellido.Name = "txtBoxResApellido";
            txtBoxResApellido.Size = new Size(300, 27);
            txtBoxResApellido.TabIndex = 40;
            // 
            // txtBoxResDni
            // 
            txtBoxResDni.Anchor = AnchorStyles.None;
            txtBoxResDni.Location = new Point(744, 262);
            txtBoxResDni.Name = "txtBoxResDni";
            txtBoxResDni.Size = new Size(300, 27);
            txtBoxResDni.TabIndex = 44;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(587, 264);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 42;
            label1.Text = "DNI:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(49, 264);
            label2.Name = "label2";
            label2.Size = new Size(157, 23);
            label2.TabIndex = 41;
            label2.Text = "Fecha Nacimiento:";
            // 
            // txtBoxResTelefono
            // 
            txtBoxResTelefono.Anchor = AnchorStyles.None;
            txtBoxResTelefono.Location = new Point(744, 323);
            txtBoxResTelefono.Name = "txtBoxResTelefono";
            txtBoxResTelefono.Size = new Size(300, 27);
            txtBoxResTelefono.TabIndex = 48;
            // 
            // txtBoxResDireccion
            // 
            txtBoxResDireccion.Anchor = AnchorStyles.None;
            txtBoxResDireccion.Location = new Point(212, 324);
            txtBoxResDireccion.Name = "txtBoxResDireccion";
            txtBoxResDireccion.Size = new Size(300, 27);
            txtBoxResDireccion.TabIndex = 47;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(587, 325);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 46;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(49, 325);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 45;
            label4.Text = "Direccion:";
            // 
            // txtBoxResFichaMed
            // 
            txtBoxResFichaMed.Anchor = AnchorStyles.None;
            txtBoxResFichaMed.Location = new Point(744, 387);
            txtBoxResFichaMed.Name = "txtBoxResFichaMed";
            txtBoxResFichaMed.Size = new Size(300, 27);
            txtBoxResFichaMed.TabIndex = 52;
            // 
            // txtBoxResEmail
            // 
            txtBoxResEmail.Anchor = AnchorStyles.None;
            txtBoxResEmail.Location = new Point(212, 388);
            txtBoxResEmail.Name = "txtBoxResEmail";
            txtBoxResEmail.Size = new Size(300, 27);
            txtBoxResEmail.TabIndex = 51;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(587, 389);
            label5.Name = "label5";
            label5.Size = new Size(119, 23);
            label5.TabIndex = 50;
            label5.Text = "Ficha medica:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(49, 389);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 49;
            label6.Text = "Email:";
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.Anchor = AnchorStyles.None;
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatosCliente.Location = new Point(49, 145);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(277, 39);
            lblDatosCliente.TabIndex = 53;
            lblDatosCliente.Text = "Datos del Cliente";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.Location = new Point(49, 453);
            label8.Name = "label8";
            label8.Size = new Size(109, 23);
            label8.TabIndex = 54;
            label8.Text = "Tipo cliente:";
            // 
            // btnActualizarDatos
            // 
            btnActualizarDatos.Anchor = AnchorStyles.None;
            btnActualizarDatos.BackColor = Color.FromArgb(120, 10, 90);
            btnActualizarDatos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarDatos.ForeColor = Color.White;
            btnActualizarDatos.Location = new Point(424, 584);
            btnActualizarDatos.Name = "btnActualizarDatos";
            btnActualizarDatos.Size = new Size(246, 45);
            btnActualizarDatos.TabIndex = 58;
            btnActualizarDatos.Text = "ACTUALIZAR DATOS";
            btnActualizarDatos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizarDatos.UseVisualStyleBackColor = false;
            btnActualizarDatos.Click += btnActualizarDatos_Click;
            // 
            // txtBoxResMoroso
            // 
            txtBoxResMoroso.Anchor = AnchorStyles.None;
            txtBoxResMoroso.Location = new Point(744, 513);
            txtBoxResMoroso.Name = "txtBoxResMoroso";
            txtBoxResMoroso.Size = new Size(300, 27);
            txtBoxResMoroso.TabIndex = 62;
            // 
            // txtBoxResCarnet
            // 
            txtBoxResCarnet.Anchor = AnchorStyles.None;
            txtBoxResCarnet.Location = new Point(212, 514);
            txtBoxResCarnet.Name = "txtBoxResCarnet";
            txtBoxResCarnet.Size = new Size(300, 27);
            txtBoxResCarnet.TabIndex = 61;
            // 
            // lblMoroso
            // 
            lblMoroso.Anchor = AnchorStyles.None;
            lblMoroso.AutoSize = true;
            lblMoroso.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblMoroso.Location = new Point(587, 515);
            lblMoroso.Name = "lblMoroso";
            lblMoroso.Size = new Size(75, 23);
            lblMoroso.TabIndex = 60;
            lblMoroso.Text = "Moroso:";
            // 
            // lblCarnet
            // 
            lblCarnet.Anchor = AnchorStyles.None;
            lblCarnet.AutoSize = true;
            lblCarnet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCarnet.Location = new Point(49, 515);
            lblCarnet.Name = "lblCarnet";
            lblCarnet.Size = new Size(68, 23);
            lblCarnet.TabIndex = 59;
            lblCarnet.Text = "Carnet:";
            // 
            // cBoxTipoCliente
            // 
            cBoxTipoCliente.Anchor = AnchorStyles.None;
            cBoxTipoCliente.FormattingEnabled = true;
            cBoxTipoCliente.Items.AddRange(new object[] { "Socio", "No Socio" });
            cBoxTipoCliente.Location = new Point(212, 454);
            cBoxTipoCliente.Name = "cBoxTipoCliente";
            cBoxTipoCliente.Size = new Size(300, 28);
            cBoxTipoCliente.TabIndex = 63;
            cBoxTipoCliente.SelectedIndexChanged += cBoxTipoCliente_SelectedIndexChanged;
            // 
            // lblFechaInscr
            // 
            lblFechaInscr.Anchor = AnchorStyles.None;
            lblFechaInscr.AutoSize = true;
            lblFechaInscr.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblFechaInscr.Location = new Point(587, 454);
            lblFechaInscr.Name = "lblFechaInscr";
            lblFechaInscr.Size = new Size(151, 23);
            lblFechaInscr.TabIndex = 64;
            lblFechaInscr.Text = "Fecha inscripcion:";
            // 
            // dtpResFechaInscr
            // 
            dtpResFechaInscr.Anchor = AnchorStyles.None;
            dtpResFechaInscr.Location = new Point(744, 452);
            dtpResFechaInscr.Name = "dtpResFechaInscr";
            dtpResFechaInscr.Size = new Size(300, 27);
            dtpResFechaInscr.TabIndex = 66;
            // 
            // dtpResFechaNac
            // 
            dtpResFechaNac.Anchor = AnchorStyles.None;
            dtpResFechaNac.Location = new Point(212, 260);
            dtpResFechaNac.Name = "dtpResFechaNac";
            dtpResFechaNac.Size = new Size(300, 27);
            dtpResFechaNac.TabIndex = 67;
            // 
            // DetalleCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1088, 652);
            Controls.Add(dtpResFechaNac);
            Controls.Add(dtpResFechaInscr);
            Controls.Add(lblFechaInscr);
            Controls.Add(cBoxTipoCliente);
            Controls.Add(txtBoxResMoroso);
            Controls.Add(txtBoxResCarnet);
            Controls.Add(lblMoroso);
            Controls.Add(lblCarnet);
            Controls.Add(btnActualizarDatos);
            Controls.Add(label8);
            Controls.Add(lblDatosCliente);
            Controls.Add(txtBoxResFichaMed);
            Controls.Add(txtBoxResEmail);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtBoxResTelefono);
            Controls.Add(txtBoxResDireccion);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtBoxResDni);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtBoxResApellido);
            Controls.Add(txtBoxResNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblCodigo);
            Controls.Add(pbVolver);
            Controls.Add(imgBoxOpc);
            Controls.Add(lblCliente);
            Name = "DetalleCliente";
            Text = "DetalleCliente";
            ((System.ComponentModel.ISupportInitialize)pbVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbVolver;
        private PictureBox imgBoxOpc;
        private Label lblCliente;
        private TextBox txtBoxResNombre;
        private Label lblApellido;
        private Label lblCodigo;
        private TextBox txtBoxResApellido;
        private TextBox txtBoxResDni;
        private Label label1;
        private Label label2;
        private TextBox txtBoxResTelefono;
        private TextBox txtBoxResDireccion;
        private Label label3;
        private Label label4;
        private TextBox txtBoxResFichaMed;
        private TextBox txtBoxResEmail;
        private Label label5;
        private Label label6;
        private Label lblDatosCliente;
        private Label label8;
        private Button btnActualizarDatos;
        private TextBox txtBoxResMoroso;
        private TextBox txtBoxResCarnet;
        private Label lblMoroso;
        private Label lblCarnet;
        private ComboBox cBoxTipoCliente;
        private Label lblFechaInscr;
        private DateTimePicker dtpResFechaInscr;
        private DateTimePicker dtpResFechaNac;
    }
}