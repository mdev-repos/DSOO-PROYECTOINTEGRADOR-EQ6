namespace ClubDeportivoApp
{
    partial class Actividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actividades));
            lblTituloOpc = new Label();
            pbVolver = new PictureBox();
            pbVerActividades = new PictureBox();
            pbCrearModificarActividad = new PictureBox();
            pbInscribirActividad = new PictureBox();
            VolverBtn = new Button();
            ListarActividadesBtn = new Button();
            InscribirActBtn = new Button();
            CrearModificarBtn = new Button();
            imgBoxOpc = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVerActividades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCrearModificarActividad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInscribirActividad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).BeginInit();
            SuspendLayout();
            // 
            // lblTituloOpc
            // 
            lblTituloOpc.Anchor = AnchorStyles.None;
            lblTituloOpc.AutoSize = true;
            lblTituloOpc.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloOpc.ForeColor = Color.FromArgb(120, 10, 90);
            lblTituloOpc.Location = new Point(365, 75);
            lblTituloOpc.Name = "lblTituloOpc";
            lblTituloOpc.Size = new Size(201, 31);
            lblTituloOpc.TabIndex = 58;
            lblTituloOpc.Text = "PANEL DE PAGOS";
            // 
            // pbVolver
            // 
            pbVolver.Anchor = AnchorStyles.None;
            pbVolver.BackColor = Color.FromArgb(120, 10, 90);
            pbVolver.BackgroundImageLayout = ImageLayout.Stretch;
            pbVolver.Image = (Image)resources.GetObject("pbVolver.Image");
            pbVolver.Location = new Point(608, 591);
            pbVolver.Name = "pbVolver";
            pbVolver.Padding = new Padding(5, 5, 5, 5);
            pbVolver.Size = new Size(88, 88);
            pbVolver.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVolver.TabIndex = 57;
            pbVolver.TabStop = false;
            // 
            // pbVerActividades
            // 
            pbVerActividades.Anchor = AnchorStyles.None;
            pbVerActividades.BackColor = Color.DarkGreen;
            pbVerActividades.BackgroundImageLayout = ImageLayout.Stretch;
            pbVerActividades.Image = (Image)resources.GetObject("pbVerActividades.Image");
            pbVerActividades.Location = new Point(608, 455);
            pbVerActividades.Name = "pbVerActividades";
            pbVerActividades.Padding = new Padding(5, 5, 5, 5);
            pbVerActividades.Size = new Size(88, 88);
            pbVerActividades.SizeMode = PictureBoxSizeMode.Zoom;
            pbVerActividades.TabIndex = 56;
            pbVerActividades.TabStop = false;
            // 
            // pbCrearModificarActividad
            // 
            pbCrearModificarActividad.Anchor = AnchorStyles.None;
            pbCrearModificarActividad.BackColor = Color.DarkGreen;
            pbCrearModificarActividad.BackgroundImageLayout = ImageLayout.Stretch;
            pbCrearModificarActividad.Image = (Image)resources.GetObject("pbCrearModificarActividad.Image");
            pbCrearModificarActividad.Location = new Point(608, 309);
            pbCrearModificarActividad.Name = "pbCrearModificarActividad";
            pbCrearModificarActividad.Padding = new Padding(5, 5, 5, 5);
            pbCrearModificarActividad.Size = new Size(88, 88);
            pbCrearModificarActividad.SizeMode = PictureBoxSizeMode.Zoom;
            pbCrearModificarActividad.TabIndex = 55;
            pbCrearModificarActividad.TabStop = false;
            // 
            // pbInscribirActividad
            // 
            pbInscribirActividad.Anchor = AnchorStyles.None;
            pbInscribirActividad.BackColor = Color.DarkGreen;
            pbInscribirActividad.BackgroundImageLayout = ImageLayout.Stretch;
            pbInscribirActividad.Image = (Image)resources.GetObject("pbInscribirActividad.Image");
            pbInscribirActividad.Location = new Point(608, 163);
            pbInscribirActividad.Name = "pbInscribirActividad";
            pbInscribirActividad.Padding = new Padding(5, 5, 5, 5);
            pbInscribirActividad.Size = new Size(88, 88);
            pbInscribirActividad.SizeMode = PictureBoxSizeMode.Zoom;
            pbInscribirActividad.TabIndex = 54;
            pbInscribirActividad.TabStop = false;
            // 
            // VolverBtn
            // 
            VolverBtn.Anchor = AnchorStyles.None;
            VolverBtn.BackColor = Color.FromArgb(120, 10, 90);
            VolverBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VolverBtn.ForeColor = Color.Linen;
            VolverBtn.Location = new Point(715, 591);
            VolverBtn.Name = "VolverBtn";
            VolverBtn.Size = new Size(186, 88);
            VolverBtn.TabIndex = 53;
            VolverBtn.Text = "Volver";
            VolverBtn.UseVisualStyleBackColor = false;
            VolverBtn.Click += VolverBtn_Click;
            // 
            // ListarActividadesBtn
            // 
            ListarActividadesBtn.Anchor = AnchorStyles.None;
            ListarActividadesBtn.BackColor = Color.DarkGreen;
            ListarActividadesBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListarActividadesBtn.ForeColor = Color.Linen;
            ListarActividadesBtn.Location = new Point(715, 455);
            ListarActividadesBtn.Name = "ListarActividadesBtn";
            ListarActividadesBtn.Size = new Size(186, 88);
            ListarActividadesBtn.TabIndex = 52;
            ListarActividadesBtn.Text = "Ver Actividades";
            ListarActividadesBtn.UseVisualStyleBackColor = false;
            // 
            // InscribirActBtn
            // 
            InscribirActBtn.Anchor = AnchorStyles.None;
            InscribirActBtn.BackColor = Color.DarkGreen;
            InscribirActBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InscribirActBtn.ForeColor = Color.Linen;
            InscribirActBtn.Location = new Point(715, 163);
            InscribirActBtn.Name = "InscribirActBtn";
            InscribirActBtn.Size = new Size(186, 88);
            InscribirActBtn.TabIndex = 51;
            InscribirActBtn.Text = "Inscribir | Cobrar Actividad";
            InscribirActBtn.UseVisualStyleBackColor = false;
            // 
            // CrearModificarBtn
            // 
            CrearModificarBtn.Anchor = AnchorStyles.None;
            CrearModificarBtn.BackColor = Color.DarkGreen;
            CrearModificarBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrearModificarBtn.ForeColor = Color.Linen;
            CrearModificarBtn.Location = new Point(715, 309);
            CrearModificarBtn.Name = "CrearModificarBtn";
            CrearModificarBtn.Size = new Size(186, 88);
            CrearModificarBtn.TabIndex = 50;
            CrearModificarBtn.Text = "Crear | Modificar Actividad";
            CrearModificarBtn.UseVisualStyleBackColor = false;
            CrearModificarBtn.Click += CrearBtn_Click;
            // 
            // imgBoxOpc
            // 
            imgBoxOpc.Anchor = AnchorStyles.None;
            imgBoxOpc.BackColor = Color.Transparent;
            imgBoxOpc.Image = (Image)resources.GetObject("imgBoxOpc.Image");
            imgBoxOpc.Location = new Point(82, 163);
            imgBoxOpc.Name = "imgBoxOpc";
            imgBoxOpc.Padding = new Padding(10, 11, 10, 11);
            imgBoxOpc.Size = new Size(475, 516);
            imgBoxOpc.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxOpc.TabIndex = 49;
            imgBoxOpc.TabStop = false;
            // 
            // Actividades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(984, 761);
            Controls.Add(lblTituloOpc);
            Controls.Add(pbVolver);
            Controls.Add(pbVerActividades);
            Controls.Add(pbCrearModificarActividad);
            Controls.Add(pbInscribirActividad);
            Controls.Add(VolverBtn);
            Controls.Add(ListarActividadesBtn);
            Controls.Add(InscribirActBtn);
            Controls.Add(CrearModificarBtn);
            Controls.Add(imgBoxOpc);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 798);
            Name = "Actividades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor | Sports Club";
            ((System.ComponentModel.ISupportInitialize)pbVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVerActividades).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCrearModificarActividad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInscribirActividad).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloOpc;
        private PictureBox pbVolver;
        private PictureBox pbVerActividades;
        private PictureBox pbCrearModificarActividad;
        private PictureBox pbInscribirActividad;
        private Button VolverBtn;
        private Button ListarActividadesBtn;
        private Button InscribirActBtn;
        private Button CrearModificarBtn;
        private PictureBox imgBoxOpc;
    }
}