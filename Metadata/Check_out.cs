using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Check_out
    {
        public int ID { get; set; }
        public int id_Check_In { get; set; }
        public int id_Func { get; set; }
        public double valor_total { get; set; }
        public DateTime dataSaida { get; set; }

        public Check_out(int id, int idCkI, int idF, double total, DateTime saida)
        {
            this.ID = id;
            this.id_Check_In = idCkI;
            this.id_Func = idF;
            this.valor_total = total;
            this.dataSaida = saida;
        }

        public Check_out(int idCkI, int idF, double total, DateTime saida)
        {
            this.id_Check_In = idCkI;
            this.id_Func = idF;
            this.valor_total = total;
            this.dataSaida = saida;
        }


    }
}
