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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeamBuilder
{
    public partial class FormMain : Form
    {
        public FormMain(DatabaseHandler databaseHandler)
        {
            this.databaseHandler = databaseHandler;

            InitializeComponent();
            ResetDataGridView();
            LoadPositions();
            LoadNationalities();
            LoadLeagues();
            LoadClubs();
        }

        private void ResetDataGridView()
        {
            using (SQLiteConnection connection = new SQLiteConnection(databaseHandler.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Players";
                SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectCommand);

                databaseDataset = new DataSet();
                adapter.Fill(databaseDataset);
                DataGridViewPlayers.DataSource = databaseDataset.Tables[0];
                DataGridViewPlayers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                connection.Close();
            }
        }

        private void LoadPositions()
        {
            using (SQLiteConnection connection = new SQLiteConnection(databaseHandler.ConnectionString))
            {
                connection.Open();

                string query = "SELECT DISTINCT pozycja FROM Players ORDER BY pozycja ASC";
                SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectCommand);

                databaseDataset = new DataSet();
                adapter.Fill(databaseDataset);

                DataTable table = databaseDataset.Tables[0];
                DataRow row = table.NewRow();
                row["pozycja"] = "<brak>";

                table.Rows.InsertAt(row, 0);
                ComboBoxPosition.DataSource = databaseDataset.Tables[0];
                ComboBoxPosition.DisplayMember = "pozycja";

                connection.Close();
            }
        }

        private void LoadNationalities()
        {
            using (SQLiteConnection connection = new SQLiteConnection(databaseHandler.ConnectionString))
            {
                connection.Open();

                string query = "SELECT DISTINCT kraj FROM Players ORDER BY kraj ASC";
                SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectCommand);

                databaseDataset = new DataSet();
                adapter.Fill(databaseDataset);

                DataTable table = databaseDataset.Tables[0];
                DataRow row = table.NewRow();
                row["kraj"] = "<brak>";
                table.Rows.InsertAt(row, 0);

                ComboBoxNationality.DataSource = databaseDataset.Tables[0];
                ComboBoxNationality.DisplayMember = "kraj";

                connection.Close();
            }
        }
        private void LoadLeagues()
        {
            using (SQLiteConnection connection = new SQLiteConnection(databaseHandler.ConnectionString))
            {
                connection.Open();

                string query = "SELECT DISTINCT liga FROM Players ORDER BY liga ASC";
                SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectCommand);

                databaseDataset = new DataSet();
                adapter.Fill(databaseDataset);

                DataTable table = databaseDataset.Tables[0];
                DataRow row = table.NewRow();
                row["liga"] = "<brak>";
                table.Rows.InsertAt(row, 0);

                ComboBoxLeague.DataSource = databaseDataset.Tables[0];
                ComboBoxLeague.DisplayMember = "liga";

                connection.Close();
            }
        }
        private void LoadClubs()
        {
            using (SQLiteConnection connection = new SQLiteConnection(databaseHandler.ConnectionString))
            {
                connection.Open();

                string query = "SELECT DISTINCT klub FROM Players ORDER BY klub ASC";
                SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectCommand);

                databaseDataset = new DataSet();
                adapter.Fill(databaseDataset);

                DataTable table = databaseDataset.Tables[0];
                DataRow row = table.NewRow();
                row["klub"] = "<brak>";
                table.Rows.InsertAt(row, 0);

                ComboBoxClub.DataSource = table;
                ComboBoxClub.DisplayMember = "klub";

                connection.Close();
            }
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(databaseHandler.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Players WHERE kraj = 'Poland'";
                SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectCommand);

                databaseDataset = new DataSet();
                adapter.Fill(databaseDataset);
                DataGridViewPlayers.DataSource = databaseDataset.Tables[0];
                DataGridViewPlayers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);


                connection.Close();
            }
        }

        private void ButtonResetFilters_Click(object sender, EventArgs e)
        {
            ResetDataGridView();
        }

        private void ButtonAddPlayer_Click(object sender, EventArgs e)
        {
            LabelPriceValue.Text = DataGridViewPlayers.SelectedRows[0].Cells["cena"].Value.ToString();
        }
    }
}
