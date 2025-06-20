namespace ClubDeportivoApp
{
    partial class Inscribir_Actividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscribir_Actividad));
            pbVolver = new PictureBox();
            imgBoxOpc = new PictureBox();
            label2 = new Label();
            btnLimpiar = new Button();
            btnBuscarCliente = new Button();
            txtDni = new TextBox();
            lblDni = new Label();
            lblFechaInscr = new Label();
            cBoxActividad = new ComboBox();
            label8 = new Label();
            txtBoxApellido = new TextBox();
            txtBoxNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtBoxValor = new TextBox();
            button1 = new Button();
            label1 = new Label();
            txtBoxHorarios = new TextBox();
            lblDatosCliente = new Label();
            lblDatosActividad = new Label();
            lblDiaUso = new Label();
            dtpDiaUso = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pbVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).BeginInit();
            SuspendLayout();
            // 
            // pbVolver
            // 
            pbVolver.Anchor = AnchorStyles.None;
            pbVolver.BackColor = Color.Linen;
            pbVolver.Cursor = Cursors.Hand;
            pbVolver.Image = (Image)resources.GetObject("pbVolver.Image");
            pbVolver.Location = new Point(874, 82);
            pbVolver.Name = "pbVolver";
            pbVolver.Size = new Size(43, 27);
            pbVolver.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVolver.TabIndex = 29;
            pbVolver.TabStop = false;
            pbVolver.Click += pbVolver_Click;
            // 
            // imgBoxOpc
            // 
            imgBoxOpc.Anchor = AnchorStyles.None;
            imgBoxOpc.BackColor = Color.Linen;
            imgBoxOpc.Image = (Image)resources.GetObject("imgBoxOpc.Image");
            imgBoxOpc.Location = new Point(91, 55);
            imgBoxOpc.Name = "imgBoxOpc";
            imgBoxOpc.Size = new Size(91, 93);
            imgBoxOpc.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxOpc.TabIndex = 28;
            imgBoxOpc.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(120, 10, 90);
            label2.Location = new Point(274, 72);
            label2.Name = "label2";
            label2.Size = new Size(522, 54);
            label2.TabIndex = 27;
            label2.Text = "INSCRIBIR ACTIVIDAD";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.BackColor = Color.DarkGreen;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.Location = new Point(599, 290);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(235, 45);
            btnLimpiar.TabIndex = 38;
            btnLimpiar.Text = "LIMPIAR BUSQUEDA";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Anchor = AnchorStyles.None;
            btnBuscarCliente.BackColor = Color.FromArgb(120, 10, 90);
            btnBuscarCliente.Cursor = Cursors.Hand;
            btnBuscarCliente.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnBuscarCliente.ForeColor = Color.White;
            btnBuscarCliente.Image = (Image)resources.GetObject("btnBuscarCliente.Image");
            btnBuscarCliente.Location = new Point(604, 235);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(230, 45);
            btnBuscarCliente.TabIndex = 37;
            btnBuscarCliente.Text = "BUSCAR CLIENTE";
            btnBuscarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.Location = new Point(267, 246);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(300, 27);
            txtDni.TabIndex = 36;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(219, 247);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(41, 23);
            lblDni.TabIndex = 35;
            lblDni.Text = "DNI";
            // 
            // lblFechaInscr
            // 
            lblFechaInscr.Anchor = AnchorStyles.None;
            lblFechaInscr.AutoSize = true;
            lblFechaInscr.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblFechaInscr.Location = new Point(593, 489);
            lblFechaInscr.Name = "lblFechaInscr";
            lblFechaInscr.Size = new Size(51, 23);
            lblFechaInscr.TabIndex = 73;
            lblFechaInscr.Text = "Valor";
            // 
            // cBoxActividad
            // 
            cBoxActividad.Anchor = AnchorStyles.None;
            cBoxActividad.FormattingEnabled = true;
            cBoxActividad.Location = new Point(267, 488);
            cBoxActividad.Name = "cBoxActividad";
            cBoxActividad.Size = new Size(300, 28);
            cBoxActividad.TabIndex = 72;
            cBoxActividad.SelectedIndexChanged += cBoxActividad_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.Location = new Point(174, 488);
            label8.Name = "label8";
            label8.Size = new Size(87, 23);
            label8.TabIndex = 71;
            label8.Text = "Actividad";
            // 
            // txtBoxApellido
            // 
            txtBoxApellido.Anchor = AnchorStyles.None;
            txtBoxApellido.Location = new Point(267, 363);
            txtBoxApellido.Name = "txtBoxApellido";
            txtBoxApellido.Size = new Size(300, 27);
            txtBoxApellido.TabIndex = 70;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Anchor = AnchorStyles.None;
            txtBoxNombre.Location = new Point(267, 301);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(300, 27);
            txtBoxNombre.TabIndex = 69;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(182, 364);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 68;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(184, 301);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 67;
            label6.Text = "Nombre";
            // 
            // txtBoxValor
            // 
            txtBoxValor.Anchor = AnchorStyles.None;
            txtBoxValor.Location = new Point(650, 488);
            txtBoxValor.Name = "txtBoxValor";
            txtBoxValor.Size = new Size(184, 27);
            txtBoxValor.TabIndex = 74;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(120, 10, 90);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(404, 676);
            button1.Name = "button1";
            button1.Size = new Size(195, 45);
            button1.TabIndex = 75;
            button1.Text = "INSCRIBIR";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(183, 547);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 76;
            label1.Text = "Horarios";
            // 
            // txtBoxHorarios
            // 
            txtBoxHorarios.Anchor = AnchorStyles.None;
            txtBoxHorarios.Location = new Point(267, 543);
            txtBoxHorarios.Name = "txtBoxHorarios";
            txtBoxHorarios.Size = new Size(567, 27);
            txtBoxHorarios.TabIndex = 77;
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.Anchor = AnchorStyles.None;
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosCliente.Location = new Point(91, 183);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(248, 32);
            lblDatosCliente.TabIndex = 78;
            lblDatosCliente.Text = "Datos del Cliente";
            // 
            // lblDatosActividad
            // 
            lblDatosActividad.Anchor = AnchorStyles.None;
            lblDatosActividad.AutoSize = true;
            lblDatosActividad.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosActividad.Location = new Point(91, 423);
            lblDatosActividad.Name = "lblDatosActividad";
            lblDatosActividad.Size = new Size(302, 32);
            lblDatosActividad.TabIndex = 79;
            lblDatosActividad.Text = "Datos de la Actividad";
            // 
            // lblDiaUso
            // 
            lblDiaUso.Anchor = AnchorStyles.None;
            lblDiaUso.AutoSize = true;
            lblDiaUso.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDiaUso.Location = new Point(161, 601);
            lblDiaUso.Name = "lblDiaUso";
            lblDiaUso.Size = new Size(94, 23);
            lblDiaUso.TabIndex = 80;
            lblDiaUso.Text = "Dia de uso";
            // 
            // dtpDiaUso
            // 
            dtpDiaUso.Anchor = AnchorStyles.None;
            dtpDiaUso.Location = new Point(267, 598);
            dtpDiaUso.Margin = new Padding(3, 4, 3, 4);
            dtpDiaUso.Name = "dtpDiaUso";
            dtpDiaUso.Size = new Size(300, 27);
            dtpDiaUso.TabIndex = 81;
            // 
            // Inscribir_Actividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1008, 753);
            Controls.Add(dtpDiaUso);
            Controls.Add(lblDiaUso);
            Controls.Add(lblDatosActividad);
            Controls.Add(lblDatosCliente);
            Controls.Add(txtBoxHorarios);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtBoxValor);
            Controls.Add(lblFechaInscr);
            Controls.Add(cBoxActividad);
            Controls.Add(label8);
            Controls.Add(txtBoxApellido);
            Controls.Add(txtBoxNombre);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscarCliente);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(pbVolver);
            Controls.Add(imgBoxOpc);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 800);
            Name = "Inscribir_Actividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor | Sports Club";
            ((System.ComponentModel.ISupportInitialize)pbVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbVolver;
        private PictureBox imgBoxOpc;
        private Label label2;
        private Button btnLimpiar;
        private Button btnBuscarCliente;
        private TextBox txtDni;
        private Label lblDni;
        private Label lblFechaInscr;
        private ComboBox cBoxActividad;
        private Label label8;
        private TextBox txtBoxApellido;
        private TextBox txtBoxNombre;
        private Label label5;
        private Label label6;
        private TextBox txtBoxValor;
        private Button button1;
        private Label label1;
        private TextBox txtBoxHorarios;
        private Label lblDatosCliente;
        private Label lblDatosActividad;
        private Label lblDiaUso;
        private DateTimePicker dtpDiaUso;
    }
}