namespace ConexaoBD.Models
{
    internal class Funcionario
    {
        public int Id_Funcionario { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateOnly DataAdmissao { get; set; }
        public DateOnly DataNasc {  get; set; }
        public string Email { get; set; }
    }
}
