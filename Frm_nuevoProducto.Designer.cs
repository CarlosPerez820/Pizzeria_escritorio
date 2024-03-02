namespace SistemaPiezzeria
{
    partial class Frm_nuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_nuevoProducto));
            panel_Principal = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_Imagen = new Button();
            comboBox2 = new ComboBox();
            label11 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            comboBox1 = new ComboBox();
            panelDerecha = new Panel();
            button1 = new Button();
            img_producto = new PictureBox();
            panel_titulo = new Panel();
            label2 = new Label();
            panel_Principal.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelDerecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_producto).BeginInit();
            panel_titulo.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Principal
            // 
            panel_Principal.BackColor = Color.FromArgb(242, 231, 217);
            panel_Principal.Controls.Add(tableLayoutPanel1);
            panel_Principal.Controls.Add(panelDerecha);
            panel_Principal.Controls.Add(panel_titulo);
            panel_Principal.Dock = DockStyle.Fill;
            panel_Principal.Location = new Point(0, 0);
            panel_Principal.Name = "panel_Principal";
            panel_Principal.Size = new Size(1017, 853);
            panel_Principal.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.7209625F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.2790375F));
            tableLayoutPanel1.Controls.Add(btn_Imagen, 1, 9);
            tableLayoutPanel1.Controls.Add(comboBox2, 1, 8);
            tableLayoutPanel1.Controls.Add(label11, 0, 9);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 8);
            tableLayoutPanel1.Controls.Add(label3, 0, 7);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Controls.Add(label8, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label9, 0, 4);
            tableLayoutPanel1.Controls.Add(label10, 0, 5);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox6, 1, 5);
            tableLayoutPanel1.Controls.Add(textBox7, 1, 6);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(691, 773);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_Imagen
            // 
            btn_Imagen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Imagen.BackColor = Color.FromArgb(249, 199, 79);
            btn_Imagen.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Imagen.ForeColor = Color.FromArgb(39, 39, 39);
            btn_Imagen.Location = new Point(284, 663);
            btn_Imagen.Margin = new Padding(3, 2, 3, 2);
            btn_Imagen.Name = "btn_Imagen";
            btn_Imagen.Size = new Size(257, 48);
            btn_Imagen.TabIndex = 31;
            btn_Imagen.Text = "Imagen";
            btn_Imagen.UseVisualStyleBackColor = false;
            btn_Imagen.Click += btn_Imagen_Click;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Left;
            comboBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(284, 597);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(290, 39);
            comboBox2.TabIndex = 30;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(278, 663);
            label11.Name = "label11";
            label11.Size = new Size(0, 35);
            label11.TabIndex = 20;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(225, 13);
            label4.Name = "label4";
            label4.Size = new Size(53, 35);
            label4.TabIndex = 11;
            label4.Text = "ID:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(136, 599);
            label1.Name = "label1";
            label1.Size = new Size(142, 35);
            label1.TabIndex = 12;
            label1.Text = "Categoria:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(199, 521);
            label3.Name = "label3";
            label3.Size = new Size(79, 35);
            label3.TabIndex = 13;
            label3.Text = "Tipo:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(38, 440);
            label5.Name = "label5";
            label5.Size = new Size(240, 35);
            label5.TabIndex = 14;
            label5.Text = "Cantidad minima:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(165, 74);
            label8.Name = "label8";
            label8.Size = new Size(113, 35);
            label8.TabIndex = 17;
            label8.Text = "Codigo:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(154, 136);
            label7.Name = "label7";
            label7.Size = new Size(124, 35);
            label7.TabIndex = 16;
            label7.Text = "Nombre:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(185, 207);
            label6.Name = "label6";
            label6.Size = new Size(93, 35);
            label6.TabIndex = 15;
            label6.Text = "Costo:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(101, 289);
            label9.Name = "label9";
            label9.Size = new Size(177, 35);
            label9.TabIndex = 18;
            label9.Text = "Precio Venta:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(189, 368);
            label10.Name = "label10";
            label10.Size = new Size(89, 35);
            label10.TabIndex = 21;
            label10.Text = "Stock:";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left;
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(284, 11);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(290, 38);
            textBox4.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(284, 72);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(290, 38);
            textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(284, 135);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 38);
            textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(284, 205);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 38);
            textBox1.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left;
            textBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(284, 287);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(290, 38);
            textBox5.TabIndex = 26;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Left;
            textBox6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(284, 366);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(290, 38);
            textBox6.TabIndex = 27;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left;
            textBox7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(284, 438);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(290, 38);
            textBox7.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left;
            comboBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(284, 519);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 39);
            comboBox1.TabIndex = 29;
            // 
            // panelDerecha
            // 
            panelDerecha.Controls.Add(button1);
            panelDerecha.Controls.Add(img_producto);
            panelDerecha.Dock = DockStyle.Right;
            panelDerecha.Location = new Point(691, 80);
            panelDerecha.Name = "panelDerecha";
            panelDerecha.Size = new Size(326, 773);
            panelDerecha.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.FromArgb(249, 199, 79);
            button1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(39, 39, 39);
            button1.Location = new Point(24, 646);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(257, 65);
            button1.TabIndex = 32;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // img_producto
            // 
            img_producto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            img_producto.BorderStyle = BorderStyle.Fixed3D;
            img_producto.Image = (Image)resources.GetObject("img_producto.Image");
            img_producto.Location = new Point(3, 0);
            img_producto.Name = "img_producto";
            img_producto.Size = new Size(291, 265);
            img_producto.SizeMode = PictureBoxSizeMode.StretchImage;
            img_producto.TabIndex = 1;
            img_producto.TabStop = false;
            // 
            // panel_titulo
            // 
            panel_titulo.Controls.Add(label2);
            panel_titulo.Dock = DockStyle.Top;
            panel_titulo.Location = new Point(0, 0);
            panel_titulo.Name = "panel_titulo";
            panel_titulo.Size = new Size(1017, 80);
            panel_titulo.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(39, 39, 39);
            label2.Location = new Point(354, 9);
            label2.Name = "label2";
            label2.Size = new Size(382, 65);
            label2.TabIndex = 9;
            label2.Text = "Nuevo Producto";
            // 
            // Frm_nuevoProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 853);
            Controls.Add(panel_Principal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_nuevoProducto";
            Text = "Frm_nuevoProducto";
            panel_Principal.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelDerecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_producto).EndInit();
            panel_titulo.ResumeLayout(false);
            panel_titulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Principal;
        private Panel panel_titulo;
        private Label label2;
        private Panel panelDerecha;
        private PictureBox img_producto;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label11;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label10;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private ComboBox comboBox1;
        private Button btn_Imagen;
        private Button button1;
    }
}