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
            labelTitle = new Label();
            comboBoxFormation = new ComboBox();
            buttonSave = new Button();
            buttonLoad = new Button();
            buttonResetSquad = new Button();
            textBoxPlayer = new TextBox();
            buttonResetFilters = new Button();
            comboBoxPosition = new ComboBox();
            numericUpDownMinPrice = new NumericUpDown();
            numericUpDownMaxPrice = new NumericUpDown();
            labelPosition = new Label();
            labelMinPrice = new Label();
            labelMaxPrice = new Label();
            textBoxCountry = new TextBox();
            textBoxLeague = new TextBox();
            textBoxClub = new TextBox();
            buttonAddPlayer = new Button();
            buttonDeletePlayer = new Button();
            dataGridViewPlayers = new DataGridView();
            richTextBoxStats = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("ROG Fonts", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(312, 33);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(380, 44);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "SquadBuilder";
            labelTitle.Click += label1_Click;
            // 
            // comboBoxFormation
            // 
            comboBoxFormation.BackColor = SystemColors.ControlDark;
            comboBoxFormation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormation.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            comboBoxFormation.ForeColor = SystemColors.WindowText;
            comboBoxFormation.FormattingEnabled = true;
            comboBoxFormation.Items.AddRange(new object[] { "4-3-3", "4-4-2", "3-5-2" });
            comboBoxFormation.Location = new Point(50, 86);
            comboBoxFormation.Name = "comboBoxFormation";
            comboBoxFormation.RightToLeft = RightToLeft.No;
            comboBoxFormation.Size = new Size(159, 40);
            comboBoxFormation.TabIndex = 1;
            comboBoxFormation.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.DarkGray;
            buttonSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonSave.Location = new Point(50, 132);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(159, 64);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Zapisz";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += button1_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = Color.DarkGray;
            buttonLoad.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonLoad.Location = new Point(50, 202);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(159, 64);
            buttonLoad.TabIndex = 3;
            buttonLoad.Text = "Wczytaj";
            buttonLoad.UseVisualStyleBackColor = false;
            // 
            // buttonResetSquad
            // 
            buttonResetSquad.BackColor = Color.DarkGray;
            buttonResetSquad.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonResetSquad.Location = new Point(50, 272);
            buttonResetSquad.Name = "buttonResetSquad";
            buttonResetSquad.Size = new Size(159, 64);
            buttonResetSquad.TabIndex = 4;
            buttonResetSquad.Text = "Reset";
            buttonResetSquad.UseVisualStyleBackColor = false;
            // 
            // textBoxPlayer
            // 
            textBoxPlayer.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxPlayer.ForeColor = SystemColors.ControlDarkDark;
            textBoxPlayer.Location = new Point(717, 44);
            textBoxPlayer.Name = "textBoxPlayer";
            textBoxPlayer.Size = new Size(182, 35);
            textBoxPlayer.TabIndex = 5;
            textBoxPlayer.Text = "Wpisz gracza";
            // 
            // buttonResetFilters
            // 
            buttonResetFilters.BackColor = Color.DarkGray;
            buttonResetFilters.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonResetFilters.Location = new Point(894, 45);
            buttonResetFilters.Name = "buttonResetFilters";
            buttonResetFilters.Size = new Size(110, 35);
            buttonResetFilters.TabIndex = 6;
            buttonResetFilters.Text = "Reset";
            buttonResetFilters.UseVisualStyleBackColor = false;
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.BackColor = SystemColors.ControlDark;
            comboBoxPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPosition.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Items.AddRange(new object[] { "BRA", "OBR", "POM", "NAP" });
            comboBoxPosition.Location = new Point(717, 106);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(80, 38);
            comboBoxPosition.TabIndex = 7;
            // 
            // numericUpDownMinPrice
            // 
            numericUpDownMinPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            numericUpDownMinPrice.Location = new Point(803, 106);
            numericUpDownMinPrice.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownMinPrice.Name = "numericUpDownMinPrice";
            numericUpDownMinPrice.Size = new Size(96, 35);
            numericUpDownMinPrice.TabIndex = 8;
            // 
            // numericUpDownMaxPrice
            // 
            numericUpDownMaxPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            numericUpDownMaxPrice.Location = new Point(905, 107);
            numericUpDownMaxPrice.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownMaxPrice.Name = "numericUpDownMaxPrice";
            numericUpDownMaxPrice.Size = new Size(96, 35);
            numericUpDownMaxPrice.TabIndex = 9;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPosition.Location = new Point(726, 82);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(61, 21);
            labelPosition.TabIndex = 10;
            labelPosition.Text = "Pozycja";
            // 
            // labelMinPrice
            // 
            labelMinPrice.AutoSize = true;
            labelMinPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelMinPrice.Location = new Point(793, 82);
            labelMinPrice.Name = "labelMinPrice";
            labelMinPrice.Size = new Size(113, 21);
            labelMinPrice.TabIndex = 11;
            labelMinPrice.Text = "Cena min(mln)";
            labelMinPrice.Click += label2_Click;
            // 
            // labelMaxPrice
            // 
            labelMaxPrice.AutoSize = true;
            labelMaxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelMaxPrice.Location = new Point(908, 82);
            labelMaxPrice.Name = "labelMaxPrice";
            labelMaxPrice.Size = new Size(115, 21);
            labelMaxPrice.TabIndex = 12;
            labelMaxPrice.Text = "Cena max(mln)";
            // 
            // textBoxCountry
            // 
            textBoxCountry.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxCountry.ForeColor = SystemColors.ControlDarkDark;
            textBoxCountry.Location = new Point(717, 150);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(80, 35);
            textBoxCountry.TabIndex = 13;
            textBoxCountry.Text = "Kraj";
            textBoxCountry.TextChanged += textBox1_TextChanged;
            // 
            // textBoxLeague
            // 
            textBoxLeague.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxLeague.ForeColor = SystemColors.ControlDarkDark;
            textBoxLeague.Location = new Point(803, 150);
            textBoxLeague.Name = "textBoxLeague";
            textBoxLeague.Size = new Size(96, 35);
            textBoxLeague.TabIndex = 14;
            textBoxLeague.Text = "Liga";
            // 
            // textBoxClub
            // 
            textBoxClub.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxClub.ForeColor = SystemColors.ControlDarkDark;
            textBoxClub.Location = new Point(908, 150);
            textBoxClub.Name = "textBoxClub";
            textBoxClub.Size = new Size(96, 35);
            textBoxClub.TabIndex = 15;
            textBoxClub.Text = "Klub";
            // 
            // buttonAddPlayer
            // 
            buttonAddPlayer.BackColor = Color.DarkGray;
            buttonAddPlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonAddPlayer.Location = new Point(717, 438);
            buttonAddPlayer.Name = "buttonAddPlayer";
            buttonAddPlayer.Size = new Size(130, 83);
            buttonAddPlayer.TabIndex = 16;
            buttonAddPlayer.Text = "Dodaj gracza";
            buttonAddPlayer.UseVisualStyleBackColor = false;
            // 
            // buttonDeletePlayer
            // 
            buttonDeletePlayer.BackColor = Color.DarkGray;
            buttonDeletePlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonDeletePlayer.Location = new Point(871, 438);
            buttonDeletePlayer.Name = "buttonDeletePlayer";
            buttonDeletePlayer.Size = new Size(130, 83);
            buttonDeletePlayer.TabIndex = 17;
            buttonDeletePlayer.Text = "Usuń Gracza";
            buttonDeletePlayer.UseVisualStyleBackColor = false;
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Location = new Point(717, 191);
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.Size = new Size(284, 241);
            dataGridViewPlayers.TabIndex = 19;
            dataGridViewPlayers.CellContentClick += dataGridView1_CellContentClick;
            // 
            // richTextBoxStats
            // 
            richTextBoxStats.Location = new Point(50, 342);
            richTextBoxStats.Name = "richTextBoxStats";
            richTextBoxStats.Size = new Size(159, 119);
            richTextBoxStats.TabIndex = 21;
            richTextBoxStats.Text = "Team Stats\nOverall:\nZgranie:\nCena:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1016, 533);
            Controls.Add(richTextBoxStats);
            Controls.Add(dataGridViewPlayers);
            Controls.Add(buttonDeletePlayer);
            Controls.Add(buttonAddPlayer);
            Controls.Add(textBoxClub);
            Controls.Add(textBoxLeague);
            Controls.Add(textBoxCountry);
            Controls.Add(labelMaxPrice);
            Controls.Add(labelMinPrice);
            Controls.Add(labelPosition);
            Controls.Add(numericUpDownMaxPrice);
            Controls.Add(numericUpDownMinPrice);
            Controls.Add(comboBoxPosition);
            Controls.Add(buttonResetFilters);
            Controls.Add(textBoxPlayer);
            Controls.Add(buttonResetSquad);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxFormation);
            Controls.Add(labelTitle);
            Name = "FormMain";
            Text = "Team Builder";
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private RichTextBox richTextBoxStats;
    }
}
