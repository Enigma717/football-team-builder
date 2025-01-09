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
using System.Runtime.Remoting.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Xsl;
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
            this.filteringComponents = new List<Tuple<string, Component>>();

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
            Tuple<string, Component>[] components = {
                new Tuple<string, Component>( "pozycja", this.comboBoxPosition ),
                new Tuple<string, Component>( "kraj", this.comboBoxNationality ),
                new Tuple<string, Component>( "klub", this.comboBoxClub ),
                new Tuple<string, Component>( "liga", this.comboBoxLeague ),
                new Tuple<string, Component>( "minCena", this.numericUpDownMinPrice ), 
                new Tuple<string, Component>( "maxCena", this.numericUpDownMaxPrice ),
                new Tuple<string, Component>( "piłkarz", this.textBoxPlayer ) 
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
                player.DefaultPosition = player.Text;
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

        private void UpdatePlayersChemistry()
        {
            foreach (var player in players)
            {
                var playerClub = player.PlayerClub;
                var playerLeague = player.PlayerLeague;
                var playerNationality = player.PlayerNationality;

                int sameClub = 0;
                int sameLeague = 0;
                int sameNationality = 0;

                players.ForEach(otherPlayer =>
                {
                    if (player == otherPlayer)
                        return;

                    if (playerClub == otherPlayer.PlayerClub && otherPlayer.PlayerClub != "")
                        sameClub++;

                    if (playerLeague == otherPlayer.PlayerLeague && otherPlayer.PlayerLeague != "")
                        sameLeague++;

                    if (playerNationality == otherPlayer.PlayerNationality && otherPlayer.PlayerNationality != "")
                        sameNationality++;
                });

                if (sameLeague >= 8 || sameNationality >= 8 || sameClub >= 7)
                    player.PlayerChemistry = 3;
                else if (sameLeague >= 5 || sameNationality >= 5 || sameClub >= 4)
                    player.PlayerChemistry = 2;
                else if (sameLeague >= 3 || sameNationality >= 3 || sameClub >= 2)
                    player.PlayerChemistry = 1;
            }
        }

        private void UpdateTeamStats()
        {
            double chemistrySum = 0.0;
            double overallSum = 0.0;
            double priceSum = 0.0;

            foreach (var player in players)
            {
                chemistrySum += player.PlayerChemistry;
                overallSum += player.PlayerOverall;
                priceSum += player.PlayerPrice;
            }

            labelChemistryValue.Text = chemistrySum.ToString();

            overallSum *= 0.9 + (chemistrySum / 330.0);
            overallSum /= 11.0;
            labelOverallValue.Text = Convert.ToInt32(overallSum).ToString();

            priceSum /= 1000000.0;
            labelPriceValue.Text = priceSum.ToString() + " mln €";
        }

        private void ResetPlayerLabel(PlayerLabel player)
        {
            player.Text = player.DefaultPosition;
            player.PlayerName = "";
            player.PlayerPosition = "";
            player.PlayerClub = "";
            player.PlayerLeague = "";
            player.PlayerNationality = "";
            player.PlayerOverall = 0;
            player.PlayerPrice = 0;
            player.PlayerChemistry = 0;
        }

        private void AssignPlayerData(PlayerLabel sourcePlayer, PlayerLabel destinationPlayer)
        {
            sourcePlayer.Text = destinationPlayer.Text;
            sourcePlayer.PlayerName = destinationPlayer.PlayerName;
            sourcePlayer.PlayerPosition = destinationPlayer.PlayerPosition;
            sourcePlayer.PlayerClub = destinationPlayer.PlayerClub;
            sourcePlayer.PlayerLeague = destinationPlayer.PlayerLeague;
            sourcePlayer.PlayerNationality = destinationPlayer.PlayerNationality;
            sourcePlayer.PlayerOverall = destinationPlayer.PlayerOverall;
            sourcePlayer.PlayerPrice = destinationPlayer.PlayerPrice;
            sourcePlayer.PlayerChemistry = destinationPlayer.PlayerChemistry;
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            string query = DEFAULT_FILTER_QUERY;
            var filtersMap = new Dictionary<string, string>();

            foreach (var filteringComponent in filteringComponents)
            {
                if (filteringComponent.Item2 is System.Windows.Forms.ComboBox)
                {
                    var comboBoxComponent = filteringComponent.Item2 as System.Windows.Forms.ComboBox;
                    DataRowView selectedValue = comboBoxComponent.SelectedValue as DataRowView;
                    var selectedValueString = selectedValue.Row[0] as string;
                    var filterKey = filteringComponent.Item1;

                    filtersMap[filterKey] = selectedValueString;
                }
                else if (filteringComponent.Item2 is System.Windows.Forms.NumericUpDown)
                {
                    var numericUpDownComponent = filteringComponent.Item2 as System.Windows.Forms.NumericUpDown;
                    var filterKey = filteringComponent.Item1;
                    
                    filtersMap[filterKey] = numericUpDownComponent.Value.ToString();
                }
                else if (filteringComponent.Item2 is System.Windows.Forms.TextBox)
                {
                    var textBoxComponent = filteringComponent.Item2 as System.Windows.Forms.TextBox;
                    var filterKey = filteringComponent.Item1;

                    filtersMap[filterKey] = textBoxComponent.Text;
                }
            }

            foreach (var filter in filtersMap)
            {
                if (filter.Key == "minCena")
                {
                    if (filter.Value != "0" && filter.Value != "")
                        query += " cena >= '" + filter.Value + "' AND";
                }
                else if (filter.Key == "maxCena")
                {
                    if (filter.Value != "0" && filter.Value != "")
                        query += " cena <= '" + filter.Value + "' AND";
                }
                else if (filter.Key == "piłkarz")
                {
                    if (filter.Value != "")
                        query += " " + filter.Key + " = '" + filter.Value + "' AND";
                }
                else if (filter.Value != NOT_SELECTED_ITEM)
                {
                    query += " " + filter.Key + " = '" + filter.Value + "' AND";
                }
            }
            
            if (query == DEFAULT_FILTER_QUERY)
                return;

            query = query.Substring(0, query.Length - 4);

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
            foreach (var filteringComponent in filteringComponents)
            {
                if (filteringComponent.Item2 is System.Windows.Forms.ComboBox)
                {
                    var comboBoxComponent = filteringComponent.Item2 as System.Windows.Forms.ComboBox;
                    comboBoxComponent.SelectedIndex = 0;
                }
                else if (filteringComponent.Item2 is System.Windows.Forms.NumericUpDown)
                {
                    var numericUpDownComponent = filteringComponent.Item2 as System.Windows.Forms.NumericUpDown;
                    numericUpDownComponent.Value = 0;
                }
                else if (filteringComponent.Item2 is System.Windows.Forms.TextBox)
                {
                    var textBoxComponent = filteringComponent.Item2 as System.Windows.Forms.TextBox;
                    textBoxComponent.Text = "";
                }
            }

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
                    if (selectedPlayerLabel.PlayerName != "")
                    {
                        var tempPlayer = new PlayerLabel();

                        AssignPlayerData(tempPlayer, selectedPlayerLabel);
                        AssignPlayerData(selectedPlayerLabel, player);
                        AssignPlayerData(player, tempPlayer);

                        return;
                    }

                    ResetPlayerLabel(player);
                }
            }

            selectedPlayerLabel.Text = playerName;
            selectedPlayerLabel.PlayerName = playerName;
            selectedPlayerLabel.PlayerPosition = playerPosition;
            selectedPlayerLabel.PlayerClub = playerClub;
            selectedPlayerLabel.PlayerLeague = playerLeague;
            selectedPlayerLabel.PlayerNationality = playerNationality;
            selectedPlayerLabel.PlayerOverall = selectedPlayerLabel.CalculateOverall(playerOverall, playerPosition);
            selectedPlayerLabel.PlayerPrice = playerPrice;
            selectedPlayerLabel.PlayerChemistry = 0;

            UpdatePlayersChemistry();
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
