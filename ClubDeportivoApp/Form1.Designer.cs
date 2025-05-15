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
            pictureBox1 = new PictureBox();
            txtPass = new TextBox();
            btnINGRESAR = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(294, 89);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(228, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += textBox1_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(294, 158);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(228, 23);
            txtPass.TabIndex = 4;
            // 
            // btnINGRESAR
            // 
            btnINGRESAR.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnINGRESAR.Location = new Point(362, 213);
            btnINGRESAR.Name = "btnINGRESAR";
            btnINGRESAR.Size = new Size(124, 27);
            btnINGRESAR.TabIndex = 5;
            btnINGRESAR.Text = "INGRESAR";
            btnINGRESAR.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnINGRESAR);
            Controls.Add(txtPass);
            Controls.Add(pictureBox1);
            Controls.Add(txtUsuario);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
        private TextBox txtPass;
        private Button btnINGRESAR;
    }
}
