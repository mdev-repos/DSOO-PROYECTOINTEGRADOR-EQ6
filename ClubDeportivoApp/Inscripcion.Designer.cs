namespace ClubDeportivoApp
{
    partial class Inscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripcion));
            lblNombre = new Label();
            lblApellido = new Label();
            lblEmail = new Label();
            lblDireccion = new Label();
            lblDni = new Label();
            lblFichaMedica = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            btnInscribir = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            lblFechaNac = new Label();
            rbtnFichaMedica = new RadioButton();
            dtpFechaNac = new DateTimePicker();
            lblDatosPersonales = new Label();
            gboxTipoCliente = new GroupBox();
            rbtNoSocio = new RadioButton();
            rbtSocio = new RadioButton();
            lblTituloList = new Label();
            gboxTipoCliente.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(175, 292);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(500, 292);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(90, 25);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(500, 492);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(65, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.None;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(175, 439);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(102, 25);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "Dirección";
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(175, 343);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(44, 25);
            lblDni.TabIndex = 4;
            lblDni.Text = "Dni";
            // 
            // lblFichaMedica
            // 
            lblFichaMedica.Anchor = AnchorStyles.None;
            lblFichaMedica.AutoSize = true;
            lblFichaMedica.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFichaMedica.Location = new Point(175, 543);
            lblFichaMedica.Name = "lblFichaMedica";
            lblFichaMedica.Size = new Size(141, 25);
            lblFichaMedica.TabIndex = 5;
            lblFichaMedica.Text = "Ficha Médica";
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.None;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(175, 490);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(97, 25);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(283, 292);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(590, 491);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.Location = new Point(283, 490);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(191, 27);
            txtTelefono.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.None;
            txtDireccion.Location = new Point(283, 440);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(191, 27);
            txtDireccion.TabIndex = 6;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.Location = new Point(283, 343);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(191, 27);
            txtDni.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Location = new Point(590, 292);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(191, 27);
            txtApellido.TabIndex = 3;
            // 
            // btnInscribir
            // 
            btnInscribir.Anchor = AnchorStyles.None;
            btnInscribir.BackColor = Color.DarkGreen;
            btnInscribir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInscribir.ForeColor = Color.Linen;
            btnInscribir.Location = new Point(410, 618);
            btnInscribir.Margin = new Padding(3, 4, 3, 4);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(138, 47);
            btnInscribir.TabIndex = 11;
            btnInscribir.Text = "INSCRIBIR";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.BackColor = Color.Navy;
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Linen;
            btnLimpiar.Location = new Point(175, 618);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(138, 47);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.BackColor = Color.FromArgb(120, 10, 90);
            btnVolver.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.Linen;
            btnVolver.Location = new Point(643, 618);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(138, 47);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblFechaNac
            // 
            lblFechaNac.Anchor = AnchorStyles.None;
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaNac.Location = new Point(175, 390);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(215, 25);
            lblFechaNac.TabIndex = 17;
            lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // rbtnFichaMedica
            // 
            rbtnFichaMedica.Anchor = AnchorStyles.None;
            rbtnFichaMedica.AutoSize = true;
            rbtnFichaMedica.ForeColor = Color.DarkGreen;
            rbtnFichaMedica.Location = new Point(322, 549);
            rbtnFichaMedica.Margin = new Padding(3, 4, 3, 4);
            rbtnFichaMedica.Name = "rbtnFichaMedica";
            rbtnFichaMedica.Size = new Size(17, 16);
            rbtnFichaMedica.TabIndex = 9;
            rbtnFichaMedica.TabStop = true;
            rbtnFichaMedica.UseVisualStyleBackColor = true;
            rbtnFichaMedica.CheckedChanged += rbtnFichaMedica_CheckedChanged;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Anchor = AnchorStyles.None;
            dtpFechaNac.Location = new Point(415, 390);
            dtpFechaNac.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(228, 27);
            dtpFechaNac.TabIndex = 5;
            dtpFechaNac.ValueChanged += dtpFechaNac_ValueChanged;
            // 
            // lblDatosPersonales
            // 
            lblDatosPersonales.Anchor = AnchorStyles.None;
            lblDatosPersonales.AutoSize = true;
            lblDatosPersonales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosPersonales.Location = new Point(175, 243);
            lblDatosPersonales.Name = "lblDatosPersonales";
            lblDatosPersonales.Size = new Size(143, 23);
            lblDatosPersonales.TabIndex = 23;
            lblDatosPersonales.Text = "Datos Personales";
            // 
            // gboxTipoCliente
            // 
            gboxTipoCliente.Anchor = AnchorStyles.None;
            gboxTipoCliente.Controls.Add(rbtNoSocio);
            gboxTipoCliente.Controls.Add(rbtSocio);
            gboxTipoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxTipoCliente.Location = new Point(175, 112);
            gboxTipoCliente.Margin = new Padding(3, 4, 3, 4);
            gboxTipoCliente.Name = "gboxTipoCliente";
            gboxTipoCliente.Padding = new Padding(3, 4, 3, 4);
            gboxTipoCliente.Size = new Size(606, 103);
            gboxTipoCliente.TabIndex = 1;
            gboxTipoCliente.TabStop = false;
            gboxTipoCliente.Text = "Tipo de Cliente";
            // 
            // rbtNoSocio
            // 
            rbtNoSocio.AutoSize = true;
            rbtNoSocio.Location = new Point(366, 45);
            rbtNoSocio.Margin = new Padding(3, 4, 3, 4);
            rbtNoSocio.Name = "rbtNoSocio";
            rbtNoSocio.Size = new Size(102, 27);
            rbtNoSocio.TabIndex = 1;
            rbtNoSocio.TabStop = true;
            rbtNoSocio.Text = "No Socio";
            rbtNoSocio.UseVisualStyleBackColor = true;
            rbtNoSocio.CheckedChanged += rbtNoSocio_CheckedChanged;
            // 
            // rbtSocio
            // 
            rbtSocio.AutoSize = true;
            rbtSocio.Location = new Point(141, 45);
            rbtSocio.Margin = new Padding(3, 4, 3, 4);
            rbtSocio.Name = "rbtSocio";
            rbtSocio.Size = new Size(74, 27);
            rbtSocio.TabIndex = 0;
            rbtSocio.TabStop = true;
            rbtSocio.Text = "Socio";
            rbtSocio.UseVisualStyleBackColor = true;
            rbtSocio.CheckedChanged += rbtSocio_CheckedChanged;
            // 
            // lblTituloList
            // 
            lblTituloList.Anchor = AnchorStyles.None;
            lblTituloList.AutoSize = true;
            lblTituloList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloList.ForeColor = Color.FromArgb(120, 10, 90);
            lblTituloList.Location = new Point(390, 63);
            lblTituloList.Name = "lblTituloList";
            lblTituloList.Size = new Size(158, 31);
            lblTituloList.TabIndex = 30;
            lblTituloList.Text = "INSCRIPCIÓN";
            // 
            // Inscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(982, 753);
            Controls.Add(lblTituloList);
            Controls.Add(gboxTipoCliente);
            Controls.Add(lblDatosPersonales);
            Controls.Add(dtpFechaNac);
            Controls.Add(rbtnFichaMedica);
            Controls.Add(lblFechaNac);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnInscribir);
            Controls.Add(txtApellido);
            Controls.Add(txtDni);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblFichaMedica);
            Controls.Add(lblDni);
            Controls.Add(lblDireccion);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1000, 800);
            Name = "Inscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor | Sports Club";
            Load += Inscripcion_Load;
            gboxTipoCliente.ResumeLayout(false);
            gboxTipoCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblEmail;
        private Label lblDireccion;
        private Label lblDni;
        private Label lblFichaMedica;
        private Label lblTelefono;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtFichaMedica;
        private Button btnInscribir;
        private Button btnLimpiar;
        private Button btnVolver;
        private Label lblFechaNac;
        private RadioButton rbtnFichaMedica;
        private DateTimePicker dtpFechaNac;
        private Label lblTipoCliente;
        private Label lblDatosPersonales;
        private GroupBox gboxTipoCliente;
        private RadioButton rbtNoSocio;
        private RadioButton rbtSocio;
        private Label lblTituloList;
    }
}