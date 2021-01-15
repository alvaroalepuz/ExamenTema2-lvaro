using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class MercadoRepository
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
        //internal Mercado Retrieve()
        //{
        //    MySqlConnection con = Connect();
        //    MySqlCommand command = con.CreateCommand();
        //    command.CommandText = "select * from mercado";

        //    con.Open();
        //    MySqlDataReader res = command.ExecuteReader();
        //    Mercado m = null;
        //    if (res.Read())
        //    {
        //        Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4) + " " + res.GetDouble(5));
        //        m = new Mercado(res.GetInt32(0), res.GetDouble(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4), res.GetDouble(5));
        //    }
        //    con.Close();
        //    return m;
        //}
        //internal MercadoDto Filtrar()
        //{
        //    MySqlConnection con = Connect();
        //    MySqlCommand command = con.CreateCommand();
        //    command.CommandText = "select Mercado, CuotaOver, CuotaUnder from mercado";

        //    con.Open();
        //    MySqlDataReader res = command.ExecuteReader();
        //    MercadoDto m = null;

        //    if (res.Read())
        //    {
        //        Debug.WriteLine("Recuperado: " + res.GetDouble(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2));
        //        m = new MercadoDto(res.GetDouble(0), res.GetDouble(1), res.GetDouble(2));

        //    }
        //    con.Close();
        //    return m;
        //}
        //internal MercadoDto Filtrar2()
        //{

        //    MySqlConnection con = Connect();
        //    MySqlCommand command = con.CreateCommand();
        //    command.CommandText = "SELECT IdMercado, Mercado, CuotaOver, CuotaUnder,DineroOver,DineroUnder FROM mercado INNER JOIN evento  WHERE IdEvento = 1;";
        //    con.Open();
        //    MySqlDataReader res = command.ExecuteReader();
        //    MercadoDto e = null;
        //    if (res.Read())
        //    {
        //        Debug.WriteLine("Recuperado: " + res.GetDouble(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2));
        //        e = new MercadoDto(res.GetDouble(0), res.GetDouble(1), res.GetDouble(2));

        //    }
        //    return e;
        //}
        internal List<Mercado> Retrieve()
        {

            List<Mercado> mercados = new List<Mercado>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                mercados = context.mercados.ToList();
            }

            return mercados;

        }
        public static MercadoDto ToDTO(Mercado m)
        {
            return new MercadoDto(m.mercado, m.cuotaOver, m.cuotaUnder);
        }

        internal List<MercadoDto> Retrieve2()
        {
            List<MercadoDto> mercados = new List<MercadoDto>();
         

            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                mercados = context.mercados.Select(m => ToDTO(m)).ToList();
            }
            

            return mercados;
        }
        internal void Save(Mercado m)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();

            context.mercados.Add(m);
            context.SaveChanges();

        }

    }
}