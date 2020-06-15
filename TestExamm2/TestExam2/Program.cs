using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TestExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverName = @"DESKTOP-LTPHR86\CLOVER", dbName = "SouvenirShop2";
            ConnectionToDB.ConnectToDB(serverName, dbName);

            Console.ReadLine();

        }
    }
}
