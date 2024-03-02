namespace SistemaPiezzeria
{
    partial class Frm_Menu
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
            panel_search = new TableLayoutPanel();
            btn_Ingresar = new Button();
            textBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            button5 = new Button();
            button4 = new Button();
            panel_list = new FlowLayoutPanel();
            viewProduct1 = new Custom_Controls.viewProduct();
            viewProduct2 = new Custom_Controls.viewProduct();
            viewProduct3 = new Custom_Controls.viewProduct();
            viewProduct4 = new Custom_Controls.viewProduct();
            viewProduct5 = new Custom_Controls.viewProduct();
            viewProduct6 = new Custom_Controls.viewProduct();
            panel_titulo.SuspendLayout();
            panel_search.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel_list.SuspendLayout();
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
            label2.Location = new Point(423, 9);
            label2.Name = "label2";
            label2.Size = new Size(191, 65);
            label2.TabIndex = 9;
            label2.Text = "Menu's";
            // 
            // panel_search
            // 
            panel_search.ColumnCount = 2;
            panel_search.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.9242859F));
            panel_search.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0757122F));
            panel_search.Controls.Add(btn_Ingresar, 1, 0);
            panel_search.Controls.Add(textBox1, 0, 0);
            panel_search.Dock = DockStyle.Top;
            panel_search.Location = new Point(0, 80);
            panel_search.Name = "panel_search";
            panel_search.RowCount = 1;
            panel_search.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panel_search.Size = new Size(1017, 48);
            panel_search.TabIndex = 4;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = Color.FromArgb(249, 199, 79);
            btn_Ingresar.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ingresar.ForeColor = Color.FromArgb(39, 39, 39);
            btn_Ingresar.Location = new Point(826, 2);
            btn_Ingresar.Margin = new Padding(3, 2, 3, 2);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(188, 44);
            btn_Ingresar.TabIndex = 16;
            btn_Ingresar.Text = "Buscar";
            btn_Ingresar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(26, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(771, 27);
            textBox1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.6211472F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.3788528F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 259F));
            tableLayoutPanel1.Controls.Add(button3, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 128);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1017, 65);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.BackColor = Color.FromArgb(87, 160, 73);
            button3.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(793, 19);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(188, 44);
            button3.TabIndex = 19;
            button3.Text = "Ver";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.FromArgb(87, 160, 73);
            button2.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(431, 19);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(218, 44);
            button2.TabIndex = 18;
            button2.Text = "Nueva Promocion";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.FromArgb(87, 160, 73);
            button1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(67, 19);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(188, 44);
            button1.TabIndex = 17;
            button1.Text = "Nuevo alimento";
            button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.6211472F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.3788528F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.6211472F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.3788528F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.0798759F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.9201241F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 355F));
            tableLayoutPanel4.Controls.Add(button5, 0, 0);
            tableLayoutPanel4.Controls.Add(button4, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 193);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(10, 25, 0, 0);
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1017, 76);
            tableLayoutPanel4.TabIndex = 6;
            tableLayoutPanel4.Paint += tableLayoutPanel4_Paint;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(231, 76, 60);
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(326, 27);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(332, 47);
            button5.TabIndex = 20;
            button5.Text = "Promociones/Paquetes";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(231, 76, 60);
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(13, 27);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(307, 47);
            button4.TabIndex = 19;
            button4.Text = "Alimentos";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel_list
            // 
            panel_list.AutoScroll = true;
            panel_list.Controls.Add(viewProduct1);
            panel_list.Controls.Add(viewProduct2);
            panel_list.Controls.Add(viewProduct3);
            panel_list.Controls.Add(viewProduct4);
            panel_list.Controls.Add(viewProduct5);
            panel_list.Controls.Add(viewProduct6);
            panel_list.Dock = DockStyle.Fill;
            panel_list.Location = new Point(0, 269);
            panel_list.Name = "panel_list";
            panel_list.Padding = new Padding(20);
            panel_list.Size = new Size(1017, 584);
            panel_list.TabIndex = 7;
            // 
            // viewProduct1
            // 
            viewProduct1.Location = new Point(23, 23);
            viewProduct1.Name = "viewProduct1";
            viewProduct1.Size = new Size(414, 219);
            viewProduct1.TabIndex = 0;
            // 
            // viewProduct2
            // 
            viewProduct2.Location = new Point(443, 23);
            viewProduct2.Name = "viewProduct2";
            viewProduct2.Size = new Size(410, 219);
            viewProduct2.TabIndex = 1;
            // 
            // viewProduct3
            // 
            viewProduct3.Location = new Point(23, 248);
            viewProduct3.Name = "viewProduct3";
            viewProduct3.Size = new Size(414, 219);
            viewProduct3.TabIndex = 2;
            // 
            // viewProduct4
            // 
            viewProduct4.Location = new Point(443, 248);
            viewProduct4.Name = "viewProduct4";
            viewProduct4.Size = new Size(410, 219);
            viewProduct4.TabIndex = 3;
            // 
            // viewProduct5
            // 
            viewProduct5.Location = new Point(23, 473);
            viewProduct5.Name = "viewProduct5";
            viewProduct5.Size = new Size(414, 219);
            viewProduct5.TabIndex = 4;
            // 
            // viewProduct6
            // 
            viewProduct6.Location = new Point(443, 473);
            viewProduct6.Name = "viewProduct6";
            viewProduct6.Size = new Size(414, 219);
            viewProduct6.TabIndex = 5;
            // 
            // Frm_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 231, 217);
            ClientSize = new Size(1017, 853);
            Controls.Add(panel_list);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel_search);
            Controls.Add(panel_titulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Menu";
            Text = "Frm_Menu";
            panel_titulo.ResumeLayout(false);
            panel_titulo.PerformLayout();
            panel_search.ResumeLayout(false);
            panel_search.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel_list.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_titulo;
        private Label label2;
        private TableLayoutPanel panel_search;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBox1;
        private Button btn_Ingresar;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
        private FlowLayoutPanel panel_list;
        private Custom_Controls.viewProduct viewProduct1;
        private Custom_Controls.viewProduct viewProduct2;
        private Custom_Controls.viewProduct viewProduct3;
        private Custom_Controls.viewProduct viewProduct4;
        private Custom_Controls.viewProduct viewProduct5;
        private Custom_Controls.viewProduct viewProduct6;
    }
}