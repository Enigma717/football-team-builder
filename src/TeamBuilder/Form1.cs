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
            selectedLabel = labelPlayer1;

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
                dataGridViewPlayers.DataSource = databaseDataset.Tables[0];
                dataGridViewPlayers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

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
                comboBoxPosition.DataSource = databaseDataset.Tables[0];
                comboBoxPosition.DisplayMember = "pozycja";

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

                comboBoxNationality.DataSource = databaseDataset.Tables[0];
                comboBoxNationality.DisplayMember = "kraj";

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

                comboBoxLeague.DataSource = databaseDataset.Tables[0];
                comboBoxLeague.DisplayMember = "liga";

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

                comboBoxClub.DataSource = table;
                comboBoxClub.DisplayMember = "klub";

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
                dataGridViewPlayers.DataSource = databaseDataset.Tables[0];
                dataGridViewPlayers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                connection.Close();
            }
        }

        private void ButtonResetFilters_Click(object sender, EventArgs e)
        {
            ResetDataGridView();
        }

        private void ButtonAddPlayer_Click(object sender, EventArgs e)
        {
            selectedLabel.Text = dataGridViewPlayers.SelectedRows[0].Cells["piłkarz"].Value.ToString();
        }

        private void ButtonDeletePlayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectedLabel.Name);
        }

        private void LabelPlayer1_Click(object sender, EventArgs e)
        {
            selectedLabel = sender as Label;
        }

        private void labelPlayer2_Click(object sender, EventArgs e)
        {
            selectedLabel = sender as Label;
        }

        private void labelPlayer3_Click(object sender, EventArgs e)
        {
            selectedLabel = sender as Label;
        }

        private void labelPlayer4_Click(object sender, EventArgs e)
        {
            selectedLabel = sender as Label;
        }

        private void labelPlayer5_Click(object sender, EventArgs e)
        {
            selectedLabel = sender as Label;
        }

        private void labelPlayer6_Click(object sender, EventArgs e)
        {
            selectedLabel = sender as Label;
        }

        private void labelPlayer7_Click(object sender, EventArgs e)
        {
            selectedLabel = sender as Label;
        }

        private void labelPlayer8_Click(object sender, EventArgs e)
        {
            selectedLabel = sender as Label;
        }

        private void labelPlayer9_Click(object sender, EventArgs e)
        {
            selectedLabel = sender as Label;
        }

        private void labelPlayer10_Click(object sender, EventArgs e)
        {
            selectedLabel = sender as Label;
        }

        private void labelPlayer11_Click(object sender, EventArgs e)
        {
            selectedLabel = sender as Label;
        }
    }
}
