using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;


namespace DAL
{
    public class DAO_Mysql
    {
        protected MySqlConnection con;
        protected MySqlCommand comando;
        protected MySqlDataAdapter da;
        public MySqlDataReader dr;


        public DAO_Mysql(string servidor, string usuario, string senha, string banco)
        {
            try
            {
                con = new MySqlConnection();
                con.ConnectionString = string.Format("server={0};uid={1};pwd={2};database={3}", servidor, usuario, senha, banco);

                comando = new MySqlCommand();
                comando.Connection = con;

                da = new MySqlDataAdapter();                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void Abrir_Conexao()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void Fechar_Conexao()
        {
            try
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object Query_com_Retorno(string tabela, string campos)
        {
            try
            {
                comando.CommandText = string.Format("select {0} from {1}", campos, tabela);

                Abrir_Conexao();
                return comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Visualizar_Dados(string tabela)
        {
            DataTable dt = new DataTable();
            try
            {
                comando.CommandText = string.Format("select * from {0}", tabela);

                da.SelectCommand = comando;
                Abrir_Conexao();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Visualizar_Dados(string tabela, string campos)
        {
            DataTable dt = new DataTable();
            try
            {
                comando.CommandText = string.Format("select {0} from {1}", campos, tabela);

                da.SelectCommand = comando;
                Abrir_Conexao();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Visualizar_Dados(string tabela, string campos, string condicao)
        {
            DataTable dt = new DataTable();
            try
            {
                comando.CommandText = string.Format("select {0} from {1} where {2}", campos, tabela, condicao);

                da.SelectCommand = comando;
                Abrir_Conexao();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void Inserir_dados(string tabela, string valores)
        {
            try
            {
                comando.CommandText = string.Format("insert into {0} values({1})", tabela, valores);

                Abrir_Conexao();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void Inserir_dados(string tabela, string campos, string valores)
        {
            try
            {
                comando.CommandText = string.Format("insert into {0}({1}) values({2})", tabela, campos, valores);

                Abrir_Conexao();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void Excluir_dados(string tabela, string condicao)
        {
            try
            {
                comando.CommandText = string.Format("delete from {0} where {1}", tabela, condicao);

                Abrir_Conexao();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void Alterar_dados(string tabela, string valores, string condicao)
        {
            try
            {
                comando.CommandText = string.Format("Update {0} set {1} where {2}", tabela, valores, condicao);

                Abrir_Conexao();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

    }    
}
 