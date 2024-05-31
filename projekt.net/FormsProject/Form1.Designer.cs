using System;

namespace FormsProject
{
    partial class fm_winForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_winForms));
            this.pnl_page1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_readType = new System.Windows.Forms.Label();
            this.rb_web = new System.Windows.Forms.RadioButton();
            this.rb_file = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_league = new System.Windows.Forms.Label();
            this.rb_leagueFemale = new System.Windows.Forms.RadioButton();
            this.rb_leagueMale = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_lang = new System.Windows.Forms.Label();
            this.rb_langHR = new System.Windows.Forms.RadioButton();
            this.rb_langEN = new System.Windows.Forms.RadioButton();
            this.pnl_page2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_favPlayers = new System.Windows.Forms.TabPage();
            this.flp_players = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_favs = new System.Windows.Forms.Label();
            this.lbl_players = new System.Windows.Forms.Label();
            this.pnl_favPlayers = new System.Windows.Forms.Panel();
            this.flp_favPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Players = new System.Windows.Forms.Panel();
            this.tb_favRep = new System.Windows.Forms.TabPage();
            this.btn_leagueBrowse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_repPath = new System.Windows.Forms.TextBox();
            this.cb_favRep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_rankings = new System.Windows.Forms.TabPage();
            this.tb_ranking = new System.Windows.Forms.TabControl();
            this.tb_igraci = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_igraci = new System.Windows.Forms.DataGridView();
            this.tb_utakmice = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_utakmice = new System.Windows.Forms.DataGridView();
            this.tb_settings = new System.Windows.Forms.TabPage();
            this.btn_confirmChanges = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_settingsFileW = new System.Windows.Forms.RadioButton();
            this.rb_settingsFileF = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_settingsLeagueF = new System.Windows.Forms.RadioButton();
            this.rb_settingsLeagueM = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_settingsLangHR = new System.Windows.Forms.RadioButton();
            this.rb_settingsLangEN = new System.Windows.Forms.RadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.playerRankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchRankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_page1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_page2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tb_favPlayers.SuspendLayout();
            this.pnl_favPlayers.SuspendLayout();
            this.tb_favRep.SuspendLayout();
            this.tb_rankings.SuspendLayout();
            this.tb_ranking.SuspendLayout();
            this.tb_igraci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_igraci)).BeginInit();
            this.tb_utakmice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_utakmice)).BeginInit();
            this.tb_settings.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerRankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchRankBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_page1
            // 
            resources.ApplyResources(this.pnl_page1, "pnl_page1");
            this.pnl_page1.Controls.Add(this.panel3);
            this.pnl_page1.Controls.Add(this.label1);
            this.pnl_page1.Controls.Add(this.btn_submit);
            this.pnl_page1.Controls.Add(this.panel2);
            this.pnl_page1.Controls.Add(this.panel1);
            this.pnl_page1.Name = "pnl_page1";
            this.pnl_page1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_page1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_readType);
            this.panel3.Controls.Add(this.rb_web);
            this.panel3.Controls.Add(this.rb_file);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // lbl_readType
            // 
            resources.ApplyResources(this.lbl_readType, "lbl_readType");
            this.lbl_readType.Name = "lbl_readType";
            // 
            // rb_web
            // 
            resources.ApplyResources(this.rb_web, "rb_web");
            this.rb_web.Name = "rb_web";
            this.rb_web.TabStop = true;
            this.rb_web.UseVisualStyleBackColor = true;
            this.rb_web.CheckedChanged += new System.EventHandler(this.rb_web_CheckedChanged);
            // 
            // rb_file
            // 
            resources.ApplyResources(this.rb_file, "rb_file");
            this.rb_file.Checked = true;
            this.rb_file.Name = "rb_file";
            this.rb_file.TabStop = true;
            this.rb_file.UseVisualStyleBackColor = true;
            this.rb_file.CheckedChanged += new System.EventHandler(this.rb_file_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btn_submit, "btn_submit");
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_league);
            this.panel2.Controls.Add(this.rb_leagueFemale);
            this.panel2.Controls.Add(this.rb_leagueMale);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lbl_league
            // 
            resources.ApplyResources(this.lbl_league, "lbl_league");
            this.lbl_league.Name = "lbl_league";
            // 
            // rb_leagueFemale
            // 
            resources.ApplyResources(this.rb_leagueFemale, "rb_leagueFemale");
            this.rb_leagueFemale.Name = "rb_leagueFemale";
            this.rb_leagueFemale.TabStop = true;
            this.rb_leagueFemale.UseVisualStyleBackColor = true;
            this.rb_leagueFemale.CheckedChanged += new System.EventHandler(this.rb_leagueFemale_CheckedChanged);
            // 
            // rb_leagueMale
            // 
            resources.ApplyResources(this.rb_leagueMale, "rb_leagueMale");
            this.rb_leagueMale.Checked = true;
            this.rb_leagueMale.Name = "rb_leagueMale";
            this.rb_leagueMale.TabStop = true;
            this.rb_leagueMale.UseVisualStyleBackColor = true;
            this.rb_leagueMale.CheckedChanged += new System.EventHandler(this.rb_leagueMale_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_lang);
            this.panel1.Controls.Add(this.rb_langHR);
            this.panel1.Controls.Add(this.rb_langEN);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lbl_lang
            // 
            resources.ApplyResources(this.lbl_lang, "lbl_lang");
            this.lbl_lang.Name = "lbl_lang";
            // 
            // rb_langHR
            // 
            resources.ApplyResources(this.rb_langHR, "rb_langHR");
            this.rb_langHR.Name = "rb_langHR";
            this.rb_langHR.UseVisualStyleBackColor = true;
            this.rb_langHR.CheckedChanged += new System.EventHandler(this.rb_langHR_CheckedChanged);
            // 
            // rb_langEN
            // 
            resources.ApplyResources(this.rb_langEN, "rb_langEN");
            this.rb_langEN.Checked = true;
            this.rb_langEN.Name = "rb_langEN";
            this.rb_langEN.TabStop = true;
            this.rb_langEN.UseVisualStyleBackColor = true;
            this.rb_langEN.CheckedChanged += new System.EventHandler(this.rb_langEN_CheckedChanged);
            // 
            // pnl_page2
            // 
            resources.ApplyResources(this.pnl_page2, "pnl_page2");
            this.pnl_page2.Controls.Add(this.tabControl1);
            this.pnl_page2.Name = "pnl_page2";
            this.pnl_page2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_page2_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tb_favPlayers);
            this.tabControl1.Controls.Add(this.tb_favRep);
            this.tabControl1.Controls.Add(this.tb_rankings);
            this.tabControl1.Controls.Add(this.tb_settings);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tb_favPlayers
            // 
            this.tb_favPlayers.Controls.Add(this.flp_players);
            this.tb_favPlayers.Controls.Add(this.lbl_favs);
            this.tb_favPlayers.Controls.Add(this.lbl_players);
            this.tb_favPlayers.Controls.Add(this.pnl_favPlayers);
            this.tb_favPlayers.Controls.Add(this.pnl_Players);
            resources.ApplyResources(this.tb_favPlayers, "tb_favPlayers");
            this.tb_favPlayers.Name = "tb_favPlayers";
            this.tb_favPlayers.UseVisualStyleBackColor = true;
            this.tb_favPlayers.Click += new System.EventHandler(this.tb_favPlayers_Click);
            // 
            // flp_players
            // 
            this.flp_players.AllowDrop = true;
            resources.ApplyResources(this.flp_players, "flp_players");
            this.flp_players.BackColor = System.Drawing.Color.Silver;
            this.flp_players.Name = "flp_players";
            this.flp_players.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_players_Paint);
            // 
            // lbl_favs
            // 
            resources.ApplyResources(this.lbl_favs, "lbl_favs");
            this.lbl_favs.Name = "lbl_favs";
            // 
            // lbl_players
            // 
            resources.ApplyResources(this.lbl_players, "lbl_players");
            this.lbl_players.Name = "lbl_players";
            // 
            // pnl_favPlayers
            // 
            this.pnl_favPlayers.BackColor = System.Drawing.Color.Silver;
            this.pnl_favPlayers.Controls.Add(this.flp_favPlayers);
            resources.ApplyResources(this.pnl_favPlayers, "pnl_favPlayers");
            this.pnl_favPlayers.Name = "pnl_favPlayers";
            // 
            // flp_favPlayers
            // 
            this.flp_favPlayers.AllowDrop = true;
            resources.ApplyResources(this.flp_favPlayers, "flp_favPlayers");
            this.flp_favPlayers.Name = "flp_favPlayers";
            this.flp_favPlayers.Tag = "0";
            this.flp_favPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flp_favPlayrs_DragDrop);
            this.flp_favPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.flp_favPlayers_DragEnter);
            this.flp_favPlayers.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_favPlayers_Paint);
            // 
            // pnl_Players
            // 
            this.pnl_Players.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.pnl_Players, "pnl_Players");
            this.pnl_Players.Name = "pnl_Players";
            // 
            // tb_favRep
            // 
            this.tb_favRep.Controls.Add(this.btn_leagueBrowse);
            this.tb_favRep.Controls.Add(this.label6);
            this.tb_favRep.Controls.Add(this.tb_repPath);
            this.tb_favRep.Controls.Add(this.cb_favRep);
            this.tb_favRep.Controls.Add(this.label2);
            resources.ApplyResources(this.tb_favRep, "tb_favRep");
            this.tb_favRep.Name = "tb_favRep";
            this.tb_favRep.UseVisualStyleBackColor = true;
            this.tb_favRep.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_leagueBrowse
            // 
            resources.ApplyResources(this.btn_leagueBrowse, "btn_leagueBrowse");
            this.btn_leagueBrowse.Name = "btn_leagueBrowse";
            this.btn_leagueBrowse.UseVisualStyleBackColor = true;
            this.btn_leagueBrowse.Click += new System.EventHandler(this.btn_leagueBrowse_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tb_repPath
            // 
            resources.ApplyResources(this.tb_repPath, "tb_repPath");
            this.tb_repPath.Name = "tb_repPath";
            this.tb_repPath.TextChanged += new System.EventHandler(this.tb_repPath_TextChanged);
            // 
            // cb_favRep
            // 
            this.cb_favRep.FormattingEnabled = true;
            resources.ApplyResources(this.cb_favRep, "cb_favRep");
            this.cb_favRep.Name = "cb_favRep";
            this.cb_favRep.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cb_favRep.Click += new System.EventHandler(this.cb_favRep_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_rankings
            // 
            this.tb_rankings.Controls.Add(this.tb_ranking);
            resources.ApplyResources(this.tb_rankings, "tb_rankings");
            this.tb_rankings.Name = "tb_rankings";
            this.tb_rankings.UseVisualStyleBackColor = true;
            // 
            // tb_ranking
            // 
            this.tb_ranking.Controls.Add(this.tb_igraci);
            this.tb_ranking.Controls.Add(this.tb_utakmice);
            resources.ApplyResources(this.tb_ranking, "tb_ranking");
            this.tb_ranking.Name = "tb_ranking";
            this.tb_ranking.SelectedIndex = 0;
            // 
            // tb_igraci
            // 
            this.tb_igraci.Controls.Add(this.button1);
            this.tb_igraci.Controls.Add(this.dgv_igraci);
            resources.ApplyResources(this.tb_igraci, "tb_igraci");
            this.tb_igraci.Name = "tb_igraci";
            this.tb_igraci.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_igraci
            // 
            this.dgv_igraci.AllowUserToAddRows = false;
            this.dgv_igraci.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgv_igraci, "dgv_igraci");
            this.dgv_igraci.Name = "dgv_igraci";
            this.dgv_igraci.ReadOnly = true;
            this.dgv_igraci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_igraci_CellContentClick_1);
            // 
            // tb_utakmice
            // 
            this.tb_utakmice.Controls.Add(this.button2);
            this.tb_utakmice.Controls.Add(this.dgv_utakmice);
            resources.ApplyResources(this.tb_utakmice, "tb_utakmice");
            this.tb_utakmice.Name = "tb_utakmice";
            this.tb_utakmice.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_utakmice
            // 
            this.dgv_utakmice.AllowUserToAddRows = false;
            this.dgv_utakmice.AllowUserToDeleteRows = false;
            this.dgv_utakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_utakmice, "dgv_utakmice");
            this.dgv_utakmice.Name = "dgv_utakmice";
            this.dgv_utakmice.ReadOnly = true;
            this.dgv_utakmice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_utakmice_CellContentClick_1);
            // 
            // tb_settings
            // 
            this.tb_settings.Controls.Add(this.btn_confirmChanges);
            this.tb_settings.Controls.Add(this.panel4);
            this.tb_settings.Controls.Add(this.panel5);
            this.tb_settings.Controls.Add(this.panel6);
            resources.ApplyResources(this.tb_settings, "tb_settings");
            this.tb_settings.Name = "tb_settings";
            this.tb_settings.UseVisualStyleBackColor = true;
            // 
            // btn_confirmChanges
            // 
            resources.ApplyResources(this.btn_confirmChanges, "btn_confirmChanges");
            this.btn_confirmChanges.Name = "btn_confirmChanges";
            this.btn_confirmChanges.UseVisualStyleBackColor = true;
            this.btn_confirmChanges.Click += new System.EventHandler(this.btn_confirmChanges_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.rb_settingsFileW);
            this.panel4.Controls.Add(this.rb_settingsFileF);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // rb_settingsFileW
            // 
            resources.ApplyResources(this.rb_settingsFileW, "rb_settingsFileW");
            this.rb_settingsFileW.Name = "rb_settingsFileW";
            this.rb_settingsFileW.TabStop = true;
            this.rb_settingsFileW.UseVisualStyleBackColor = true;
            this.rb_settingsFileW.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_settingsFileF
            // 
            resources.ApplyResources(this.rb_settingsFileF, "rb_settingsFileF");
            this.rb_settingsFileF.Checked = true;
            this.rb_settingsFileF.Name = "rb_settingsFileF";
            this.rb_settingsFileF.TabStop = true;
            this.rb_settingsFileF.UseVisualStyleBackColor = true;
            this.rb_settingsFileF.CheckedChanged += new System.EventHandler(this.rb_settingsFileF_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.rb_settingsLeagueF);
            this.panel5.Controls.Add(this.rb_settingsLeagueM);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // rb_settingsLeagueF
            // 
            resources.ApplyResources(this.rb_settingsLeagueF, "rb_settingsLeagueF");
            this.rb_settingsLeagueF.Name = "rb_settingsLeagueF";
            this.rb_settingsLeagueF.TabStop = true;
            this.rb_settingsLeagueF.UseVisualStyleBackColor = true;
            this.rb_settingsLeagueF.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rb_settingsLeagueM
            // 
            resources.ApplyResources(this.rb_settingsLeagueM, "rb_settingsLeagueM");
            this.rb_settingsLeagueM.Checked = true;
            this.rb_settingsLeagueM.Name = "rb_settingsLeagueM";
            this.rb_settingsLeagueM.TabStop = true;
            this.rb_settingsLeagueM.UseVisualStyleBackColor = true;
            this.rb_settingsLeagueM.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.rb_settingsLangHR);
            this.panel6.Controls.Add(this.rb_settingsLangEN);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // rb_settingsLangHR
            // 
            resources.ApplyResources(this.rb_settingsLangHR, "rb_settingsLangHR");
            this.rb_settingsLangHR.Name = "rb_settingsLangHR";
            this.rb_settingsLangHR.UseVisualStyleBackColor = true;
            this.rb_settingsLangHR.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rb_settingsLangEN
            // 
            resources.ApplyResources(this.rb_settingsLangEN, "rb_settingsLangEN");
            this.rb_settingsLangEN.Checked = true;
            this.rb_settingsLangEN.Name = "rb_settingsLangEN";
            this.rb_settingsLangEN.TabStop = true;
            this.rb_settingsLangEN.UseVisualStyleBackColor = true;
            this.rb_settingsLangEN.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // playerRankBindingSource
            // 
            this.playerRankBindingSource.DataSource = typeof(DAL.playerRank);
            // 
            // matchRankBindingSource
            // 
            this.matchRankBindingSource.DataSource = typeof(DAL.matchRank);
            // 
            // fm_winForms
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_page2);
            this.Controls.Add(this.pnl_page1);
            this.Name = "fm_winForms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fm_winForms_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_page1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_page2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tb_favPlayers.ResumeLayout(false);
            this.tb_favPlayers.PerformLayout();
            this.pnl_favPlayers.ResumeLayout(false);
            this.tb_favRep.ResumeLayout(false);
            this.tb_favRep.PerformLayout();
            this.tb_rankings.ResumeLayout(false);
            this.tb_ranking.ResumeLayout(false);
            this.tb_igraci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_igraci)).EndInit();
            this.tb_utakmice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_utakmice)).EndInit();
            this.tb_settings.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerRankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchRankBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel pnl_page1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_league;
        private System.Windows.Forms.RadioButton rb_leagueFemale;
        private System.Windows.Forms.RadioButton rb_leagueMale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_lang;
        private System.Windows.Forms.RadioButton rb_langHR;
        private System.Windows.Forms.RadioButton rb_langEN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_readType;
        private System.Windows.Forms.RadioButton rb_web;
        private System.Windows.Forms.RadioButton rb_file;
        private System.Windows.Forms.Panel pnl_page2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tb_favRep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tb_favPlayers;
        private System.Windows.Forms.ComboBox cb_favRep;
        private System.Windows.Forms.TabPage tb_rankings;
        private System.Windows.Forms.TabPage tb_settings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_settingsFileW;
        private System.Windows.Forms.RadioButton rb_settingsFileF;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_settingsLeagueF;
        private System.Windows.Forms.RadioButton rb_settingsLeagueM;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_settingsLangHR;
        private System.Windows.Forms.RadioButton rb_settingsLangEN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_repPath;
        private System.Windows.Forms.Button btn_leagueBrowse;
        private System.Windows.Forms.Button btn_confirmChanges;
        private System.Windows.Forms.Panel pnl_Players;
        private System.Windows.Forms.Panel pnl_favPlayers;
        private System.Windows.Forms.Label lbl_favs;
        private System.Windows.Forms.Label lbl_players;
        private System.Windows.Forms.FlowLayoutPanel flp_favPlayers;
        private System.Windows.Forms.FlowLayoutPanel flp_players;
        private System.Windows.Forms.TabControl tb_ranking;
        private System.Windows.Forms.TabPage tb_igraci;
        private System.Windows.Forms.TabPage tb_utakmice;
        private System.Windows.Forms.BindingSource playerRankBindingSource;
        private System.Windows.Forms.BindingSource matchRankBindingSource;
        private System.Windows.Forms.DataGridView dgv_igraci;
        private System.Windows.Forms.DataGridView dgv_utakmice;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button2;
    }
}

