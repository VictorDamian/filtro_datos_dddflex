using System.Data.SqlClient;

namespace Infra.DataAccess.Repository
{
    public class ConnectionSQL
    {
        protected SqlConnection con = new SqlConnection("Server=DANTES\\DANTES;DataBase=Practica_Patrones;Integrated Security=true");
    }
}
