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
            this.selecttraderbtn = new System.Windows.Forms.Button();
            this.submuittreebtn = new System.Windows.Forms.Button();
            this.traderlbl = new System.Windows.Forms.Label();
            this.tradercb = new System.Windows.Forms.ComboBox();
            this.questlbl = new System.Windows.Forms.Label();
            this.currentquestcb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.selecttraderbtn);
            this.panel1.Controls.Add(this.submuittreebtn);
            this.panel1.Controls.Add(this.traderlbl);
            this.panel1.Controls.Add(this.tradercb);
            this.panel1.Controls.Add(this.questlbl);
            this.panel1.Controls.Add(this.currentquestcb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 450);
            this.panel1.TabIndex = 2;
            // 
            // selecttraderbtn
            // 
            this.selecttraderbtn.Location = new System.Drawing.Point(51, 55);
            this.selecttraderbtn.Name = "selecttraderbtn";
            this.selecttraderbtn.Size = new System.Drawing.Size(110, 23);
            this.selecttraderbtn.TabIndex = 6;
            this.selecttraderbtn.Text = "Select Trader";
            this.selecttraderbtn.UseVisualStyleBackColor = true;
            this.selecttraderbtn.Click += new System.EventHandler(this.selecttraderbtn_Click);
            // 
            // submuittreebtn
            // 
            this.submuittreebtn.Location = new System.Drawing.Point(51, 415);
            this.submuittreebtn.Name = "submuittreebtn";
            this.submuittreebtn.Size = new System.Drawing.Size(110, 23);
            this.submuittreebtn.TabIndex = 5;
            this.submuittreebtn.Text = "See Quest Tree";
            this.submuittreebtn.UseVisualStyleBackColor = true;
            this.submuittreebtn.Click += new System.EventHandler(this.submuittreebtn_Click);
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
            this.tradercb.Items.AddRange(new object[] {
            "Therapist",
            "Prapor",
            "Peacekeeper",
            "Mechanic",
            "Jaeger",
            "Skier",
            "Ragman",
            "Fence",
            "All"});
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
            // questtree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_trader);
            this.Name = "questtree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "questtree";
            this.Load += new System.EventHandler(this.skilltree_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_trader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label questlbl;
        private System.Windows.Forms.ComboBox currentquestcb;
        private System.Windows.Forms.Label traderlbl;
        private System.Windows.Forms.ComboBox tradercb;
        private System.Windows.Forms.Button submuittreebtn;
        private System.Windows.Forms.Button selecttraderbtn;
    }
}