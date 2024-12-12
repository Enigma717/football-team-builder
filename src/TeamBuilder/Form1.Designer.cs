using System.Data;
using System.Windows.Forms;

namespace TeamBuilder
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ComboBoxFormation = new System.Windows.Forms.ComboBox();
            this.ButtonSaveSquad = new System.Windows.Forms.Button();
            this.ButtonLoadSquad = new System.Windows.Forms.Button();
            this.ButtonResetSquad = new System.Windows.Forms.Button();
            this.TextBoxPlayer = new System.Windows.Forms.TextBox();
            this.ButtonResetFilters = new System.Windows.Forms.Button();
            this.ComboBoxPosition = new System.Windows.Forms.ComboBox();
            this.NumericUpDownMinPrice = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.LabelPosition = new System.Windows.Forms.Label();
            this.LabelMinPrice = new System.Windows.Forms.Label();
            this.LabelMaxPrice = new System.Windows.Forms.Label();
            this.TextBoxCountry = new System.Windows.Forms.TextBox();
            this.TextBoxLeague = new System.Windows.Forms.TextBox();
            this.TextBoxClub = new System.Windows.Forms.TextBox();
            this.ButtonAddPlayer = new System.Windows.Forms.Button();
            this.ButtonDeletePlayer = new System.Windows.Forms.Button();
            this.DataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.GroupBoxTeam = new System.Windows.Forms.GroupBox();
            this.LabelPlayer11 = new System.Windows.Forms.Label();
            this.LabelPlayer10 = new System.Windows.Forms.Label();
            this.LabelPlayer9 = new System.Windows.Forms.Label();
            this.LabelPlayer8 = new System.Windows.Forms.Label();
            this.LabelPlayer7 = new System.Windows.Forms.Label();
            this.LabelPlayer6 = new System.Windows.Forms.Label();
            this.LabelPlayer5 = new System.Windows.Forms.Label();
            this.LabelPlayer4 = new System.Windows.Forms.Label();
            this.LabelPlayer3 = new System.Windows.Forms.Label();
            this.LabelPlayer2 = new System.Windows.Forms.Label();
            this.LabelPlayer1 = new System.Windows.Forms.Label();
            this.TextBoxOverall = new System.Windows.Forms.TextBox();
            this.TextBoxChemistry = new System.Windows.Forms.TextBox();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.LabelCountry = new System.Windows.Forms.Label();
            this.LabelLeague = new System.Windows.Forms.Label();
            this.LabelClub = new System.Windows.Forms.Label();
            this.LabelOverall = new System.Windows.Forms.Label();
            this.LabelChemistry = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.ButtonFilter = new System.Windows.Forms.Button();
            this.LabelFormation = new System.Windows.Forms.Label();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.GroupBoxStats = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPlayers)).BeginInit();
            this.GroupBoxTeam.SuspendLayout();
            this.GroupBoxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.Font = new System.Drawing.Font("ROG Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(237, 10);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(499, 58);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "SquadBuilder";
            // 
            // ComboBoxFormation
            // 
            this.ComboBoxFormation.AllowDrop = true;
            this.ComboBoxFormation.AutoCompleteCustomSource.AddRange(new string[] {
            "4-3-3",
            "4-4-2",
            "3-5-2-1"});
            this.ComboBoxFormation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ComboBoxFormation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFormation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxFormation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ComboBoxFormation.FormattingEnabled = true;
            this.ComboBoxFormation.Items.AddRange(new object[] {
            "4-3-3",
            "4-4-2",
            "3-5-2-1"});
            this.ComboBoxFormation.Location = new System.Drawing.Point(24, 97);
            this.ComboBoxFormation.Name = "ComboBoxFormation";
            this.ComboBoxFormation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboBoxFormation.Size = new System.Drawing.Size(180, 40);
            this.ComboBoxFormation.TabIndex = 1;
            // 
            // ButtonSaveSquad
            // 
            this.ButtonSaveSquad.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonSaveSquad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSaveSquad.Location = new System.Drawing.Point(33, 149);
            this.ButtonSaveSquad.Name = "ButtonSaveSquad";
            this.ButtonSaveSquad.Size = new System.Drawing.Size(163, 55);
            this.ButtonSaveSquad.TabIndex = 2;
            this.ButtonSaveSquad.Text = "Zapisz";
            this.ButtonSaveSquad.UseVisualStyleBackColor = false;
            // 
            // ButtonLoadSquad
            // 
            this.ButtonLoadSquad.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonLoadSquad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonLoadSquad.Location = new System.Drawing.Point(33, 216);
            this.ButtonLoadSquad.Name = "ButtonLoadSquad";
            this.ButtonLoadSquad.Size = new System.Drawing.Size(163, 53);
            this.ButtonLoadSquad.TabIndex = 3;
            this.ButtonLoadSquad.Text = "Wczytaj";
            this.ButtonLoadSquad.UseVisualStyleBackColor = false;
            // 
            // ButtonResetSquad
            // 
            this.ButtonResetSquad.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonResetSquad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonResetSquad.Location = new System.Drawing.Point(33, 275);
            this.ButtonResetSquad.Name = "ButtonResetSquad";
            this.ButtonResetSquad.Size = new System.Drawing.Size(163, 62);
            this.ButtonResetSquad.TabIndex = 4;
            this.ButtonResetSquad.Text = "Reset";
            this.ButtonResetSquad.UseVisualStyleBackColor = false;
            this.ButtonResetSquad.Click += new System.EventHandler(this.ButtonResetSquad_Click);
            // 
            // TextBoxPlayer
            // 
            this.TextBoxPlayer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxPlayer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxPlayer.Location = new System.Drawing.Point(843, 56);
            this.TextBoxPlayer.Name = "TextBoxPlayer";
            this.TextBoxPlayer.Size = new System.Drawing.Size(416, 35);
            this.TextBoxPlayer.TabIndex = 5;
            // 
            // ButtonResetFilters
            // 
            this.ButtonResetFilters.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonResetFilters.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonResetFilters.Location = new System.Drawing.Point(1277, 149);
            this.ButtonResetFilters.Name = "ButtonResetFilters";
            this.ButtonResetFilters.Size = new System.Drawing.Size(134, 51);
            this.ButtonResetFilters.TabIndex = 6;
            this.ButtonResetFilters.Text = "Reset";
            this.ButtonResetFilters.UseVisualStyleBackColor = false;
            this.ButtonResetFilters.Click += new System.EventHandler(this.ButtonResetFilters_Click);
            // 
            // ComboBoxPosition
            // 
            this.ComboBoxPosition.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ComboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPosition.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxPosition.FormattingEnabled = true;
            this.ComboBoxPosition.Items.AddRange(new object[] {
            "GK",
            "DEF",
            "MID",
            "ATT"});
            this.ComboBoxPosition.Location = new System.Drawing.Point(843, 125);
            this.ComboBoxPosition.Name = "ComboBoxPosition";
            this.ComboBoxPosition.Size = new System.Drawing.Size(124, 38);
            this.ComboBoxPosition.TabIndex = 7;
            this.ComboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPosition_SelectedIndexChanged);
            // 
            // NumericUpDownMinPrice
            // 
            this.NumericUpDownMinPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumericUpDownMinPrice.Location = new System.Drawing.Point(994, 126);
            this.NumericUpDownMinPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumericUpDownMinPrice.Name = "NumericUpDownMinPrice";
            this.NumericUpDownMinPrice.Size = new System.Drawing.Size(123, 35);
            this.NumericUpDownMinPrice.TabIndex = 8;
            // 
            // NumericUpDownMaxPrice
            // 
            this.NumericUpDownMaxPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumericUpDownMaxPrice.Location = new System.Drawing.Point(1137, 126);
            this.NumericUpDownMaxPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumericUpDownMaxPrice.Name = "NumericUpDownMaxPrice";
            this.NumericUpDownMaxPrice.Size = new System.Drawing.Size(122, 35);
            this.NumericUpDownMaxPrice.TabIndex = 9;
            // 
            // LabelPosition
            // 
            this.LabelPosition.AutoSize = true;
            this.LabelPosition.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPosition.ForeColor = System.Drawing.Color.Black;
            this.LabelPosition.Location = new System.Drawing.Point(875, 97);
            this.LabelPosition.Name = "LabelPosition";
            this.LabelPosition.Size = new System.Drawing.Size(75, 25);
            this.LabelPosition.TabIndex = 10;
            this.LabelPosition.Text = "Pozycja";
            // 
            // LabelMinPrice
            // 
            this.LabelMinPrice.AutoSize = true;
            this.LabelMinPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelMinPrice.ForeColor = System.Drawing.Color.Black;
            this.LabelMinPrice.Location = new System.Drawing.Point(1009, 97);
            this.LabelMinPrice.Name = "LabelMinPrice";
            this.LabelMinPrice.Size = new System.Drawing.Size(92, 25);
            this.LabelMinPrice.TabIndex = 11;
            this.LabelMinPrice.Text = "Cena min";
            // 
            // LabelMaxPrice
            // 
            this.LabelMaxPrice.AutoSize = true;
            this.LabelMaxPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelMaxPrice.ForeColor = System.Drawing.Color.Black;
            this.LabelMaxPrice.Location = new System.Drawing.Point(1150, 98);
            this.LabelMaxPrice.Name = "LabelMaxPrice";
            this.LabelMaxPrice.Size = new System.Drawing.Size(95, 25);
            this.LabelMaxPrice.TabIndex = 12;
            this.LabelMaxPrice.Text = "Cena max";
            // 
            // TextBoxCountry
            // 
            this.TextBoxCountry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxCountry.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxCountry.Location = new System.Drawing.Point(843, 193);
            this.TextBoxCountry.Name = "TextBoxCountry";
            this.TextBoxCountry.Size = new System.Drawing.Size(124, 35);
            this.TextBoxCountry.TabIndex = 13;
            // 
            // TextBoxLeague
            // 
            this.TextBoxLeague.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxLeague.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxLeague.Location = new System.Drawing.Point(991, 193);
            this.TextBoxLeague.Name = "TextBoxLeague";
            this.TextBoxLeague.Size = new System.Drawing.Size(134, 35);
            this.TextBoxLeague.TabIndex = 14;
            // 
            // TextBoxClub
            // 
            this.TextBoxClub.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxClub.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxClub.Location = new System.Drawing.Point(1143, 193);
            this.TextBoxClub.Name = "TextBoxClub";
            this.TextBoxClub.Size = new System.Drawing.Size(116, 35);
            this.TextBoxClub.TabIndex = 15;
            this.TextBoxClub.TextChanged += new System.EventHandler(this.TextBoxClub_TextChanged);
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
            // 
            // DataGridViewPlayers
            // 
            this.DataGridViewPlayers.AllowUserToAddRows = false;
            this.DataGridViewPlayers.AllowUserToDeleteRows = false;
            this.DataGridViewPlayers.AllowUserToResizeColumns = false;
            this.DataGridViewPlayers.AllowUserToResizeRows = false;
            this.DataGridViewPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridViewPlayers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPlayers.Location = new System.Drawing.Point(756, 234);
            this.DataGridViewPlayers.MultiSelect = false;
            this.DataGridViewPlayers.Name = "DataGridViewPlayers";
            this.DataGridViewPlayers.ReadOnly = true;
            this.DataGridViewPlayers.RowHeadersVisible = false;
            this.DataGridViewPlayers.RowHeadersWidth = 20;
            this.DataGridViewPlayers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPlayers.Size = new System.Drawing.Size(633, 555);
            this.DataGridViewPlayers.TabIndex = 19;
            // 
            // GroupBoxTeam
            // 
            this.GroupBoxTeam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GroupBoxTeam.BackgroundImage")));
            this.GroupBoxTeam.Controls.Add(this.LabelPlayer11);
            this.GroupBoxTeam.Controls.Add(this.LabelPlayer10);
            this.GroupBoxTeam.Controls.Add(this.LabelPlayer9);
            this.GroupBoxTeam.Controls.Add(this.LabelPlayer8);
            this.GroupBoxTeam.Controls.Add(this.LabelPlayer7);
            this.GroupBoxTeam.Controls.Add(this.LabelPlayer6);
            this.GroupBoxTeam.Controls.Add(this.LabelPlayer5);
            this.GroupBoxTeam.Controls.Add(this.LabelPlayer4);
            this.GroupBoxTeam.Controls.Add(this.LabelPlayer3);
            this.GroupBoxTeam.Controls.Add(this.LabelPlayer2);
            this.GroupBoxTeam.Controls.Add(this.LabelPlayer1);
            this.GroupBoxTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBoxTeam.Location = new System.Drawing.Point(236, 91);
            this.GroupBoxTeam.Name = "GroupBoxTeam";
            this.GroupBoxTeam.Size = new System.Drawing.Size(500, 698);
            this.GroupBoxTeam.TabIndex = 20;
            this.GroupBoxTeam.TabStop = false;
            this.GroupBoxTeam.Text = "Mój Skład";
            // 
            // LabelPlayer11
            // 
            this.LabelPlayer11.AutoSize = true;
            this.LabelPlayer11.BackColor = System.Drawing.Color.Transparent;
            this.LabelPlayer11.Location = new System.Drawing.Point(56, 183);
            this.LabelPlayer11.Name = "LabelPlayer11";
            this.LabelPlayer11.Size = new System.Drawing.Size(51, 26);
            this.LabelPlayer11.TabIndex = 10;
            this.LabelPlayer11.Text = "ATT";
            // 
            // LabelPlayer10
            // 
            this.LabelPlayer10.AutoSize = true;
            this.LabelPlayer10.BackColor = System.Drawing.Color.Transparent;
            this.LabelPlayer10.Location = new System.Drawing.Point(345, 183);
            this.LabelPlayer10.Name = "LabelPlayer10";
            this.LabelPlayer10.Size = new System.Drawing.Size(51, 26);
            this.LabelPlayer10.TabIndex = 9;
            this.LabelPlayer10.Text = "ATT";
            this.LabelPlayer10.Click += new System.EventHandler(this.LabelPlayer10_Click);
            // 
            // LabelPlayer9
            // 
            this.LabelPlayer9.AutoSize = true;
            this.LabelPlayer9.BackColor = System.Drawing.Color.Transparent;
            this.LabelPlayer9.Location = new System.Drawing.Point(220, 109);
            this.LabelPlayer9.Name = "LabelPlayer9";
            this.LabelPlayer9.Size = new System.Drawing.Size(51, 26);
            this.LabelPlayer9.TabIndex = 8;
            this.LabelPlayer9.Text = "ATT";
            // 
            // LabelPlayer8
            // 
            this.LabelPlayer8.AutoSize = true;
            this.LabelPlayer8.BackColor = System.Drawing.Color.Transparent;
            this.LabelPlayer8.Location = new System.Drawing.Point(93, 325);
            this.LabelPlayer8.Name = "LabelPlayer8";
            this.LabelPlayer8.Size = new System.Drawing.Size(52, 26);
            this.LabelPlayer8.TabIndex = 7;
            this.LabelPlayer8.Text = "MID";
            // 
            // LabelPlayer7
            // 
            this.LabelPlayer7.AutoSize = true;
            this.LabelPlayer7.BackColor = System.Drawing.Color.Transparent;
            this.LabelPlayer7.Location = new System.Drawing.Point(220, 407);
            this.LabelPlayer7.Name = "LabelPlayer7";
            this.LabelPlayer7.Size = new System.Drawing.Size(52, 26);
            this.LabelPlayer7.TabIndex = 6;
            this.LabelPlayer7.Text = "MID";
            // 
            // LabelPlayer6
            // 
            this.LabelPlayer6.AutoSize = true;
            this.LabelPlayer6.BackColor = System.Drawing.Color.Transparent;
            this.LabelPlayer6.Location = new System.Drawing.Point(332, 325);
            this.LabelPlayer6.Name = "LabelPlayer6";
            this.LabelPlayer6.Size = new System.Drawing.Size(52, 26);
            this.LabelPlayer6.TabIndex = 5;
            this.LabelPlayer6.Text = "MID";
            this.LabelPlayer6.Click += new System.EventHandler(this.LabelPlayer6_Click);
            // 
            // LabelPlayer5
            // 
            this.LabelPlayer5.AutoSize = true;
            this.LabelPlayer5.BackColor = System.Drawing.Color.Transparent;
            this.LabelPlayer5.Location = new System.Drawing.Point(17, 519);
            this.LabelPlayer5.Name = "LabelPlayer5";
            this.LabelPlayer5.Size = new System.Drawing.Size(56, 26);
            this.LabelPlayer5.TabIndex = 4;
            this.LabelPlayer5.Text = "DEF";
            // 
            // LabelPlayer4
            // 
            this.LabelPlayer4.AutoSize = true;
            this.LabelPlayer4.BackColor = System.Drawing.Color.Transparent;
            this.LabelPlayer4.Location = new System.Drawing.Point(127, 555);
            this.LabelPlayer4.Name = "LabelPlayer4";
            this.LabelPlayer4.Size = new System.Drawing.Size(56, 26);
            this.LabelPlayer4.TabIndex = 3;
            this.LabelPlayer4.Text = "DEF";
            // 
            // LabelPlayer3
            // 
            this.LabelPlayer3.AutoSize = true;
            this.LabelPlayer3.BackColor = System.Drawing.Color.Transparent;
            this.LabelPlayer3.Location = new System.Drawing.Point(300, 555);
            this.LabelPlayer3.Name = "LabelPlayer3";
            this.LabelPlayer3.Size = new System.Drawing.Size(56, 26);
            this.LabelPlayer3.TabIndex = 2;
            this.LabelPlayer3.Text = "DEF";
            // 
            // LabelPlayer2
            // 
            this.LabelPlayer2.AutoSize = true;
            this.LabelPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.LabelPlayer2.Location = new System.Drawing.Point(414, 519);
            this.LabelPlayer2.Name = "LabelPlayer2";
            this.LabelPlayer2.Size = new System.Drawing.Size(56, 26);
            this.LabelPlayer2.TabIndex = 1;
            this.LabelPlayer2.Text = "DEF";
            this.LabelPlayer2.Click += new System.EventHandler(this.LabelPlayer2_Click);
            // 
            // LabelPlayer1
            // 
            this.LabelPlayer1.AutoSize = true;
            this.LabelPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.LabelPlayer1.Location = new System.Drawing.Point(228, 636);
            this.LabelPlayer1.Name = "LabelPlayer1";
            this.LabelPlayer1.Size = new System.Drawing.Size(44, 26);
            this.LabelPlayer1.TabIndex = 0;
            this.LabelPlayer1.Text = "GK";
            this.LabelPlayer1.Click += new System.EventHandler(this.LabelPlayer1_Click);
            // 
            // TextBoxOverall
            // 
            this.TextBoxOverall.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxOverall.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxOverall.Location = new System.Drawing.Point(92, 28);
            this.TextBoxOverall.Name = "TextBoxOverall";
            this.TextBoxOverall.Size = new System.Drawing.Size(93, 35);
            this.TextBoxOverall.TabIndex = 21;
            this.TextBoxOverall.Text = "Overall";
            // 
            // TextBoxChemistry
            // 
            this.TextBoxChemistry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxChemistry.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxChemistry.Location = new System.Drawing.Point(92, 74);
            this.TextBoxChemistry.Name = "TextBoxChemistry";
            this.TextBoxChemistry.Size = new System.Drawing.Size(93, 35);
            this.TextBoxChemistry.TabIndex = 22;
            this.TextBoxChemistry.Text = "Zgranie";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxPrice.Location = new System.Drawing.Point(92, 120);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(93, 35);
            this.TextBoxPrice.TabIndex = 23;
            this.TextBoxPrice.Text = "Cena";
            // 
            // LabelCountry
            // 
            this.LabelCountry.AutoSize = true;
            this.LabelCountry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCountry.ForeColor = System.Drawing.Color.Black;
            this.LabelCountry.Location = new System.Drawing.Point(884, 165);
            this.LabelCountry.Name = "LabelCountry";
            this.LabelCountry.Size = new System.Drawing.Size(45, 25);
            this.LabelCountry.TabIndex = 28;
            this.LabelCountry.Text = "Kraj";
            // 
            // LabelLeague
            // 
            this.LabelLeague.AutoSize = true;
            this.LabelLeague.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelLeague.ForeColor = System.Drawing.Color.Black;
            this.LabelLeague.Location = new System.Drawing.Point(1033, 164);
            this.LabelLeague.Name = "LabelLeague";
            this.LabelLeague.Size = new System.Drawing.Size(47, 25);
            this.LabelLeague.TabIndex = 29;
            this.LabelLeague.Text = "Liga";
            // 
            // LabelClub
            // 
            this.LabelClub.AutoSize = true;
            this.LabelClub.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelClub.ForeColor = System.Drawing.Color.Black;
            this.LabelClub.Location = new System.Drawing.Point(1172, 166);
            this.LabelClub.Name = "LabelClub";
            this.LabelClub.Size = new System.Drawing.Size(50, 25);
            this.LabelClub.TabIndex = 30;
            this.LabelClub.Text = "Klub";
            // 
            // LabelOverall
            // 
            this.LabelOverall.AutoSize = true;
            this.LabelOverall.BackColor = System.Drawing.Color.Transparent;
            this.LabelOverall.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelOverall.ForeColor = System.Drawing.Color.Black;
            this.LabelOverall.Location = new System.Drawing.Point(12, 35);
            this.LabelOverall.Name = "LabelOverall";
            this.LabelOverall.Size = new System.Drawing.Size(72, 25);
            this.LabelOverall.TabIndex = 31;
            this.LabelOverall.Text = "Overall";
            this.LabelOverall.Click += new System.EventHandler(this.LabelOverall_Click);
            // 
            // LabelChemistry
            // 
            this.LabelChemistry.AutoSize = true;
            this.LabelChemistry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelChemistry.ForeColor = System.Drawing.Color.Black;
            this.LabelChemistry.Location = new System.Drawing.Point(9, 81);
            this.LabelChemistry.Name = "LabelChemistry";
            this.LabelChemistry.Size = new System.Drawing.Size(77, 25);
            this.LabelChemistry.TabIndex = 32;
            this.LabelChemistry.Text = "Zgranie";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPrice.ForeColor = System.Drawing.Color.Black;
            this.LabelPrice.Location = new System.Drawing.Point(12, 127);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(55, 25);
            this.LabelPrice.TabIndex = 33;
            this.LabelPrice.Text = "Cena";
            this.LabelPrice.Click += new System.EventHandler(this.LabelPrice_Click);
            // 
            // ButtonFilter
            // 
            this.ButtonFilter.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonFilter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonFilter.Location = new System.Drawing.Point(1277, 83);
            this.ButtonFilter.Name = "ButtonFilter";
            this.ButtonFilter.Size = new System.Drawing.Size(134, 50);
            this.ButtonFilter.TabIndex = 34;
            this.ButtonFilter.Text = "Filtruj";
            this.ButtonFilter.UseVisualStyleBackColor = false;
            this.ButtonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // LabelFormation
            // 
            this.LabelFormation.AutoSize = true;
            this.LabelFormation.BackColor = System.Drawing.Color.Transparent;
            this.LabelFormation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelFormation.ForeColor = System.Drawing.Color.Black;
            this.LabelFormation.Location = new System.Drawing.Point(79, 63);
            this.LabelFormation.Name = "LabelFormation";
            this.LabelFormation.Size = new System.Drawing.Size(89, 25);
            this.LabelFormation.TabIndex = 35;
            this.LabelFormation.Text = "Formacja";
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.BackColor = System.Drawing.Color.Transparent;
            this.LabelSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSearch.ForeColor = System.Drawing.Color.Black;
            this.LabelSearch.Location = new System.Drawing.Point(994, 19);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(131, 25);
            this.LabelSearch.TabIndex = 36;
            this.LabelSearch.Text = "Wyszukiwanie";
            this.LabelSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // GroupBoxStats
            // 
            this.GroupBoxStats.BackColor = System.Drawing.Color.Gray;
            this.GroupBoxStats.Controls.Add(this.LabelPrice);
            this.GroupBoxStats.Controls.Add(this.LabelChemistry);
            this.GroupBoxStats.Controls.Add(this.LabelOverall);
            this.GroupBoxStats.Controls.Add(this.TextBoxPrice);
            this.GroupBoxStats.Controls.Add(this.TextBoxChemistry);
            this.GroupBoxStats.Controls.Add(this.TextBoxOverall);
            this.GroupBoxStats.Location = new System.Drawing.Point(24, 382);
            this.GroupBoxStats.Name = "GroupBoxStats";
            this.GroupBoxStats.Size = new System.Drawing.Size(201, 184);
            this.GroupBoxStats.TabIndex = 37;
            this.GroupBoxStats.TabStop = false;
            this.GroupBoxStats.Text = "Statystyki drużyny";
            this.GroupBoxStats.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1418, 818);
            this.Controls.Add(this.GroupBoxStats);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.LabelFormation);
            this.Controls.Add(this.ButtonFilter);
            this.Controls.Add(this.LabelClub);
            this.Controls.Add(this.LabelLeague);
            this.Controls.Add(this.LabelCountry);
            this.Controls.Add(this.GroupBoxTeam);
            this.Controls.Add(this.DataGridViewPlayers);
            this.Controls.Add(this.ButtonDeletePlayer);
            this.Controls.Add(this.ButtonAddPlayer);
            this.Controls.Add(this.TextBoxClub);
            this.Controls.Add(this.TextBoxLeague);
            this.Controls.Add(this.TextBoxCountry);
            this.Controls.Add(this.LabelMaxPrice);
            this.Controls.Add(this.LabelMinPrice);
            this.Controls.Add(this.LabelPosition);
            this.Controls.Add(this.NumericUpDownMaxPrice);
            this.Controls.Add(this.NumericUpDownMinPrice);
            this.Controls.Add(this.ComboBoxPosition);
            this.Controls.Add(this.ButtonResetFilters);
            this.Controls.Add(this.TextBoxPlayer);
            this.Controls.Add(this.ButtonResetSquad);
            this.Controls.Add(this.ButtonLoadSquad);
            this.Controls.Add(this.ButtonSaveSquad);
            this.Controls.Add(this.ComboBoxFormation);
            this.Controls.Add(this.LabelTitle);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Builder";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPlayers)).EndInit();
            this.GroupBoxTeam.ResumeLayout(false);
            this.GroupBoxTeam.PerformLayout();
            this.GroupBoxStats.ResumeLayout(false);
            this.GroupBoxStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelTitle;
        private ComboBox ComboBoxFormation;
        private Button ButtonSaveSquad;
        private Button ButtonLoadSquad;
        private Button ButtonResetSquad;
        private TextBox TextBoxPlayer;
        private Button ButtonResetFilters;
        private ComboBox ComboBoxPosition;
        private NumericUpDown NumericUpDownMinPrice;
        private NumericUpDown NumericUpDownMaxPrice;
        private Label LabelPosition;
        private Label LabelMinPrice;
        private Label LabelMaxPrice;
        private TextBox TextBoxCountry;
        private TextBox TextBoxLeague;
        private TextBox TextBoxClub;
        private Button ButtonAddPlayer;
        private Button ButtonDeletePlayer;
        private DataGridView DataGridViewPlayers;
        private GroupBox GroupBoxTeam;
        private Label LabelPlayer11;
        private Label LabelPlayer10;
        private Label LabelPlayer9;
        private Label LabelPlayer8;
        private Label LabelPlayer7;
        private Label LabelPlayer6;
        private Label LabelPlayer5;
        private Label LabelPlayer4;
        private Label LabelPlayer3;
        private Label LabelPlayer2;
        private Label LabelPlayer1;
        private TextBox TextBoxOverall;
        private TextBox TextBoxChemistry;
        private TextBox TextBoxPrice;
        private Label LabelCountry;
        private Label LabelLeague;
        private Label LabelClub;
        private Label LabelOverall;
        private Label LabelChemistry;
        private Label LabelPrice;

        private DatabaseHandler databaseHandler;
        private DataSet databaseDataset;
        private Button ButtonFilter;
        private Label LabelFormation;
        private Label LabelSearch;
        private GroupBox GroupBoxStats;
    }
}
