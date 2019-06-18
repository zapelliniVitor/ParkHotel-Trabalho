using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Quarto
    {
        public int ID { get; set; }
        public int TipoQuarto { get; set; }
        public double PrecoQuarto { get; set; }
        public int StatusQuarto { get; set; }
        public string DescriçãoQuarto { get; set; }

        //Com ID
        public Quarto(int id, int tipoQuarto, double precoQuarto, int statusQuarto, string descricaoQuarto)
        {
            this.ID = id;
            this.TipoQuarto = tipoQuarto;
            this.PrecoQuarto = precoQuarto;
            this.StatusQuarto = statusQuarto;
            this.DescriçãoQuarto = descricaoQuarto;
        }

        //Sem ID
        public Quarto(int tipoQuarto, double precoQuarto, int statusQuarto, string descricaoQuarto)
        {
            this.TipoQuarto = tipoQuarto;
            this.PrecoQuarto = precoQuarto;
            this.StatusQuarto = statusQuarto;
            this.DescriçãoQuarto = descricaoQuarto;
        }


    }
}
