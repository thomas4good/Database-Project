namespace Database_Project
{
    partial class questtree
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
            this.cbx_trader = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewquesttreebtn = new System.Windows.Forms.Button();
            this.traderlbl = new System.Windows.Forms.Label();
            this.tradercb = new System.Windows.Forms.ComboBox();
            this.questlbl = new System.Windows.Forms.Label();
            this.currentquestcb = new System.Windows.Forms.ComboBox();
            this.questnamelbl = new System.Windows.Forms.Label();
            this.questdesclbl = new System.Windows.Forms.Label();
            this.questgiverlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.questnamedb = new System.Windows.Forms.Label();
            this.questgiverdb = new System.Windows.Forms.Label();
            this.questdescdb = new System.Windows.Forms.Label();
            this.AllQuestsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Shortagelbl = new System.Windows.Forms.Label();
            this.Sanitary1lbl = new System.Windows.Forms.Label();
            this.aqua1lbl = new System.Windows.Forms.Label();
            this.painlbl = new System.Windows.Forms.Label();
            this.pharmlbl = new System.Windows.Forms.Label();
            this.hipplbl = new System.Windows.Forms.Label();
            this.Sanitary2lbl = new System.Windows.Forms.Label();
            this.agua2lbl = new System.Windows.Forms.Label();
            this.health1lbl = new System.Windows.Forms.Label();
            this.generallbl1 = new System.Windows.Forms.Label();
            this.supplbl = new System.Windows.Forms.Label();
            this.carlbl = new System.Windows.Forms.Label();
            this.health2lbl = new System.Windows.Forms.Label();
            this.health3lbl = new System.Windows.Forms.Label();
            this.privlbl = new System.Windows.Forms.Label();
            this.health4lbl = new System.Windows.Forms.Label();
            this.athletelbl = new System.Windows.Forms.Label();
            this.deconlbl = new System.Windows.Forms.Label();
            this.health5lbl = new System.Windows.Forms.Label();
            this.TherapistPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.AllQuestsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TherapistPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_trader
            // 
            this.cbx_trader.FormattingEnabled = true;
            this.cbx_trader.Items.AddRange(new object[] {
            "Therapist",
            "Prapor",
            "Peacekeeper",
            "Mechanic",
            "Jaeger",
            "Skier",
            "Ragman",
            "Fence"});
            this.cbx_trader.Location = new System.Drawing.Point(12, 12);
            this.cbx_trader.Name = "cbx_trader";
            this.cbx_trader.Size = new System.Drawing.Size(121, 21);
            this.cbx_trader.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.viewquesttreebtn);
            this.panel1.Controls.Add(this.traderlbl);
            this.panel1.Controls.Add(this.tradercb);
            this.panel1.Controls.Add(this.questlbl);
            this.panel1.Controls.Add(this.currentquestcb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 1041);
            this.panel1.TabIndex = 2;
            // 
            // viewquesttreebtn
            // 
            this.viewquesttreebtn.Location = new System.Drawing.Point(51, 557);
            this.viewquesttreebtn.Name = "viewquesttreebtn";
            this.viewquesttreebtn.Size = new System.Drawing.Size(110, 23);
            this.viewquesttreebtn.TabIndex = 5;
            this.viewquesttreebtn.Text = "See Full Quest Tree";
            this.viewquesttreebtn.UseVisualStyleBackColor = true;
            this.viewquesttreebtn.Click += new System.EventHandler(this.submuittreebtn_Click);
            // 
            // traderlbl
            // 
            this.traderlbl.AutoSize = true;
            this.traderlbl.Location = new System.Drawing.Point(89, 12);
            this.traderlbl.Name = "traderlbl";
            this.traderlbl.Size = new System.Drawing.Size(41, 13);
            this.traderlbl.TabIndex = 3;
            this.traderlbl.Text = "Trader:";
            // 
            // tradercb
            // 
            this.tradercb.FormattingEnabled = true;
            this.tradercb.Location = new System.Drawing.Point(12, 28);
            this.tradercb.Name = "tradercb";
            this.tradercb.Size = new System.Drawing.Size(184, 21);
            this.tradercb.TabIndex = 2;
            this.tradercb.SelectedIndexChanged += new System.EventHandler(this.tradercb_SelectedIndexChanged);
            // 
            // questlbl
            // 
            this.questlbl.AutoSize = true;
            this.questlbl.Location = new System.Drawing.Point(74, 173);
            this.questlbl.Name = "questlbl";
            this.questlbl.Size = new System.Drawing.Size(75, 13);
            this.questlbl.TabIndex = 1;
            this.questlbl.Text = "Current Quest:";
            this.questlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentquestcb
            // 
            this.currentquestcb.Enabled = false;
            this.currentquestcb.FormattingEnabled = true;
            this.currentquestcb.Location = new System.Drawing.Point(12, 189);
            this.currentquestcb.Name = "currentquestcb";
            this.currentquestcb.Size = new System.Drawing.Size(184, 21);
            this.currentquestcb.TabIndex = 0;
            this.currentquestcb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // questnamelbl
            // 
            this.questnamelbl.AutoSize = true;
            this.questnamelbl.Location = new System.Drawing.Point(9, 52);
            this.questnamelbl.Name = "questnamelbl";
            this.questnamelbl.Size = new System.Drawing.Size(69, 13);
            this.questnamelbl.TabIndex = 6;
            this.questnamelbl.Text = "Quest Name:";
            // 
            // questdesclbl
            // 
            this.questdesclbl.AutoSize = true;
            this.questdesclbl.Location = new System.Drawing.Point(9, 115);
            this.questdesclbl.Name = "questdesclbl";
            this.questdesclbl.Size = new System.Drawing.Size(94, 13);
            this.questdesclbl.TabIndex = 7;
            this.questdesclbl.Text = "Quest Description:";
            // 
            // questgiverlbl
            // 
            this.questgiverlbl.AutoSize = true;
            this.questgiverlbl.Location = new System.Drawing.Point(9, 11);
            this.questgiverlbl.Name = "questgiverlbl";
            this.questgiverlbl.Size = new System.Drawing.Size(66, 13);
            this.questgiverlbl.TabIndex = 8;
            this.questgiverlbl.Text = "Quest Giver:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 736);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // questnamedb
            // 
            this.questnamedb.Location = new System.Drawing.Point(81, 52);
            this.questnamedb.Name = "questnamedb";
            this.questnamedb.Size = new System.Drawing.Size(142, 13);
            this.questnamedb.TabIndex = 10;
            this.questnamedb.Text = "Name";
            // 
            // questgiverdb
            // 
            this.questgiverdb.Location = new System.Drawing.Point(81, 11);
            this.questgiverdb.Name = "questgiverdb";
            this.questgiverdb.Size = new System.Drawing.Size(142, 13);
            this.questgiverdb.TabIndex = 11;
            this.questgiverdb.Text = "Name";
            // 
            // questdescdb
            // 
            this.questdescdb.Location = new System.Drawing.Point(3, 137);
            this.questdescdb.Name = "questdescdb";
            this.questdescdb.Size = new System.Drawing.Size(220, 309);
            this.questdescdb.TabIndex = 12;
            this.questdescdb.Text = "Description";
            // 
            // AllQuestsPanel
            // 
            this.AllQuestsPanel.BackgroundImage = global::Database_Project.Properties.Resources.Quest_Tree;
            this.AllQuestsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AllQuestsPanel.Controls.Add(this.TherapistPanel);
            this.AllQuestsPanel.Location = new System.Drawing.Point(229, 1);
            this.AllQuestsPanel.Name = "AllQuestsPanel";
            this.AllQuestsPanel.Size = new System.Drawing.Size(1673, 1040);
            this.AllQuestsPanel.TabIndex = 3;
            this.AllQuestsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TherapistPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.questgiverlbl);
            this.panel2.Controls.Add(this.questdescdb);
            this.panel2.Controls.Add(this.questnamelbl);
            this.panel2.Controls.Add(this.questnamedb);
            this.panel2.Controls.Add(this.questdesclbl);
            this.panel2.Controls.Add(this.questgiverdb);
            this.panel2.Location = new System.Drawing.Point(0, 586);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 455);
            this.panel2.TabIndex = 13;
            // 
            // Shortagelbl
            // 
            this.Shortagelbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Shortagelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Shortagelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shortagelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Shortagelbl.Location = new System.Drawing.Point(4, 293);
            this.Shortagelbl.Name = "Shortagelbl";
            this.Shortagelbl.Size = new System.Drawing.Size(159, 48);
            this.Shortagelbl.TabIndex = 11;
            this.Shortagelbl.Tag = "1";
            this.Shortagelbl.Text = "Shortage";
            this.Shortagelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sanitary1lbl
            // 
            this.Sanitary1lbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Sanitary1lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sanitary1lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sanitary1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sanitary1lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sanitary1lbl.Location = new System.Drawing.Point(169, 217);
            this.Sanitary1lbl.Name = "Sanitary1lbl";
            this.Sanitary1lbl.Size = new System.Drawing.Size(159, 48);
            this.Sanitary1lbl.TabIndex = 31;
            this.Sanitary1lbl.Tag = "2";
            this.Sanitary1lbl.Text = "Sanitary Standards - Part 1";
            this.Sanitary1lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aqua1lbl
            // 
            this.aqua1lbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.aqua1lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aqua1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aqua1lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aqua1lbl.Location = new System.Drawing.Point(169, 367);
            this.aqua1lbl.Name = "aqua1lbl";
            this.aqua1lbl.Size = new System.Drawing.Size(159, 48);
            this.aqua1lbl.TabIndex = 32;
            this.aqua1lbl.Tag = "2";
            this.aqua1lbl.Text = "Operation Aquarius - Part 1";
            this.aqua1lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painlbl
            // 
            this.painlbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.painlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.painlbl.Location = new System.Drawing.Point(496, 293);
            this.painlbl.Name = "painlbl";
            this.painlbl.Size = new System.Drawing.Size(159, 48);
            this.painlbl.TabIndex = 35;
            this.painlbl.Tag = "4";
            this.painlbl.Text = "Painkiller";
            this.painlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pharmlbl
            // 
            this.pharmlbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pharmlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pharmlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pharmlbl.Location = new System.Drawing.Point(661, 293);
            this.pharmlbl.Name = "pharmlbl";
            this.pharmlbl.Size = new System.Drawing.Size(159, 48);
            this.pharmlbl.TabIndex = 38;
            this.pharmlbl.Tag = "5";
            this.pharmlbl.Text = "Pharmacist";
            this.pharmlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hipplbl
            // 
            this.hipplbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.hipplbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hipplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hipplbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hipplbl.Location = new System.Drawing.Point(991, 469);
            this.hipplbl.Name = "hipplbl";
            this.hipplbl.Size = new System.Drawing.Size(159, 48);
            this.hipplbl.TabIndex = 43;
            this.hipplbl.Tag = "8";
            this.hipplbl.Text = "Hippocratic Vow";
            this.hipplbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sanitary2lbl
            // 
            this.Sanitary2lbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Sanitary2lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sanitary2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sanitary2lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sanitary2lbl.Location = new System.Drawing.Point(334, 217);
            this.Sanitary2lbl.Name = "Sanitary2lbl";
            this.Sanitary2lbl.Size = new System.Drawing.Size(159, 48);
            this.Sanitary2lbl.TabIndex = 51;
            this.Sanitary2lbl.Tag = "3";
            this.Sanitary2lbl.Text = "Sanitary Standards - Part 2";
            this.Sanitary2lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agua2lbl
            // 
            this.agua2lbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.agua2lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agua2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agua2lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agua2lbl.Location = new System.Drawing.Point(334, 367);
            this.agua2lbl.Name = "agua2lbl";
            this.agua2lbl.Size = new System.Drawing.Size(159, 46);
            this.agua2lbl.TabIndex = 52;
            this.agua2lbl.Tag = "3";
            this.agua2lbl.Text = "Operation Aquarius - Part 2";
            this.agua2lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // health1lbl
            // 
            this.health1lbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.health1lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.health1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health1lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.health1lbl.Location = new System.Drawing.Point(826, 217);
            this.health1lbl.Name = "health1lbl";
            this.health1lbl.Size = new System.Drawing.Size(159, 48);
            this.health1lbl.TabIndex = 53;
            this.health1lbl.Tag = "6";
            this.health1lbl.Text = "Health Care Privacy - Part 1";
            this.health1lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generallbl1
            // 
            this.generallbl1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.generallbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generallbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generallbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generallbl1.Location = new System.Drawing.Point(826, 293);
            this.generallbl1.Name = "generallbl1";
            this.generallbl1.Size = new System.Drawing.Size(159, 48);
            this.generallbl1.TabIndex = 54;
            this.generallbl1.Tag = "6";
            this.generallbl1.Text = "General Wares";
            this.generallbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supplbl
            // 
            this.supplbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.supplbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.supplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.supplbl.Location = new System.Drawing.Point(826, 367);
            this.supplbl.Name = "supplbl";
            this.supplbl.Size = new System.Drawing.Size(159, 48);
            this.supplbl.TabIndex = 55;
            this.supplbl.Tag = "6";
            this.supplbl.Text = "Supply Plans";
            this.supplbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carlbl
            // 
            this.carlbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.carlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.carlbl.Location = new System.Drawing.Point(991, 293);
            this.carlbl.Name = "carlbl";
            this.carlbl.Size = new System.Drawing.Size(159, 48);
            this.carlbl.TabIndex = 56;
            this.carlbl.Tag = "7";
            this.carlbl.Text = "Car Repair";
            this.carlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // health2lbl
            // 
            this.health2lbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.health2lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.health2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health2lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.health2lbl.Location = new System.Drawing.Point(991, 217);
            this.health2lbl.Name = "health2lbl";
            this.health2lbl.Size = new System.Drawing.Size(159, 48);
            this.health2lbl.TabIndex = 57;
            this.health2lbl.Tag = "7";
            this.health2lbl.Text = "Health Care Privacy - Part 2";
            this.health2lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // health3lbl
            // 
            this.health3lbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.health3lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.health3lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health3lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.health3lbl.Location = new System.Drawing.Point(1156, 217);
            this.health3lbl.Name = "health3lbl";
            this.health3lbl.Size = new System.Drawing.Size(159, 48);
            this.health3lbl.TabIndex = 58;
            this.health3lbl.Tag = "8";
            this.health3lbl.Text = "Health Care Privacy - Part 3";
            this.health3lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // privlbl
            // 
            this.privlbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.privlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.privlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.privlbl.Location = new System.Drawing.Point(1321, 293);
            this.privlbl.Name = "privlbl";
            this.privlbl.Size = new System.Drawing.Size(159, 48);
            this.privlbl.TabIndex = 59;
            this.privlbl.Tag = "10";
            this.privlbl.Text = "Private Clinic";
            this.privlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // health4lbl
            // 
            this.health4lbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.health4lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.health4lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health4lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.health4lbl.Location = new System.Drawing.Point(1321, 217);
            this.health4lbl.Name = "health4lbl";
            this.health4lbl.Size = new System.Drawing.Size(159, 48);
            this.health4lbl.TabIndex = 60;
            this.health4lbl.Tag = "9";
            this.health4lbl.Text = "Health Care Privacy - Part 4";
            this.health4lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // athletelbl
            // 
            this.athletelbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.athletelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.athletelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.athletelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.athletelbl.Location = new System.Drawing.Point(1321, 153);
            this.athletelbl.Name = "athletelbl";
            this.athletelbl.Size = new System.Drawing.Size(159, 48);
            this.athletelbl.TabIndex = 61;
            this.athletelbl.Tag = "10";
            this.athletelbl.Text = "Athlete";
            this.athletelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deconlbl
            // 
            this.deconlbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.deconlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deconlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deconlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deconlbl.Location = new System.Drawing.Point(1486, 293);
            this.deconlbl.Name = "deconlbl";
            this.deconlbl.Size = new System.Drawing.Size(159, 48);
            this.deconlbl.TabIndex = 62;
            this.deconlbl.Tag = "11";
            this.deconlbl.Text = "Decontamination Service";
            this.deconlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // health5lbl
            // 
            this.health5lbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.health5lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.health5lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health5lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.health5lbl.Location = new System.Drawing.Point(1486, 217);
            this.health5lbl.Name = "health5lbl";
            this.health5lbl.Size = new System.Drawing.Size(159, 48);
            this.health5lbl.TabIndex = 63;
            this.health5lbl.Tag = "10";
            this.health5lbl.Text = "Health Care Privacy - Part 5";
            this.health5lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TherapistPanel
            // 
            this.TherapistPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.TherapistPanel.Controls.Add(this.health5lbl);
            this.TherapistPanel.Controls.Add(this.deconlbl);
            this.TherapistPanel.Controls.Add(this.athletelbl);
            this.TherapistPanel.Controls.Add(this.health4lbl);
            this.TherapistPanel.Controls.Add(this.privlbl);
            this.TherapistPanel.Controls.Add(this.health3lbl);
            this.TherapistPanel.Controls.Add(this.health2lbl);
            this.TherapistPanel.Controls.Add(this.carlbl);
            this.TherapistPanel.Controls.Add(this.supplbl);
            this.TherapistPanel.Controls.Add(this.generallbl1);
            this.TherapistPanel.Controls.Add(this.health1lbl);
            this.TherapistPanel.Controls.Add(this.agua2lbl);
            this.TherapistPanel.Controls.Add(this.Sanitary2lbl);
            this.TherapistPanel.Controls.Add(this.hipplbl);
            this.TherapistPanel.Controls.Add(this.pharmlbl);
            this.TherapistPanel.Controls.Add(this.painlbl);
            this.TherapistPanel.Controls.Add(this.aqua1lbl);
            this.TherapistPanel.Controls.Add(this.Sanitary1lbl);
            this.TherapistPanel.Controls.Add(this.Shortagelbl);
            this.TherapistPanel.Location = new System.Drawing.Point(0, 0);
            this.TherapistPanel.Name = "TherapistPanel";
            this.TherapistPanel.Size = new System.Drawing.Size(1673, 1040);
            this.TherapistPanel.TabIndex = 4;
            // 
            // questtree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.AllQuestsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_trader);
            this.Name = "questtree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "questtree";
            this.Load += new System.EventHandler(this.skilltree_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AllQuestsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TherapistPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_trader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label questlbl;
        private System.Windows.Forms.ComboBox currentquestcb;
        private System.Windows.Forms.Label traderlbl;
        private System.Windows.Forms.ComboBox tradercb;
        private System.Windows.Forms.Button viewquesttreebtn;
        private System.Windows.Forms.Panel AllQuestsPanel;
        private System.Windows.Forms.Label questdescdb;
        private System.Windows.Forms.Label questgiverdb;
        private System.Windows.Forms.Label questnamedb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label questgiverlbl;
        private System.Windows.Forms.Label questdesclbl;
        private System.Windows.Forms.Label questnamelbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel TherapistPanel;
        private System.Windows.Forms.Label health5lbl;
        private System.Windows.Forms.Label deconlbl;
        private System.Windows.Forms.Label athletelbl;
        private System.Windows.Forms.Label health4lbl;
        private System.Windows.Forms.Label privlbl;
        private System.Windows.Forms.Label health3lbl;
        private System.Windows.Forms.Label health2lbl;
        private System.Windows.Forms.Label carlbl;
        private System.Windows.Forms.Label supplbl;
        private System.Windows.Forms.Label generallbl1;
        private System.Windows.Forms.Label health1lbl;
        private System.Windows.Forms.Label agua2lbl;
        private System.Windows.Forms.Label Sanitary2lbl;
        private System.Windows.Forms.Label hipplbl;
        private System.Windows.Forms.Label pharmlbl;
        private System.Windows.Forms.Label painlbl;
        private System.Windows.Forms.Label aqua1lbl;
        private System.Windows.Forms.Label Sanitary1lbl;
        private System.Windows.Forms.Label Shortagelbl;
    }
}