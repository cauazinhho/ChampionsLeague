using ChampionsLeague.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeague.Controller
{
    internal class ControllerEst
    {
        public void Cadastro()
        {
        SqlConnection cn = new SqlConnection(Conexao.Conectar()); 
        SqlCommand cmd = new SqlCommand("P_CadastrarAtleta", cn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        try
            {
                cmd.Parameters.AddWithValue("@atleta", Ativos.Atleta);
                cmd.Parameters.AddWithValue("@elenco", Ativos.Elenco);
                cmd.Parameters.AddWithValue("@posicao", Ativos.Posicao);
                cmd.Parameters.AddWithValue("@gols", Ativos.Gols);
                cmd.Parameters.AddWithValue("@assistencia", Ativos.Assistencia);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Todos os registro foram feitos com sucesso.");
            }
            catch (Exception) 
            {
                throw;
            }
        }

        public void Excluir()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_Excluir", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Ativos.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Excluidos com Sucesso");
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void PesquisaCodigo()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PesquisaCodigo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("codigo", Ativos.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

                var bb = cmd.ExecuteReader();
                if (bb.Read())
                {
                    Ativos.Codigo = Convert.ToInt32(bb["codigo"]);
                    Ativos.Atleta = (string)bb["atleta"];
                    Ativos.Elenco = (string)bb["elenco"];
                    Ativos.Posicao = (string)bb["posicao"];
                    Ativos.Gols = (int)bb["gols"];
                    Ativos.Assistencia = (int)bb["assistencia"];
                }
                else
                {
                    Ativos.Codigo = 0;
                    Ativos.Atleta = "";
                    Ativos.Elenco = "";
                    Ativos.Posicao = "";
                    Ativos.Gols = 0;
                    Ativos.Assistencia = 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Alterar()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_Alterar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                
                cmd.Parameters.AddWithValue("@codigo", Ativos.Codigo);
                cmd.Parameters.AddWithValue("@atleta", Ativos.Atleta);
                cmd.Parameters.AddWithValue("@elenco", Ativos.Elenco);
                cmd.Parameters.AddWithValue("@posicao", Ativos.Posicao);
                cmd.Parameters.AddWithValue("@gols", Ativos.Gols);
                cmd.Parameters.AddWithValue("@assistencia", Ativos.Assistencia);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Alterados com sucesso.");
            }

            catch (Exception) {
                throw;
            }
        }
        public static BindingSource VisualizarNomeAtleta()

        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_VisualizarNomeAtleta", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            {
                cmd.Parameters.AddWithValue("@atleta", Ativos.Atleta);
                cn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                sqlData.Fill(table);
                BindingSource dados = new BindingSource();
                dados.DataSource = table;

                return dados;
            }
        }


    }
}
