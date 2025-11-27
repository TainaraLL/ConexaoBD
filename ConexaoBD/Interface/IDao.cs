using ConexaoBD.Models;
using System.Collections.Generic;

namespace ConexaoBD.Interface
{
    internal interface IDao<T> //coleção/classe genérica
    {
        void Create (T t); //
        void Update (T t);
        void Delete (int id);
        List<T> GetAll ();
    }
}
