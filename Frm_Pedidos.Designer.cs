namespace SistemaPiezzeria
{
    partial class Frm_Pedidos
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
            panelTable_buscar = new TableLayoutPanel();
            panel_BarSearch = new Panel();
            textBox1 = new TextBox();
            panel_btnSearch = new Panel();
            btn_Ingresar = new Button();
            panel_bottom = new Panel();
            btn_View = new Button();
            panel_center = new Panel();
            dataGridView1 = new DataGridView();
            panel_titulo.SuspendLayout();
            panelTable_buscar.SuspendLayout();
            panel_BarSearch.SuspendLayout();
            panel_btnSearch.SuspendLayout();
            panel_bottom.SuspendLayout();
            panel_center.SuspendLayout();
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
            panel_titulo.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(39, 39, 39);
            label2.Location = new Point(432, 9);
            label2.Name = "label2";
            label2.Size = new Size(200, 65);
            label2.TabIndex = 9;
            label2.Text = "Pedidos";
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
            panelTable_buscar.TabIndex = 2;
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
            textBox1.Location = new Point(7, 13);
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
            // panel_bottom
            // 
            panel_bottom.Controls.Add(btn_View);
            panel_bottom.Dock = DockStyle.Bottom;
            panel_bottom.Location = new Point(0, 778);
            panel_bottom.Name = "panel_bottom";
            panel_bottom.Padding = new Padding(0, 0, 0, 20);
            panel_bottom.Size = new Size(1017, 75);
            panel_bottom.TabIndex = 3;
            // 
            // btn_View
            // 
            btn_View.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_View.BackColor = Color.FromArgb(87, 160, 73);
            btn_View.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_View.ForeColor = Color.White;
            btn_View.Location = new Point(792, 15);
            btn_View.Margin = new Padding(3, 2, 3, 2);
            btn_View.Name = "btn_View";
            btn_View.Size = new Size(196, 49);
            btn_View.TabIndex = 16;
            btn_View.Text = "Ver";
            btn_View.UseVisualStyleBackColor = false;
            btn_View.Click += btn_View_Click;
            // 
            // panel_center
            // 
            panel_center.Controls.Add(dataGridView1);
            panel_center.Dock = DockStyle.Fill;
            panel_center.Location = new Point(0, 140);
            panel_center.Name = "panel_center";
            panel_center.Padding = new Padding(20, 25, 20, 15);
            panel_center.Size = new Size(1017, 638);
            panel_center.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(20, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(977, 598);
            dataGridView1.TabIndex = 0;
            // 
            // Frm_Pedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 231, 217);
            ClientSize = new Size(1017, 853);
            Controls.Add(panel_center);
            Controls.Add(panel_bottom);
            Controls.Add(panelTable_buscar);
            Controls.Add(panel_titulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Pedidos";
            Text = "Frm_Pedidos";
            panel_titulo.ResumeLayout(false);
            panel_titulo.PerformLayout();
            panelTable_buscar.ResumeLayout(false);
            panel_BarSearch.ResumeLayout(false);
            panel_BarSearch.PerformLayout();
            panel_btnSearch.ResumeLayout(false);
            panel_bottom.ResumeLayout(false);
            panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Panel panel_bottom;
        private Button btn_View;
        private Panel panel_center;
        private DataGridView dataGridView1;
    }
}