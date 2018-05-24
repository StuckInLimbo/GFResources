namespace GFResources
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.numManpower = new System.Windows.Forms.NumericUpDown();
            this.numAmmo = new System.Windows.Forms.NumericUpDown();
            this.numRations = new System.Windows.Forms.NumericUpDown();
            this.numParts = new System.Windows.Forms.NumericUpDown();
            this.labelManpower = new System.Windows.Forms.Label();
            this.labelAmmo = new System.Windows.Forms.Label();
            this.labelRation = new System.Windows.Forms.Label();
            this.labelParts = new System.Windows.Forms.Label();
            this.groupBoxCurrent = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDesired = new System.Windows.Forms.GroupBox();
            this.numManpowerDesired = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numAmmoDesired = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numRationsDesired = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numPartsDesired = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxLogistics = new System.Windows.Forms.GroupBox();
            this.labelE4Rewards = new System.Windows.Forms.Label();
            this.labelE3Rewards = new System.Windows.Forms.Label();
            this.labelE2Rewards = new System.Windows.Forms.Label();
            this.labelE1Rewards = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.labelE4Resources = new System.Windows.Forms.Label();
            this.comboE4Map = new System.Windows.Forms.ComboBox();
            this.comboE4Chapter = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelE3Resources = new System.Windows.Forms.Label();
            this.comboE3Map = new System.Windows.Forms.ComboBox();
            this.comboE3Chapter = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelE2Resources = new System.Windows.Forms.Label();
            this.comboE2Map = new System.Windows.Forms.ComboBox();
            this.comboE2Chapter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelE1Resources = new System.Windows.Forms.Label();
            this.comboE1Map = new System.Windows.Forms.ComboBox();
            this.comboE1Chapter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelMinOutput = new System.Windows.Forms.Label();
            this.labelMaterials = new System.Windows.Forms.Label();
            this.labelMaxOutput = new System.Windows.Forms.Label();
            this.checkBoxGreat = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numManpower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParts)).BeginInit();
            this.groupBoxCurrent.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBoxDesired.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numManpowerDesired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmoDesired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRationsDesired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPartsDesired)).BeginInit();
            this.groupBoxLogistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            this.SuspendLayout();
            // 
            // numManpower
            // 
            this.numManpower.Location = new System.Drawing.Point(7, 55);
            this.numManpower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numManpower.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numManpower.Name = "numManpower";
            this.numManpower.Size = new System.Drawing.Size(74, 26);
            this.numManpower.TabIndex = 0;
            // 
            // numAmmo
            // 
            this.numAmmo.Location = new System.Drawing.Point(88, 55);
            this.numAmmo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numAmmo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAmmo.Name = "numAmmo";
            this.numAmmo.Size = new System.Drawing.Size(74, 26);
            this.numAmmo.TabIndex = 1;
            // 
            // numRations
            // 
            this.numRations.Location = new System.Drawing.Point(169, 55);
            this.numRations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numRations.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRations.Name = "numRations";
            this.numRations.Size = new System.Drawing.Size(74, 26);
            this.numRations.TabIndex = 2;
            // 
            // numParts
            // 
            this.numParts.Location = new System.Drawing.Point(250, 55);
            this.numParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numParts.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numParts.Name = "numParts";
            this.numParts.Size = new System.Drawing.Size(74, 26);
            this.numParts.TabIndex = 3;
            // 
            // labelManpower
            // 
            this.labelManpower.AutoSize = true;
            this.labelManpower.Location = new System.Drawing.Point(8, 34);
            this.labelManpower.Name = "labelManpower";
            this.labelManpower.Size = new System.Drawing.Size(75, 18);
            this.labelManpower.TabIndex = 4;
            this.labelManpower.Text = "Manpower";
            // 
            // labelAmmo
            // 
            this.labelAmmo.AutoSize = true;
            this.labelAmmo.Location = new System.Drawing.Point(86, 34);
            this.labelAmmo.Name = "labelAmmo";
            this.labelAmmo.Size = new System.Drawing.Size(51, 18);
            this.labelAmmo.TabIndex = 5;
            this.labelAmmo.Text = "Ammo";
            // 
            // labelRation
            // 
            this.labelRation.AutoSize = true;
            this.labelRation.Location = new System.Drawing.Point(166, 34);
            this.labelRation.Name = "labelRation";
            this.labelRation.Size = new System.Drawing.Size(55, 18);
            this.labelRation.TabIndex = 6;
            this.labelRation.Text = "Rations";
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Location = new System.Drawing.Point(248, 34);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(41, 18);
            this.labelParts.TabIndex = 7;
            this.labelParts.Text = "Parts";
            // 
            // groupBoxCurrent
            // 
            this.groupBoxCurrent.Controls.Add(this.numManpower);
            this.groupBoxCurrent.Controls.Add(this.labelParts);
            this.groupBoxCurrent.Controls.Add(this.numAmmo);
            this.groupBoxCurrent.Controls.Add(this.labelRation);
            this.groupBoxCurrent.Controls.Add(this.numRations);
            this.groupBoxCurrent.Controls.Add(this.labelAmmo);
            this.groupBoxCurrent.Controls.Add(this.numParts);
            this.groupBoxCurrent.Controls.Add(this.labelManpower);
            this.groupBoxCurrent.Location = new System.Drawing.Point(14, 34);
            this.groupBoxCurrent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCurrent.Name = "groupBoxCurrent";
            this.groupBoxCurrent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCurrent.Size = new System.Drawing.Size(366, 96);
            this.groupBoxCurrent.TabIndex = 8;
            this.groupBoxCurrent.TabStop = false;
            this.groupBoxCurrent.Text = "Current Materials";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(818, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ToolStripReset_Clicked);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.howToUseToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuAbout_Clicked);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.howToUseToolStripMenuItem.Text = "How to Use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.ToolStripHowToUse_Clicked);
            // 
            // groupBoxDesired
            // 
            this.groupBoxDesired.Controls.Add(this.numManpowerDesired);
            this.groupBoxDesired.Controls.Add(this.label1);
            this.groupBoxDesired.Controls.Add(this.numAmmoDesired);
            this.groupBoxDesired.Controls.Add(this.label2);
            this.groupBoxDesired.Controls.Add(this.numRationsDesired);
            this.groupBoxDesired.Controls.Add(this.label3);
            this.groupBoxDesired.Controls.Add(this.numPartsDesired);
            this.groupBoxDesired.Controls.Add(this.label4);
            this.groupBoxDesired.Location = new System.Drawing.Point(431, 34);
            this.groupBoxDesired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDesired.Name = "groupBoxDesired";
            this.groupBoxDesired.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDesired.Size = new System.Drawing.Size(364, 96);
            this.groupBoxDesired.TabIndex = 9;
            this.groupBoxDesired.TabStop = false;
            this.groupBoxDesired.Text = "Desired Materials";
            // 
            // numManpowerDesired
            // 
            this.numManpowerDesired.Location = new System.Drawing.Point(7, 55);
            this.numManpowerDesired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numManpowerDesired.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numManpowerDesired.Name = "numManpowerDesired";
            this.numManpowerDesired.Size = new System.Drawing.Size(74, 26);
            this.numManpowerDesired.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parts";
            // 
            // numAmmoDesired
            // 
            this.numAmmoDesired.Location = new System.Drawing.Point(88, 55);
            this.numAmmoDesired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numAmmoDesired.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAmmoDesired.Name = "numAmmoDesired";
            this.numAmmoDesired.Size = new System.Drawing.Size(74, 26);
            this.numAmmoDesired.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rations";
            // 
            // numRationsDesired
            // 
            this.numRationsDesired.Location = new System.Drawing.Point(169, 55);
            this.numRationsDesired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numRationsDesired.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRationsDesired.Name = "numRationsDesired";
            this.numRationsDesired.Size = new System.Drawing.Size(74, 26);
            this.numRationsDesired.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ammo";
            // 
            // numPartsDesired
            // 
            this.numPartsDesired.Location = new System.Drawing.Point(250, 55);
            this.numPartsDesired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPartsDesired.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPartsDesired.Name = "numPartsDesired";
            this.numPartsDesired.Size = new System.Drawing.Size(74, 26);
            this.numPartsDesired.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Manpower";
            // 
            // groupBoxLogistics
            // 
            this.groupBoxLogistics.Controls.Add(this.checkBoxGreat);
            this.groupBoxLogistics.Controls.Add(this.labelE4Rewards);
            this.groupBoxLogistics.Controls.Add(this.labelE3Rewards);
            this.groupBoxLogistics.Controls.Add(this.labelE2Rewards);
            this.groupBoxLogistics.Controls.Add(this.labelE1Rewards);
            this.groupBoxLogistics.Controls.Add(this.labelHours);
            this.groupBoxLogistics.Controls.Add(this.numHours);
            this.groupBoxLogistics.Controls.Add(this.labelE4Resources);
            this.groupBoxLogistics.Controls.Add(this.comboE4Map);
            this.groupBoxLogistics.Controls.Add(this.comboE4Chapter);
            this.groupBoxLogistics.Controls.Add(this.label11);
            this.groupBoxLogistics.Controls.Add(this.labelE3Resources);
            this.groupBoxLogistics.Controls.Add(this.comboE3Map);
            this.groupBoxLogistics.Controls.Add(this.comboE3Chapter);
            this.groupBoxLogistics.Controls.Add(this.label9);
            this.groupBoxLogistics.Controls.Add(this.labelE2Resources);
            this.groupBoxLogistics.Controls.Add(this.comboE2Map);
            this.groupBoxLogistics.Controls.Add(this.comboE2Chapter);
            this.groupBoxLogistics.Controls.Add(this.label7);
            this.groupBoxLogistics.Controls.Add(this.labelE1Resources);
            this.groupBoxLogistics.Controls.Add(this.comboE1Map);
            this.groupBoxLogistics.Controls.Add(this.comboE1Chapter);
            this.groupBoxLogistics.Controls.Add(this.label5);
            this.groupBoxLogistics.Location = new System.Drawing.Point(12, 157);
            this.groupBoxLogistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLogistics.Name = "groupBoxLogistics";
            this.groupBoxLogistics.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLogistics.Size = new System.Drawing.Size(783, 376);
            this.groupBoxLogistics.TabIndex = 10;
            this.groupBoxLogistics.TabStop = false;
            this.groupBoxLogistics.Text = "Logistics";
            // 
            // labelE4Rewards
            // 
            this.labelE4Rewards.AutoSize = true;
            this.labelE4Rewards.Location = new System.Drawing.Point(149, 338);
            this.labelE4Rewards.Name = "labelE4Rewards";
            this.labelE4Rewards.Size = new System.Drawing.Size(41, 18);
            this.labelE4Rewards.TabIndex = 21;
            this.labelE4Rewards.Text = "blank";
            // 
            // labelE3Rewards
            // 
            this.labelE3Rewards.AutoSize = true;
            this.labelE3Rewards.Location = new System.Drawing.Point(149, 260);
            this.labelE3Rewards.Name = "labelE3Rewards";
            this.labelE3Rewards.Size = new System.Drawing.Size(41, 18);
            this.labelE3Rewards.TabIndex = 20;
            this.labelE3Rewards.Text = "blank";
            // 
            // labelE2Rewards
            // 
            this.labelE2Rewards.AutoSize = true;
            this.labelE2Rewards.Location = new System.Drawing.Point(149, 182);
            this.labelE2Rewards.Name = "labelE2Rewards";
            this.labelE2Rewards.Size = new System.Drawing.Size(41, 18);
            this.labelE2Rewards.TabIndex = 19;
            this.labelE2Rewards.Text = "blank";
            // 
            // labelE1Rewards
            // 
            this.labelE1Rewards.AutoSize = true;
            this.labelE1Rewards.Location = new System.Drawing.Point(149, 104);
            this.labelE1Rewards.Name = "labelE1Rewards";
            this.labelE1Rewards.Size = new System.Drawing.Size(41, 18);
            this.labelE1Rewards.TabIndex = 18;
            this.labelE1Rewards.Text = "blank";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(10, 25);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(56, 18);
            this.labelHours.TabIndex = 17;
            this.labelHours.Text = "Hours: ";
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(69, 23);
            this.numHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numHours.Maximum = new decimal(new int[] {
            168,
            0,
            0,
            0});
            this.numHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(57, 26);
            this.numHours.TabIndex = 16;
            this.numHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHours.ValueChanged += new System.EventHandler(this.NumHours_ValueChanged);
            // 
            // labelE4Resources
            // 
            this.labelE4Resources.AutoSize = true;
            this.labelE4Resources.Location = new System.Drawing.Point(149, 308);
            this.labelE4Resources.Name = "labelE4Resources";
            this.labelE4Resources.Size = new System.Drawing.Size(41, 18);
            this.labelE4Resources.TabIndex = 15;
            this.labelE4Resources.Text = "blank";
            // 
            // comboE4Map
            // 
            this.comboE4Map.FormattingEnabled = true;
            this.comboE4Map.Items.AddRange(new object[] {
            "Episode 1",
            "Episode 2",
            "Episode 3",
            "Episode 4"});
            this.comboE4Map.Location = new System.Drawing.Point(5, 335);
            this.comboE4Map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboE4Map.Name = "comboE4Map";
            this.comboE4Map.Size = new System.Drawing.Size(138, 26);
            this.comboE4Map.TabIndex = 14;
            // 
            // comboE4Chapter
            // 
            this.comboE4Chapter.FormattingEnabled = true;
            this.comboE4Chapter.Items.AddRange(new object[] {
            "Chapter 0",
            "Chapter 1",
            "Chapter 2",
            "Chapter 3",
            "Chapter 4",
            "Chapter 5",
            "Chapter 6",
            "Chapter 7",
            "Chapter 8",
            "Chapter 9",
            "Chapter 10"});
            this.comboE4Chapter.Location = new System.Drawing.Point(6, 305);
            this.comboE4Chapter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboE4Chapter.Name = "comboE4Chapter";
            this.comboE4Chapter.Size = new System.Drawing.Size(137, 26);
            this.comboE4Chapter.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Echelon 4";
            // 
            // labelE3Resources
            // 
            this.labelE3Resources.AutoSize = true;
            this.labelE3Resources.Location = new System.Drawing.Point(149, 230);
            this.labelE3Resources.Name = "labelE3Resources";
            this.labelE3Resources.Size = new System.Drawing.Size(41, 18);
            this.labelE3Resources.TabIndex = 11;
            this.labelE3Resources.Text = "blank";
            // 
            // comboE3Map
            // 
            this.comboE3Map.FormattingEnabled = true;
            this.comboE3Map.Items.AddRange(new object[] {
            "Episode 1",
            "Episode 2",
            "Episode 3",
            "Episode 4"});
            this.comboE3Map.Location = new System.Drawing.Point(5, 257);
            this.comboE3Map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboE3Map.Name = "comboE3Map";
            this.comboE3Map.Size = new System.Drawing.Size(138, 26);
            this.comboE3Map.TabIndex = 10;
            // 
            // comboE3Chapter
            // 
            this.comboE3Chapter.FormattingEnabled = true;
            this.comboE3Chapter.Items.AddRange(new object[] {
            "Chapter 0",
            "Chapter 1",
            "Chapter 2",
            "Chapter 3",
            "Chapter 4",
            "Chapter 5",
            "Chapter 6",
            "Chapter 7",
            "Chapter 8",
            "Chapter 9",
            "Chapter 10"});
            this.comboE3Chapter.Location = new System.Drawing.Point(5, 227);
            this.comboE3Chapter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboE3Chapter.Name = "comboE3Chapter";
            this.comboE3Chapter.Size = new System.Drawing.Size(138, 26);
            this.comboE3Chapter.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Echelon 3";
            // 
            // labelE2Resources
            // 
            this.labelE2Resources.AutoSize = true;
            this.labelE2Resources.Location = new System.Drawing.Point(149, 152);
            this.labelE2Resources.Name = "labelE2Resources";
            this.labelE2Resources.Size = new System.Drawing.Size(41, 18);
            this.labelE2Resources.TabIndex = 7;
            this.labelE2Resources.Text = "blank";
            // 
            // comboE2Map
            // 
            this.comboE2Map.FormattingEnabled = true;
            this.comboE2Map.Items.AddRange(new object[] {
            "Episode 1",
            "Episode 2",
            "Episode 3",
            "Episode 4"});
            this.comboE2Map.Location = new System.Drawing.Point(6, 179);
            this.comboE2Map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboE2Map.Name = "comboE2Map";
            this.comboE2Map.Size = new System.Drawing.Size(137, 26);
            this.comboE2Map.TabIndex = 6;
            // 
            // comboE2Chapter
            // 
            this.comboE2Chapter.FormattingEnabled = true;
            this.comboE2Chapter.Items.AddRange(new object[] {
            "Chapter 0",
            "Chapter 1",
            "Chapter 2",
            "Chapter 3",
            "Chapter 4",
            "Chapter 5",
            "Chapter 6",
            "Chapter 7",
            "Chapter 8",
            "Chapter 9",
            "Chapter 10"});
            this.comboE2Chapter.Location = new System.Drawing.Point(6, 149);
            this.comboE2Chapter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboE2Chapter.Name = "comboE2Chapter";
            this.comboE2Chapter.Size = new System.Drawing.Size(137, 26);
            this.comboE2Chapter.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Echelon 2";
            // 
            // labelE1Resources
            // 
            this.labelE1Resources.AutoSize = true;
            this.labelE1Resources.Location = new System.Drawing.Point(149, 74);
            this.labelE1Resources.Name = "labelE1Resources";
            this.labelE1Resources.Size = new System.Drawing.Size(41, 18);
            this.labelE1Resources.TabIndex = 3;
            this.labelE1Resources.Text = "blank";
            // 
            // comboE1Map
            // 
            this.comboE1Map.FormattingEnabled = true;
            this.comboE1Map.Items.AddRange(new object[] {
            "Episode 1",
            "Episode 2",
            "Episode 3",
            "Episode 4"});
            this.comboE1Map.Location = new System.Drawing.Point(5, 101);
            this.comboE1Map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboE1Map.Name = "comboE1Map";
            this.comboE1Map.Size = new System.Drawing.Size(138, 26);
            this.comboE1Map.TabIndex = 2;
            // 
            // comboE1Chapter
            // 
            this.comboE1Chapter.FormattingEnabled = true;
            this.comboE1Chapter.Items.AddRange(new object[] {
            "Chapter 0",
            "Chapter 1",
            "Chapter 2",
            "Chapter 3",
            "Chapter 4",
            "Chapter 5",
            "Chapter 6",
            "Chapter 7",
            "Chapter 8",
            "Chapter 9",
            "Chapter 10"});
            this.comboE1Chapter.Location = new System.Drawing.Point(5, 71);
            this.comboE1Chapter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboE1Chapter.Name = "comboE1Chapter";
            this.comboE1Chapter.Size = new System.Drawing.Size(138, 26);
            this.comboE1Chapter.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Echelon 1";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 537);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(99, 37);
            this.buttonCalculate.TabIndex = 11;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // labelMinOutput
            // 
            this.labelMinOutput.AutoSize = true;
            this.labelMinOutput.Location = new System.Drawing.Point(16, 614);
            this.labelMinOutput.Name = "labelMinOutput";
            this.labelMinOutput.Size = new System.Drawing.Size(41, 18);
            this.labelMinOutput.TabIndex = 12;
            this.labelMinOutput.Text = "blank";
            // 
            // labelMaterials
            // 
            this.labelMaterials.AutoSize = true;
            this.labelMaterials.Location = new System.Drawing.Point(17, 586);
            this.labelMaterials.Name = "labelMaterials";
            this.labelMaterials.Size = new System.Drawing.Size(41, 18);
            this.labelMaterials.TabIndex = 13;
            this.labelMaterials.Text = "blank";
            // 
            // labelMaxOutput
            // 
            this.labelMaxOutput.AutoSize = true;
            this.labelMaxOutput.Location = new System.Drawing.Point(16, 643);
            this.labelMaxOutput.Name = "labelMaxOutput";
            this.labelMaxOutput.Size = new System.Drawing.Size(41, 18);
            this.labelMaxOutput.TabIndex = 14;
            this.labelMaxOutput.Text = "blank";
            // 
            // checkBoxGreat
            // 
            this.checkBoxGreat.AutoSize = true;
            this.checkBoxGreat.Location = new System.Drawing.Point(152, 27);
            this.checkBoxGreat.Name = "checkBoxGreat";
            this.checkBoxGreat.Size = new System.Drawing.Size(162, 22);
            this.checkBoxGreat.TabIndex = 22;
            this.checkBoxGreat.Text = "Show Great Reward?";
            this.checkBoxGreat.UseVisualStyleBackColor = true;
            this.checkBoxGreat.CheckedChanged += new System.EventHandler(this.checkBoxGreat_CheckedChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(818, 671);
            this.Controls.Add(this.labelMaxOutput);
            this.Controls.Add(this.labelMaterials);
            this.Controls.Add(this.labelMinOutput);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxLogistics);
            this.Controls.Add(this.groupBoxDesired);
            this.Controls.Add(this.groupBoxCurrent);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form";
            this.Text = "GF Resource Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numManpower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParts)).EndInit();
            this.groupBoxCurrent.ResumeLayout(false);
            this.groupBoxCurrent.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxDesired.ResumeLayout(false);
            this.groupBoxDesired.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numManpowerDesired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmoDesired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRationsDesired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPartsDesired)).EndInit();
            this.groupBoxLogistics.ResumeLayout(false);
            this.groupBoxLogistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numManpower;
        private System.Windows.Forms.NumericUpDown numAmmo;
        private System.Windows.Forms.NumericUpDown numRations;
        private System.Windows.Forms.NumericUpDown numParts;
        private System.Windows.Forms.Label labelManpower;
        private System.Windows.Forms.Label labelAmmo;
        private System.Windows.Forms.Label labelRation;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.GroupBox groupBoxCurrent;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxDesired;
        private System.Windows.Forms.NumericUpDown numManpowerDesired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAmmoDesired;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRationsDesired;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPartsDesired;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxLogistics;
        private System.Windows.Forms.ComboBox comboE1Chapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboE1Map;
        private System.Windows.Forms.Label labelE1Resources;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelMinOutput;
        private System.Windows.Forms.Label labelE4Resources;
        private System.Windows.Forms.ComboBox comboE4Map;
        private System.Windows.Forms.ComboBox comboE4Chapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelE3Resources;
        private System.Windows.Forms.ComboBox comboE3Map;
        private System.Windows.Forms.ComboBox comboE3Chapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelE2Resources;
        private System.Windows.Forms.ComboBox comboE2Map;
        private System.Windows.Forms.ComboBox comboE2Chapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMaterials;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label labelMaxOutput;
        private System.Windows.Forms.Label labelE4Rewards;
        private System.Windows.Forms.Label labelE3Rewards;
        private System.Windows.Forms.Label labelE2Rewards;
        private System.Windows.Forms.Label labelE1Rewards;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxGreat;
    }
}

