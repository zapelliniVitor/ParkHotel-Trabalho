using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class SaidaProduto
    {
        public int ID { get; set; }
        public DateTime DataSaida { get; set; }
        public int ID_check_in { get; set; }
        public double ValorTotal{ get; set; }

        public SaidaProduto(int id, DateTime saida, int idCheckIn, double total)
        {
            this.ID = id;
            this.DataSaida = saida;
            this.ID_check_in = idCheckIn;
            this.ValorTotal = total;
        }

        public SaidaProduto(DateTime saida, int idCheckIn, double total)
        {
            this.DataSaida = saida;
            this.ID_check_in = idCheckIn;
            this.ValorTotal = total;
        }


    }
}
