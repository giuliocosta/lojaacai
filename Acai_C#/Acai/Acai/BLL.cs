using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace Acai
{
        class ClassProdutos
        {

        private int idproduto, estoque;
        private string nomeproduto, unidade;
        private double preco_custo, preco_venda;        


        DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "acai");

                    
        public double PRECO_CUSTO
        {
            get { return preco_custo; }
            set { preco_custo = value; }
        }

        public double PRECO_VENDA
        {
            get { return preco_venda; }
            set { preco_venda = value; }
        }
        public int IDPRODUTO
        {
            get { return idproduto; }
            set { idproduto = value; }
        }
        public int ESTOQUE
        {
            get { return estoque; }
            set { estoque = value; }
        }

        public string UNIDADE
        {
            get { return unidade; }
            set { unidade = value; }
        }

        public string NOMEPRODUTO
        {
            get { return nomeproduto; }
            set { nomeproduto = value; }
        }
        

        public void NovoProduto()
        {
            try
            {
                string valores = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}'", null, NOMEPRODUTO, UNIDADE, PRECO_CUSTO.ToString().Replace(',', '.'), PRECO_VENDA.ToString().Replace(',', '.'), ESTOQUE);
                dao.Inserir_dados("produto", valores);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarProduto()
        {
            try
            {
                string valores = string.Format("nomeproduto = '{0}',unidade = '{1}', preco_custo = '{2}',preco_venda = '{3}',estoque = '{4}'", NOMEPRODUTO, UNIDADE, PRECO_CUSTO.ToString().Replace(',', '.'), PRECO_VENDA.ToString().Replace(',', '.'), ESTOQUE);
                string condicao = string.Format("idproduto = '{0}'", IDPRODUTO);
                dao.Alterar_dados("produto", valores,condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirProduto()
        {
            try
            {
                string condicao = string.Format("idproduto = '{0}'", IDPRODUTO);
                dao.Excluir_dados("produto", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable visualizarTodosProdutos()
        {
            try
            {
                DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "acai");
                return dao.Visualizar_Dados("produto");
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable PesquisarProduto()
        {
            try
            {
                DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "acai");
                string condicao = string.Format("idproduto = '{0}'", IDPRODUTO);
                return dao.Visualizar_Dados("produto", "*", condicao);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void AlterarEstoque()
        {
            try
            {
                string valores = string.Format("estoque = estoque - 1'");
                string condicao = string.Format("idproduto = '{0}'", IDPRODUTO);
                dao.Alterar_dados("produto", valores, condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

        class ClassLogin
        {

            private int idlogin;
            private string nome, usuario, senha, tipo;
            


            DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "acai");

            public int IDLOGIN
            {
                get { return idlogin; }
                set { idlogin = value; }
            }
            public string NOME
            {
                get { return nome; }
                set { nome = value; }
            }

            public string USUARIO
            {
                get { return usuario; }
                set { usuario = value; }
            }

            public string SENHA 
            {
                get { return senha; }
                set { senha = value; }
            }

            public string TIPO
            {
                get { return tipo; }
                set { tipo = value; }
            }


            public void NovoUsuario()
            {
                try
                {
                    string valores = string.Format("'{0}','{1}','{2}','{3}','{4}'", null, NOME, USUARIO, SENHA, TIPO);
                    dao.Inserir_dados("login", valores);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void AlterarUsuario()
            {
                try
                {
                    string valores = string.Format("nome = '{0}',usuario = '{1}', senha = '{2}',tipo = '{3}'", NOME, USUARIO, SENHA, TIPO);
                    string condicao = string.Format("idlogin = '{0}'", IDLOGIN);
                    dao.Alterar_dados("login", valores, condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void ExcluirUsuario()
            {
                try
                {
                    string condicao = string.Format("idlogin = '{0}'", IDLOGIN);
                    dao.Excluir_dados("login", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public DataTable visualizarTodosUsuarios()
            {
                try
                {
                    DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "acai");
                    return dao.Visualizar_Dados("login");

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public DataTable PesquisarUsuario()
            {
                try
                {
                    DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "acai");
                    string condicao = string.Format("idlogin = '{0}'", IDLOGIN);
                    return dao.Visualizar_Dados("login", "*", condicao);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable PesquisarLoginFuncionario()
            {
                try
                {
                    DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "acai");
                    string condicao = string.Format("usuario = '{0}' AND senha = '{1}'", USUARIO, SENHA);
                    return dao.Visualizar_Dados("login", "*", condicao);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        class ItensVenda
        {
            private int id_ped, id_prod;
            private double preco;

            DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "acai");

            public double PRECO
            {
                get { return preco; }
                set { preco = value; }
            }

            public int ID_PROD
            {
                get { return id_prod; }
                set { id_prod = value; }
            }
            public int ID_PED
            {
                get { return id_ped; }
                set { id_ped = value; }
            }

            public void NovoItem()
            {
                try
                {
                    string valores = string.Format("'{0}','{1}','{2}','{3}'", null, PRECO.ToString().Replace(',', '.'), ID_PROD, ID_PED);
                    dao.Inserir_dados("item_pedido", valores);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        class ClassVenda
        {
            private int id_ped;
            private double valor_total;
            private string data_ped;
            


            DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "acai");

            public int ID_PED
            {
                get { return id_ped; }
                set { id_ped = value; }
            }
            public double VALOR_TOTAL
            {
                get { return valor_total; }
                set { valor_total = value; }
            }
            public string DATA_PED
            {
                get { return data_ped; }
                set { data_ped = value; }
            }

            public void Novo_Venda()
            {
                try
                {
                    string valores = string.Format("'{0}','{1}','{2}'", null, DATA_PED, VALOR_TOTAL);
                    dao.Inserir_dados("pedido", valores);
                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable Pedido()
            {
                try
                {
                    
                    DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "acai");                   
                    return dao.Visualizar_Dados("pedido", "max(idpedido)");
                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable PesquisarData()
            {
                try
                {
                    DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "acai");
                    string condicao = string.Format("dt_pedido = '{0}'", DATA_PED);
                    return dao.Visualizar_Dados("pedido", "*", condicao);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable PesquisarDataValor()
            {
                try
                {
                    DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "acai");
                    string condicao = string.Format("dt_pedido = '{0}'", DATA_PED);
                    return dao.Visualizar_Dados("pedido", "sum(val_pedido)", condicao);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            
        }

}
    

