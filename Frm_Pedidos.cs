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
    public partial class Frm_Pedidos : Form
    {
        public Frm_Pedidos()
        {
            InitializeComponent();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            Frm_infoPedido form = new Frm_infoPedido();
            form.ShowDialog();
        }
    }
}
