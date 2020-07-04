using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoMVCD26.DAL
{
    public class DALMVC
    {
        private MySqlConnection conexao;
        private string string_conexao = "Persist security info = false;" +
                                        "server=localhost;" +
                                        "database=ProjetoMVCD26;" +
                                        "user=root ; pwd=;";

        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Problemas ao conectar com o banco de dados. \nErro: " + ex.Message);
            }
        }

        public void executarComando(String sql)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }catch (MySqlException ex)
            {
                throw new Exception("Não foi possivel executar a pesquisa no banco de dados, \n Erro: " + ex.Message);
            }finally
            {
                conexao.Close();
            }
        }

        public DataTable executarConsulta(string sql)
        {
            try
            {
                conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                dados.Fill(dt);
                return dt;
            }catch (MySqlException ex)
            {
                throw new Exception("Não foi possivel selecionar os registros no banco de dados. \nErro: " + ex.Message);
            }finally
            {
                conexao.Close();
            }
        }
    }

    
}