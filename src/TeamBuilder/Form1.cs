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
        public FormMain(DatabaseHandler databaseHandler)
        {
            this.databaseHandler = databaseHandler;

            InitializeComponent();
            ResetDataGridView();
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

        private void ButtonResetFilters_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(databaseHandler.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Players WHERE nationality_name = 'Poland'";
                SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectCommand);

                databaseDataset = new DataSet();
                adapter.Fill(databaseDataset);
                DataGridViewPlayers.DataSource = databaseDataset.Tables[0];
                DataGridViewPlayers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                connection.Close();
            }
        }

        private void ButtonResetSquad_Click(object sender, EventArgs e)
        {
            ResetDataGridView();

        }

        private void LabelPlayer6_Click(object sender, EventArgs e)
        {

        }

        private void LabelPlayer2_Click(object sender, EventArgs e)
        {

        }

        private void LabelPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxClub_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelOverall_Click(object sender, EventArgs e)
        {

        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelPlayer10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LabelPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
