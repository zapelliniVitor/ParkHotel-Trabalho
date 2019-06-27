using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Reserva
    {
        public int ID { get; set; }
        public int IdCliente { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataSaidaPrevista { get; set; }
        public int IdFuncionario { get; set; }

        public Reserva(int id, int idCliente, DateTime entrada, DateTime saidaPrevista, int idFuncionario)
        {
            this.ID = id;
            this.IdCliente = idCliente;
            this.dataEntrada = entrada;
            this.dataSaidaPrevista = saidaPrevista;
            this.IdFuncionario = IdFuncionario;
        }

        public Reserva( int idCliente, DateTime entrada, DateTime saidaPrevista, int idFuncionario)
        {
            this.IdCliente = idCliente;
            this.dataEntrada = entrada;
            this.dataSaidaPrevista = saidaPrevista;
            this.IdFuncionario = IdFuncionario;
        }

    }
}
