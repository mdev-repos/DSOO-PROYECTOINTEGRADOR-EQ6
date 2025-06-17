namespace ClubDeportivoApp
{
    partial class Baja_Socio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baja_Socio));
            lblTituloOpc = new Label();
            btnBuscarSocio = new Button();
            txtDniInput = new TextBox();
            lblDni = new Label();
            label3 = new Label();
            txtCodCliente = new TextBox();
            txtNombreCliente = new TextBox();
            lblCodCliente = new Label();
            lblApellido = new Label();
            lblCodigo = new Label();
            label1 = new Label();
            txtApellidoCliente = new TextBox();
            txtEstadoCliente = new TextBox();
            btnVolver = new Button();
            btnLimpiar = new Button();
            btnReincorporar = new Button();
            btnBaja = new Button();
            SuspendLayout();
            // 
            // lblTituloOpc
            // 
            lblTituloOpc.Anchor = AnchorStyles.None;
            lblTituloOpc.AutoSize = true;
            lblTituloOpc.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloOpc.ForeColor = Color.FromArgb(120, 10, 90);
            lblTituloOpc.Location = new Point(332, 62);
            lblTituloOpc.Name = "lblTituloOpc";
            lblTituloOpc.Size = new Size(307, 31);
            lblTituloOpc.TabIndex = 39;
            lblTituloOpc.Text = "BAJA | REINCORPORACION";
            // 
            // btnBuscarSocio
            // 
            btnBuscarSocio.Anchor = AnchorStyles.None;
            btnBuscarSocio.BackColor = Color.DarkGreen;
            btnBuscarSocio.Cursor = Cursors.Hand;
            btnBuscarSocio.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnBuscarSocio.ForeColor = Color.White;
            btnBuscarSocio.Image = (Image)resources.GetObject("btnBuscarSocio.Image");
            btnBuscarSocio.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarSocio.Location = new Point(426, 139);
            btnBuscarSocio.Name = "btnBuscarSocio";
            btnBuscarSocio.Size = new Size(126, 48);
            btnBuscarSocio.TabIndex = 41;
            btnBuscarSocio.Text = "BUSCAR";
            btnBuscarSocio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarSocio.UseVisualStyleBackColor = false;
            btnBuscarSocio.Click += btnBuscarSocio_Click;
            // 
            // txtDniInput
            // 
            txtDniInput.Anchor = AnchorStyles.None;
            txtDniInput.Location = new Point(198, 152);
            txtDniInput.MaximumSize = new Size(238, 45);
            txtDniInput.Name = "txtDniInput";
            txtDniInput.Size = new Size(195, 27);
            txtDniInput.TabIndex = 40;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(42, 154);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(134, 23);
            lblDni.TabIndex = 42;
            lblDni.Text = "DNI DEL SOCIO";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(608, 274);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 53;
            // 
            // txtCodCliente
            // 
            txtCodCliente.Anchor = AnchorStyles.None;
            txtCodCliente.Location = new Point(142, 217);
            txtCodCliente.Name = "txtCodCliente";
            txtCodCliente.ReadOnly = true;
            txtCodCliente.Size = new Size(281, 27);
            txtCodCliente.TabIndex = 47;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Anchor = AnchorStyles.None;
            txtNombreCliente.Location = new Point(142, 257);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.ReadOnly = true;
            txtNombreCliente.Size = new Size(281, 27);
            txtNombreCliente.TabIndex = 48;
            // 
            // lblCodCliente
            // 
            lblCodCliente.Anchor = AnchorStyles.None;
            lblCodCliente.AutoSize = true;
            lblCodCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCodCliente.Location = new Point(43, 217);
            lblCodCliente.Name = "lblCodCliente";
            lblCodCliente.Size = new Size(77, 23);
            lblCodCliente.TabIndex = 52;
            lblCodCliente.Text = "CODIGO";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblApellido.Location = new Point(461, 258);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(90, 23);
            lblApellido.TabIndex = 51;
            lblApellido.Text = "APELLIDO";
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.None;
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCodigo.Location = new Point(43, 258);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(83, 23);
            lblCodigo.TabIndex = 50;
            lblCodigo.Text = "NOMBRE";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(473, 217);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 55;
            label1.Text = "ESTADO";
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Anchor = AnchorStyles.None;
            txtApellidoCliente.Location = new Point(571, 258);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.ReadOnly = true;
            txtApellidoCliente.Size = new Size(281, 27);
            txtApellidoCliente.TabIndex = 56;
            // 
            // txtEstadoCliente
            // 
            txtEstadoCliente.Anchor = AnchorStyles.None;
            txtEstadoCliente.Location = new Point(571, 217);
            txtEstadoCliente.Name = "txtEstadoCliente";
            txtEstadoCliente.ReadOnly = true;
            txtEstadoCliente.Size = new Size(281, 27);
            txtEstadoCliente.TabIndex = 57;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.BackColor = Color.FromArgb(120, 10, 90);
            btnVolver.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.Linen;
            btnVolver.Location = new Point(759, 645);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(152, 53);
            btnVolver.TabIndex = 58;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.BackColor = Color.Navy;
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Linen;
            btnLimpiar.Location = new Point(584, 645);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(152, 53);
            btnLimpiar.TabIndex = 60;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnReincorporar
            // 
            btnReincorporar.Anchor = AnchorStyles.None;
            btnReincorporar.BackColor = Color.DarkGreen;
            btnReincorporar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReincorporar.ForeColor = Color.Linen;
            btnReincorporar.Location = new Point(238, 353);
            btnReincorporar.Margin = new Padding(3, 4, 3, 4);
            btnReincorporar.Name = "btnReincorporar";
            btnReincorporar.Size = new Size(172, 53);
            btnReincorporar.TabIndex = 59;
            btnReincorporar.Text = "REINCORPORAR";
            btnReincorporar.UseVisualStyleBackColor = false;
            // 
            // btnBaja
            // 
            btnBaja.Anchor = AnchorStyles.None;
            btnBaja.BackColor = Color.Black;
            btnBaja.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaja.ForeColor = Color.Linen;
            btnBaja.Location = new Point(43, 353);
            btnBaja.Margin = new Padding(3, 4, 3, 4);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(172, 53);
            btnBaja.TabIndex = 61;
            btnBaja.Text = "EFECTUAR BAJA";
            btnBaja.UseVisualStyleBackColor = false;
            // 
            // Baja_Socio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(982, 753);
            Controls.Add(btnBaja);
            Controls.Add(btnLimpiar);
            Controls.Add(btnReincorporar);
            Controls.Add(btnVolver);
            Controls.Add(txtEstadoCliente);
            Controls.Add(txtApellidoCliente);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtCodCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblCodCliente);
            Controls.Add(lblApellido);
            Controls.Add(lblCodigo);
            Controls.Add(btnBuscarSocio);
            Controls.Add(txtDniInput);
            Controls.Add(lblDni);
            Controls.Add(lblTituloOpc);
            MinimumSize = new Size(1000, 800);
            Name = "Baja_Socio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor | Sports Club";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloOpc;
        private Button btnBuscarSocio;
        private TextBox txtDniInput;
        private Label lblDni;
        private Label label3;
        private TextBox txtCodCliente;
        private TextBox txtNombreCliente;
        private Label lblCodCliente;
        private Label lblApellido;
        private Label lblCodigo;
        private Label label1;
        private TextBox txtApellidoCliente;
        private TextBox txtEstadoCliente;
        private Button btnVolver;
        private Button btnLimpiar;
        private Button btnReincorporar;
        private Button btnBaja;
    }
}