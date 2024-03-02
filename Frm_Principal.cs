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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void abrirFirmulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelPrincipal.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(formulario);
                panelPrincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }


        private void btn_inventario_Click(object sender, EventArgs e)
        {
            abrirFirmulario<Frm_Inventario>();
        }

        private void btn_nuevoProducto_Click(object sender, EventArgs e)
        {
            abrirFirmulario<Frm_nuevoProducto>();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            abrirFirmulario<Frm_ventas>();
        }

        private void btn_pedidos_Click(object sender, EventArgs e)
        {
            abrirFirmulario<Frm_Pedidos>();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            abrirFirmulario<Frm_Clientes>();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            abrirFirmulario<Frm_Usuarios>();
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            abrirFirmulario<Frm_Empleados>();
        }

        private void btn_colonies_Click(object sender, EventArgs e)
        {
            abrirFirmulario<Frm_Colonias>();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            abrirFirmulario<Frm_Menu>();
        }

        private void btn_corte_Click(object sender, EventArgs e)
        {
            abrirFirmulario<Frm_Corte>();
        }

        private void btn_estadistic_Click(object sender, EventArgs e)
        {
            abrirFirmulario<Frm_Estadistic>();
        }
    }
}
