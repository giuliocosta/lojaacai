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
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();            
        }

        
        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ClassProdutos p = new ClassProdutos();
                p.NOMEPRODUTO = txtNome.Text;
                p.UNIDADE = cmbUnidade.Text;
                p.PRECO_CUSTO = double.Parse(txtCusto.Text);
                p.PRECO_VENDA = double.Parse(txtVenda.Text);
                p.ESTOQUE = int.Parse(txtEstoque.Text);
                

                p.NovoProduto();
                MessageBox.Show("Produto cadastrado com sucesso !");

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

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            ClassProdutos p = new ClassProdutos();
            dtgProdutos.DataSource = p.visualizarTodosProdutos();
        }
    }
}
