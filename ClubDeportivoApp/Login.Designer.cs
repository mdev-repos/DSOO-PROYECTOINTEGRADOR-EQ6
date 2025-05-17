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
            txtContraseña = new TextBox();
            imgBoxLog = new PictureBox();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)imgBoxLog).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtUsuario.Location = new Point(356, 79);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(340, 31);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtContraseña.Location = new Point(356, 144);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(340, 31);
            txtContraseña.TabIndex = 1;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // imgBoxLog
            // 
            imgBoxLog.Image = (Image)resources.GetObject("imgBoxLog.Image");
            imgBoxLog.Location = new Point(76, 54);
            imgBoxLog.Margin = new Padding(3, 4, 3, 4);
            imgBoxLog.Name = "imgBoxLog";
            imgBoxLog.Size = new Size(230, 241);
            imgBoxLog.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxLog.TabIndex = 2;
            imgBoxLog.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DarkGreen;
            btnIngresar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.Linen;
            btnIngresar.Location = new Point(457, 220);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(130, 50);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(782, 353);
            Controls.Add(btnIngresar);
            Controls.Add(imgBoxLog);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(800, 400);
            MinimumSize = new Size(800, 400);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)imgBoxLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private PictureBox imgBoxLog;
        private Button btnIngresar;
    }
}
