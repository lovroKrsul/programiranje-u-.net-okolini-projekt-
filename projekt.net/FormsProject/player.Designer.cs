namespace FormsProject
{
    partial class player
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_playerName = new System.Windows.Forms.Label();
            this.lbl_playerNum = new System.Windows.Forms.Label();
            this.lbl_playerPos = new System.Windows.Forms.Label();
            this.lbl_playerCap = new System.Windows.Forms.Label();
            this.lbl_PlayerStar = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_player = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_playerName
            // 
            this.lbl_playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_playerName.Location = new System.Drawing.Point(83, 3);
            this.lbl_playerName.Name = "lbl_playerName";
            this.lbl_playerName.Size = new System.Drawing.Size(172, 23);
            this.lbl_playerName.TabIndex = 1;
            this.lbl_playerName.Text = "ime";
            this.lbl_playerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_playerName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.player_MouseDown);
            this.lbl_playerName.MouseEnter += new System.EventHandler(this.lbl_playerPos_MouseEnter);
            this.lbl_playerName.MouseLeave += new System.EventHandler(this.lbl_playerPos_MouseLeave);
            this.lbl_playerName.MouseHover += new System.EventHandler(this.lbl_playerPos_MouseHover_1);
            // 
            // lbl_playerNum
            // 
            this.lbl_playerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_playerNum.Location = new System.Drawing.Point(238, 41);
            this.lbl_playerNum.Name = "lbl_playerNum";
            this.lbl_playerNum.Size = new System.Drawing.Size(48, 23);
            this.lbl_playerNum.TabIndex = 2;
            this.lbl_playerNum.Text = "broj dresa";
            this.lbl_playerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_playerNum.Click += new System.EventHandler(this.lbl_playerNum_Click);
            this.lbl_playerNum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.player_MouseDown);
            this.lbl_playerNum.MouseEnter += new System.EventHandler(this.lbl_playerPos_MouseEnter);
            this.lbl_playerNum.MouseLeave += new System.EventHandler(this.lbl_playerPos_MouseLeave);
            this.lbl_playerNum.MouseHover += new System.EventHandler(this.lbl_playerPos_MouseHover_1);
            // 
            // lbl_playerPos
            // 
            this.lbl_playerPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_playerPos.Location = new System.Drawing.Point(101, 37);
            this.lbl_playerPos.Name = "lbl_playerPos";
            this.lbl_playerPos.Size = new System.Drawing.Size(77, 23);
            this.lbl_playerPos.TabIndex = 3;
            this.lbl_playerPos.Text = "poz";
            this.lbl_playerPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_playerPos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.player_MouseDown);
            this.lbl_playerPos.MouseEnter += new System.EventHandler(this.lbl_playerPos_MouseEnter);
            this.lbl_playerPos.MouseLeave += new System.EventHandler(this.lbl_playerPos_MouseLeave);
            this.lbl_playerPos.MouseHover += new System.EventHandler(this.lbl_playerPos_MouseHover_1);
            // 
            // lbl_playerCap
            // 
            this.lbl_playerCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_playerCap.Location = new System.Drawing.Point(163, 37);
            this.lbl_playerCap.Name = "lbl_playerCap";
            this.lbl_playerCap.Size = new System.Drawing.Size(48, 23);
            this.lbl_playerCap.TabIndex = 4;
            this.lbl_playerCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_playerCap.Click += new System.EventHandler(this.lbl_playerCap_Click);
            this.lbl_playerCap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.player_MouseDown);
            this.lbl_playerCap.MouseEnter += new System.EventHandler(this.lbl_playerPos_MouseEnter);
            this.lbl_playerCap.MouseLeave += new System.EventHandler(this.lbl_playerPos_MouseLeave);
            // 
            // lbl_PlayerStar
            // 
            this.lbl_PlayerStar.Font = new System.Drawing.Font("Wingdings", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_PlayerStar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_PlayerStar.Location = new System.Drawing.Point(261, 0);
            this.lbl_PlayerStar.Name = "lbl_PlayerStar";
            this.lbl_PlayerStar.Size = new System.Drawing.Size(42, 41);
            this.lbl_PlayerStar.TabIndex = 5;
            this.lbl_PlayerStar.Text = "«";
            this.lbl_PlayerStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_PlayerStar.Visible = false;
            this.lbl_PlayerStar.Click += new System.EventHandler(this.lbl_PlayerStar_Click);
            this.lbl_PlayerStar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.player_MouseDown);
            this.lbl_PlayerStar.MouseEnter += new System.EventHandler(this.lbl_playerPos_MouseEnter);
            this.lbl_PlayerStar.MouseLeave += new System.EventHandler(this.lbl_playerPos_MouseLeave);
            this.lbl_PlayerStar.MouseHover += new System.EventHandler(this.lbl_playerPos_MouseHover_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.addToFavoritesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 48);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.player_UpdateCMS);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.selectToolStripMenuItem.Text = "select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // addToFavoritesToolStripMenuItem
            // 
            this.addToFavoritesToolStripMenuItem.Name = "addToFavoritesToolStripMenuItem";
            this.addToFavoritesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addToFavoritesToolStripMenuItem.Text = "add to favourites";
            this.addToFavoritesToolStripMenuItem.Click += new System.EventHandler(this.addToFavoritesToolStripMenuItem_Click);
            // 
            // pb_player
            // 
            this.pb_player.BackgroundImage = global::FormsProject.Properties.Resources.player;
            this.pb_player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_player.Location = new System.Drawing.Point(0, 0);
            this.pb_player.Name = "pb_player";
            this.pb_player.Size = new System.Drawing.Size(95, 75);
            this.pb_player.TabIndex = 6;
            this.pb_player.TabStop = false;
            this.pb_player.Click += new System.EventHandler(this.pb_player_Click_1);
            this.pb_player.MouseDown += new System.Windows.Forms.MouseEventHandler(this.player_MouseDown);
            this.pb_player.MouseEnter += new System.EventHandler(this.lbl_playerPos_MouseEnter);
            this.pb_player.MouseLeave += new System.EventHandler(this.lbl_playerPos_MouseLeave);
            this.pb_player.MouseHover += new System.EventHandler(this.lbl_playerPos_MouseHover_1);
            // 
            // player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pb_player);
            this.Controls.Add(this.lbl_PlayerStar);
            this.Controls.Add(this.lbl_playerCap);
            this.Controls.Add(this.lbl_playerPos);
            this.Controls.Add(this.lbl_playerNum);
            this.Controls.Add(this.lbl_playerName);
            this.Name = "player";
            this.Size = new System.Drawing.Size(301, 75);
            this.Load += new System.EventHandler(this.player_Load);
            this.Click += new System.EventHandler(this.player_Click);
            this.DoubleClick += new System.EventHandler(this.player_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.player_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.player_MouseDown);
            this.MouseEnter += new System.EventHandler(this.player_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.player_MouseLeave);
            this.MouseHover += new System.EventHandler(this.player_MouseHover);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_playerName;
        private System.Windows.Forms.Label lbl_playerNum;
        private System.Windows.Forms.Label lbl_playerPos;
        private System.Windows.Forms.Label lbl_playerCap;
        private System.Windows.Forms.Label lbl_PlayerStar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToFavoritesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_player;
    }
}
