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
    public partial class PesquisaVenda : Form
    {
        public PesquisaVenda()
        {
            InitializeComponent();
        }

        private void btninclui_Click(object sender, EventArgs e)
        {
            ClassVenda v = new ClassVenda();
            v.DATA_PED = dtpPedido.Value.ToString("yyyyMMdd");
            dtgPesq.DataSource = v.PesquisarData();
            DataTable dt = v.PesquisarDataValor();

            textBox1.Text = dt.Rows[0]["sum(val_pedido)"].ToString();

        }
    }
}
