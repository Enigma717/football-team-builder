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
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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

            this.selectedPlayerLabel = labelPlayer1;
            this.players = new List<PlayerLabel>();
            this.filteringComponents = new List<IComponent>();

            InitializeFilteringComponentsList();
            InitializePlayersList();

            ResetDataGridView();
            LoadPositions();
            LoadNationalities();
            LoadLeagues();
            LoadClubs();
        }

        private void InitializeFilteringComponentsList()
        {
            IComponent[] components = {
                this.textBoxPlayer, 
                this.numericUpDownMinPrice, 
                this.numericUpDownMaxPrice,
                this.comboBoxPosition,
                this.comboBoxNationality,
                this.comboBoxClub,
                this.comboBoxPosition
            };

            filteringComponents.AddRange(components);
        }

        private void InitializePlayersList()
        {
            var playerLabels = this.groupBoxTeam.Controls
                .OfType<PlayerLabel>()
                .ToList();

            foreach (var player in playerLabels)
            {
                player.DefaultText = player.Text;
                player.PlayerName = "";
                player.PlayerPosition = "";
                player.PlayerClub = "";
                player.PlayerLeague = "";
                player.PlayerNationality = "";
                player.PlayerOverall = 0;
                player.PlayerPrice = 0;
                player.PlayerChemistry = 0;
            }

            players.AddRange(playerLabels);
        }

        private void ResetDataGridView()
        {
            using (SQLiteConnection connection = new SQLiteConnection(databaseHandler.ConnectionString))
            {
                connection.Open();

                string query = DEFAULT_QUERY;
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
                row["pozycja"] = NOT_SELECTED_ITEM;

                table.Rows.InsertAt(row, 0);
                comboBoxPosition.DataSource = table;
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
                row["kraj"] = NOT_SELECTED_ITEM;
                table.Rows.InsertAt(row, 0);

                comboBoxNationality.DataSource = table;
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
                row["liga"] = NOT_SELECTED_ITEM;
                table.Rows.InsertAt(row, 0);

                comboBoxLeague.DataSource = table;
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
                row["klub"] = NOT_SELECTED_ITEM;
                table.Rows.InsertAt(row, 0);

                comboBoxClub.DataSource = table;
                comboBoxClub.DisplayMember = "klub";

                connection.Close();
            }
        }

        private void UpdateTeamStats()
        {
            var priceSum = 0;
            var overallSum = 0;

            foreach (var player in players)
            {
                //MessageBox.Show(player.Name);
                priceSum += player.PlayerPrice;
                overallSum += player.PlayerOverall;
            }

            priceSum /= 1000000;
            labelPriceValue.Text = priceSum.ToString();

            overallSum /= 11;
            labelOverallValue.Text = overallSum.ToString();
        }

        private void ResetPlayerLabel(PlayerLabel player)
        {
            player.Text = player.DefaultText;
            player.PlayerName = "";
            player.PlayerPosition = "";
            player.PlayerClub = "";
            player.PlayerLeague = "";
            player.PlayerNationality = "";
            player.PlayerOverall = 0;
            player.PlayerPrice = 0;
            player.PlayerChemistry = 0;
        }

        //private void SwapPlayers(PlayerLabel firstPlayer, PlayerLabel secondPlayer)
        //{
        //    var tempPlayer = new PlayerLabel();

        //    tempPlayer = firstPlayer;
        //    firstPlayer = secondPlayer;
        //    secondPlayer = tempPlayer;
        //}

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            string query = DEFAULT_QUERY;
            string selectedPositionString = "";
            string selectedNationalityString = "";
            string selectedLeagueString = "";
            string selectedClubString = "";

            var filtersMap = new Dictionary<string, string>();

            DataRowView selectedPosition = comboBoxPosition.SelectedValue as DataRowView;
            DataRowView selectedNationality = comboBoxNationality.SelectedValue as DataRowView;
            DataRowView selectedLeague = comboBoxLeague.SelectedValue as DataRowView;
            DataRowView selectedClub = comboBoxClub.SelectedValue as DataRowView;

            int selectedBoxes = 0;

            if (selectedPosition != null)
            {
                selectedPositionString = selectedPosition.Row["pozycja"] as string;
                //filtersMap["pozycja"] = selectedPosition.Row["pozycja"] as string;
                selectedBoxes++;
            }

            if (selectedNationality != null)
            {
                selectedNationalityString = selectedNationality.Row["kraj"] as string;
                //filtersMap["kraj"] = selectedPosition.Row["kraj"] as string;
                selectedBoxes++;
            }

            if (selectedLeague != null)
            {
                selectedLeagueString = selectedLeague.Row["liga"] as string;
                //filtersMap["liga"] = selectedPosition.Row["liga"] as string;
                selectedBoxes++;
            }

            if (selectedClub != null)
            {
                selectedClubString = selectedClub.Row["klub"] as string;
                selectedBoxes++;
            }

            if (selectedBoxes == 0)
            {
                return;
            }
            else
            {
                query += " WHERE";
            }

            MessageBox.Show(query);

            if (selectedPositionString != NOT_SELECTED_ITEM)
            {
                query += " pozycja = '" + selectedPositionString + "' AND";
            }

            if (selectedNationalityString != NOT_SELECTED_ITEM)
            {
                query += " kraj = '" + selectedNationalityString + "' AND";
            }

            if (selectedLeagueString != NOT_SELECTED_ITEM)
            {
                query += " liga = '" + selectedLeagueString + "' AND";
            }

            if (selectedClubString != NOT_SELECTED_ITEM)
            {
                query += " klub = '" + selectedClubString + "' AND";
            }

            MessageBox.Show(query);

            if (query == DEFAULT_QUERY)
                return;

            query = query.Substring(0, query.Length - 4);

            MessageBox.Show(query);

            using (SQLiteConnection connection = new SQLiteConnection(databaseHandler.ConnectionString))
            {
                connection.Open();

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
            var playerName = dataGridViewPlayers.SelectedRows[0].Cells["piłkarz"].Value.ToString();
            var playerPosition = dataGridViewPlayers.SelectedRows[0].Cells["pozycja"].Value.ToString();
            var playerClub = dataGridViewPlayers.SelectedRows[0].Cells["klub"].Value.ToString();
            var playerLeague = dataGridViewPlayers.SelectedRows[0].Cells["liga"].Value.ToString();
            var playerNationality = dataGridViewPlayers.SelectedRows[0].Cells["kraj"].Value.ToString();
            var playerOverall = Convert.ToInt32(dataGridViewPlayers.SelectedRows[0].Cells["ovr"].Value.ToString());
            var playerPrice = Convert.ToInt32(dataGridViewPlayers.SelectedRows[0].Cells["cena"].Value.ToString());

            foreach (var player in players)
            {
                if (player.PlayerName == playerName)
                {
                    //var message = "Podany gracz znajduje się już w składzie.     : ";
                    //message += selectedPlayerLabel.PlayerName.ToString();
                    //MessageBox.Show(message);

                    //if (selectedPlayerLabel.PlayerName != "")
                    //{
                    //    SwapPlayers(selectedPlayerLabel, player);
                    //    return;
                    //}

                    ResetPlayerLabel(player);
                }
            }

            selectedPlayerLabel.Text = playerName;
            selectedPlayerLabel.PlayerName = playerName;
            selectedPlayerLabel.PlayerPosition = playerPosition;
            selectedPlayerLabel.PlayerClub = playerClub;
            selectedPlayerLabel.PlayerLeague = playerLeague;
            selectedPlayerLabel.PlayerNationality = playerNationality;
            selectedPlayerLabel.PlayerOverall = playerOverall;
            selectedPlayerLabel.PlayerPrice = playerPrice;
            selectedPlayerLabel.PlayerChemistry = 1;

            UpdateTeamStats();
        }

        private void ButtonDeletePlayer_Click(object sender, EventArgs e)
        {
            ResetPlayerLabel(selectedPlayerLabel);
            UpdateTeamStats();
        }
        private void buttonResetSquad_Click(object sender, EventArgs e)
        {
            foreach (var player in players)
            {
                ResetPlayerLabel(player);
            }
            
            UpdateTeamStats();
        }

        private void LabelPlayer1_Click(object sender, EventArgs e)
        {
            selectedPlayerLabel = sender as PlayerLabel;
        }

        private void labelPlayer2_Click(object sender, EventArgs e)
        {
            selectedPlayerLabel = sender as PlayerLabel;
        }

        private void labelPlayer3_Click(object sender, EventArgs e)
        {
            selectedPlayerLabel = sender as PlayerLabel;
        }

        private void labelPlayer4_Click(object sender, EventArgs e)
        {
            selectedPlayerLabel = sender as PlayerLabel;
        }

        private void labelPlayer5_Click(object sender, EventArgs e)
        {
            selectedPlayerLabel = sender as PlayerLabel;
        }

        private void labelPlayer6_Click(object sender, EventArgs e)
        {
            selectedPlayerLabel = sender as PlayerLabel;
        }

        private void labelPlayer7_Click(object sender, EventArgs e)
        {
            selectedPlayerLabel = sender as PlayerLabel;
        }

        private void labelPlayer8_Click(object sender, EventArgs e)
        {
            selectedPlayerLabel = sender as PlayerLabel;
        }

        private void labelPlayer9_Click(object sender, EventArgs e)
        {
            selectedPlayerLabel = sender as PlayerLabel;
        }

        private void labelPlayer10_Click(object sender, EventArgs e)
        {
            selectedPlayerLabel = sender as PlayerLabel;
        }

        private void labelPlayer11_Click(object sender, EventArgs e)
        {
            selectedPlayerLabel = sender as PlayerLabel;
        }
    }
}
