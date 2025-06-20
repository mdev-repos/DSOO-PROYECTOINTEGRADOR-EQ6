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
            lblHorario = new Label();
            btnVolverActividad = new Button();
            btnLimpiar = new Button();
            btnCrearActividad = new Button();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            txtActividad = new TextBox();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            gboxCrearModificar = new GroupBox();
            rbtModificar = new RadioButton();
            rbtCrear = new RadioButton();
            lblCreacion = new Label();
            txtHorarios = new TextBox();
            btnBuscarActividad = new Button();
            btnModificar = new Button();
            gboxCrearModificar.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloList
            // 
            lblTituloList.Anchor = AnchorStyles.None;
            lblTituloList.AutoSize = true;
            lblTituloList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloList.ForeColor = Color.FromArgb(120, 10, 90);
            lblTituloList.Location = new Point(267, 55);
            lblTituloList.Name = "lblTituloList";
            lblTituloList.Size = new Size(299, 25);
            lblTituloList.TabIndex = 31;
            lblTituloList.Text = "CREAR | MODIFICAR ACTIVIDAD";
            // 
            // lblNombreActividad
            // 
            lblNombreActividad.Anchor = AnchorStyles.None;
            lblNombreActividad.AutoSize = true;
            lblNombreActividad.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblNombreActividad.Location = new Point(63, 337);
            lblNombreActividad.Name = "lblNombreActividad";
            lblNombreActividad.Size = new Size(68, 18);
            lblNombreActividad.TabIndex = 32;
            lblNombreActividad.Text = "Nombre";
            // 
            // lblHorario
            // 
            lblHorario.Anchor = AnchorStyles.None;
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblHorario.Location = new Point(8, 389);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(126, 18);
            lblHorario.TabIndex = 34;
            lblHorario.Text = "Dias y Horarios";
            // 
            // btnVolverActividad
            // 
            btnVolverActividad.Anchor = AnchorStyles.None;
            btnVolverActividad.BackColor = Color.FromArgb(120, 10, 90);
            btnVolverActividad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverActividad.ForeColor = Color.Linen;
            btnVolverActividad.Location = new Point(635, 478);
            btnVolverActividad.Name = "btnVolverActividad";
            btnVolverActividad.Size = new Size(147, 50);
            btnVolverActividad.TabIndex = 10;
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
            btnLimpiar.Location = new Point(52, 478);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(147, 50);
            btnLimpiar.TabIndex = 7;
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
            btnCrearActividad.Location = new Point(245, 478);
            btnCrearActividad.Name = "btnCrearActividad";
            btnCrearActividad.Size = new Size(147, 50);
            btnCrearActividad.TabIndex = 8;
            btnCrearActividad.Text = "CREAR ACTIVIDAD";
            btnCrearActividad.UseVisualStyleBackColor = false;
            btnCrearActividad.Click += btnCrearActividad_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.Anchor = AnchorStyles.None;
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblPrecio.Location = new Point(548, 337);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(57, 18);
            lblPrecio.TabIndex = 43;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.None;
            txtPrecio.Location = new Point(627, 337);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(155, 23);
            txtPrecio.TabIndex = 5;
            // 
            // txtActividad
            // 
            txtActividad.Anchor = AnchorStyles.None;
            txtActividad.Location = new Point(143, 337);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(337, 23);
            txtActividad.TabIndex = 4;
            txtActividad.TextChanged += txtActividad_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.None;
            txtCodigo.Location = new Point(143, 286);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(337, 23);
            txtCodigo.TabIndex = 2;
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.None;
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblCodigo.Location = new Point(68, 287);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(62, 18);
            lblCodigo.TabIndex = 48;
            lblCodigo.Text = "Código";
            // 
            // gboxCrearModificar
            // 
            gboxCrearModificar.Anchor = AnchorStyles.None;
            gboxCrearModificar.Controls.Add(rbtModificar);
            gboxCrearModificar.Controls.Add(rbtCrear);
            gboxCrearModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxCrearModificar.Location = new Point(158, 107);
            gboxCrearModificar.Name = "gboxCrearModificar";
            gboxCrearModificar.Size = new Size(530, 102);
            gboxCrearModificar.TabIndex = 49;
            gboxCrearModificar.TabStop = false;
            gboxCrearModificar.Text = "Seleccion de Modo";
            // 
            // rbtModificar
            // 
            rbtModificar.AutoSize = true;
            rbtModificar.Location = new Point(294, 49);
            rbtModificar.Name = "rbtModificar";
            rbtModificar.Size = new Size(147, 21);
            rbtModificar.TabIndex = 1;
            rbtModificar.TabStop = true;
            rbtModificar.Text = "Modificar Actividad";
            rbtModificar.UseVisualStyleBackColor = true;
            rbtModificar.CheckedChanged += rbtModificar_CheckedChanged_1;
            // 
            // rbtCrear
            // 
            rbtCrear.AutoSize = true;
            rbtCrear.Location = new Point(97, 49);
            rbtCrear.Name = "rbtCrear";
            rbtCrear.Size = new Size(120, 21);
            rbtCrear.TabIndex = 0;
            rbtCrear.TabStop = true;
            rbtCrear.Text = "Crear Actividad";
            rbtCrear.UseVisualStyleBackColor = true;
            rbtCrear.CheckedChanged += rbtCrear_CheckedChanged_1;
            // 
            // lblCreacion
            // 
            lblCreacion.Anchor = AnchorStyles.None;
            lblCreacion.AutoSize = true;
            lblCreacion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreacion.Location = new Point(52, 226);
            lblCreacion.Name = "lblCreacion";
            lblCreacion.Size = new Size(95, 25);
            lblCreacion.TabIndex = 50;
            lblCreacion.Text = "Actividad";
            // 
            // txtHorarios
            // 
            txtHorarios.Anchor = AnchorStyles.None;
            txtHorarios.Location = new Point(143, 388);
            txtHorarios.Name = "txtHorarios";
            txtHorarios.Size = new Size(640, 23);
            txtHorarios.TabIndex = 6;
            // 
            // btnBuscarActividad
            // 
            btnBuscarActividad.Anchor = AnchorStyles.None;
            btnBuscarActividad.BackColor = Color.FromArgb(120, 10, 90);
            btnBuscarActividad.Cursor = Cursors.Hand;
            btnBuscarActividad.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnBuscarActividad.ForeColor = Color.White;
            btnBuscarActividad.Image = (Image)resources.GetObject("btnBuscarActividad.Image");
            btnBuscarActividad.Location = new Point(576, 276);
            btnBuscarActividad.Margin = new Padding(3, 2, 3, 2);
            btnBuscarActividad.Name = "btnBuscarActividad";
            btnBuscarActividad.Size = new Size(206, 40);
            btnBuscarActividad.TabIndex = 3;
            btnBuscarActividad.Text = "BUSCAR ACTIVIDAD";
            btnBuscarActividad.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarActividad.UseVisualStyleBackColor = false;
            btnBuscarActividad.Click += btnBuscarActividad_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.DarkGreen;
            btnModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Linen;
            btnModificar.Location = new Point(436, 478);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(147, 50);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "MODIFICAR ACTIVIDAD";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // Crear_Actividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(861, 571);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscarActividad);
            Controls.Add(txtHorarios);
            Controls.Add(lblCreacion);
            Controls.Add(gboxCrearModificar);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(txtActividad);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(btnCrearActividad);
            Controls.Add(btnLimpiar);
            Controls.Add(btnVolverActividad);
            Controls.Add(lblHorario);
            Controls.Add(lblNombreActividad);
            Controls.Add(lblTituloList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(877, 610);
            Name = "Crear_Actividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor | Sports Club";
            gboxCrearModificar.ResumeLayout(false);
            gboxCrearModificar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloList;
        private Label lblNombreActividad;
        private ComboBox cbNombreActividad;
        private Label lblHorario;
        private Button btnVolverActividad;
        private Button btnLimpiar;
        private Button btnCrearActividad;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private TextBox txtActividad;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private GroupBox gboxCrearModificar;
        private RadioButton rbtModificar;
        private RadioButton rbtCrear;
        private Label lblCreacion;
        private TextBox txtHorarios;
        private Button btnBuscarActividad;
        private Button btnModificar;
    }
}