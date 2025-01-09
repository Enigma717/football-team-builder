using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace TeamBuilder
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private const string NOT_SELECTED_ITEM = "<brak>";
        private const string DEFAULT_QUERY = "SELECT * FROM Players";

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxFormation = new System.Windows.Forms.ComboBox();
            this.buttonSaveSquad = new System.Windows.Forms.Button();
            this.buttonLoadSquad = new System.Windows.Forms.Button();
            this.buttonResetSquad = new System.Windows.Forms.Button();
            this.textBoxPlayer = new System.Windows.Forms.TextBox();
            this.buttonResetFilters = new System.Windows.Forms.Button();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.numericUpDownMinPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.ButtonAddPlayer = new System.Windows.Forms.Button();
            this.ButtonDeletePlayer = new System.Windows.Forms.Button();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.groupBoxTeam = new System.Windows.Forms.GroupBox();
            this.labelPlayer11 = new TeamBuilder.PlayerLabel();
            this.labelPlayer10 = new TeamBuilder.PlayerLabel();
            this.labelPlayer9 = new TeamBuilder.PlayerLabel();
            this.labelPlayer8 = new TeamBuilder.PlayerLabel();
            this.labelPlayer7 = new TeamBuilder.PlayerLabel();
            this.labelPlayer6 = new TeamBuilder.PlayerLabel();
            this.labelPlayer5 = new TeamBuilder.PlayerLabel();
            this.labelPlayer4 = new TeamBuilder.PlayerLabel();
            this.labelPlayer3 = new TeamBuilder.PlayerLabel();
            this.labelPlayer2 = new TeamBuilder.PlayerLabel();
            this.labelPlayer1 = new TeamBuilder.PlayerLabel();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelLeague = new System.Windows.Forms.Label();
            this.labelClub = new System.Windows.Forms.Label();
            this.labelOverall = new System.Windows.Forms.Label();
            this.labelChemistry = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelFormation = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.labelPriceValue = new System.Windows.Forms.Label();
            this.labelChemistryValue = new System.Windows.Forms.Label();
            this.labelOverallValue = new System.Windows.Forms.Label();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.comboBoxLeague = new System.Windows.Forms.ComboBox();
            this.comboBoxClub = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.groupBoxTeam.SuspendLayout();
            this.groupBoxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(324, 19);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(313, 55);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "SquadBuilder";
            // 
            // comboBoxFormation
            // 
            this.comboBoxFormation.AllowDrop = true;
            this.comboBoxFormation.AutoCompleteCustomSource.AddRange(new string[] {
            "4-3-3",
            "4-4-2",
            "3-5-2-1"});
            this.comboBoxFormation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxFormation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFormation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxFormation.FormattingEnabled = true;
            this.comboBoxFormation.Items.AddRange(new object[] {
            "4-3-3",
            "4-4-2",
            "3-5-2-1"});
            this.comboBoxFormation.Location = new System.Drawing.Point(27, 97);
            this.comboBoxFormation.Name = "comboBoxFormation";
            this.comboBoxFormation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxFormation.Size = new System.Drawing.Size(180, 40);
            this.comboBoxFormation.TabIndex = 1;
            // 
            // buttonSaveSquad
            // 
            this.buttonSaveSquad.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSaveSquad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveSquad.Location = new System.Drawing.Point(36, 152);
            this.buttonSaveSquad.Name = "buttonSaveSquad";
            this.buttonSaveSquad.Size = new System.Drawing.Size(163, 55);
            this.buttonSaveSquad.TabIndex = 2;
            this.buttonSaveSquad.Text = "Zapisz";
            this.buttonSaveSquad.UseVisualStyleBackColor = false;
            // 
            // buttonLoadSquad
            // 
            this.buttonLoadSquad.BackColor = System.Drawing.Color.DarkGray;
            this.buttonLoadSquad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoadSquad.Location = new System.Drawing.Point(36, 216);
            this.buttonLoadSquad.Name = "buttonLoadSquad";
            this.buttonLoadSquad.Size = new System.Drawing.Size(163, 53);
            this.buttonLoadSquad.TabIndex = 3;
            this.buttonLoadSquad.Text = "Wczytaj";
            this.buttonLoadSquad.UseVisualStyleBackColor = false;
            // 
            // buttonResetSquad
            // 
            this.buttonResetSquad.BackColor = System.Drawing.Color.DarkGray;
            this.buttonResetSquad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonResetSquad.Location = new System.Drawing.Point(36, 275);
            this.buttonResetSquad.Name = "buttonResetSquad";
            this.buttonResetSquad.Size = new System.Drawing.Size(163, 53);
            this.buttonResetSquad.TabIndex = 4;
            this.buttonResetSquad.Text = "Reset";
            this.buttonResetSquad.UseVisualStyleBackColor = false;
            this.buttonResetSquad.Click += new System.EventHandler(this.buttonResetSquad_Click);
            // 
            // textBoxPlayer
            // 
            this.textBoxPlayer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPlayer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPlayer.Location = new System.Drawing.Point(866, 47);
            this.textBoxPlayer.Name = "textBoxPlayer";
            this.textBoxPlayer.Size = new System.Drawing.Size(416, 35);
            this.textBoxPlayer.TabIndex = 5;
            // 
            // buttonResetFilters
            // 
            this.buttonResetFilters.BackColor = System.Drawing.Color.DarkGray;
            this.buttonResetFilters.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonResetFilters.Location = new System.Drawing.Point(1116, 286);
            this.buttonResetFilters.Name = "buttonResetFilters";
            this.buttonResetFilters.Size = new System.Drawing.Size(217, 51);
            this.buttonResetFilters.TabIndex = 6;
            this.buttonResetFilters.Text = "Reset";
            this.buttonResetFilters.UseVisualStyleBackColor = false;
            this.buttonResetFilters.Click += new System.EventHandler(this.ButtonResetFilters_Click);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(797, 126);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(154, 29);
            this.comboBoxPosition.TabIndex = 7;
            // 
            // numericUpDownMinPrice
            // 
            this.numericUpDownMinPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownMinPrice.Location = new System.Drawing.Point(995, 125);
            this.numericUpDownMinPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownMinPrice.Name = "numericUpDownMinPrice";
            this.numericUpDownMinPrice.Size = new System.Drawing.Size(149, 35);
            this.numericUpDownMinPrice.TabIndex = 8;
            // 
            // numericUpDownMaxPrice
            // 
            this.numericUpDownMaxPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownMaxPrice.Location = new System.Drawing.Point(1185, 125);
            this.numericUpDownMaxPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownMaxPrice.Name = "numericUpDownMaxPrice";
            this.numericUpDownMaxPrice.Size = new System.Drawing.Size(148, 35);
            this.numericUpDownMaxPrice.TabIndex = 9;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosition.ForeColor = System.Drawing.Color.Black;
            this.labelPosition.Location = new System.Drawing.Point(837, 98);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(75, 25);
            this.labelPosition.TabIndex = 10;
            this.labelPosition.Text = "Pozycja";
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinPrice.ForeColor = System.Drawing.Color.Black;
            this.labelMinPrice.Location = new System.Drawing.Point(1025, 97);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(92, 25);
            this.labelMinPrice.TabIndex = 11;
            this.labelMinPrice.Text = "Cena min";
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMaxPrice.ForeColor = System.Drawing.Color.Black;
            this.labelMaxPrice.Location = new System.Drawing.Point(1208, 98);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(95, 25);
            this.labelMaxPrice.TabIndex = 12;
            this.labelMaxPrice.Text = "Cena max";
            // 
            // ButtonAddPlayer
            // 
            this.ButtonAddPlayer.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonAddPlayer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAddPlayer.Location = new System.Drawing.Point(27, 619);
            this.ButtonAddPlayer.Name = "ButtonAddPlayer";
            this.ButtonAddPlayer.Size = new System.Drawing.Size(194, 61);
            this.ButtonAddPlayer.TabIndex = 16;
            this.ButtonAddPlayer.Text = "Dodaj gracza";
            this.ButtonAddPlayer.UseVisualStyleBackColor = false;
            this.ButtonAddPlayer.Click += new System.EventHandler(this.ButtonAddPlayer_Click);
            // 
            // ButtonDeletePlayer
            // 
            this.ButtonDeletePlayer.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonDeletePlayer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonDeletePlayer.Location = new System.Drawing.Point(27, 695);
            this.ButtonDeletePlayer.Name = "ButtonDeletePlayer";
            this.ButtonDeletePlayer.Size = new System.Drawing.Size(194, 58);
            this.ButtonDeletePlayer.TabIndex = 17;
            this.ButtonDeletePlayer.Text = "Usuń Gracza";
            this.ButtonDeletePlayer.UseVisualStyleBackColor = false;
            this.ButtonDeletePlayer.Click += new System.EventHandler(this.ButtonDeletePlayer_Click);
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.AllowUserToAddRows = false;
            this.dataGridViewPlayers.AllowUserToDeleteRows = false;
            this.dataGridViewPlayers.AllowUserToResizeRows = false;
            this.dataGridViewPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPlayers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(756, 382);
            this.dataGridViewPlayers.MultiSelect = false;
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.ReadOnly = true;
            this.dataGridViewPlayers.RowHeadersVisible = false;
            this.dataGridViewPlayers.RowHeadersWidth = 20;
            this.dataGridViewPlayers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(633, 407);
            this.dataGridViewPlayers.TabIndex = 19;
            // 
            // groupBoxTeam
            // 
            this.groupBoxTeam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxTeam.BackgroundImage")));
            this.groupBoxTeam.Controls.Add(this.labelPlayer11);
            this.groupBoxTeam.Controls.Add(this.labelPlayer10);
            this.groupBoxTeam.Controls.Add(this.labelPlayer9);
            this.groupBoxTeam.Controls.Add(this.labelPlayer8);
            this.groupBoxTeam.Controls.Add(this.labelPlayer7);
            this.groupBoxTeam.Controls.Add(this.labelPlayer6);
            this.groupBoxTeam.Controls.Add(this.labelPlayer5);
            this.groupBoxTeam.Controls.Add(this.labelPlayer4);
            this.groupBoxTeam.Controls.Add(this.labelPlayer3);
            this.groupBoxTeam.Controls.Add(this.labelPlayer2);
            this.groupBoxTeam.Controls.Add(this.labelPlayer1);
            this.groupBoxTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxTeam.Location = new System.Drawing.Point(236, 91);
            this.groupBoxTeam.Name = "groupBoxTeam";
            this.groupBoxTeam.Size = new System.Drawing.Size(500, 698);
            this.groupBoxTeam.TabIndex = 20;
            this.groupBoxTeam.TabStop = false;
            this.groupBoxTeam.Text = "Mój Skład";
            // 
            // labelPlayer11
            // 
            this.labelPlayer11.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer11.DefaultText = null;
            this.labelPlayer11.Location = new System.Drawing.Point(24, 184);
            this.labelPlayer11.Name = "labelPlayer11";
            this.labelPlayer11.PlayerChemistry = 0;
            this.labelPlayer11.PlayerClub = null;
            this.labelPlayer11.PlayerLeague = null;
            this.labelPlayer11.PlayerName = null;
            this.labelPlayer11.PlayerNationality = null;
            this.labelPlayer11.PlayerOverall = 0;
            this.labelPlayer11.PlayerPosition = null;
            this.labelPlayer11.PlayerPrice = 0;
            this.labelPlayer11.Size = new System.Drawing.Size(234, 26);
            this.labelPlayer11.TabIndex = 10;
            this.labelPlayer11.Text = "ATT";
            this.labelPlayer11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayer11.Click += new System.EventHandler(this.labelPlayer11_Click);
            // 
            // labelPlayer10
            // 
            this.labelPlayer10.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer10.DefaultText = null;
            this.labelPlayer10.Location = new System.Drawing.Point(260, 184);
            this.labelPlayer10.Name = "labelPlayer10";
            this.labelPlayer10.PlayerChemistry = 0;
            this.labelPlayer10.PlayerClub = null;
            this.labelPlayer10.PlayerLeague = null;
            this.labelPlayer10.PlayerName = null;
            this.labelPlayer10.PlayerNationality = null;
            this.labelPlayer10.PlayerOverall = 0;
            this.labelPlayer10.PlayerPosition = null;
            this.labelPlayer10.PlayerPrice = 0;
            this.labelPlayer10.Size = new System.Drawing.Size(234, 26);
            this.labelPlayer10.TabIndex = 9;
            this.labelPlayer10.Text = "ATT";
            this.labelPlayer10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayer10.Click += new System.EventHandler(this.labelPlayer10_Click);
            // 
            // labelPlayer9
            // 
            this.labelPlayer9.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer9.DefaultText = null;
            this.labelPlayer9.Location = new System.Drawing.Point(129, 116);
            this.labelPlayer9.Name = "labelPlayer9";
            this.labelPlayer9.PlayerChemistry = 0;
            this.labelPlayer9.PlayerClub = "";
            this.labelPlayer9.PlayerLeague = null;
            this.labelPlayer9.PlayerName = null;
            this.labelPlayer9.PlayerNationality = null;
            this.labelPlayer9.PlayerOverall = 0;
            this.labelPlayer9.PlayerPosition = null;
            this.labelPlayer9.PlayerPrice = 0;
            this.labelPlayer9.Size = new System.Drawing.Size(234, 26);
            this.labelPlayer9.TabIndex = 8;
            this.labelPlayer9.Text = "ATT";
            this.labelPlayer9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayer9.Click += new System.EventHandler(this.labelPlayer9_Click);
            // 
            // labelPlayer8
            // 
            this.labelPlayer8.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer8.DefaultText = null;
            this.labelPlayer8.Location = new System.Drawing.Point(24, 325);
            this.labelPlayer8.Name = "labelPlayer8";
            this.labelPlayer8.PlayerChemistry = 0;
            this.labelPlayer8.PlayerClub = null;
            this.labelPlayer8.PlayerLeague = null;
            this.labelPlayer8.PlayerName = null;
            this.labelPlayer8.PlayerNationality = null;
            this.labelPlayer8.PlayerOverall = 0;
            this.labelPlayer8.PlayerPosition = null;
            this.labelPlayer8.PlayerPrice = 0;
            this.labelPlayer8.Size = new System.Drawing.Size(234, 26);
            this.labelPlayer8.TabIndex = 7;
            this.labelPlayer8.Text = "MID";
            this.labelPlayer8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayer8.Click += new System.EventHandler(this.labelPlayer8_Click);
            // 
            // labelPlayer7
            // 
            this.labelPlayer7.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer7.DefaultText = null;
            this.labelPlayer7.Location = new System.Drawing.Point(138, 395);
            this.labelPlayer7.Name = "labelPlayer7";
            this.labelPlayer7.PlayerChemistry = 0;
            this.labelPlayer7.PlayerClub = null;
            this.labelPlayer7.PlayerLeague = null;
            this.labelPlayer7.PlayerName = null;
            this.labelPlayer7.PlayerNationality = null;
            this.labelPlayer7.PlayerOverall = 0;
            this.labelPlayer7.PlayerPosition = null;
            this.labelPlayer7.PlayerPrice = 0;
            this.labelPlayer7.Size = new System.Drawing.Size(234, 26);
            this.labelPlayer7.TabIndex = 6;
            this.labelPlayer7.Text = "MID";
            this.labelPlayer7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayer7.Click += new System.EventHandler(this.labelPlayer7_Click);
            // 
            // labelPlayer6
            // 
            this.labelPlayer6.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer6.DefaultText = null;
            this.labelPlayer6.Location = new System.Drawing.Point(266, 326);
            this.labelPlayer6.Name = "labelPlayer6";
            this.labelPlayer6.PlayerChemistry = 0;
            this.labelPlayer6.PlayerClub = null;
            this.labelPlayer6.PlayerLeague = null;
            this.labelPlayer6.PlayerName = null;
            this.labelPlayer6.PlayerNationality = null;
            this.labelPlayer6.PlayerOverall = 0;
            this.labelPlayer6.PlayerPosition = null;
            this.labelPlayer6.PlayerPrice = 0;
            this.labelPlayer6.Size = new System.Drawing.Size(234, 26);
            this.labelPlayer6.TabIndex = 5;
            this.labelPlayer6.Text = "MID";
            this.labelPlayer6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayer6.Click += new System.EventHandler(this.labelPlayer6_Click);
            // 
            // labelPlayer5
            // 
            this.labelPlayer5.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer5.DefaultText = null;
            this.labelPlayer5.Location = new System.Drawing.Point(6, 481);
            this.labelPlayer5.Name = "labelPlayer5";
            this.labelPlayer5.PlayerChemistry = 0;
            this.labelPlayer5.PlayerClub = null;
            this.labelPlayer5.PlayerLeague = null;
            this.labelPlayer5.PlayerName = null;
            this.labelPlayer5.PlayerNationality = null;
            this.labelPlayer5.PlayerOverall = 0;
            this.labelPlayer5.PlayerPosition = null;
            this.labelPlayer5.PlayerPrice = 0;
            this.labelPlayer5.Size = new System.Drawing.Size(234, 26);
            this.labelPlayer5.TabIndex = 4;
            this.labelPlayer5.Text = "DEF";
            this.labelPlayer5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayer5.Click += new System.EventHandler(this.labelPlayer5_Click);
            // 
            // labelPlayer4
            // 
            this.labelPlayer4.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer4.DefaultText = null;
            this.labelPlayer4.Location = new System.Drawing.Point(38, 555);
            this.labelPlayer4.Name = "labelPlayer4";
            this.labelPlayer4.PlayerChemistry = 0;
            this.labelPlayer4.PlayerClub = null;
            this.labelPlayer4.PlayerLeague = null;
            this.labelPlayer4.PlayerName = null;
            this.labelPlayer4.PlayerNationality = null;
            this.labelPlayer4.PlayerOverall = 0;
            this.labelPlayer4.PlayerPosition = null;
            this.labelPlayer4.PlayerPrice = 0;
            this.labelPlayer4.Size = new System.Drawing.Size(234, 26);
            this.labelPlayer4.TabIndex = 3;
            this.labelPlayer4.Text = "DEF";
            this.labelPlayer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayer4.Click += new System.EventHandler(this.labelPlayer4_Click);
            // 
            // labelPlayer3
            // 
            this.labelPlayer3.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer3.DefaultText = null;
            this.labelPlayer3.Location = new System.Drawing.Point(243, 555);
            this.labelPlayer3.Name = "labelPlayer3";
            this.labelPlayer3.PlayerChemistry = 0;
            this.labelPlayer3.PlayerClub = null;
            this.labelPlayer3.PlayerLeague = null;
            this.labelPlayer3.PlayerName = null;
            this.labelPlayer3.PlayerNationality = null;
            this.labelPlayer3.PlayerOverall = 0;
            this.labelPlayer3.PlayerPosition = null;
            this.labelPlayer3.PlayerPrice = 0;
            this.labelPlayer3.Size = new System.Drawing.Size(234, 26);
            this.labelPlayer3.TabIndex = 2;
            this.labelPlayer3.Text = "DEF";
            this.labelPlayer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayer3.Click += new System.EventHandler(this.labelPlayer3_Click);
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2.DefaultText = null;
            this.labelPlayer2.Location = new System.Drawing.Point(266, 481);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.PlayerChemistry = 0;
            this.labelPlayer2.PlayerClub = null;
            this.labelPlayer2.PlayerLeague = null;
            this.labelPlayer2.PlayerName = null;
            this.labelPlayer2.PlayerNationality = null;
            this.labelPlayer2.PlayerOverall = 0;
            this.labelPlayer2.PlayerPosition = null;
            this.labelPlayer2.PlayerPrice = 0;
            this.labelPlayer2.Size = new System.Drawing.Size(234, 26);
            this.labelPlayer2.TabIndex = 1;
            this.labelPlayer2.Text = "DEF";
            this.labelPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayer2.Click += new System.EventHandler(this.labelPlayer2_Click);
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1.DefaultText = null;
            this.labelPlayer1.Location = new System.Drawing.Point(138, 636);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.PlayerChemistry = 0;
            this.labelPlayer1.PlayerClub = null;
            this.labelPlayer1.PlayerLeague = null;
            this.labelPlayer1.PlayerName = null;
            this.labelPlayer1.PlayerNationality = null;
            this.labelPlayer1.PlayerOverall = 0;
            this.labelPlayer1.PlayerPosition = null;
            this.labelPlayer1.PlayerPrice = 0;
            this.labelPlayer1.Size = new System.Drawing.Size(234, 26);
            this.labelPlayer1.TabIndex = 0;
            this.labelPlayer1.Text = "GK";
            this.labelPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayer1.Click += new System.EventHandler(this.LabelPlayer1_Click);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCountry.ForeColor = System.Drawing.Color.Black;
            this.labelCountry.Location = new System.Drawing.Point(912, 169);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(45, 25);
            this.labelCountry.TabIndex = 28;
            this.labelCountry.Text = "Kraj";
            // 
            // labelLeague
            // 
            this.labelLeague.AutoSize = true;
            this.labelLeague.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLeague.ForeColor = System.Drawing.Color.Black;
            this.labelLeague.Location = new System.Drawing.Point(912, 232);
            this.labelLeague.Name = "labelLeague";
            this.labelLeague.Size = new System.Drawing.Size(47, 25);
            this.labelLeague.TabIndex = 29;
            this.labelLeague.Text = "Liga";
            // 
            // labelClub
            // 
            this.labelClub.AutoSize = true;
            this.labelClub.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClub.ForeColor = System.Drawing.Color.Black;
            this.labelClub.Location = new System.Drawing.Point(912, 291);
            this.labelClub.Name = "labelClub";
            this.labelClub.Size = new System.Drawing.Size(50, 25);
            this.labelClub.TabIndex = 30;
            this.labelClub.Text = "Klub";
            // 
            // labelOverall
            // 
            this.labelOverall.AutoSize = true;
            this.labelOverall.BackColor = System.Drawing.Color.Transparent;
            this.labelOverall.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOverall.ForeColor = System.Drawing.Color.Black;
            this.labelOverall.Location = new System.Drawing.Point(12, 35);
            this.labelOverall.Name = "labelOverall";
            this.labelOverall.Size = new System.Drawing.Size(72, 25);
            this.labelOverall.TabIndex = 31;
            this.labelOverall.Text = "Overall";
            // 
            // labelChemistry
            // 
            this.labelChemistry.AutoSize = true;
            this.labelChemistry.BackColor = System.Drawing.Color.Transparent;
            this.labelChemistry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChemistry.ForeColor = System.Drawing.Color.Black;
            this.labelChemistry.Location = new System.Drawing.Point(9, 81);
            this.labelChemistry.Name = "labelChemistry";
            this.labelChemistry.Size = new System.Drawing.Size(77, 25);
            this.labelChemistry.TabIndex = 32;
            this.labelChemistry.Text = "Zgranie";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.ForeColor = System.Drawing.Color.Black;
            this.labelPrice.Location = new System.Drawing.Point(12, 127);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(55, 25);
            this.labelPrice.TabIndex = 33;
            this.labelPrice.Text = "Cena";
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.DarkGray;
            this.buttonFilter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFilter.Location = new System.Drawing.Point(1116, 207);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(217, 50);
            this.buttonFilter.TabIndex = 34;
            this.buttonFilter.Text = "Filtruj";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // labelFormation
            // 
            this.labelFormation.AutoSize = true;
            this.labelFormation.BackColor = System.Drawing.Color.Transparent;
            this.labelFormation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFormation.ForeColor = System.Drawing.Color.Black;
            this.labelFormation.Location = new System.Drawing.Point(71, 69);
            this.labelFormation.Name = "labelFormation";
            this.labelFormation.Size = new System.Drawing.Size(89, 25);
            this.labelFormation.TabIndex = 35;
            this.labelFormation.Text = "Formacja";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSearch.ForeColor = System.Drawing.Color.Black;
            this.labelSearch.Location = new System.Drawing.Point(1007, 19);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(131, 25);
            this.labelSearch.TabIndex = 36;
            this.labelSearch.Text = "Wyszukiwanie";
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.BackColor = System.Drawing.Color.Gray;
            this.groupBoxStats.Controls.Add(this.labelPriceValue);
            this.groupBoxStats.Controls.Add(this.labelChemistryValue);
            this.groupBoxStats.Controls.Add(this.labelOverallValue);
            this.groupBoxStats.Controls.Add(this.labelPrice);
            this.groupBoxStats.Controls.Add(this.labelChemistry);
            this.groupBoxStats.Controls.Add(this.labelOverall);
            this.groupBoxStats.Location = new System.Drawing.Point(17, 382);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(201, 184);
            this.groupBoxStats.TabIndex = 37;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Statystyki drużyny";
            // 
            // labelPriceValue
            // 
            this.labelPriceValue.AutoSize = true;
            this.labelPriceValue.BackColor = System.Drawing.Color.Transparent;
            this.labelPriceValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPriceValue.ForeColor = System.Drawing.Color.Black;
            this.labelPriceValue.Location = new System.Drawing.Point(90, 127);
            this.labelPriceValue.Name = "labelPriceValue";
            this.labelPriceValue.Size = new System.Drawing.Size(22, 25);
            this.labelPriceValue.TabIndex = 36;
            this.labelPriceValue.Text = "0";
            // 
            // labelChemistryValue
            // 
            this.labelChemistryValue.AutoSize = true;
            this.labelChemistryValue.BackColor = System.Drawing.Color.Transparent;
            this.labelChemistryValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChemistryValue.ForeColor = System.Drawing.Color.Black;
            this.labelChemistryValue.Location = new System.Drawing.Point(90, 81);
            this.labelChemistryValue.Name = "labelChemistryValue";
            this.labelChemistryValue.Size = new System.Drawing.Size(22, 25);
            this.labelChemistryValue.TabIndex = 35;
            this.labelChemistryValue.Text = "0";
            // 
            // labelOverallValue
            // 
            this.labelOverallValue.AutoSize = true;
            this.labelOverallValue.BackColor = System.Drawing.Color.Transparent;
            this.labelOverallValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOverallValue.ForeColor = System.Drawing.Color.Black;
            this.labelOverallValue.Location = new System.Drawing.Point(90, 35);
            this.labelOverallValue.Name = "labelOverallValue";
            this.labelOverallValue.Size = new System.Drawing.Size(22, 25);
            this.labelOverallValue.TabIndex = 34;
            this.labelOverallValue.Text = "0";
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNationality.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Items.AddRange(new object[] {
            "GK",
            "DEF",
            "MID",
            "ATT"});
            this.comboBoxNationality.Location = new System.Drawing.Point(797, 197);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(280, 29);
            this.comboBoxNationality.TabIndex = 38;
            // 
            // comboBoxLeague
            // 
            this.comboBoxLeague.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeague.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxLeague.FormattingEnabled = true;
            this.comboBoxLeague.Items.AddRange(new object[] {
            "GK",
            "DEF",
            "MID",
            "ATT"});
            this.comboBoxLeague.Location = new System.Drawing.Point(797, 259);
            this.comboBoxLeague.Name = "comboBoxLeague";
            this.comboBoxLeague.Size = new System.Drawing.Size(280, 29);
            this.comboBoxLeague.TabIndex = 39;
            // 
            // comboBoxClub
            // 
            this.comboBoxClub.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxClub.FormattingEnabled = true;
            this.comboBoxClub.Items.AddRange(new object[] {
            "GK",
            "DEF",
            "MID",
            "ATT"});
            this.comboBoxClub.Location = new System.Drawing.Point(797, 318);
            this.comboBoxClub.Name = "comboBoxClub";
            this.comboBoxClub.Size = new System.Drawing.Size(280, 29);
            this.comboBoxClub.TabIndex = 40;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1418, 818);
            this.Controls.Add(this.comboBoxClub);
            this.Controls.Add(this.comboBoxLeague);
            this.Controls.Add(this.comboBoxNationality);
            this.Controls.Add(this.groupBoxStats);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelFormation);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.labelClub);
            this.Controls.Add(this.labelLeague);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.groupBoxTeam);
            this.Controls.Add(this.dataGridViewPlayers);
            this.Controls.Add(this.ButtonDeletePlayer);
            this.Controls.Add(this.ButtonAddPlayer);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.labelMinPrice);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.numericUpDownMaxPrice);
            this.Controls.Add(this.numericUpDownMinPrice);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.buttonResetFilters);
            this.Controls.Add(this.textBoxPlayer);
            this.Controls.Add(this.buttonResetSquad);
            this.Controls.Add(this.buttonLoadSquad);
            this.Controls.Add(this.buttonSaveSquad);
            this.Controls.Add(this.comboBoxFormation);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Builder";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.groupBoxTeam.ResumeLayout(false);
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private ComboBox comboBoxFormation;
        private Button buttonSaveSquad;
        private Button buttonLoadSquad;
        private Button buttonResetSquad;
        private TextBox textBoxPlayer;
        private Button buttonResetFilters;
        private ComboBox comboBoxPosition;
        private NumericUpDown numericUpDownMinPrice;
        private NumericUpDown numericUpDownMaxPrice;
        private Label labelPosition;
        private Label labelMinPrice;
        private Label labelMaxPrice;
        private Button ButtonAddPlayer;
        private Button ButtonDeletePlayer;
        private DataGridView dataGridViewPlayers;
        private GroupBox groupBoxTeam;
        private PlayerLabel labelPlayer11;
        private PlayerLabel labelPlayer10;
        private PlayerLabel labelPlayer9;
        private PlayerLabel labelPlayer8;
        private PlayerLabel labelPlayer7;
        private PlayerLabel labelPlayer6;
        private PlayerLabel labelPlayer5;
        private PlayerLabel labelPlayer4;
        private PlayerLabel labelPlayer3;
        private PlayerLabel labelPlayer2;
        private PlayerLabel labelPlayer1;
        private Label labelCountry;
        private Label labelLeague;
        private Label labelClub;
        private Label labelOverall;
        private Label labelChemistry;
        private Label labelPrice;
        private Button buttonFilter;
        private Label labelFormation;
        private Label labelSearch;
        private GroupBox groupBoxStats;
        private ComboBox comboBoxNationality;
        private ComboBox comboBoxLeague;
        private ComboBox comboBoxClub;
        private Label labelPriceValue;
        private Label labelChemistryValue;
        private Label labelOverallValue;

        private PlayerLabel selectedPlayerLabel;
        private List<PlayerLabel> players;
        private List<IComponent> filteringComponents;

        private DatabaseHandler databaseHandler;
        private DataSet databaseDataset;
    }
}
