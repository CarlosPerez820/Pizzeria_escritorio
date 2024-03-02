namespace SistemaPiezzeria
{
    partial class Frm_Empleados
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
            panel_titulo.SuspendLayout();
            panel_bottom.SuspendLayout();
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
            label2.Location = new Point(409, 9);
            label2.Name = "label2";
            label2.Size = new Size(264, 65);
            label2.TabIndex = 9;
            label2.Text = "Empleados";
            // 
            // panel_bottom
            // 
            panel_bottom.Controls.Add(button1);
            panel_bottom.Controls.Add(button2);
            panel_bottom.Dock = DockStyle.Bottom;
            panel_bottom.Location = new Point(0, 762);
            panel_bottom.Name = "panel_bottom";
            panel_bottom.Size = new Size(1017, 91);
            panel_bottom.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(231, 76, 60);
            button1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(818, 13);
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
            // Frm_Empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 231, 217);
            ClientSize = new Size(1017, 853);
            Controls.Add(panel_bottom);
            Controls.Add(panel_titulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Empleados";
            Text = "Frm_Empleados";
            Load += Frm_Empleados_Load;
            panel_titulo.ResumeLayout(false);
            panel_titulo.PerformLayout();
            panel_bottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_titulo;
        private Label label2;
        private Panel panel_bottom;
        private Button button1;
        private Button button2;
    }
}