﻿namespace Database_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_trader = new System.Windows.Forms.ComboBox();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.btn_items = new System.Windows.Forms.Button();
            this.btn_quests = new System.Windows.Forms.Button();
            this.skilltreebtn = new System.Windows.Forms.Button();
            this.btn_kills = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_skills = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_skills);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.skilltreebtn);
            this.panel1.Controls.Add(this.btn_kills);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx_trader);
            this.panel1.Controls.Add(this.btn_items);
            this.panel1.Controls.Add(this.btn_quests);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 450);
            this.panel1.TabIndex = 0;
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
            // dgv_main
            // 
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(186, 12);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.Size = new System.Drawing.Size(602, 329);
            this.dgv_main.TabIndex = 1;
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
            // skilltreebtn
            // 
            this.skilltreebtn.Location = new System.Drawing.Point(40, 405);
            this.skilltreebtn.Name = "skilltreebtn";
            this.skilltreebtn.Size = new System.Drawing.Size(79, 23);
            this.skilltreebtn.TabIndex = 4;
            this.skilltreebtn.Text = "Skill Tree";
            this.skilltreebtn.UseVisualStyleBackColor = true;
            this.skilltreebtn.Click += new System.EventHandler(this.button1_Click_1);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seach Quests";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seach Quests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seach Quests";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Seach Quests";
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
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_trader;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.Button btn_items;
        private System.Windows.Forms.Button btn_quests;
        private System.Windows.Forms.Button skilltreebtn;
        private System.Windows.Forms.Button btn_kills;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_skills;
    }
}