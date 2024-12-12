using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamBuilder
{
    public sealed class DatabaseHandler
    {
        private static readonly DatabaseHandler DatabaseInstance = new DatabaseHandler();

        private DatabaseHandler()
        {
            string baseDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string dbPath = Path.Combine(baseDirectory, "Players.db");
            ConnectionString = "Data Source=" + dbPath + ";Version=3;New=False";
        }

        public static DatabaseHandler Instance
        {
            get { return DatabaseInstance; }
        }
        public string ConnectionString { get; }
    }
}
