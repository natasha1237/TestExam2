using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TestExam2
{
    class ConnectionToDB
    {

        public static SqlConnection ConnectToDB(string serverName, string DBName)
        {
            string connectionString = @"Data Source =" + serverName + ";Initial Catalog=" + DBName + ";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connection open");
                Console.WriteLine("Властивостi пiдключення");
                Console.WriteLine("\tРядок пiдключення: {0}", connection.ConnectionString);
                Console.WriteLine("\tБаза даних: {0}", connection.Database);
                Console.WriteLine("\tСервер: {0}", connection.DataSource);
                Console.WriteLine("\tВерсiя сервера: {0}", connection.ServerVersion);
                Console.WriteLine("\tСтан: {0}", connection.State);
                Console.WriteLine("\tWorkstationld: {0}", connection.WorkstationId);
                return connection;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }   
}
