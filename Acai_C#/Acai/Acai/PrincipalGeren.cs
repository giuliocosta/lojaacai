using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acai
{
    public partial class PrincipalGeren : Form
    {
        public PrincipalGeren()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            CadastroProdutos p = new CadastroProdutos();
            p.Show();
        }

        private void btnAltProd_Click(object sender, EventArgs e)
        {
            AlterarProdutos p = new AlterarProdutos();
            p.Show();
        }

        private void btnCadUsu_Click(object sender, EventArgs e)
        {
            CadastraUsuario u = new CadastraUsuario();
            u.Show();
        }

        private void btnAltUsu_Click(object sender, EventArgs e)
        {
            AlterarUsuarios u = new AlterarUsuarios();
            u.Show();
        }

        private void btnPesqVenda_Click(object sender, EventArgs e)
        {
            PesquisaVenda v = new PesquisaVenda();
            v.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            Venda v = new Venda();
            v.Show();
        }
    }
}
