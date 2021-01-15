using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class UsuarioRepository
    {
        //private MySqlConnection Connect()
        //{
        //    string server = "server=127.0.0.1;";
        //    string port = "port=3306;";
        //    string database = "database=PlaceMyBet;";
        //    string usuario = "uid=root;";
        //    string password = "pwd=;";
        //    string dateTimeAvailable = "Convert Zero Datetime=True";
        //    string connectionstring = server + port + database + usuario + password + dateTimeAvailable;
        //    MySqlConnection con = new MySqlConnection(connectionstring);
        //    return con;
        //}
        //internal Usuario Retrieve()
        //{
        //    MySqlConnection con = Connect();
        //    MySqlCommand command = con.CreateCommand();
        //    command.CommandText = "select * from usuarios";

        //    con.Open();
        //    MySqlDataReader res = command.ExecuteReader();
        //    Usuario u = null;
        //    if (res.Read())
        //    {
        //        Debug.WriteLine("Recuperado: " + res.GetString(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetInt32(3) + " " + res.GetInt32(4));
        //        u = new Usuario(res.GetString(0), res.GetString(1), res.GetString(2), res.GetInt32(3), res.GetInt32(4));
        //    }
        //    con.Close();
        //    return u;
        //}

    }
}