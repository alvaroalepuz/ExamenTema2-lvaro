using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class EventoRepository
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
        //internal Evento Retrieve()
        //{
        //    MySqlConnection con = Connect();
        //    MySqlCommand command = con.CreateCommand();
        //    command.CommandText = "select * from evento";

        //    con.Open();
        //    MySqlDataReader res = command.ExecuteReader();
        //    Evento e = null;
        //    if (res.Read())
        //    {
        //        Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetDateTime(3).ToString("yyyy-MM-dd") + " " + res.GetInt32(4)); 
        //        e = new Evento(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetDateTime(3).ToString("yyyy-MM-dd"), res.GetInt32(4));
        //    }
        //    con.Close();
        //    return e;
        //}
        //internal EventoDto Filtrar()
        //{
        //    MySqlConnection con = Connect();
        //    MySqlCommand command = con.CreateCommand();
        //    command.CommandText = "select NombreELocal, NombreEVisitante, Fecha from evento";

        //    con.Open();
        //    MySqlDataReader res = command.ExecuteReader();
        //    EventoDto e = null;

        //    if (res.Read())
        //    {
        //        Debug.WriteLine("Recuperado: " + res.GetString(0) + " " + res.GetString(1) + " " + res.GetDateTime(2).ToString("yyyy-MM-dd"));
        //        e = new EventoDto(res.GetString(0), res.GetString(1), res.GetDateTime(2).ToString("yyyy-MM-dd"));

        //    }
        //    con.Close();
        //    return e;
        //}

        internal List<Evento> Retrieve()
        {

            List<Evento> eventos = new List<Evento>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                eventos = context.eventos.ToList();
            }

            return eventos;

        }
        internal List<Evento> Retrieve2(int id)
        {

            List<Evento> eventos = new List<Evento>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                eventos = context.eventos.ToList();
            }

            return eventos;

        }
        internal Evento Retrieve3(int id)
        {

            Evento eventos;
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                eventos = context.eventos.Find(id);
            }

            return eventos;

        }
        internal void Update(Evento e)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();

            context.eventos.Update(e);
            context.SaveChanges();

        }

        internal void Delete(Evento e)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();

            context.eventos.Remove(e);
            context.SaveChanges();

        }



    }
}