using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace DELEGACIA.DAL
{
    public class Conexao
    {
        MySqlConnection con = new MySqlConnection(@"Data Source = localhost; DATABASE = delegacia ; UID = root; PASSWORD=;");

        public MySqlConnection conectar() 
        {
            if (con.State == ConnectionState.Closed) 
            {
                con.Open();
            }
            return con;
        }
        public MySqlConnection desconectar() 
        {
            if (con.State == ConnectionState.Open) 
            {
                con.Close();
            }
            return con;
        }
    }
}
