namespace SistemaPiezzeria
{
    partial class Frm_Corte
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
            panel_titulo = new Panel();
            label2 = new Label();
            panel_buttons = new TableLayoutPanel();
            panel4 = new Panel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            dateTimePicker3 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            panel_bottom = new Panel();
            btn_Ingresar = new Button();
            panel_data = new Panel();
            dataGridView1 = new DataGridView();
            panel_titulo.SuspendLayout();
            panel_buttons.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel_bottom.SuspendLayout();
            panel_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label2.Location = new Point(409, 9);
            label2.Name = "label2";
            label2.Size = new Size(319, 65);
            label2.TabIndex = 9;
            label2.Text = "Corte de Caja";
            // 
            // panel_buttons
            // 
            panel_buttons.ColumnCount = 2;
            panel_buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panel_buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panel_buttons.Controls.Add(panel4, 1, 1);
            panel_buttons.Controls.Add(panel3, 0, 1);
            panel_buttons.Controls.Add(panel2, 1, 0);
            panel_buttons.Controls.Add(panel1, 0, 0);
            panel_buttons.Dock = DockStyle.Top;
            panel_buttons.Location = new Point(0, 80);
            panel_buttons.Name = "panel_buttons";
            panel_buttons.RowCount = 2;
            panel_buttons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panel_buttons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panel_buttons.Size = new Size(1017, 125);
            panel_buttons.TabIndex = 4;
            panel_buttons.Paint += panel_buttons_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(comboBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(511, 65);
            panel4.Name = "panel4";
            panel4.Size = new Size(503, 57);
            panel4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(249, 199, 79);
            button1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(39, 39, 39);
            button1.Location = new Point(270, 6);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(185, 49);
            button1.TabIndex = 17;
            button1.Text = "Ver";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(502, 57);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(39, 39, 39);
            label5.Location = new Point(29, 16);
            label5.Name = "label5";
            label5.Size = new Size(209, 28);
            label5.TabIndex = 36;
            label5.Text = "Total Vendido: $$$";
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(511, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(503, 56);
            panel2.TabIndex = 1;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(292, 16);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(90, 27);
            dateTimePicker3.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(39, 39, 39);
            label4.Location = new Point(241, 15);
            label4.Name = "label4";
            label4.Size = new Size(30, 28);
            label4.TabIndex = 38;
            label4.Text = "a:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(132, 15);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(85, 27);
            dateTimePicker2.TabIndex = 37;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(39, 39, 39);
            label3.Location = new Point(13, 15);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 36;
            label3.Text = "Rango de:";
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 56);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 14);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(199, 27);
            dateTimePicker1.TabIndex = 35;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(39, 39, 39);
            label1.Location = new Point(29, 13);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 34;
            label1.Text = "Fecha:";
            // 
            // panel_bottom
            // 
            panel_bottom.Controls.Add(btn_Ingresar);
            panel_bottom.Dock = DockStyle.Bottom;
            panel_bottom.Location = new Point(0, 783);
            panel_bottom.Name = "panel_bottom";
            panel_bottom.Size = new Size(1017, 70);
            panel_bottom.TabIndex = 5;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.Anchor = AnchorStyles.Top;
            btn_Ingresar.BackColor = Color.FromArgb(249, 199, 79);
            btn_Ingresar.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ingresar.ForeColor = Color.FromArgb(39, 39, 39);
            btn_Ingresar.Location = new Point(410, 11);
            btn_Ingresar.Margin = new Padding(3, 2, 3, 2);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(196, 49);
            btn_Ingresar.TabIndex = 16;
            btn_Ingresar.Text = "Generar Reporte";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // panel_data
            // 
            panel_data.Controls.Add(dataGridView1);
            panel_data.Dock = DockStyle.Fill;
            panel_data.Location = new Point(0, 205);
            panel_data.Name = "panel_data";
            panel_data.Padding = new Padding(20, 40, 20, 20);
            panel_data.Size = new Size(1017, 578);
            panel_data.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(20, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(977, 518);
            dataGridView1.TabIndex = 0;
            // 
            // Frm_Corte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 231, 217);
            ClientSize = new Size(1017, 853);
            Controls.Add(panel_data);
            Controls.Add(panel_bottom);
            Controls.Add(panel_buttons);
            Controls.Add(panel_titulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Corte";
            Text = "Frm_Corte";
            panel_titulo.ResumeLayout(false);
            panel_titulo.PerformLayout();
            panel_buttons.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_bottom.ResumeLayout(false);
            panel_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_titulo;
        private Label label2;
        private TableLayoutPanel panel_buttons;
        private Panel panel_bottom;
        private Panel panel2;
        private Panel panel1;
        private Button btn_Ingresar;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private ComboBox comboBox1;
        private Label label5;
        private DateTimePicker dateTimePicker3;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Panel panel_data;
        private DataGridView dataGridView1;
    }
}