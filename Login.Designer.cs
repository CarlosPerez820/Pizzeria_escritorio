namespace SistemaPiezzeria
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btn_Ingresar = new Button();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 231, 217);
            panel1.Controls.Add(btn_Ingresar);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 778);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(331, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(270, 384);
            label2.Name = "label2";
            label2.Size = new Size(380, 28);
            label2.TabIndex = 4;
            label2.Text = "Por favor inicie sesión con sus credenciales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(39, 39, 39);
            label1.Location = new Point(313, 321);
            label1.Name = "label1";
            label1.Size = new Size(294, 43);
            label1.TabIndex = 5;
            label1.Text = "Fruteria Atlixco";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(364, 412);
            label3.Name = "label3";
            label3.Size = new Size(181, 28);
            label3.TabIndex = 6;
            label3.Text = "para poder acceder";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = Color.FromArgb(249, 199, 79);
            btn_Ingresar.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ingresar.ForeColor = Color.FromArgb(39, 39, 39);
            btn_Ingresar.Location = new Point(364, 633);
            btn_Ingresar.Margin = new Padding(3, 2, 3, 2);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(190, 67);
            btn_Ingresar.TabIndex = 14;
            btn_Ingresar.Text = "Ingresar";
            btn_Ingresar.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(357, 541);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 38);
            textBox2.TabIndex = 13;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(189, 544);
            label5.Name = "label5";
            label5.Size = new Size(162, 35);
            label5.TabIndex = 12;
            label5.Text = "Contraseña:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(357, 482);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 38);
            textBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(230, 482);
            label4.Name = "label4";
            label4.Size = new Size(121, 35);
            label4.TabIndex = 10;
            label4.Text = "Usuario:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 778);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_Ingresar;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
