namespace ClubDeportivoApp
{
    partial class Listado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado));
            lblTituloList = new Label();
            btnVolver = new Button();
            dgvMorosos = new DataGridView();
            btnTodos = new Button();
            btnVencimientoHoy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMorosos).BeginInit();
            SuspendLayout();
            // 
            // lblTituloList
            // 
            lblTituloList.Anchor = AnchorStyles.None;
            lblTituloList.AutoSize = true;
            lblTituloList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloList.ForeColor = Color.FromArgb(120, 10, 90);
            lblTituloList.Location = new Point(366, 63);
            lblTituloList.Name = "lblTituloList";
            lblTituloList.Size = new Size(262, 31);
            lblTituloList.TabIndex = 29;
            lblTituloList.Text = "LISTADO DE MOROSOS";
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.BackColor = Color.FromArgb(120, 10, 90);
            btnVolver.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.Linen;
            btnVolver.Location = new Point(734, 648);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(152, 53);
            btnVolver.TabIndex = 30;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvMorosos
            // 
            dgvMorosos.Anchor = AnchorStyles.None;
            dgvMorosos.BackgroundColor = Color.Linen;
            dgvMorosos.BorderStyle = BorderStyle.None;
            dgvMorosos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMorosos.Location = new Point(12, 147);
            dgvMorosos.MinimumSize = new Size(788, 455);
            dgvMorosos.Name = "dgvMorosos";
            dgvMorosos.RowHeadersWidth = 51;
            dgvMorosos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvMorosos.Size = new Size(948, 455);
            dgvMorosos.TabIndex = 31;
            // 
            // btnTodos
            // 
            btnTodos.Anchor = AnchorStyles.None;
            btnTodos.BackColor = Color.Navy;
            btnTodos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTodos.ForeColor = Color.Linen;
            btnTodos.Location = new Point(83, 648);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(152, 53);
            btnTodos.TabIndex = 32;
            btnTodos.Text = "VER TODOS";
            btnTodos.UseVisualStyleBackColor = false;
            btnTodos.Click += btnTodos_Click_1;
            // 
            // btnVencimientoHoy
            // 
            btnVencimientoHoy.Anchor = AnchorStyles.None;
            btnVencimientoHoy.BackColor = Color.DarkGreen;
            btnVencimientoHoy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVencimientoHoy.ForeColor = Color.Linen;
            btnVencimientoHoy.Location = new Point(411, 648);
            btnVencimientoHoy.Name = "btnVencimientoHoy";
            btnVencimientoHoy.Size = new Size(152, 53);
            btnVencimientoHoy.TabIndex = 33;
            btnVencimientoHoy.Text = "VER HOY";
            btnVencimientoHoy.UseVisualStyleBackColor = false;
            btnVencimientoHoy.Click += btnVencimientoHoy_Click_1;
            // 
            // Listado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(982, 753);
            Controls.Add(btnVencimientoHoy);
            Controls.Add(btnTodos);
            Controls.Add(dgvMorosos);
            Controls.Add(btnVolver);
            Controls.Add(lblTituloList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 800);
            Name = "Listado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor | Sports Club";
            Load += Listado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMorosos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloList;
        private Button btnVolver;
        private DataGridView dgvMorosos;
        private Button btnTodos;
        private Button btnVencimientoHoy;
    }
}