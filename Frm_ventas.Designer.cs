namespace SistemaPiezzeria
{
    partial class Frm_ventas
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
            Button button1;
            Button button2;
            Button button3;
            Button button4;
            Button button5;
            panel_titulo = new Panel();
            label2 = new Label();
            panelTable_buscar = new TableLayoutPanel();
            panel_BarSearch = new Panel();
            textBox1 = new TextBox();
            panel_btnSearch = new Panel();
            btn_Ingresar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            btn_cobrar = new Button();
            label8 = new Label();
            panel2 = new Panel();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel_carrito = new Panel();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            viewProduct1 = new Custom_Controls.viewProduct();
            viewProduct2 = new Custom_Controls.viewProduct();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel_titulo.SuspendLayout();
            panelTable_buscar.SuspendLayout();
            panel_BarSearch.SuspendLayout();
            panel_btnSearch.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel_carrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.FromArgb(87, 160, 73);
            button1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 18);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(127, 49);
            button1.TabIndex = 16;
            button1.Text = "Todo";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.FromArgb(87, 160, 73);
            button2.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(140, 18);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(127, 49);
            button2.TabIndex = 17;
            button2.Text = "Bebidas";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.BackColor = Color.FromArgb(87, 160, 73);
            button3.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(294, 18);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(127, 49);
            button3.TabIndex = 18;
            button3.Text = "Comida";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom;
            button4.BackColor = Color.FromArgb(87, 160, 73);
            button4.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(449, 18);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(127, 49);
            button4.TabIndex = 19;
            button4.Text = "Paquetes";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom;
            button5.BackColor = Color.FromArgb(87, 160, 73);
            button5.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(588, 18);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(151, 49);
            button5.TabIndex = 20;
            button5.Text = "Promociones";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel_titulo
            // 
            panel_titulo.Controls.Add(label2);
            panel_titulo.Dock = DockStyle.Top;
            panel_titulo.Location = new Point(0, 0);
            panel_titulo.Name = "panel_titulo";
            panel_titulo.Size = new Size(1017, 80);
            panel_titulo.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(39, 39, 39);
            label2.Location = new Point(412, 9);
            label2.Name = "label2";
            label2.Size = new Size(176, 65);
            label2.TabIndex = 9;
            label2.Text = "Ventas";
            // 
            // panelTable_buscar
            // 
            panelTable_buscar.ColumnCount = 2;
            panelTable_buscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.8426743F));
            panelTable_buscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.1573257F));
            panelTable_buscar.Controls.Add(panel_BarSearch, 0, 0);
            panelTable_buscar.Controls.Add(panel_btnSearch, 1, 0);
            panelTable_buscar.Dock = DockStyle.Top;
            panelTable_buscar.Location = new Point(0, 80);
            panelTable_buscar.Name = "panelTable_buscar";
            panelTable_buscar.RowCount = 1;
            panelTable_buscar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelTable_buscar.Size = new Size(1017, 60);
            panelTable_buscar.TabIndex = 3;
            // 
            // panel_BarSearch
            // 
            panel_BarSearch.Controls.Add(textBox1);
            panel_BarSearch.Dock = DockStyle.Fill;
            panel_BarSearch.Location = new Point(3, 3);
            panel_BarSearch.Name = "panel_BarSearch";
            panel_BarSearch.Padding = new Padding(10);
            panel_BarSearch.Size = new Size(806, 54);
            panel_BarSearch.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(10, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(786, 38);
            textBox1.TabIndex = 0;
            // 
            // panel_btnSearch
            // 
            panel_btnSearch.Controls.Add(btn_Ingresar);
            panel_btnSearch.Dock = DockStyle.Fill;
            panel_btnSearch.Location = new Point(815, 3);
            panel_btnSearch.Name = "panel_btnSearch";
            panel_btnSearch.Size = new Size(199, 54);
            panel_btnSearch.TabIndex = 1;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = Color.FromArgb(249, 199, 79);
            btn_Ingresar.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ingresar.ForeColor = Color.FromArgb(39, 39, 39);
            btn_Ingresar.Location = new Point(3, 2);
            btn_Ingresar.Margin = new Padding(3, 2, 3, 2);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(196, 49);
            btn_Ingresar.TabIndex = 15;
            btn_Ingresar.Text = "Buscar";
            btn_Ingresar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.5401459F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.4598541F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 168F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 162F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 271F));
            tableLayoutPanel1.Controls.Add(button5, 4, 0);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 140);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1017, 69);
            tableLayoutPanel1.TabIndex = 4;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 707);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.2753639F));
            tableLayoutPanel2.Size = new Size(1017, 146);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_cobrar);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(511, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 140);
            panel1.TabIndex = 0;
            // 
            // btn_cobrar
            // 
            btn_cobrar.Anchor = AnchorStyles.None;
            btn_cobrar.BackColor = Color.FromArgb(249, 199, 79);
            btn_cobrar.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cobrar.ForeColor = Color.FromArgb(39, 39, 39);
            btn_cobrar.Location = new Point(180, 85);
            btn_cobrar.Margin = new Padding(3, 2, 3, 2);
            btn_cobrar.Name = "btn_cobrar";
            btn_cobrar.Size = new Size(196, 45);
            btn_cobrar.TabIndex = 16;
            btn_cobrar.Text = "Cobrar";
            btn_cobrar.UseVisualStyleBackColor = false;
            btn_cobrar.Click += btn_cobrar_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(214, 18);
            label8.Name = "label8";
            label8.Size = new Size(134, 35);
            label8.TabIndex = 18;
            label8.Text = "Total: $$$";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 140);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Right;
            textBox4.Location = new Point(137, 108);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(348, 27);
            textBox4.TabIndex = 26;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 106);
            label5.Name = "label5";
            label5.Size = new Size(80, 28);
            label5.TabIndex = 25;
            label5.Text = "Notas:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Right;
            textBox3.Location = new Point(219, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(266, 27);
            textBox3.TabIndex = 24;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(83, 78);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 23;
            label4.Text = "Dirección:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Right;
            textBox2.Location = new Point(219, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 27);
            textBox2.TabIndex = 22;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 45);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 21;
            label3.Text = "Colonia:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(219, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 28);
            comboBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 11);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 19;
            label1.Text = "Cliente:";
            // 
            // panel_carrito
            // 
            panel_carrito.Controls.Add(dataGridView1);
            panel_carrito.Dock = DockStyle.Right;
            panel_carrito.Location = new Point(731, 209);
            panel_carrito.Name = "panel_carrito";
            panel_carrito.Padding = new Padding(0, 0, 10, 0);
            panel_carrito.Size = new Size(286, 498);
            panel_carrito.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(276, 498);
            dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(viewProduct1);
            flowLayoutPanel1.Controls.Add(viewProduct2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 209);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(731, 498);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // viewProduct1
            // 
            viewProduct1.Location = new Point(8, 8);
            viewProduct1.Name = "viewProduct1";
            viewProduct1.Size = new Size(355, 218);
            viewProduct1.TabIndex = 0;
            // 
            // viewProduct2
            // 
            viewProduct2.Location = new Point(369, 8);
            viewProduct2.Name = "viewProduct2";
            viewProduct2.Size = new Size(350, 218);
            viewProduct2.TabIndex = 1;
            // 
            // Frm_ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 231, 217);
            ClientSize = new Size(1017, 853);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel_carrito);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelTable_buscar);
            Controls.Add(panel_titulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_ventas";
            Text = "Frm_ventas";
            panel_titulo.ResumeLayout(false);
            panel_titulo.PerformLayout();
            panelTable_buscar.ResumeLayout(false);
            panel_BarSearch.ResumeLayout(false);
            panel_BarSearch.PerformLayout();
            panel_btnSearch.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_carrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_titulo;
        private Label label2;
        private TableLayoutPanel panelTable_buscar;
        private Panel panel_BarSearch;
        private TextBox textBox1;
        private Panel panel_btnSearch;
        private Button btn_Ingresar;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label8;
        private Button btn_cobrar;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label5;
        private Panel panel_carrito;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Custom_Controls.viewProduct viewProduct1;
        private Custom_Controls.viewProduct viewProduct2;
    }
}