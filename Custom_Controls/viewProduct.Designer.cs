namespace SistemaPiezzeria.Custom_Controls
{
    partial class viewProduct
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewProduct));
            panel_Main = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_Main
            // 
            panel_Main.BackColor = Color.FromArgb(39, 39, 39);
            panel_Main.Controls.Add(button1);
            panel_Main.Controls.Add(label4);
            panel_Main.Controls.Add(label3);
            panel_Main.Controls.Add(label2);
            panel_Main.Controls.Add(label1);
            panel_Main.Controls.Add(pictureBox1);
            panel_Main.Dock = DockStyle.Fill;
            panel_Main.Location = new Point(0, 0);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new Size(375, 223);
            panel_Main.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(180, 3);
            label1.Name = "label1";
            label1.Size = new Size(99, 27);
            label1.TabIndex = 1;
            label1.Text = "Nombre ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(180, 42);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 2;
            label2.Text = "$150.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(180, 84);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 3;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(180, 137);
            label4.Name = "label4";
            label4.Size = new Size(79, 22);
            label4.TabIndex = 4;
            label4.Text = "En Stock:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 199, 79);
            button1.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(39, 39, 39);
            button1.Location = new Point(180, 172);
            button1.Name = "button1";
            button1.Size = new Size(175, 38);
            button1.TabIndex = 5;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // viewProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_Main);
            Name = "viewProduct";
            Size = new Size(375, 223);
            panel_Main.ResumeLayout(false);
            panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Main;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label4;
    }
}
