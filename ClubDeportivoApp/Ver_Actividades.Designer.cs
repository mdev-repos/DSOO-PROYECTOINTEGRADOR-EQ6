namespace ClubDeportivoApp
{
    partial class Ver_Actividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_Actividades));
            lblTituloOpc = new Label();
            btnVolver = new Button();
            dgvActividades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // lblTituloOpc
            // 
            lblTituloOpc.Anchor = AnchorStyles.None;
            lblTituloOpc.AutoSize = true;
            lblTituloOpc.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloOpc.ForeColor = Color.FromArgb(120, 10, 90);
            lblTituloOpc.Location = new Point(253, 63);
            lblTituloOpc.Name = "lblTituloOpc";
            lblTituloOpc.Size = new Size(446, 31);
            lblTituloOpc.TabIndex = 59;
            lblTituloOpc.Text = "LISTADO DE ACTIVIDADES DISPONIBLES";
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.BackColor = Color.FromArgb(120, 10, 90);
            btnVolver.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.Linen;
            btnVolver.Location = new Point(730, 645);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(152, 53);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvActividades
            // 
            dgvActividades.Anchor = AnchorStyles.None;
            dgvActividades.BackgroundColor = Color.Linen;
            dgvActividades.BorderStyle = BorderStyle.None;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.Location = new Point(26, 133);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowHeadersWidth = 51;
            dgvActividades.Size = new Size(923, 481);
            dgvActividades.TabIndex = 0;
            // 
            // Ver_Actividades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(982, 753);
            Controls.Add(dgvActividades);
            Controls.Add(btnVolver);
            Controls.Add(lblTituloOpc);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 798);
            Name = "Ver_Actividades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor | Sports Club";
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloOpc;
        private Button btnVolver;
        private DataGridView dgvActividades;
    }
}