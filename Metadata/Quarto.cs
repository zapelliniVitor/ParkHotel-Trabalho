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
        public string PrecoQuarto { get; set; }
        public int StatusQuarto { get; set; }
        public string DescriçãoQuarto { get; set; }
        public int n_Quarto { get; set; }

        public override string ToString()
        {
            return n_Quarto.ToString() + " (ID " + ID.ToString() + ")";
        }


        //Com ID
        public Quarto(int id, int tipoQuarto, string precoQuarto, int statusQuarto, string descricaoQuarto, int nQuarto)
        {
            this.ID = id;
            this.TipoQuarto = tipoQuarto;
            this.PrecoQuarto = precoQuarto;
            this.StatusQuarto = statusQuarto;
            this.DescriçãoQuarto = descricaoQuarto;
            this.n_Quarto = nQuarto;
        }

        //Sem ID
        public Quarto(int tipoQuarto, string precoQuarto, int statusQuarto, string descricaoQuarto, int nQuarto)
        {
            this.TipoQuarto = tipoQuarto;
            this.PrecoQuarto = precoQuarto;
            this.StatusQuarto = statusQuarto;
            this.DescriçãoQuarto = descricaoQuarto;
            this.n_Quarto = nQuarto;
        }

        public Quarto(int id)
        {
            this.ID = id;
        }
    }
}
