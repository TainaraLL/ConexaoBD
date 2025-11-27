using ConexaoBD.Utilitarios;
using ConexaoBD.Models;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using ConexaoBD.Interface;

namespace ConexaoBD.DAO
{
   /* internal class PlanoDAO : IPlano
    {
        public void Create(Plano plano)
        {
            try
            {
                string sql = @"INSERT INTO plano (Descricao, ValorSugerido, Atv) VALUES (@Descricao, @ValorSugerido, @Atv)";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Descricao", plano.Descricao);
                    cmd.Parameters.AddWithValue("@ValorSugerido", plano.ValorSugerido);
                    cmd.Parameters.AddWithValue("@Atv", plano.Atv);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Plano plano)
        {
            try
            {
                string sql = @"UPDATE plano SET Descricao = @Descricao, ValorSugerido = @ValorSugerido, Atv = @Atv WHERE id_plano = @id_plano;";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Descricao", plano.Descricao);
                    cmd.Parameters.AddWithValue("@ValorSugerido", plano.ValorSugerido);
                    cmd.Parameters.AddWithValue("@Atv", plano.Atv);
                    cmd.Parameters.AddWithValue("@id_plano", plano.Id_Plano);

                    var linhas = cmd.ExecuteNonQuery();

                    if (linhas == 0)
                    {
                        throw new Exception("Nenhum registro foi atualizado (verifique o id_plano).");

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id_plano)
        {
            try
            {
                string sql = @"DELETE FROM plano WHERE id_plano = @id_plano;";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id_plano", id_plano);

                    var linhasAfestadas = cmd.ExecuteNonQuery();

                    if (linhasAfestadas == 0)
                    {
                        throw new Exception("Nenhum registro encontrado com esse ID");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /*public List<Plano> GetAll()
        {
            List<Plano> listPlano = new List<Plano>();

            try
            {
                string sql = "SELECT * FROM Plano ORDER BY Atv";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Plano objPlano = new Plano();

                        objPlano.Id_Plano = dr.GetInt32("id_plano");
                        objPlano.Descricao = dr.GetString("descricao");
                        objPlano.ValorSugerido = dr.GetDouble("valorsugerido");
                        objPlano.Atv = dr.GetBoolean("atv");

                        listPlano.Add(objPlano);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        Plano IPlano.GetId(int id)
        {
            throw new NotImplementedException();
        }
    }*/
}
