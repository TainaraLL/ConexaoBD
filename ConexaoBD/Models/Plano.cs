using System.Windows.Markup;

namespace ConexaoBD.Models
{
    internal class Plano
    {
        private double _ValorSugerido;

        public int Id_Plano { get; set; }
        public string Descricao { get; set; }
        public double ValorSugerido
        {
            get
            {
                return _ValorSugerido;
            }
            set
            {
                if (value > 0)
                {
                    _ValorSugerido = value;
                }
                else
                {
                    throw new Exception("Valor Inválida!");
                }
            }
        }

        public bool Atv { get; set; } //Ativo  
    }
}
