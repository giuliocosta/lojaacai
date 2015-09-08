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
    public partial class AlterarUsuarios : Form
    {
        public AlterarUsuarios()
        {
            InitializeComponent();
        }

        private void AlterarUsuarios_Load(object sender, EventArgs e)
        {
            ClassLogin l = new ClassLogin();
            dtgUsuario.DataSource = l.visualizarTodosUsuarios();
        }

        private void dtgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgUsuario.Rows[e.RowIndex].Cells["idlogin"].Value.ToString();
            txtNome.Text = dtgUsuario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtLogin.Text = dtgUsuario.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            txtSenha.Text = dtgUsuario.Rows[e.RowIndex].Cells["senha"].Value.ToString();
            cmbTipo.Text = dtgUsuario.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassLogin l = new ClassLogin();
                l.IDLOGIN = int.Parse(txtId.Text);
                l.NOME = txtNome.Text;
                l.USUARIO = txtLogin.Text;
                l.SENHA = txtSenha.Text;
                l.TIPO = cmbTipo.Text;

                l.AlterarUsuario();
                MessageBox.Show("Usuário alterado com sucesso !");
                dtgUsuario.DataSource = l.visualizarTodosUsuarios();

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

        private void btnExluir_Click(object sender, EventArgs e)
        {
            try
            {
                ClassLogin l = new ClassLogin();
                l.IDLOGIN = int.Parse(txtId.Text);

                l.ExcluirUsuario();
                MessageBox.Show("Usuário excluído com sucesso !");
                dtgUsuario.DataSource = l.visualizarTodosUsuarios();

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
    }
}
