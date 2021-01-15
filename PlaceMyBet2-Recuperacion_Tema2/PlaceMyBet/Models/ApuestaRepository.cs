using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace PlaceMyBet.Models
{
    public class ApuestaRepository
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
        //internal Apuesta RetrieveData(int id)
        //{
        //    MySqlConnection con = Connect();
        //    MySqlCommand command = con.CreateCommand();
        //    command.CommandText = "select * from apuesta where IdApuesta=@A";
        //    command.Parameters.AddWithValue("@A", id);

        //    con.Open();
        //    MySqlDataReader res = command.ExecuteReader();
        //    Apuesta a = null;
        //    if (res.Read())
        //    {
        //        Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetDouble(2) + " " + res.GetInt32(3) + " " + res.GetString(4));
        //        a = new Apuesta(res.GetInt32(0), res.GetString(1), res.GetDouble(2), res.GetInt32(3), res.GetString(4));
        //    }
        //    con.Close();
        //    return a;
        //}

        //internal ApuestaDto Filtrar()
        //{
        //    MySqlConnection con = Connect();
        //    MySqlCommand command = con.CreateCommand();
        //    command.CommandText = "select Tipo, Dinero, CuotaOver,CuotaUnder,Email, Fecha from apuesta INNER JOIN mercado INNER JOIN evento";

        //    con.Open();
        //    MySqlDataReader res = command.ExecuteReader();
        //    ApuestaDto a = null;

        //    if (res.Read())
        //    {
        //        Debug.WriteLine("Recuperado: " + res.GetString(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetString(4) + " " + res.GetDateTime(5).ToString("yyyy-MM-dd"));
        //        a = new ApuestaDto(res.GetString(0), res.GetDouble(1), res.GetDouble(2), res.GetDouble(3), res.GetString(4), res.GetDateTime(5).ToString("yyyy-MM-dd"));

        //    }
        //    con.Close();
        //    return a;
        //}
        //internal ApuestaDto2 Filtrar2()
        //{

        //    MySqlConnection con = Connect();
        //    MySqlCommand command = con.CreateCommand();
        //    command.CommandText = "SELECT IdEvento , Tipo, CuotaOver, CuotaUnder ,Dinero FROM evento INNER JOIN mercado INNER JOIN apuesta WHERE Mercado = 1.5;";
        //    con.Open();
        //    MySqlDataReader res = command.ExecuteReader();
        //    ApuestaDto2 a = null;
        //    if (res.Read())
        //    {
        //        Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4));
        //        a = new ApuestaDto2(res.GetInt32(0), res.GetString(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4));

        //    }
        //    return a;
        //}

        //internal ApuestaDto3 Filtrar3()
        //{

        //    MySqlConnection con = Connect();
        //    MySqlCommand command = con.CreateCommand();
        //    command.CommandText = "SELECT mercado , Tipo ,CuotaOver, CuotaUnder ,Dinero FROM mercado INNER JOIN apuesta INNER JOIN usuarios WHERE IDMercado = MercadoIDFK AND IDMercado = MercadoIDFK3;";
        //    con.Open();
        //    MySqlDataReader res = command.ExecuteReader();
        //    ApuestaDto3 a = null;
        //    if (res.Read())
        //    {
        //        Debug.WriteLine("Recuperado: " + res.GetDouble(0) + " " + res.GetString(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4));
        //        a = new ApuestaDto3(res.GetDouble(0), res.GetString(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4));

        //    }
        //    return a;
        //}

        ////internal void Save(Apuesta apuesta)
        ////{

        ////    MySqlConnection con = Connect();
        ////    MySqlCommand command = con.CreateCommand();
        ////    command.CommandText = "insert into apuesta(Tipo, Dinero, MercadoIDFK, Email) values ('" + apuesta.tipo + "','" + apuesta.dinero + "','" + apuesta.mercado + "','" + apuesta.correo + "');";
        ////    Debug.WriteLine("comando " + command.CommandText);
        ////    try
        ////    {
        ////        con.Open();
        ////        command.ExecuteNonQuery();
        ////        con.Close();
        ////    }
        ////    catch (MySqlException)
        ////    {

        ////        Debug.WriteLine("Se ha producido un error");
        ////    }
        ////}
        internal List<Apuesta> Retrieve()
        {

            List<Apuesta> apuestas = new List<Apuesta>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuestas = context.apuestas.ToList();
            }

            return apuestas;

        }

        internal List<Apuesta> Retrieve(int id)
        {
            List<Apuesta> apuestas1 = new List<Apuesta>();

            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuestas1 = context.apuestas.Include(p => p.mercados2).ToList();
            }


            return apuestas1;
        }
        internal void Save(Apuesta a)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();

            context.apuestas.Add(a);
            context.SaveChanges();

        }


        /// ////////////////////EXAMEN/////////////////////////////////////////////////////////////////////////////////////////



        public static ApuestaDto ToDTO(Apuesta a, Evento e)
        {
            return new ApuestaDto(a.apuestaId,a.tipo,a.dinero,a.mercadoId,e.nombreLocal,e.nombreVisitante);
        }

        internal List<ApuestaDto> Retrieve2(string nombreEquipo)
        {
            List<ApuestaDto> apuestadto = new List<ApuestaDto>();
            Evento e = new Evento();

            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuestadto = context.apuestas
                    .Select(a => ToDTO(a, e))
                    .Where(n=> n.nombreVisitante==nombreEquipo)
                    .ToList();

            }


            return apuestadto;
        }

    }



}