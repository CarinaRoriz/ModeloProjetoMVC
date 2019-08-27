using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Models
{
    public class ModeloTeste
    {
        public ModeloTeste()
        {
            Descricao = "Modelo de teste";
            DataHora = DateTime.Now;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
    }
}
