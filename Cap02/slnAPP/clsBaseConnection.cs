using System;

namespace Chinook.Data
{
    public class clsBaseConnection
    {
        public string GetConection()
        {
            string cadenaConexion = "Server=S000-00;DataBase=ChinookSabado;User ID=sa;Password=sql;";
            return cadenaConexion;
        }

    }
}
