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
    public partial class AlterarProdutos : Form
    {
        public AlterarProdutos()
        {
            InitializeComponent();
        }

        private void dtgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgProdutos.Rows[e.RowIndex].Cells["idproduto"].Value.ToString();
            txtNome.Text = dtgProdutos.Rows[e.RowIndex].Cells["nomeproduto"].Value.ToString();
            cmbUnidade.Text = dtgProdutos.Rows[e.RowIndex].Cells["unidade"].Value.ToString();
            txtCusto.Text = dtgProdutos.Rows[e.RowIndex].Cells["preco_custo"].Value.ToString();
            txtVenda.Text = dtgProdutos.Rows[e.RowIndex].Cells["preco_venda"].Value.ToString();
            txtEstoque.Text = dtgProdutos.Rows[e.RowIndex].Cells["estoque"].Value.ToString();

        }

        private void AlterarProdutos_Load(object sender, EventArgs e)
        {
            ClassProdutos p = new ClassProdutos();
            dtgProdutos.DataSource = p.visualizarTodosProdutos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassProdutos p = new ClassProdutos();
                p.IDPRODUTO = int.Parse(txtId.Text);
                p.NOMEPRODUTO = txtNome.Text;
                p.UNIDADE = cmbUnidade.Text;
                p.PRECO_CUSTO = double.Parse(txtCusto.Text);
                p.PRECO_VENDA = double.Parse(txtVenda.Text);
                p.ESTOQUE = int.Parse(txtEstoque.Text);

                p.AlterarProduto();
                MessageBox.Show("Produto alterado com sucesso !");

                dtgProdutos.DataSource = p.visualizarTodosProdutos();

                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is System.Windows.Forms.TextBox)
                    {

                        this.Controls[i].Text = "";
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ClassProdutos p = new ClassProdutos();
                p.IDPRODUTO = int.Parse(txtId.Text);
                p.ExcluirProduto();
                MessageBox.Show("Produto excluído com sucesso !");

                dtgProdutos.DataSource = p.visualizarTodosProdutos();

                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is System.Windows.Forms.TextBox)
                    {

                        this.Controls[i].Text = "";
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
