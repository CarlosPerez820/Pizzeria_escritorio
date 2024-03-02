namespace SistemaPiezzeria
{
    partial class Frm_Estadistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Estadistic));
            panel_titulo = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel_chatBart = new Panel();
            panel_listClient = new Panel();
            panel_titulo.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel_titulo
            // 
            panel_titulo.Controls.Add(label2);
            panel_titulo.Dock = DockStyle.Top;
            panel_titulo.Location = new Point(0, 0);
            panel_titulo.Name = "panel_titulo";
            panel_titulo.Size = new Size(1017, 80);
            panel_titulo.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(39, 39, 39);
            label2.Location = new Point(388, 9);
            label2.Name = "label2";
            label2.Size = new Size(282, 65);
            label2.TabIndex = 9;
            label2.Text = "Estadisticas";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 74);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(39, 39, 39);
            label1.Location = new Point(728, 17);
            label1.Name = "label1";
            label1.Size = new Size(237, 40);
            label1.TabIndex = 30;
            label1.Text = "Hora: HH:mm";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(39, 39, 39);
            label3.Location = new Point(12, 17);
            label3.Name = "label3";
            label3.Size = new Size(342, 40);
            label3.TabIndex = 29;
            label3.Text = "Fecha: dd/mm/yyyy";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.0992966F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.9007F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 154);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 20, 10, 0);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1017, 101);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 199, 79);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(13, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 75);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(39, 39, 39);
            label4.Location = new Point(80, 10);
            label4.Name = "label4";
            label4.Size = new Size(152, 46);
            label4.TabIndex = 31;
            label4.Text = "Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(87, 160, 73);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(343, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(661, 75);
            panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(143, 10);
            label5.Name = "label5";
            label5.Size = new Size(494, 46);
            label5.TabIndex = 32;
            label5.Text = "Total Vendido del dia: $7500";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel_chatBart, 0, 0);
            tableLayoutPanel2.Controls.Add(panel_listClient, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 255);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1017, 292);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 547);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1017, 306);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // panel_chatBart
            // 
            panel_chatBart.Dock = DockStyle.Fill;
            panel_chatBart.Location = new Point(3, 3);
            panel_chatBart.Name = "panel_chatBart";
            panel_chatBart.Size = new Size(502, 286);
            panel_chatBart.TabIndex = 0;
            // 
            // panel_listClient
            // 
            panel_listClient.Dock = DockStyle.Fill;
            panel_listClient.Location = new Point(511, 3);
            panel_listClient.Name = "panel_listClient";
            panel_listClient.Size = new Size(503, 286);
            panel_listClient.TabIndex = 1;
            // 
            // Frm_Estadistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 231, 217);
            ClientSize = new Size(1017, 853);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panel_titulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Estadistic";
            Text = "Frm_Estadistic";
            panel_titulo.ResumeLayout(false);
            panel_titulo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_titulo;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel_chatBart;
        private Panel panel_listClient;
        private TableLayoutPanel tableLayoutPanel3;
    }
}