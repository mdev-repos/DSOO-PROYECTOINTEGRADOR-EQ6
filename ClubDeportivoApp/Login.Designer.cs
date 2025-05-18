namespace ClubDeportivoApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            imgBoxLog = new PictureBox();
            btnIngresar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)imgBoxLog).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtUsuario.Location = new Point(489, 219);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(358, 38);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Anchor = AnchorStyles.None;
            txtContrasenia.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtContrasenia.Location = new Point(489, 292);
            txtContrasenia.Margin = new Padding(3, 4, 3, 4);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.PlaceholderText = "Contraseña";
            txtContrasenia.Size = new Size(358, 38);
            txtContrasenia.TabIndex = 1;
            txtContrasenia.UseSystemPasswordChar = true;
            txtContrasenia.Enter += txtContraseña_Enter;
            txtContrasenia.Leave += txtContraseña_Leave;
            // 
            // imgBoxLog
            // 
            imgBoxLog.Anchor = AnchorStyles.None;
            imgBoxLog.Image = (Image)resources.GetObject("imgBoxLog.Image");
            imgBoxLog.Location = new Point(117, 156);
            imgBoxLog.Margin = new Padding(3, 4, 3, 4);
            imgBoxLog.Name = "imgBoxLog";
            imgBoxLog.Size = new Size(292, 315);
            imgBoxLog.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxLog.TabIndex = 2;
            imgBoxLog.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.BackColor = Color.DarkGreen;
            btnIngresar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.Linen;
            btnIngresar.Location = new Point(703, 370);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(128, 53);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(120, 10, 90);
            lblTitulo.Location = new Point(352, 57);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(248, 31);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "INGRESO AL SISTEMA";
            lblTitulo.Click += label1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.BackColor = Color.FromArgb(120, 10, 90);
            btnSalir.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnSalir.ForeColor = Color.Linen;
            btnSalir.Location = new Point(508, 370);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(128, 53);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(982, 553);
            Controls.Add(btnSalir);
            Controls.Add(lblTitulo);
            Controls.Add(btnIngresar);
            Controls.Add(imgBoxLog);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1000, 600);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor | Sports Club";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)imgBoxLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private PictureBox imgBoxLog;
        private Button btnIngresar;
        private Label lblTitulo;
        private Button btnSalir;
    }
}
