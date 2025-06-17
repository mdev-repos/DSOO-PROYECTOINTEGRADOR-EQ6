namespace ClubDeportivoApp
{
    partial class Crear_Actividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Actividad));
            lblTituloList = new Label();
            lblNombreActividad = new Label();
            lblDias = new Label();
            cbDias = new ComboBox();
            lblHorarios = new Label();
            cbHorarios = new ComboBox();
            lblProfesor = new Label();
            txtProfesor = new TextBox();
            btnVolverActividad = new Button();
            btnLimpiar = new Button();
            btnCrearActividad = new Button();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            txtActividad = new TextBox();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            SuspendLayout();
            // 
            // lblTituloList
            // 
            lblTituloList.Anchor = AnchorStyles.None;
            lblTituloList.AutoSize = true;
            lblTituloList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloList.ForeColor = Color.FromArgb(120, 10, 90);
            lblTituloList.Location = new Point(335, 99);
            lblTituloList.Name = "lblTituloList";
            lblTituloList.Size = new Size(183, 25);
            lblTituloList.TabIndex = 31;
            lblTituloList.Text = "NUEVA ACTIVIDAD";
            // 
            // lblNombreActividad
            // 
            lblNombreActividad.Anchor = AnchorStyles.None;
            lblNombreActividad.AutoSize = true;
            lblNombreActividad.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreActividad.Location = new Point(24, 224);
            lblNombreActividad.Name = "lblNombreActividad";
            lblNombreActividad.Size = new Size(87, 20);
            lblNombreActividad.TabIndex = 32;
            lblNombreActividad.Text = "Actividad:";
            // 
            // lblDias
            // 
            lblDias.Anchor = AnchorStyles.None;
            lblDias.AutoSize = true;
            lblDias.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDias.Location = new Point(24, 417);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(161, 20);
            lblDias.TabIndex = 34;
            lblDias.Text = "Día de la actividad:";
            // 
            // cbDias
            // 
            cbDias.FormattingEnabled = true;
            cbDias.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" });
            cbDias.Location = new Point(238, 418);
            cbDias.Name = "cbDias";
            cbDias.Size = new Size(187, 23);
            cbDias.TabIndex = 3;
            cbDias.SelectedIndexChanged += cbDias_SelectedIndexChanged;
            // 
            // lblHorarios
            // 
            lblHorarios.Anchor = AnchorStyles.None;
            lblHorarios.AutoSize = true;
            lblHorarios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHorarios.Location = new Point(475, 417);
            lblHorarios.Name = "lblHorarios";
            lblHorarios.Size = new Size(73, 20);
            lblHorarios.TabIndex = 36;
            lblHorarios.Text = "Horario:";
            // 
            // cbHorarios
            // 
            cbHorarios.Enabled = false;
            cbHorarios.FormattingEnabled = true;
            cbHorarios.Items.AddRange(new object[] { "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00" });
            cbHorarios.Location = new Point(609, 418);
            cbHorarios.Name = "cbHorarios";
            cbHorarios.Size = new Size(155, 23);
            cbHorarios.TabIndex = 4;
            // 
            // lblProfesor
            // 
            lblProfesor.Anchor = AnchorStyles.None;
            lblProfesor.AutoSize = true;
            lblProfesor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfesor.Location = new Point(24, 314);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(147, 20);
            lblProfesor.TabIndex = 38;
            lblProfesor.Text = "Profesor a cargo:";
            // 
            // txtProfesor
            // 
            txtProfesor.Location = new Point(238, 315);
            txtProfesor.Name = "txtProfesor";
            txtProfesor.Size = new Size(187, 23);
            txtProfesor.TabIndex = 1;
            // 
            // btnVolverActividad
            // 
            btnVolverActividad.Anchor = AnchorStyles.None;
            btnVolverActividad.BackColor = Color.FromArgb(120, 10, 90);
            btnVolverActividad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverActividad.ForeColor = Color.Linen;
            btnVolverActividad.Location = new Point(583, 510);
            btnVolverActividad.Name = "btnVolverActividad";
            btnVolverActividad.Size = new Size(121, 35);
            btnVolverActividad.TabIndex = 7;
            btnVolverActividad.Text = "VOLVER";
            btnVolverActividad.UseVisualStyleBackColor = false;
            btnVolverActividad.Click += btnVolverActividad_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.BackColor = Color.Navy;
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Linen;
            btnLimpiar.Location = new Point(92, 510);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 35);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCrearActividad
            // 
            btnCrearActividad.Anchor = AnchorStyles.None;
            btnCrearActividad.BackColor = Color.DarkGreen;
            btnCrearActividad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearActividad.ForeColor = Color.Linen;
            btnCrearActividad.Location = new Point(335, 510);
            btnCrearActividad.Name = "btnCrearActividad";
            btnCrearActividad.Size = new Size(146, 35);
            btnCrearActividad.TabIndex = 6;
            btnCrearActividad.Text = "CREAR ACTIVIDAD";
            btnCrearActividad.UseVisualStyleBackColor = false;
            // 
            // lblPrecio
            // 
            lblPrecio.Anchor = AnchorStyles.None;
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(475, 310);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(64, 20);
            lblPrecio.TabIndex = 43;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(609, 311);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(155, 23);
            txtPrecio.TabIndex = 2;
            // 
            // txtActividad
            // 
            txtActividad.Location = new Point(238, 225);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(187, 23);
            txtActividad.TabIndex = 0;
            txtActividad.TextChanged += txtActividad_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(609, 225);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(155, 23);
            txtCodigo.TabIndex = 46;
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.None;
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(475, 228);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(70, 20);
            lblCodigo.TabIndex = 48;
            lblCodigo.Text = "Código:";
            // 
            // Crear_Actividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 577);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(txtActividad);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(btnCrearActividad);
            Controls.Add(btnLimpiar);
            Controls.Add(btnVolverActividad);
            Controls.Add(txtProfesor);
            Controls.Add(lblProfesor);
            Controls.Add(cbHorarios);
            Controls.Add(lblHorarios);
            Controls.Add(cbDias);
            Controls.Add(lblDias);
            Controls.Add(lblNombreActividad);
            Controls.Add(lblTituloList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Crear_Actividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor | Sports Club";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloList;
        private Label lblNombreActividad;
        private ComboBox cbNombreActividad;
        private Label lblDias;
        private ComboBox cbDias;
        private Label lblHorarios;
        private ComboBox cbHorarios;
        private Label lblProfesor;
        private TextBox txtProfesor;
        private Button btnVolverActividad;
        private Button btnLimpiar;
        private Button btnCrearActividad;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private TextBox txtActividad;
        private TextBox txtCodigo;
        private Label lblCodigo;
    }
}