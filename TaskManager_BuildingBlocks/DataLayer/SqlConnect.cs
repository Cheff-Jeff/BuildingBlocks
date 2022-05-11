using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer
{
    public class SqlConnect
    {
        //variabele aanmaken die in de DAL kunnen worden gebuikt.
        internal SqlCommand cmd;
        internal SqlConnection con;

        //Methode om connection tussen database op te zetten.
        public void Initialize()
        {
            string connectionString = @"Data Source=mssqlstud.fhict.local;Database=dbi483908_bblocks;User Id=dbi483908_bblocks;Password=Building@Blocks#Data;";
            con = new SqlConnection(connectionString);
            cmd = con.CreateCommand();
        }

        //Connectie opzetten met database.
        public bool OpenConnect()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //Connectie afsluiten met database.
        public bool CloseConnect()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
