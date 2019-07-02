using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    class ReservaViewModel
    {
        public int ID { get; set; }
        public Cliente Cliente { get; set; }
        public Quarto Quarto { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime DataPrevistaEntrada { get; set; }
        public DateTime DataPrevistaSaida { get; set; }
    }
}
