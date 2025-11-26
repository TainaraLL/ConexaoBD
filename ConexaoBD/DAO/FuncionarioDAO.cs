using ConexaoBD.Utilitarios;
using ConexaoBD.Models;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace ConexaoBD.DAO

{
    internal class FuncionarioDAO // onde vou ter os métodos de acesso com o banco de dados
    {
        public void Insert(Funcionario funcionario)
        {
            try
            {
                string sql = @"INSERT INTO funcionario (Nome, Telefone, dataNasc, DataAdmissao, Email) 
                             VALUES (@Nome, @Telefone, @dataNAsc, @DataAdmissao, @Email)";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
                    cmd.Parameters.Add("@dataNasc", MySqlDbType.Date).Value = funcionario.DataNasc.ToDateTime(TimeOnly.MinValue);
                    cmd.Parameters.Add("@dataAdmissao", MySqlDbType.Date).Value = funcionario.DataAdmissao.ToDateTime(TimeOnly.MinValue);
                    cmd.Parameters.AddWithValue("@Email", funcionario.Email);

                    cmd.ExecuteNonQuery();
                }               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Funcionario funcionario)
        {
            try
            {
                string sql = @"UPDATE funcionario SET Nome = @Nome, Telefone = @Telefone, dataNasc = @dataNasc, DataAdmissao = @DataAdmissao, Email = @Email
                               WHERE id_funcionario = @id_funcionario;";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
                    cmd.Parameters.Add("@dataNasc", MySqlDbType.Date).Value = funcionario.DataNasc.ToDateTime(TimeOnly.MinValue);
                    cmd.Parameters.Add("@dataAdmissao", MySqlDbType.Date).Value = funcionario.DataAdmissao.ToDateTime(TimeOnly.MinValue);
                    cmd.Parameters.AddWithValue("@Email", funcionario.Email);
                    cmd.Parameters.AddWithValue("@id_funcionario", funcionario.Id_Funcionario);

                    var linhas = cmd.ExecuteNonQuery();

                    if (linhas == 0)
                    {
                        throw new Exception("Nenhum registro foi atualizado (verifique o id_funcionario).");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(Funcionario funcionario)
        {
            try
            {
                string sql = @"DELETE FROM funcionario WHERE id_funcionario = @id_funcionario;";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id_funcionario", funcionario.Id_Funcionario);

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

        public List<Funcionario> List()
        {
            List<Funcionario> listFun = new List<Funcionario>();

            try
            {
                string sql = "SELECT * FROM funcionario ORDER BY nome";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Funcionario objFun = new Funcionario();

                        objFun.Id_Funcionario = dr.GetInt32("id_funcionario");
                        objFun.Nome = dr.GetString("nome");
                        objFun.Telefone = dr.GetString("telefone");
                        objFun.Email = dr.GetString("email");
                        objFun.DataNasc = DateOnly.FromDateTime(dr.GetDateTime("dataNasc"));
                        objFun.DataAdmissao = DateOnly.FromDateTime(dr.GetDateTime("dataAdmissao"));

                        listFun.Add(objFun);
                    }
                }
                return listFun;
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
        }
    }
}
