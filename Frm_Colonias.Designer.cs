namespace SistemaPiezzeria
{
    partial class Frm_Colonias
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
            panel_bottom = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel_form = new Panel();
            label4 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            panel_center = new Panel();
            dataGridView1 = new DataGridView();
            panel_titulo.SuspendLayout();
            panel_bottom.SuspendLayout();
            panel_form.SuspendLayout();
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
            panel_titulo.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(39, 39, 39);
            label2.Location = new Point(308, 9);
            label2.Name = "label2";
            label2.Size = new Size(413, 65);
            label2.TabIndex = 9;
            label2.Text = "Colonias de riesgo";
            // 
            // panel_bottom
            // 
            panel_bottom.Controls.Add(button1);
            panel_bottom.Controls.Add(button2);
            panel_bottom.Dock = DockStyle.Bottom;
            panel_bottom.Location = new Point(0, 762);
            panel_bottom.Name = "panel_bottom";
            panel_bottom.Size = new Size(1017, 91);
            panel_bottom.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(231, 76, 60);
            button1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(814, 13);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(156, 49);
            button1.TabIndex = 20;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(87, 160, 73);
            button2.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(62, 13);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(156, 49);
            button2.TabIndex = 19;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel_form
            // 
            panel_form.Controls.Add(button3);
            panel_form.Controls.Add(textBox2);
            panel_form.Controls.Add(label1);
            panel_form.Controls.Add(textBox1);
            panel_form.Controls.Add(label4);
            panel_form.Dock = DockStyle.Top;
            panel_form.Location = new Point(0, 80);
            panel_form.Name = "panel_form";
            panel_form.Size = new Size(1017, 125);
            panel_form.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(39, 39, 39);
            label4.Location = new Point(12, 57);
            label4.Name = "label4";
            label4.Size = new Size(44, 28);
            label4.TabIndex = 22;
            label4.Text = "ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(81, 27);
            textBox1.TabIndex = 32;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(39, 39, 39);
            label1.Location = new Point(337, 60);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 33;
            label1.Text = "Colonia:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(442, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 27);
            textBox2.TabIndex = 34;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(87, 160, 73);
            button3.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(791, 43);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(156, 49);
            button3.TabIndex = 35;
            button3.Text = "Registrar";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel_center
            // 
            panel_center.Controls.Add(dataGridView1);
            panel_center.Dock = DockStyle.Fill;
            panel_center.Location = new Point(0, 205);
            panel_center.Name = "panel_center";
            panel_center.Padding = new Padding(35);
            panel_center.Size = new Size(1017, 557);
            panel_center.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(35, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(947, 487);
            dataGridView1.TabIndex = 0;
            // 
            // Frm_Colonias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 231, 217);
            ClientSize = new Size(1017, 853);
            Controls.Add(panel_center);
            Controls.Add(panel_form);
            Controls.Add(panel_bottom);
            Controls.Add(panel_titulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Colonias";
            Text = "Frm_Colonias";
            panel_titulo.ResumeLayout(false);
            panel_titulo.PerformLayout();
            panel_bottom.ResumeLayout(false);
            panel_form.ResumeLayout(false);
            panel_form.PerformLayout();
            panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_titulo;
        private Label label2;
        private Panel panel_bottom;
        private Button button1;
        private Button button2;
        private Panel panel_form;
        private Label label4;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private Panel panel_center;
        private DataGridView dataGridView1;
    }
}