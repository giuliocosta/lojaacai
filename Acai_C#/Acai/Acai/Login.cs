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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "") || (txtSenha.Text == ""))
            {
                MessageBox.Show("Os campos não podem ficar vazios!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {
                    ClassLogin l = new ClassLogin();
                    l.USUARIO = txtUsuario.Text;
                    l.SENHA = txtSenha.Text;
                    DataTable dt = l.PesquisarLoginFuncionario();

                    if (dt.Rows.Count > 0)
                    {
                        string tipo = dt.Rows[0]["tipo"].ToString();

                        if (tipo == "GERENTE")
                        {
                            PrincipalGeren g = new PrincipalGeren();
                            g.Show();
                            Hide();
                        }

                        else if (tipo == "FUNCIONARIO")
                        {
                            PrincipalFunc f = new PrincipalFunc();
                            f.Show();
                            Hide();
                        }
                    }

                    else if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Usuário/Senha incorreto !");
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {            
            
        }
    }
}
