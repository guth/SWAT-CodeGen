namespace Code_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rankComboBox = new System.Windows.Forms.ComboBox();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.armorComboBox = new System.Windows.Forms.ComboBox();
            this.traitComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.codeDisplay = new System.Windows.Forms.TextBox();
            this.encodeButton = new System.Windows.Forms.Button();
            this.specComboBox = new System.Windows.Forms.ComboBox();
            this.talentComboBox = new System.Windows.Forms.ComboBox();
            this.medal1 = new System.Windows.Forms.CheckBox();
            this.medal3 = new System.Windows.Forms.CheckBox();
            this.medal4 = new System.Windows.Forms.CheckBox();
            this.medal5 = new System.Windows.Forms.CheckBox();
            this.medal6 = new System.Windows.Forms.CheckBox();
            this.medalsPanel = new System.Windows.Forms.Panel();
            this.medal23 = new System.Windows.Forms.RadioButton();
            this.medal22 = new System.Windows.Forms.RadioButton();
            this.medal21 = new System.Windows.Forms.RadioButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.copyButton = new System.Windows.Forms.Button();
            this.codegenNameClearButton = new System.Windows.Forms.Button();
            this.checksumLabel = new System.Windows.Forms.Label();
            this.valueListBox = new System.Windows.Forms.ListBox();
            this.rcpdButton = new System.Windows.Forms.Button();
            this.spoofButton = new System.Windows.Forms.Button();
            this.medalsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rankComboBox
            // 
            this.rankComboBox.BackColor = System.Drawing.Color.White;
            this.rankComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankComboBox.ForeColor = System.Drawing.Color.Black;
            this.rankComboBox.FormattingEnabled = true;
            this.rankComboBox.Items.AddRange(new object[] {
            "Rank 1",
            "Rank 2",
            "Rank 3",
            "Rank 4",
            "Rank 5",
            "Rank 6",
            "Rank 7",
            "Rank 8",
            "Rank 9",
            "Rank 10",
            "Rank 11",
            "Rank 12"});
            this.rankComboBox.Location = new System.Drawing.Point(11, 28);
            this.rankComboBox.MaxDropDownItems = 12;
            this.rankComboBox.Name = "rankComboBox";
            this.rankComboBox.Size = new System.Drawing.Size(126, 24);
            this.rankComboBox.TabIndex = 9;
            this.rankComboBox.Text = "-- Select Rank --";
            // 
            // classComboBox
            // 
            this.classComboBox.BackColor = System.Drawing.Color.White;
            this.classComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classComboBox.ForeColor = System.Drawing.Color.Black;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            "Field Medic",
            "Tactician",
            "Covert Sniper",
            "Pyrotechnician",
            "Demolitions",
            "Heavy Ordnance",
            "Psychologist",
            "Cyborg",
            "Maverick - Assault Rifle",
            "Maverick - Flamethrower",
            "Maverick - Sniper Rifle",
            "Maverick - Rocket Launcher",
            "Maverick - Chaingun",
            "Watchman - Laser Rifle",
            "Watchman - Gatling Laser"});
            this.classComboBox.Location = new System.Drawing.Point(10, 72);
            this.classComboBox.MaxDropDownItems = 15;
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(126, 24);
            this.classComboBox.TabIndex = 9;
            this.classComboBox.Text = "-- Select Class --";
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // armorComboBox
            // 
            this.armorComboBox.BackColor = System.Drawing.Color.White;
            this.armorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armorComboBox.ForeColor = System.Drawing.Color.Black;
            this.armorComboBox.FormattingEnabled = true;
            this.armorComboBox.Items.AddRange(new object[] {
            "Light",
            "Medium",
            "Heavy",
            "Advanced"});
            this.armorComboBox.Location = new System.Drawing.Point(11, 116);
            this.armorComboBox.Name = "armorComboBox";
            this.armorComboBox.Size = new System.Drawing.Size(126, 24);
            this.armorComboBox.TabIndex = 9;
            this.armorComboBox.Text = "-- Select Armor --";
            // 
            // traitComboBox
            // 
            this.traitComboBox.BackColor = System.Drawing.Color.White;
            this.traitComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traitComboBox.ForeColor = System.Drawing.Color.Black;
            this.traitComboBox.FormattingEnabled = true;
            this.traitComboBox.Items.AddRange(new object[] {
            "Acrobat",
            "Chem. Reliant",
            "Dragoon",
            "Energizer",
            "Flower Child",
            "Gadgeteer",
            "Gifted",
            "Healer",
            "Pack Rat",
            "Prowler",
            "Rad. Resistant",
            "Skilled",
            "Survivalist",
            "Swift Learner",
            "Engineer",
            "Focused"});
            this.traitComboBox.Location = new System.Drawing.Point(11, 159);
            this.traitComboBox.MaxDropDownItems = 16;
            this.traitComboBox.Name = "traitComboBox";
            this.traitComboBox.Size = new System.Drawing.Size(126, 24);
            this.traitComboBox.TabIndex = 9;
            this.traitComboBox.Text = "-- Select Trait --";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(155, 30);
            this.nameTextBox.MaxLength = 15;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(132, 22);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Darc";
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // codeDisplay
            // 
            this.codeDisplay.BackColor = System.Drawing.Color.White;
            this.codeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeDisplay.ForeColor = System.Drawing.Color.Black;
            this.codeDisplay.Location = new System.Drawing.Point(155, 97);
            this.codeDisplay.Name = "codeDisplay";
            this.codeDisplay.Size = new System.Drawing.Size(132, 22);
            this.codeDisplay.TabIndex = 5;
            this.codeDisplay.Text = "-Rank Code Display-";
            // 
            // encodeButton
            // 
            this.encodeButton.BackColor = System.Drawing.Color.Transparent;
            this.encodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodeButton.ForeColor = System.Drawing.Color.Black;
            this.encodeButton.Location = new System.Drawing.Point(155, 58);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(64, 23);
            this.encodeButton.TabIndex = 6;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseMnemonic = false;
            this.encodeButton.UseVisualStyleBackColor = false;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // specComboBox
            // 
            this.specComboBox.BackColor = System.Drawing.Color.White;
            this.specComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specComboBox.ForeColor = System.Drawing.Color.Black;
            this.specComboBox.FormattingEnabled = true;
            this.specComboBox.Items.AddRange(new object[] {
            "Weaponry",
            "Power Armor",
            "Energy Cells",
            "Cybernetics",
            "Triage",
            "Chemistry",
            "Leadership",
            "Espionage",
            "Robotics"});
            this.specComboBox.Location = new System.Drawing.Point(10, 202);
            this.specComboBox.Name = "specComboBox";
            this.specComboBox.Size = new System.Drawing.Size(126, 24);
            this.specComboBox.TabIndex = 15;
            this.specComboBox.Text = "-- Select Spec --";
            // 
            // talentComboBox
            // 
            this.talentComboBox.BackColor = System.Drawing.Color.White;
            this.talentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.talentComboBox.ForeColor = System.Drawing.Color.Black;
            this.talentComboBox.FormattingEnabled = true;
            this.talentComboBox.Items.AddRange(new object[] {
            "Courage",
            "Wiring",
            "Running",
            "Spotting",
            "Toughness",
            "Tinkering",
            "Hacking"});
            this.talentComboBox.Location = new System.Drawing.Point(10, 243);
            this.talentComboBox.Name = "talentComboBox";
            this.talentComboBox.Size = new System.Drawing.Size(126, 24);
            this.talentComboBox.TabIndex = 16;
            this.talentComboBox.Text = "-- Select Talent --";
            // 
            // medal1
            // 
            this.medal1.AutoSize = true;
            this.medal1.ForeColor = System.Drawing.Color.Black;
            this.medal1.Location = new System.Drawing.Point(9, 7);
            this.medal1.Name = "medal1";
            this.medal1.Size = new System.Drawing.Size(115, 17);
            this.medal1.TabIndex = 17;
            this.medal1.Text = "Commendation Bar";
            this.medal1.UseVisualStyleBackColor = true;
            // 
            // medal3
            // 
            this.medal3.AutoSize = true;
            this.medal3.ForeColor = System.Drawing.Color.Black;
            this.medal3.Location = new System.Drawing.Point(9, 39);
            this.medal3.Name = "medal3";
            this.medal3.Size = new System.Drawing.Size(112, 17);
            this.medal3.TabIndex = 19;
            this.medal3.Text = "Life Saving Award";
            this.medal3.UseVisualStyleBackColor = true;
            // 
            // medal4
            // 
            this.medal4.AutoSize = true;
            this.medal4.ForeColor = System.Drawing.Color.Black;
            this.medal4.Location = new System.Drawing.Point(9, 55);
            this.medal4.Name = "medal4";
            this.medal4.Size = new System.Drawing.Size(94, 17);
            this.medal4.TabIndex = 20;
            this.medal4.Text = "Key to the City";
            this.medal4.UseVisualStyleBackColor = true;
            // 
            // medal5
            // 
            this.medal5.AutoSize = true;
            this.medal5.ForeColor = System.Drawing.Color.Black;
            this.medal5.Location = new System.Drawing.Point(9, 71);
            this.medal5.Name = "medal5";
            this.medal5.Size = new System.Drawing.Size(99, 17);
            this.medal5.TabIndex = 21;
            this.medal5.Text = "Medal of Honor";
            this.medal5.UseVisualStyleBackColor = true;
            // 
            // medal6
            // 
            this.medal6.AutoSize = true;
            this.medal6.ForeColor = System.Drawing.Color.Black;
            this.medal6.Location = new System.Drawing.Point(9, 23);
            this.medal6.Name = "medal6";
            this.medal6.Size = new System.Drawing.Size(123, 17);
            this.medal6.TabIndex = 22;
            this.medal6.Text = "Police Combat Cross";
            this.medal6.UseVisualStyleBackColor = true;
            // 
            // medalsPanel
            // 
            this.medalsPanel.Controls.Add(this.medal1);
            this.medalsPanel.Controls.Add(this.medal3);
            this.medalsPanel.Controls.Add(this.medal23);
            this.medalsPanel.Controls.Add(this.medal6);
            this.medalsPanel.Controls.Add(this.medal22);
            this.medalsPanel.Controls.Add(this.medal4);
            this.medalsPanel.Controls.Add(this.medal5);
            this.medalsPanel.Controls.Add(this.medal21);
            this.medalsPanel.Location = new System.Drawing.Point(155, 127);
            this.medalsPanel.Name = "medalsPanel";
            this.medalsPanel.Size = new System.Drawing.Size(149, 140);
            this.medalsPanel.TabIndex = 25;
            // 
            // medal23
            // 
            this.medal23.AutoCheck = false;
            this.medal23.AutoSize = true;
            this.medal23.Location = new System.Drawing.Point(9, 119);
            this.medal23.Name = "medal23";
            this.medal23.Size = new System.Drawing.Size(138, 17);
            this.medal23.TabIndex = 36;
            this.medal23.TabStop = true;
            this.medal23.Text = "Exceptional Merit (Lvl 3)";
            this.medal23.UseVisualStyleBackColor = true;
            this.medal23.Click += new System.EventHandler(this.medal23_Click);
            // 
            // medal22
            // 
            this.medal22.AutoCheck = false;
            this.medal22.AutoSize = true;
            this.medal22.Location = new System.Drawing.Point(9, 103);
            this.medal22.Name = "medal22";
            this.medal22.Size = new System.Drawing.Size(138, 17);
            this.medal22.TabIndex = 35;
            this.medal22.TabStop = true;
            this.medal22.Text = "Exceptional Merit (Lvl 2)";
            this.medal22.UseVisualStyleBackColor = true;
            this.medal22.Click += new System.EventHandler(this.medal22_Click);
            // 
            // medal21
            // 
            this.medal21.AutoCheck = false;
            this.medal21.AutoSize = true;
            this.medal21.Location = new System.Drawing.Point(9, 87);
            this.medal21.Name = "medal21";
            this.medal21.Size = new System.Drawing.Size(138, 17);
            this.medal21.TabIndex = 34;
            this.medal21.TabStop = true;
            this.medal21.Text = "Exceptional Merit (Lvl 1)";
            this.medal21.UseVisualStyleBackColor = true;
            this.medal21.Click += new System.EventHandler(this.medal21_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 250;
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.Transparent;
            this.copyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.ForeColor = System.Drawing.Color.Black;
            this.copyButton.Location = new System.Drawing.Point(225, 58);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(64, 23);
            this.copyButton.TabIndex = 26;
            this.copyButton.Text = "Copy";
            this.copyButton.UseMnemonic = false;
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // codegenNameClearButton
            // 
            this.codegenNameClearButton.Location = new System.Drawing.Point(294, 28);
            this.codegenNameClearButton.Name = "codegenNameClearButton";
            this.codegenNameClearButton.Size = new System.Drawing.Size(43, 23);
            this.codegenNameClearButton.TabIndex = 1;
            this.codegenNameClearButton.Text = "Clear";
            this.codegenNameClearButton.UseVisualStyleBackColor = true;
            this.codegenNameClearButton.Click += new System.EventHandler(this.codegenNameClearButton_Click);
            // 
            // checksumLabel
            // 
            this.checksumLabel.AutoSize = true;
            this.checksumLabel.Location = new System.Drawing.Point(343, 33);
            this.checksumLabel.Name = "checksumLabel";
            this.checksumLabel.Size = new System.Drawing.Size(63, 13);
            this.checksumLabel.TabIndex = 32;
            this.checksumLabel.Text = "Checksum: ";
            // 
            // valueListBox
            // 
            this.valueListBox.FormattingEnabled = true;
            this.valueListBox.Location = new System.Drawing.Point(324, 78);
            this.valueListBox.Name = "valueListBox";
            this.valueListBox.Size = new System.Drawing.Size(71, 121);
            this.valueListBox.TabIndex = 33;
            // 
            // rcpdButton
            // 
            this.rcpdButton.Location = new System.Drawing.Point(324, 205);
            this.rcpdButton.Name = "rcpdButton";
            this.rcpdButton.Size = new System.Drawing.Size(75, 23);
            this.rcpdButton.TabIndex = 34;
            this.rcpdButton.Text = "Open RPCD";
            this.rcpdButton.UseVisualStyleBackColor = true;
            this.rcpdButton.Visible = false;
            this.rcpdButton.Click += new System.EventHandler(this.rcpdButton_Click);
            // 
            // spoofButton
            // 
            this.spoofButton.Location = new System.Drawing.Point(324, 230);
            this.spoofButton.Name = "spoofButton";
            this.spoofButton.Size = new System.Drawing.Size(75, 23);
            this.spoofButton.TabIndex = 35;
            this.spoofButton.Text = "Open Spoof";
            this.spoofButton.UseVisualStyleBackColor = true;
            this.spoofButton.Visible = false;
            this.spoofButton.Click += new System.EventHandler(this.spoofButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 314);
            this.Controls.Add(this.spoofButton);
            this.Controls.Add(this.rcpdButton);
            this.Controls.Add(this.valueListBox);
            this.Controls.Add(this.checksumLabel);
            this.Controls.Add(this.codegenNameClearButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.medalsPanel);
            this.Controls.Add(this.talentComboBox);
            this.Controls.Add(this.specComboBox);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.codeDisplay);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.traitComboBox);
            this.Controls.Add(this.armorComboBox);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.rankComboBox);
            this.Name = "Form1";
            this.Text = "Darc\'s SWAT Utility";
            this.medalsPanel.ResumeLayout(false);
            this.medalsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox rankComboBox;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.ComboBox armorComboBox;
        private System.Windows.Forms.ComboBox traitComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox codeDisplay;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.ComboBox specComboBox;
        private System.Windows.Forms.ComboBox talentComboBox;
        private System.Windows.Forms.CheckBox medal1;
        private System.Windows.Forms.CheckBox medal3;
        private System.Windows.Forms.CheckBox medal4;
        private System.Windows.Forms.CheckBox medal5;
        private System.Windows.Forms.CheckBox medal6;
        private System.Windows.Forms.Panel medalsPanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button codegenNameClearButton;
        private System.Windows.Forms.Label checksumLabel;
        private System.Windows.Forms.ListBox valueListBox;
        private System.Windows.Forms.RadioButton medal21;
        private System.Windows.Forms.RadioButton medal22;
        private System.Windows.Forms.RadioButton medal23;
        private System.Windows.Forms.Button rcpdButton;
        private System.Windows.Forms.Button spoofButton;

    }
}

