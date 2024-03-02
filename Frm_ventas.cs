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
    public partial class Frm_ventas : Form
    {
        public Frm_ventas()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            Frm_ConfirmCompra confirmar = new Frm_ConfirmCompra();
            confirmar.ShowDialog();
        }
    }
}
