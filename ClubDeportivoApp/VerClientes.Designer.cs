namespace ClubDeportivoApp
{
    partial class VerClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerClientes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pbVolver = new PictureBox();
            imgBoxOpc = new PictureBox();
            label2 = new Label();
            btnBuscarCliente = new Button();
            txtDni = new TextBox();
            lblDni = new Label();
            dgvClientes = new DataGridView();
            btnComprobantePago = new Button();
            ((System.ComponentModel.ISupportInitialize)pbVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // pbVolver
            // 
            pbVolver.Anchor = AnchorStyles.None;
            pbVolver.BackColor = Color.Linen;
            pbVolver.Image = (Image)resources.GetObject("pbVolver.Image");
            pbVolver.Location = new Point(985, 103);
            pbVolver.Name = "pbVolver";
            pbVolver.Size = new Size(44, 26);
            pbVolver.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVolver.TabIndex = 32;
            pbVolver.TabStop = false;
            pbVolver.Click += pbVolver_Click;
            // 
            // imgBoxOpc
            // 
            imgBoxOpc.Anchor = AnchorStyles.None;
            imgBoxOpc.BackColor = Color.Linen;
            imgBoxOpc.Image = (Image)resources.GetObject("imgBoxOpc.Image");
            imgBoxOpc.Location = new Point(205, 76);
            imgBoxOpc.Name = "imgBoxOpc";
            imgBoxOpc.Size = new Size(92, 93);
            imgBoxOpc.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxOpc.TabIndex = 31;
            imgBoxOpc.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(120, 10, 90);
            label2.Location = new Point(409, 94);
            label2.Name = "label2";
            label2.Size = new Size(360, 54);
            label2.TabIndex = 30;
            label2.Text = "VER CLIENTES";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Anchor = AnchorStyles.None;
            btnBuscarCliente.BackColor = Color.FromArgb(120, 10, 90);
            btnBuscarCliente.Cursor = Cursors.Hand;
            btnBuscarCliente.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnBuscarCliente.ForeColor = Color.White;
            btnBuscarCliente.Image = (Image)resources.GetObject("btnBuscarCliente.Image");
            btnBuscarCliente.Location = new Point(593, 207);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(195, 45);
            btnBuscarCliente.TabIndex = 29;
            btnBuscarCliente.Text = "BUSCAR CLIENTE";
            btnBuscarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.Location = new Point(340, 218);
            txtDni.MaximumSize = new Size(238, 45);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(238, 27);
            txtDni.TabIndex = 28;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(205, 218);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(131, 23);
            lblDni.TabIndex = 27;
            lblDni.Text = "Dni del cliente:";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LavenderBlush;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.Anchor = AnchorStyles.None;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.Linen;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.MediumPurple;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.MistyRose;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Location = new Point(205, 281);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.MistyRose;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(824, 337);
            dgvClientes.TabIndex = 33;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // btnComprobantePago
            // 
            btnComprobantePago.Anchor = AnchorStyles.None;
            btnComprobantePago.BackColor = Color.DarkGreen;
            btnComprobantePago.Cursor = Cursors.Hand;
            btnComprobantePago.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprobantePago.ForeColor = Color.White;
            btnComprobantePago.Image = (Image)resources.GetObject("btnComprobantePago.Image");
            btnComprobantePago.Location = new Point(794, 207);
            btnComprobantePago.Name = "btnComprobantePago";
            btnComprobantePago.Size = new Size(235, 45);
            btnComprobantePago.TabIndex = 34;
            btnComprobantePago.Text = "LIMPIAR BUSQUEDA";
            btnComprobantePago.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComprobantePago.UseVisualStyleBackColor = false;
            btnComprobantePago.Click += btnComprobantePago_Click;
            // 
            // VerClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1133, 742);
            Controls.Add(btnComprobantePago);
            Controls.Add(dgvClientes);
            Controls.Add(pbVolver);
            Controls.Add(imgBoxOpc);
            Controls.Add(label2);
            Controls.Add(btnBuscarCliente);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Name = "VerClientes";
            Text = "VerClientes";
            ((System.ComponentModel.ISupportInitialize)pbVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxOpc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbVolver;
        private PictureBox imgBoxOpc;
        private Label label2;
        private Button btnBuscarCliente;
        private TextBox txtDni;
        private Label lblDni;
        private DataGridView dgvClientes;
        private Button btnComprobantePago;
    }
}