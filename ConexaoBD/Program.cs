using ConexaoBD.Models;
using ConexaoBD.DAO;
using ConexaoBD.Utilitarios;

FuncionarioDAO objFunDao = new FuncionarioDAO();

List<Funcionario> lista = objFunDao.List();

Console.WriteLine("Informe o nome do Funcionário: ");
//objFunDao.Nome = Console.ReadLine();

foreach (Funcionario objFun in lista)
{
    Console.WriteLine(objFun.Nome);
}

/*Conexao.Conectar();

Funcionario objFun = new Funcionario();

objFun.Id_Funcionario = 6;
objFun.Nome = "Tainara Leal";
objFun.Telefone = "(69) 9 9604-7744";
objFun.DataNasc = new DateOnly(2005, 01, 14);
objFun.DataAdmissao = new DateOnly(2025, 11, 19);
objFun.Email = "tainara@gmail.com";

FuncionarioDAO objFunDao = new FuncionarioDAO();
objFunDao.Update(objFun);

objFunDao.Delete(objFun); // objFunDao.Delete(6); 

objFunDao.List();*/