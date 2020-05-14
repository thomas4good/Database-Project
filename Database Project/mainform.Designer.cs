namespace Database_Project
{
    partial class mainform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_skills = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_kills = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_trader = new System.Windows.Forms.ComboBox();
            this.btn_items = new System.Windows.Forms.Button();
            this.btn_quests = new System.Windows.Forms.Button();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.questtreebtn = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_current = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.lbl_dip = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lbl_dip);
            this.panel1.Controls.Add(this.btn_display);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.cbx_current);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.questtreebtn);
            this.panel1.Controls.Add(this.btn_skills);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_kills);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx_trader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_skills
            // 
            this.btn_skills.Location = new System.Drawing.Point(40, 217);
            this.btn_skills.Name = "btn_skills";
            this.btn_skills.Size = new System.Drawing.Size(79, 23);
            this.btn_skills.TabIndex = 7;
            this.btn_skills.Text = "Skills";
            this.btn_skills.UseVisualStyleBackColor = true;
            this.btn_skills.Click += new System.EventHandler(this.btn_skills_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Display Required:";
            // 
            // btn_kills
            // 
            this.btn_kills.Location = new System.Drawing.Point(40, 166);
            this.btn_kills.Name = "btn_kills";
            this.btn_kills.Size = new System.Drawing.Size(79, 23);
            this.btn_kills.TabIndex = 5;
            this.btn_kills.Text = "Kills";
            this.btn_kills.UseVisualStyleBackColor = true;
            this.btn_kills.Click += new System.EventHandler(this.btn_kills_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trader:";
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
            this.cbx_trader.Location = new System.Drawing.Point(22, 23);
            this.cbx_trader.Name = "cbx_trader";
            this.cbx_trader.Size = new System.Drawing.Size(121, 21);
            this.cbx_trader.TabIndex = 0;
            // 
            // btn_items
            // 
            this.btn_items.Location = new System.Drawing.Point(40, 115);
            this.btn_items.Name = "btn_items";
            this.btn_items.Size = new System.Drawing.Size(79, 23);
            this.btn_items.TabIndex = 2;
            this.btn_items.Text = "Items";
            this.btn_items.UseVisualStyleBackColor = true;
            this.btn_items.Click += new System.EventHandler(this.btn_items_Click);
            // 
            // btn_quests
            // 
            this.btn_quests.Location = new System.Drawing.Point(40, 65);
            this.btn_quests.Name = "btn_quests";
            this.btn_quests.Size = new System.Drawing.Size(79, 23);
            this.btn_quests.TabIndex = 3;
            this.btn_quests.Text = "Show Quests";
            this.btn_quests.UseVisualStyleBackColor = true;
            this.btn_quests.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_main
            // 
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(186, 12);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.Size = new System.Drawing.Size(643, 329);
            this.dgv_main.TabIndex = 1;
            // 
            // questtreebtn
            // 
            this.questtreebtn.Location = new System.Drawing.Point(88, 424);
            this.questtreebtn.Name = "questtreebtn";
            this.questtreebtn.Size = new System.Drawing.Size(79, 23);
            this.questtreebtn.TabIndex = 4;
            this.questtreebtn.Text = "Quest Tree";
            this.questtreebtn.UseVisualStyleBackColor = true;
            this.questtreebtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(177, 402);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 31);
            this.lbl_info.TabIndex = 5;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(3, 424);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(79, 23);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Display current quest info:";
            // 
            // cbx_current
            // 
            this.cbx_current.FormattingEnabled = true;
            this.cbx_current.Items.AddRange(new object[] {
            "Therapist",
            "Prapor",
            "Peacekeeper",
            "Mechanic",
            "Jaeger",
            "Skier",
            "Ragman",
            "Fence"});
            this.cbx_current.Location = new System.Drawing.Point(7, 329);
            this.cbx_current.Name = "cbx_current";
            this.cbx_current.Size = new System.Drawing.Size(156, 21);
            this.cbx_current.TabIndex = 6;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(7, 356);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(88, 356);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(75, 23);
            this.btn_display.TabIndex = 11;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // lbl_dip
            // 
            this.lbl_dip.AutoSize = true;
            this.lbl_dip.Location = new System.Drawing.Point(40, 382);
            this.lbl_dip.Name = "lbl_dip";
            this.lbl_dip.Size = new System.Drawing.Size(84, 13);
            this.lbl_dip.TabIndex = 12;
            this.lbl_dip.Text = "Quest Displayed";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_quests);
            this.Controls.Add(this.btn_items);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.panel1);
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_trader;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.Button btn_items;
        private System.Windows.Forms.Button btn_quests;
        private System.Windows.Forms.Button questtreebtn;
        private System.Windows.Forms.Button btn_kills;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_skills;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_dip;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ComboBox cbx_current;
        private System.Windows.Forms.Label label2;
    }
}