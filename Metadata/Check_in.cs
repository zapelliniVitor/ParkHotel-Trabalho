using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Check_in
    {
        public int id { get; set; }
        public int id_reserva { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataSaidaPrevista { get; set; }
        public int id_cliente { get; set; }
        public int id_func { get; set; }
        public int id_quarto { get; set; }
        public bool EhAtivo { get; set; }


        //COM ID e COM quarto E reserva
        public Check_in(int id, int idReserva, DateTime entrada, DateTime saidaPrevista, int idCliente, int idFunc, int idQuarto, bool ehAtivo)
        {
            this.id = id;
            this.id_reserva = idReserva;
            this.dataEntrada = entrada;
            this.dataSaidaPrevista = saidaPrevista;
            this.id_cliente = idCliente;
            this.id_func = idFunc;
            this.id_quarto = idQuarto;
            this.EhAtivo = ehAtivo;
        }

        //SEM ID e COM quarto E reserva
        public Check_in(int idReserva, DateTime entrada, DateTime saidaPrevista, int idCliente, int idFunc, int idQuarto, bool ehAtivo)
        {
            this.id_reserva = idReserva;
            this.dataEntrada = entrada;
            this.dataSaidaPrevista = saidaPrevista;
            this.id_cliente = idCliente;
            this.id_func = idFunc;
            this.id_quarto = idQuarto;
            this.EhAtivo = ehAtivo;

        }

        //COM quarto e SEM reserva
        public Check_in(DateTime entrada, DateTime saidaPrevista, int idCliente, int idFunc, int idQuarto, bool ehAtivo)
        {
            this.dataEntrada = entrada;
            this.dataSaidaPrevista = saidaPrevista;
            this.id_cliente = idCliente;
            this.id_func = idFunc;
            this.id_quarto = idQuarto;
            this.EhAtivo = ehAtivo;

        }

        //SEM quarto e COM reserva
        public Check_in(int idReserva, DateTime entrada, DateTime saidaPrevista, int idCliente, int idFunc, bool ehAtivo)
        {
            this.id_reserva = idReserva;
            this.dataEntrada = entrada;
            this.dataSaidaPrevista = saidaPrevista;
            this.id_cliente = idCliente;
            this.id_func = idFunc;
            this.EhAtivo = ehAtivo;
        }


    }
}
