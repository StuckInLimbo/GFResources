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
            this.numManpower = new System.Windows.Forms.NumericUpDown();
            this.numAmmo = new System.Windows.Forms.NumericUpDown();
            this.numRations = new System.Windows.Forms.NumericUpDown();
            this.numParts = new System.Windows.Forms.NumericUpDown();
            this.labelManpower = new System.Windows.Forms.Label();
            this.labelAmmo = new System.Windows.Forms.Label();
            this.labelRation = new System.Windows.Forms.Label();
            this.labelParts = new System.Windows.Forms.Label();
            this.groupBoxCurrent = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelMaterials = new System.Windows.Forms.Label();
            this.labelOutputDrops = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numManpower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParts)).BeginInit();
            this.groupBoxCurrent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.numManpower.Location = new System.Drawing.Point(6, 46);
            this.numManpower.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numManpower.Name = "numManpower";
            this.numManpower.Size = new System.Drawing.Size(65, 21);
            this.numManpower.TabIndex = 0;
            // 
            // numAmmo
            // 
            this.numAmmo.Location = new System.Drawing.Point(77, 46);
            this.numAmmo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAmmo.Name = "numAmmo";
            this.numAmmo.Size = new System.Drawing.Size(65, 21);
            this.numAmmo.TabIndex = 1;
            // 
            // numRations
            // 
            this.numRations.Location = new System.Drawing.Point(148, 46);
            this.numRations.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRations.Name = "numRations";
            this.numRations.Size = new System.Drawing.Size(65, 21);
            this.numRations.TabIndex = 2;
            // 
            // numParts
            // 
            this.numParts.Location = new System.Drawing.Point(219, 46);
            this.numParts.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numParts.Name = "numParts";
            this.numParts.Size = new System.Drawing.Size(65, 21);
            this.numParts.TabIndex = 3;
            // 
            // labelManpower
            // 
            this.labelManpower.AutoSize = true;
            this.labelManpower.Location = new System.Drawing.Point(3, 28);
            this.labelManpower.Name = "labelManpower";
            this.labelManpower.Size = new System.Drawing.Size(66, 15);
            this.labelManpower.TabIndex = 4;
            this.labelManpower.Text = "Manpower";
            // 
            // labelAmmo
            // 
            this.labelAmmo.AutoSize = true;
            this.labelAmmo.Location = new System.Drawing.Point(75, 28);
            this.labelAmmo.Name = "labelAmmo";
            this.labelAmmo.Size = new System.Drawing.Size(43, 15);
            this.labelAmmo.TabIndex = 5;
            this.labelAmmo.Text = "Ammo";
            // 
            // labelRation
            // 
            this.labelRation.AutoSize = true;
            this.labelRation.Location = new System.Drawing.Point(145, 28);
            this.labelRation.Name = "labelRation";
            this.labelRation.Size = new System.Drawing.Size(49, 15);
            this.labelRation.TabIndex = 6;
            this.labelRation.Text = "Rations";
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Location = new System.Drawing.Point(216, 28);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(35, 15);
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
            this.groupBoxCurrent.Location = new System.Drawing.Point(12, 28);
            this.groupBoxCurrent.Name = "groupBoxCurrent";
            this.groupBoxCurrent.Size = new System.Drawing.Size(305, 80);
            this.groupBoxCurrent.TabIndex = 8;
            this.groupBoxCurrent.TabStop = false;
            this.groupBoxCurrent.Text = "Current Materials";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
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
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
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
            this.groupBoxDesired.Location = new System.Drawing.Point(323, 28);
            this.groupBoxDesired.Name = "groupBoxDesired";
            this.groupBoxDesired.Size = new System.Drawing.Size(305, 80);
            this.groupBoxDesired.TabIndex = 9;
            this.groupBoxDesired.TabStop = false;
            this.groupBoxDesired.Text = "Desired Materials";
            // 
            // numManpowerDesired
            // 
            this.numManpowerDesired.Location = new System.Drawing.Point(6, 46);
            this.numManpowerDesired.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numManpowerDesired.Name = "numManpowerDesired";
            this.numManpowerDesired.Size = new System.Drawing.Size(65, 21);
            this.numManpowerDesired.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parts";
            // 
            // numAmmoDesired
            // 
            this.numAmmoDesired.Location = new System.Drawing.Point(77, 46);
            this.numAmmoDesired.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAmmoDesired.Name = "numAmmoDesired";
            this.numAmmoDesired.Size = new System.Drawing.Size(65, 21);
            this.numAmmoDesired.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rations";
            // 
            // numRationsDesired
            // 
            this.numRationsDesired.Location = new System.Drawing.Point(148, 46);
            this.numRationsDesired.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRationsDesired.Name = "numRationsDesired";
            this.numRationsDesired.Size = new System.Drawing.Size(65, 21);
            this.numRationsDesired.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ammo";
            // 
            // numPartsDesired
            // 
            this.numPartsDesired.Location = new System.Drawing.Point(219, 46);
            this.numPartsDesired.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPartsDesired.Name = "numPartsDesired";
            this.numPartsDesired.Size = new System.Drawing.Size(65, 21);
            this.numPartsDesired.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Manpower";
            // 
            // groupBoxLogistics
            // 
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
            this.groupBoxLogistics.Location = new System.Drawing.Point(12, 186);
            this.groupBoxLogistics.Name = "groupBoxLogistics";
            this.groupBoxLogistics.Size = new System.Drawing.Size(616, 261);
            this.groupBoxLogistics.TabIndex = 10;
            this.groupBoxLogistics.TabStop = false;
            this.groupBoxLogistics.Text = "Logistics";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(7, 27);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(46, 15);
            this.labelHours.TabIndex = 17;
            this.labelHours.Text = "Hours: ";
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(59, 25);
            this.numHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(43, 21);
            this.numHours.TabIndex = 16;
            this.numHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelE4Resources
            // 
            this.labelE4Resources.AutoSize = true;
            this.labelE4Resources.Location = new System.Drawing.Point(260, 226);
            this.labelE4Resources.Name = "labelE4Resources";
            this.labelE4Resources.Size = new System.Drawing.Size(37, 15);
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
            this.comboE4Map.Location = new System.Drawing.Point(133, 223);
            this.comboE4Map.Name = "comboE4Map";
            this.comboE4Map.Size = new System.Drawing.Size(121, 23);
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
            "Chapter 6"});
            this.comboE4Chapter.Location = new System.Drawing.Point(6, 223);
            this.comboE4Chapter.Name = "comboE4Chapter";
            this.comboE4Chapter.Size = new System.Drawing.Size(121, 23);
            this.comboE4Chapter.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Echelon 4";
            // 
            // labelE3Resources
            // 
            this.labelE3Resources.AutoSize = true;
            this.labelE3Resources.Location = new System.Drawing.Point(260, 177);
            this.labelE3Resources.Name = "labelE3Resources";
            this.labelE3Resources.Size = new System.Drawing.Size(37, 15);
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
            this.comboE3Map.Location = new System.Drawing.Point(133, 174);
            this.comboE3Map.Name = "comboE3Map";
            this.comboE3Map.Size = new System.Drawing.Size(121, 23);
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
            "Chapter 6"});
            this.comboE3Chapter.Location = new System.Drawing.Point(6, 174);
            this.comboE3Chapter.Name = "comboE3Chapter";
            this.comboE3Chapter.Size = new System.Drawing.Size(121, 23);
            this.comboE3Chapter.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Echelon 3";
            // 
            // labelE2Resources
            // 
            this.labelE2Resources.AutoSize = true;
            this.labelE2Resources.Location = new System.Drawing.Point(260, 128);
            this.labelE2Resources.Name = "labelE2Resources";
            this.labelE2Resources.Size = new System.Drawing.Size(37, 15);
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
            this.comboE2Map.Location = new System.Drawing.Point(133, 125);
            this.comboE2Map.Name = "comboE2Map";
            this.comboE2Map.Size = new System.Drawing.Size(121, 23);
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
            "Chapter 6"});
            this.comboE2Chapter.Location = new System.Drawing.Point(6, 125);
            this.comboE2Chapter.Name = "comboE2Chapter";
            this.comboE2Chapter.Size = new System.Drawing.Size(121, 23);
            this.comboE2Chapter.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Echelon 2";
            // 
            // labelE1Resources
            // 
            this.labelE1Resources.AutoSize = true;
            this.labelE1Resources.Location = new System.Drawing.Point(260, 78);
            this.labelE1Resources.Name = "labelE1Resources";
            this.labelE1Resources.Size = new System.Drawing.Size(37, 15);
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
            this.comboE1Map.Location = new System.Drawing.Point(133, 75);
            this.comboE1Map.Name = "comboE1Map";
            this.comboE1Map.Size = new System.Drawing.Size(121, 23);
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
            "Chapter 6"});
            this.comboE1Chapter.Location = new System.Drawing.Point(6, 75);
            this.comboE1Chapter.Name = "comboE1Chapter";
            this.comboE1Chapter.Size = new System.Drawing.Size(121, 23);
            this.comboE1Chapter.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Echelon 1";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(18, 481);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(76, 23);
            this.buttonCalculate.TabIndex = 11;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(117, 472);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(37, 15);
            this.labelOutput.TabIndex = 12;
            this.labelOutput.Text = "blank";
            // 
            // labelMaterials
            // 
            this.labelMaterials.AutoSize = true;
            this.labelMaterials.Location = new System.Drawing.Point(12, 126);
            this.labelMaterials.Name = "labelMaterials";
            this.labelMaterials.Size = new System.Drawing.Size(85, 15);
            this.labelMaterials.TabIndex = 13;
            this.labelMaterials.Text = "labelMaterials";
            // 
            // labelOutputDrops
            // 
            this.labelOutputDrops.AutoSize = true;
            this.labelOutputDrops.Location = new System.Drawing.Point(117, 495);
            this.labelOutputDrops.Name = "labelOutputDrops";
            this.labelOutputDrops.Size = new System.Drawing.Size(37, 15);
            this.labelOutputDrops.TabIndex = 14;
            this.labelOutputDrops.Text = "blank";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(670, 519);
            this.Controls.Add(this.labelOutputDrops);
            this.Controls.Add(this.labelMaterials);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxLogistics);
            this.Controls.Add(this.groupBoxDesired);
            this.Controls.Add(this.groupBoxCurrent);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.Text = "GF Resource Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numManpower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParts)).EndInit();
            this.groupBoxCurrent.ResumeLayout(false);
            this.groupBoxCurrent.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.Label labelOutput;
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
        private System.Windows.Forms.Label labelOutputDrops;
    }
}

