using ConexaoBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD.Interface
{
    internal interface IPlano:IDao<Plano>
    {
        Plano GetId(int id);
    }
}
