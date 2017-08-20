using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace GestionBiblio.DAO
{
    class Database
    {
        string cn = "server=localhost;user id=root; password=; database=gesbiblio";
        public MySqlConnection getconnection()
        {
            MySqlConnection con = new MySqlConnection(cn);
            con.Open();
            return con;
        }
    }
}
