using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_BuildingBlocks
{
    public class DbConnection
    {
        private static string connenctionString = @"Data Source=mssqlstud.fhict.local;Database=dbi483908_bblocks;User Id=dbi483908_bblocks;Password=Building@Blocks#Data;";
        public static SqlConnection cnn;

        public static void OpenDbConnenction()
        {
            cnn = new SqlConnection(connenctionString);
            cnn.Open();
        }

        public static void CloseDbConnection()
        {
            cnn.Close();
        }
    }
}
