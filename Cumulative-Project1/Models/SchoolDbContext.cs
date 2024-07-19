using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Cumulative_Project1.Models
{
    public class SchoolDbContext
    {
       // Creating the fields according to the schooldb database configuration
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }
        private static string Database { get { return "schooldb"; } }
        private static string User { get { return "root"; } }
        private static string Password { get { return "root"; } }

        // Creating the connection string to connect with the database
        protected static string DatabaseConnectionString
        {
            get
            {
                return $"server={Server};port={Port};database={Database};user={User};password={Password};convert zero datetime=True";
            }
        }

        /// <summary>
        /// Returns a MySQL connection to the schooldb database.
        /// </summary>
        /// <example>
        /// SchoolDbContext dbContext = new SchoolDbContext();
        /// MySqlConnection conn = dbContext.DatabaseAccess();
        /// </example>
        /// <returns>MySqlConnection object</returns>
        public MySqlConnection DatabaseAccess()
        {
            return new MySqlConnection(DatabaseConnectionString);
        }
    }
}
