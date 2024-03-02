namespace SistemaPiezzeria
{
    partial class Frm_Inventario
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
            panel_Principal = new Panel();
            panelTable_opciones = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            panelTable_buscar = new TableLayoutPanel();
            panel_BarSearch = new Panel();
            textBox1 = new TextBox();
            panel_btnSearch = new Panel();
            btn_Ingresar = new Button();
            panel_titulo = new Panel();
            label2 = new Label();
            panel_tabla = new Panel();
            dataGridView1 = new DataGridView();
            panel_Principal.SuspendLayout();
            panelTable_opciones.SuspendLayout();
            panelTable_buscar.SuspendLayout();
            panel_BarSearch.SuspendLayout();
            panel_btnSearch.SuspendLayout();
            panel_titulo.SuspendLayout();
            panel_tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel_Principal
            // 
            panel_Principal.BackColor = Color.FromArgb(242, 231, 217);
            panel_Principal.Controls.Add(panel_tabla);
            panel_Principal.Controls.Add(panelTable_opciones);
            panel_Principal.Controls.Add(panelTable_buscar);
            panel_Principal.Controls.Add(panel_titulo);
            panel_Principal.Dock = DockStyle.Fill;
            panel_Principal.Location = new Point(0, 0);
            panel_Principal.Name = "panel_Principal";
            panel_Principal.Size = new Size(1017, 853);
            panel_Principal.TabIndex = 0;
            // 
            // panelTable_opciones
            // 
            panelTable_opciones.ColumnCount = 3;
            panelTable_opciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.71795F));
            panelTable_opciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.28205F));
            panelTable_opciones.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 296F));
            panelTable_opciones.Controls.Add(button1, 0, 0);
            panelTable_opciones.Controls.Add(button2, 2, 0);
            panelTable_opciones.Controls.Add(comboBox1, 1, 0);
            panelTable_opciones.Dock = DockStyle.Top;
            panelTable_opciones.Location = new Point(0, 140);
            panelTable_opciones.Name = "panelTable_opciones";
            panelTable_opciones.RowCount = 1;
            panelTable_opciones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelTable_opciones.Size = new Size(1017, 63);
            panelTable_opciones.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.FromArgb(87, 160, 73);
            button1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(92, 12);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(167, 49);
            button1.TabIndex = 16;
            button1.Text = "Stock Bajo";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.FromArgb(87, 160, 73);
            button2.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(790, 12);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(156, 49);
            button2.TabIndex = 17;
            button2.Text = "Ver info";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(460, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 18;
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
            panelTable_buscar.TabIndex = 1;
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
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(10, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(786, 27);
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
            // panel_titulo
            // 
            panel_titulo.Controls.Add(label2);
            panel_titulo.Dock = DockStyle.Top;
            panel_titulo.Location = new Point(0, 0);
            panel_titulo.Name = "panel_titulo";
            panel_titulo.Size = new Size(1017, 80);
            panel_titulo.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(39, 39, 39);
            label2.Location = new Point(404, 9);
            label2.Name = "label2";
            label2.Size = new Size(257, 65);
            label2.TabIndex = 9;
            label2.Text = "Inventario";
            // 
            // panel_tabla
            // 
            panel_tabla.Controls.Add(dataGridView1);
            panel_tabla.Dock = DockStyle.Fill;
            panel_tabla.Location = new Point(0, 203);
            panel_tabla.Name = "panel_tabla";
            panel_tabla.Padding = new Padding(20);
            panel_tabla.Size = new Size(1017, 650);
            panel_tabla.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(20, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(977, 610);
            dataGridView1.TabIndex = 0;
            // 
            // Frm_Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 853);
            Controls.Add(panel_Principal);
            ForeColor = Color.FromArgb(242, 231, 217);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Inventario";
            Text = "Frm_Inventario";
            panel_Principal.ResumeLayout(false);
            panelTable_opciones.ResumeLayout(false);
            panelTable_buscar.ResumeLayout(false);
            panel_BarSearch.ResumeLayout(false);
            panel_BarSearch.PerformLayout();
            panel_btnSearch.ResumeLayout(false);
            panel_titulo.ResumeLayout(false);
            panel_titulo.PerformLayout();
            panel_tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Principal;
        private Panel panel_titulo;
        private Label label2;
        private TableLayoutPanel panelTable_buscar;
        private Panel panel_BarSearch;
        private TextBox textBox1;
        private Panel panel_btnSearch;
        private Button btn_Ingresar;
        private TableLayoutPanel panelTable_opciones;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Panel panel_tabla;
        private DataGridView dataGridView1;
    }
}