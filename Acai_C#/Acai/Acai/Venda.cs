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
    public partial class Venda : Form
    {
        public Venda()
        {
            InitializeComponent();
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Venda_Load(object sender, EventArgs e)
        {
            ClassProdutos p = new ClassProdutos();
            dtgProdutos.DataSource = p.visualizarTodosProdutos();
        }

        
        private void btninclui_Click(object sender, EventArgs e)
        {
            try
            {
                dtgVenda.Rows.Add(txtId.Text, txtNome.Text, txtvalor.Text);
                txtId.Text = "";
                txtNome.Text = "";
                txtvalor.Text = "";

                double val = 0;
                for (int i = 0; i < dtgVenda.Rows.Count - 1; i++)
                {
                   
                    if (int.Parse(dtgVenda.Rows[i].Cells["preco_custo"].Value.ToString()) != 0)
                    {
                        double newval = 0;
                        newval = double.Parse(dtgVenda.Rows[i].Cells["preco_custo"].Value.ToString());

                        val = val + newval;
                        txttotal.Text = val.ToString();
                    }

                }
                MessageBox.Show("Incluído !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnconf_Click(object sender, EventArgs e)
        {
            try
            {
                ClassVenda v = new ClassVenda();
                v.VALOR_TOTAL = double.Parse(txttotal.Text);
                v.DATA_PED = dtpPedido.Value.ToString("yyyyMMdd");

                v.Novo_Venda();
                DataTable dt = v.Pedido();
                string ID_p = dt.Rows[0]["max(idpedido)"].ToString();                

                for (int i = 0; i < dtgVenda.Rows.Count - 1; i++)
                {
                    ItensVenda item = new ItensVenda();
                    item.ID_PED = int.Parse(ID_p);

                    item.ID_PROD = int.Parse(dtgVenda.Rows[i].Cells["idproduto"].Value.ToString());
                    item.PRECO = double.Parse(dtgVenda.Rows[i].Cells["preco_custo"].Value.ToString());
                    item.NovoItem();
                }

                MessageBox.Show("Venda concluída !");
                Venda vend = new Venda();
                vend.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            
                txtId.Text = dtgProdutos.Rows[e.RowIndex].Cells["idproduto"].Value.ToString();
                txtNome.Text = dtgProdutos.Rows[e.RowIndex].Cells["nomeproduto"].Value.ToString();
                txtvalor.Text = dtgProdutos.Rows[e.RowIndex].Cells["preco_venda"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
