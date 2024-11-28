using System.Drawing;
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxFormation = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonResetSquad = new System.Windows.Forms.Button();
            this.textBoxPlayer = new System.Windows.Forms.TextBox();
            this.buttonResetFilters = new System.Windows.Forms.Button();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.numericUpDownMinPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxLeague = new System.Windows.Forms.TextBox();
            this.textBoxClub = new System.Windows.Forms.TextBox();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.buttonDeletePlayer = new System.Windows.Forms.Button();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.groupBoxTeam = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOverall = new System.Windows.Forms.TextBox();
            this.textBoxChemistry = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelLeague = new System.Windows.Forms.Label();
            this.labelClub = new System.Windows.Forms.Label();
            this.labelOverall = new System.Windows.Forms.Label();
            this.labelChemistry = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.groupBoxTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(1116, 39);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(419, 73);
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
            this.comboBoxFormation.Location = new System.Drawing.Point(12, 144);
            this.comboBoxFormation.Name = "comboBoxFormation";
            this.comboBoxFormation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxFormation.Size = new System.Drawing.Size(180, 40);
            this.comboBoxFormation.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(331, 1565);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(300, 72);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.DarkGray;
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoad.Location = new System.Drawing.Point(12, 1565);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(300, 72);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Wczytaj";
            this.buttonLoad.UseVisualStyleBackColor = false;
            // 
            // buttonResetSquad
            // 
            this.buttonResetSquad.BackColor = System.Drawing.Color.DarkGray;
            this.buttonResetSquad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonResetSquad.Location = new System.Drawing.Point(662, 1565);
            this.buttonResetSquad.Name = "buttonResetSquad";
            this.buttonResetSquad.Size = new System.Drawing.Size(300, 72);
            this.buttonResetSquad.TabIndex = 4;
            this.buttonResetSquad.Text = "Reset";
            this.buttonResetSquad.UseVisualStyleBackColor = false;
            // 
            // textBoxPlayer
            // 
            this.textBoxPlayer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPlayer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPlayer.Location = new System.Drawing.Point(986, 220);
            this.textBoxPlayer.Name = "textBoxPlayer";
            this.textBoxPlayer.Size = new System.Drawing.Size(584, 35);
            this.textBoxPlayer.TabIndex = 5;
            // 
            // buttonResetFilters
            // 
            this.buttonResetFilters.BackColor = System.Drawing.Color.DarkGray;
            this.buttonResetFilters.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonResetFilters.Location = new System.Drawing.Point(1576, 220);
            this.buttonResetFilters.Name = "buttonResetFilters";
            this.buttonResetFilters.Size = new System.Drawing.Size(250, 35);
            this.buttonResetFilters.TabIndex = 6;
            this.buttonResetFilters.Text = "Reset";
            this.buttonResetFilters.UseVisualStyleBackColor = false;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "BRA",
            "OBR",
            "POM",
            "NAP"});
            this.comboBoxPosition.Location = new System.Drawing.Point(986, 341);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(250, 38);
            this.comboBoxPosition.TabIndex = 7;
            // 
            // numericUpDownMinPrice
            // 
            this.numericUpDownMinPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownMinPrice.Location = new System.Drawing.Point(1281, 341);
            this.numericUpDownMinPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownMinPrice.Name = "numericUpDownMinPrice";
            this.numericUpDownMinPrice.Size = new System.Drawing.Size(250, 35);
            this.numericUpDownMinPrice.TabIndex = 8;
            // 
            // numericUpDownMaxPrice
            // 
            this.numericUpDownMaxPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownMaxPrice.Location = new System.Drawing.Point(1576, 341);
            this.numericUpDownMaxPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownMaxPrice.Name = "numericUpDownMaxPrice";
            this.numericUpDownMaxPrice.Size = new System.Drawing.Size(250, 35);
            this.numericUpDownMaxPrice.TabIndex = 9;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosition.ForeColor = System.Drawing.Color.White;
            this.labelPosition.Location = new System.Drawing.Point(1127, 300);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(75, 25);
            this.labelPosition.TabIndex = 10;
            this.labelPosition.Text = "Pozycja";
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinPrice.ForeColor = System.Drawing.Color.White;
            this.labelMinPrice.Location = new System.Drawing.Point(1334, 300);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(136, 25);
            this.labelMinPrice.TabIndex = 11;
            this.labelMinPrice.Text = "Cena min(mln)";
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMaxPrice.ForeColor = System.Drawing.Color.White;
            this.labelMaxPrice.Location = new System.Drawing.Point(1625, 300);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(139, 25);
            this.labelMaxPrice.TabIndex = 12;
            this.labelMaxPrice.Text = "Cena max(mln)";
            this.labelMaxPrice.Click += new System.EventHandler(this.labelMaxPrice_Click);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCountry.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxCountry.Location = new System.Drawing.Point(986, 476);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(250, 35);
            this.textBoxCountry.TabIndex = 13;
            this.textBoxCountry.Text = "kraj";
            // 
            // textBoxLeague
            // 
            this.textBoxLeague.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLeague.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxLeague.Location = new System.Drawing.Point(1281, 476);
            this.textBoxLeague.Name = "textBoxLeague";
            this.textBoxLeague.Size = new System.Drawing.Size(250, 35);
            this.textBoxLeague.TabIndex = 14;
            this.textBoxLeague.Text = "liga";
            // 
            // textBoxClub
            // 
            this.textBoxClub.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxClub.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxClub.Location = new System.Drawing.Point(1576, 476);
            this.textBoxClub.Name = "textBoxClub";
            this.textBoxClub.Size = new System.Drawing.Size(250, 35);
            this.textBoxClub.TabIndex = 15;
            this.textBoxClub.Text = "klub";
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAddPlayer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddPlayer.Location = new System.Drawing.Point(986, 1565);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(400, 72);
            this.buttonAddPlayer.TabIndex = 16;
            this.buttonAddPlayer.Text = "Dodaj gracza";
            this.buttonAddPlayer.UseVisualStyleBackColor = false;
            // 
            // buttonDeletePlayer
            // 
            this.buttonDeletePlayer.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDeletePlayer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeletePlayer.Location = new System.Drawing.Point(1426, 1565);
            this.buttonDeletePlayer.Name = "buttonDeletePlayer";
            this.buttonDeletePlayer.Size = new System.Drawing.Size(400, 72);
            this.buttonDeletePlayer.TabIndex = 17;
            this.buttonDeletePlayer.Text = "Usuń Gracza";
            this.buttonDeletePlayer.UseVisualStyleBackColor = false;
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(986, 531);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowHeadersWidth = 62;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(840, 1000);
            this.dataGridViewPlayers.TabIndex = 19;
            // 
            // groupBoxTeam
            // 
            this.groupBoxTeam.BackgroundImage = global::TeamBuilder.Properties.Resources.fb;
            this.groupBoxTeam.Controls.Add(this.label11);
            this.groupBoxTeam.Controls.Add(this.label10);
            this.groupBoxTeam.Controls.Add(this.label9);
            this.groupBoxTeam.Controls.Add(this.label8);
            this.groupBoxTeam.Controls.Add(this.label7);
            this.groupBoxTeam.Controls.Add(this.label6);
            this.groupBoxTeam.Controls.Add(this.label5);
            this.groupBoxTeam.Controls.Add(this.label4);
            this.groupBoxTeam.Controls.Add(this.label3);
            this.groupBoxTeam.Controls.Add(this.label2);
            this.groupBoxTeam.Controls.Add(this.label1);
            this.groupBoxTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxTeam.Location = new System.Drawing.Point(12, 206);
            this.groupBoxTeam.Name = "groupBoxTeam";
            this.groupBoxTeam.Size = new System.Drawing.Size(950, 1325);
            this.groupBoxTeam.TabIndex = 20;
            this.groupBoxTeam.TabStop = false;
            this.groupBoxTeam.Text = "Mój Skład";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(786, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(660, 720);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 805);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 720);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(815, 1036);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 1036);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 1036);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 1036);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 1229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBoxOverall
            // 
            this.textBoxOverall.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOverall.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxOverall.Location = new System.Drawing.Point(198, 151);
            this.textBoxOverall.Name = "textBoxOverall";
            this.textBoxOverall.Size = new System.Drawing.Size(250, 35);
            this.textBoxOverall.TabIndex = 21;
            this.textBoxOverall.Text = "OverAll";
            // 
            // textBoxChemistry
            // 
            this.textBoxChemistry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxChemistry.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxChemistry.Location = new System.Drawing.Point(454, 151);
            this.textBoxChemistry.Name = "textBoxChemistry";
            this.textBoxChemistry.Size = new System.Drawing.Size(250, 35);
            this.textBoxChemistry.TabIndex = 22;
            this.textBoxChemistry.Text = "Zgranie";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPrice.Location = new System.Drawing.Point(712, 151);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(250, 35);
            this.textBoxPrice.TabIndex = 23;
            this.textBoxPrice.Text = "Cena";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCountry.ForeColor = System.Drawing.Color.White;
            this.labelCountry.Location = new System.Drawing.Point(1172, 435);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(45, 25);
            this.labelCountry.TabIndex = 28;
            this.labelCountry.Text = "Kraj";
            // 
            // labelLeague
            // 
            this.labelLeague.AutoSize = true;
            this.labelLeague.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLeague.ForeColor = System.Drawing.Color.White;
            this.labelLeague.Location = new System.Drawing.Point(1464, 435);
            this.labelLeague.Name = "labelLeague";
            this.labelLeague.Size = new System.Drawing.Size(47, 25);
            this.labelLeague.TabIndex = 29;
            this.labelLeague.Text = "Liga";
            // 
            // labelClub
            // 
            this.labelClub.AutoSize = true;
            this.labelClub.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClub.ForeColor = System.Drawing.Color.White;
            this.labelClub.Location = new System.Drawing.Point(1754, 435);
            this.labelClub.Name = "labelClub";
            this.labelClub.Size = new System.Drawing.Size(50, 25);
            this.labelClub.TabIndex = 30;
            this.labelClub.Text = "Klub";
            // 
            // labelOverall
            // 
            this.labelOverall.AutoSize = true;
            this.labelOverall.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOverall.ForeColor = System.Drawing.Color.White;
            this.labelOverall.Location = new System.Drawing.Point(340, 110);
            this.labelOverall.Name = "labelOverall";
            this.labelOverall.Size = new System.Drawing.Size(74, 25);
            this.labelOverall.TabIndex = 31;
            this.labelOverall.Text = "OverAll";
            // 
            // labelChemistry
            // 
            this.labelChemistry.AutoSize = true;
            this.labelChemistry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChemistry.ForeColor = System.Drawing.Color.White;
            this.labelChemistry.Location = new System.Drawing.Point(593, 109);
            this.labelChemistry.Name = "labelChemistry";
            this.labelChemistry.Size = new System.Drawing.Size(77, 25);
            this.labelChemistry.TabIndex = 32;
            this.labelChemistry.Text = "Zgranie";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(883, 109);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(55, 25);
            this.labelPrice.TabIndex = 33;
            this.labelPrice.Text = "Cena";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1829, -2);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(10, 1659);
            this.vScrollBar1.TabIndex = 34;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1838, 1649);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelChemistry);
            this.Controls.Add(this.labelOverall);
            this.Controls.Add(this.labelClub);
            this.Controls.Add(this.labelLeague);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxChemistry);
            this.Controls.Add(this.textBoxOverall);
            this.Controls.Add(this.groupBoxTeam);
            this.Controls.Add(this.dataGridViewPlayers);
            this.Controls.Add(this.buttonDeletePlayer);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.textBoxClub);
            this.Controls.Add(this.textBoxLeague);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.labelMinPrice);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.numericUpDownMaxPrice);
            this.Controls.Add(this.numericUpDownMinPrice);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.buttonResetFilters);
            this.Controls.Add(this.textBoxPlayer);
            this.Controls.Add(this.buttonResetSquad);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxFormation);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormMain";
            this.Text = "Team Builder";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.groupBoxTeam.ResumeLayout(false);
            this.groupBoxTeam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private ComboBox comboBoxFormation;
        private Button buttonSave;
        private Button buttonLoad;
        private Button buttonResetSquad;
        private TextBox textBoxPlayer;
        private Button buttonResetFilters;
        private ComboBox comboBoxPosition;
        private NumericUpDown numericUpDownMinPrice;
        private NumericUpDown numericUpDownMaxPrice;
        private Label labelPosition;
        private Label labelMinPrice;
        private Label labelMaxPrice;
        private TextBox textBoxCountry;
        private TextBox textBoxLeague;
        private TextBox textBoxClub;
        private Button buttonAddPlayer;
        private Button buttonDeletePlayer;
        private DataGridView dataGridViewPlayers;
        private GroupBox groupBoxTeam;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxOverall;
        private TextBox textBoxChemistry;
        private TextBox textBoxPrice;
        private Label labelCountry;
        private Label labelLeague;
        private Label labelClub;
        private Label labelOverall;
        private Label labelChemistry;
        private Label labelPrice;
        private VScrollBar vScrollBar1;
    }
}
