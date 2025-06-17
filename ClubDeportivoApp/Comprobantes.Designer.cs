namespace ClubDeportivoApp
{
    partial class Comprobantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprobantes));
            dgvComprobantes = new DataGridView();
            lblTituloList = new Label();
            btnVolver = new Button();
            btnBuscarComprobantes = new Button();
            txtDniInput = new TextBox();
            lblDni = new Label();
            label3 = new Label();
            txtBoxResCod = new TextBox();
            txtBoxResNombre = new TextBox();
            txtBoxResApellido = new TextBox();
            lblCodCliente = new Label();
            lblApellido = new Label();
            lblCodigo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvComprobantes).BeginInit();
            SuspendLayout();
            // 
            // dgvComprobantes
            // 
            dgvComprobantes.AllowUserToResizeColumns = false;
            dgvComprobantes.AllowUserToResizeRows = false;
            dgvComprobantes.Anchor = AnchorStyles.None;
            dgvComprobantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComprobantes.BackgroundColor = Color.Linen;
            dgvComprobantes.BorderStyle = BorderStyle.None;
            dgvComprobantes.ColumnHeadersHeight = 29;
            dgvComprobantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvComprobantes.Location = new Point(12, 314);
            dgvComprobantes.MinimumSize = new Size(950, 330);
            dgvComprobantes.Name = "dgvComprobantes";
            dgvComprobantes.RowHeadersWidth = 51;
            dgvComprobantes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvComprobantes.Size = new Size(950, 330);
            dgvComprobantes.TabIndex = 6;
            // 
            // lblTituloList
            // 
            lblTituloList.Anchor = AnchorStyles.None;
            lblTituloList.AutoSize = true;
            lblTituloList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloList.ForeColor = Color.FromArgb(120, 10, 90);
            lblTituloList.Location = new Point(340, 60);
            lblTituloList.Name = "lblTituloList";
            lblTituloList.Size = new Size(303, 31);
            lblTituloList.TabIndex = 32;
            lblTituloList.Text = "COMPROBANTES DE PAGO";
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.BackColor = Color.FromArgb(120, 10, 90);
            btnVolver.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.Linen;
            btnVolver.Location = new Point(769, 666);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(152, 53);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnBuscarComprobantes
            // 
            btnBuscarComprobantes.Anchor = AnchorStyles.None;
            btnBuscarComprobantes.BackColor = Color.DarkGreen;
            btnBuscarComprobantes.Cursor = Cursors.Hand;
            btnBuscarComprobantes.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnBuscarComprobantes.ForeColor = Color.White;
            btnBuscarComprobantes.Image = (Image)resources.GetObject("btnBuscarComprobantes.Image");
            btnBuscarComprobantes.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarComprobantes.Location = new Point(408, 128);
            btnBuscarComprobantes.Name = "btnBuscarComprobantes";
            btnBuscarComprobantes.Size = new Size(126, 48);
            btnBuscarComprobantes.TabIndex = 2;
            btnBuscarComprobantes.Text = "BUSCAR";
            btnBuscarComprobantes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarComprobantes.UseVisualStyleBackColor = false;
            btnBuscarComprobantes.Click += btnBuscarComprobantes_Click;
            // 
            // txtDniInput
            // 
            txtDniInput.Anchor = AnchorStyles.None;
            txtDniInput.Location = new Point(180, 141);
            txtDniInput.MaximumSize = new Size(238, 45);
            txtDniInput.Name = "txtDniInput";
            txtDniInput.Size = new Size(195, 27);
            txtDniInput.TabIndex = 1;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(12, 141);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(148, 23);
            lblDni.TabIndex = 36;
            lblDni.Text = "DNI DEL CLIENTE";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(577, 267);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 46;
            // 
            // txtBoxResCod
            // 
            txtBoxResCod.Anchor = AnchorStyles.None;
            txtBoxResCod.Location = new Point(111, 210);
            txtBoxResCod.Name = "txtBoxResCod";
            txtBoxResCod.ReadOnly = true;
            txtBoxResCod.Size = new Size(281, 27);
            txtBoxResCod.TabIndex = 3;
            // 
            // txtBoxResNombre
            // 
            txtBoxResNombre.Anchor = AnchorStyles.None;
            txtBoxResNombre.Location = new Point(111, 250);
            txtBoxResNombre.Name = "txtBoxResNombre";
            txtBoxResNombre.ReadOnly = true;
            txtBoxResNombre.Size = new Size(281, 27);
            txtBoxResNombre.TabIndex = 4;
            // 
            // txtBoxResApellido
            // 
            txtBoxResApellido.Anchor = AnchorStyles.None;
            txtBoxResApellido.Location = new Point(540, 251);
            txtBoxResApellido.Name = "txtBoxResApellido";
            txtBoxResApellido.ReadOnly = true;
            txtBoxResApellido.Size = new Size(349, 27);
            txtBoxResApellido.TabIndex = 5;
            // 
            // lblCodCliente
            // 
            lblCodCliente.Anchor = AnchorStyles.None;
            lblCodCliente.AutoSize = true;
            lblCodCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCodCliente.Location = new Point(12, 210);
            lblCodCliente.Name = "lblCodCliente";
            lblCodCliente.Size = new Size(77, 23);
            lblCodCliente.TabIndex = 42;
            lblCodCliente.Text = "CODIGO";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblApellido.Location = new Point(430, 251);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(90, 23);
            lblApellido.TabIndex = 41;
            lblApellido.Text = "APELLIDO";
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.None;
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCodigo.Location = new Point(12, 251);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(83, 23);
            lblCodigo.TabIndex = 40;
            lblCodigo.Text = "NOMBRE";
            // 
            // Comprobantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(982, 753);
            Controls.Add(label3);
            Controls.Add(txtBoxResCod);
            Controls.Add(txtBoxResNombre);
            Controls.Add(txtBoxResApellido);
            Controls.Add(lblCodCliente);
            Controls.Add(lblApellido);
            Controls.Add(lblCodigo);
            Controls.Add(btnBuscarComprobantes);
            Controls.Add(txtDniInput);
            Controls.Add(lblDni);
            Controls.Add(btnVolver);
            Controls.Add(dgvComprobantes);
            Controls.Add(lblTituloList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 800);
            Name = "Comprobantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor | Sports Club";
            ((System.ComponentModel.ISupportInitialize)dgvComprobantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvComprobantes;
        private Label lblTituloList;
        private Button btnVolver;
        private Button btnBuscarComprobantes;
        private TextBox txtDniInput;
        private Label lblDni;
        private Label label3;
        private TextBox txtBoxResCod;
        private TextBox txtBoxResNombre;
        private TextBox txtBoxResApellido;
        private Label lblCodCliente;
        private Label lblApellido;
        private Label lblCodigo;
    }
}