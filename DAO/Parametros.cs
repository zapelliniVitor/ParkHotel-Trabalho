using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class Parametros
    {
        public static string GetConnectionString()
        {
            //return @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\moc\Documents\ParkHotel.mdf; Integrated Security = True; Connect Timeout = 30";
            ////return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moc\Documents\ParkHotel.mdf;Integrated Security=True;Connect Timeout=30";
            //return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\ParkHotelHomeEdition.mdf;Integrated Security=True;Connect Timeout=30";
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moc\Documents\ParkHotel.mdf;Integrated Security=True;Connect Timeout=30";
        }
        
            public static FuncionarioLogado Funcionario { get; set; }
        
    }
}
