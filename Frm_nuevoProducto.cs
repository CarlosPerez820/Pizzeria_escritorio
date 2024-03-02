using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPiezzeria
{
    public partial class Frm_nuevoProducto : Form
    {
        public Frm_nuevoProducto()
        {
            InitializeComponent();
        }

        private void btn_Imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img_producto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
