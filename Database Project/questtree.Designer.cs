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
            this.AllQuestsPanel = new System.Windows.Forms.Panel();
            this.TherapistPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.AllQuestsPanel.SuspendLayout();
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
            this.viewquesttreebtn.Text = "See Quest Tree";
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
            // TherapistPanel
            // 
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
        private System.Windows.Forms.Panel TherapistPanel;
    }
}