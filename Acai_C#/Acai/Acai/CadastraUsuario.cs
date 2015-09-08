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
    public partial class CadastraUsuario : Form
    {
        public CadastraUsuario()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassLogin l = new ClassLogin();
                l.NOME = txtNome.Text;
                l.USUARIO = txtLogin.Text;
                l.SENHA = txtSenha.Text;
                l.TIPO = cmbTipo.Text;

                l.NovoUsuario();                
                MessageBox.Show("Usuário cadastrado com sucesso !");
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

        private void CadastraUsuario_Load(object sender, EventArgs e)
        {
            ClassLogin l = new ClassLogin();
            dtgUsuario.DataSource = l.visualizarTodosUsuarios();
        }
    }
}
