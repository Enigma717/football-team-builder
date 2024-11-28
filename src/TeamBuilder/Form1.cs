using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamBuilder
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // TODO: Move everything below to its own location
            string baseDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string dbPath = Path.Combine(baseDirectory, "Players.db");
            string connectionString = "Data Source=" + dbPath + ";Version=3;New=False";

            SQLiteConnection connection;
            connection = new SQLiteConnection(connectionString);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM Players", connection);
            connection.Open();

            string query = "SELECT * FROM Players";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridViewPlayers.DataSource = dt;

            dataGridViewPlayers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelMaxPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
