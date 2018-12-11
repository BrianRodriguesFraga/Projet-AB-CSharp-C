using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Web;

namespace Gestion_alarme
{
    /// <summary>
    /// This class is made for initialize and do some interactions with the database
    /// </summary>
    class Connection_db
    {
        MySqlConnection connectionString = new MySqlConnection("server=localhost;user id=root;database=alarme");

        public void OpenConnection()
        {
            connectionString.Open();
        }

        public void CloseConnection()
        {
            connectionString.Close();
        }

    }




}
