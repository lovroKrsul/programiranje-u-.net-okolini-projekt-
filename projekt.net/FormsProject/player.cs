using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormsProject
{
    public partial class player : UserControl
    {
        public bool dndSucess = false;
        public Control DNDcontrol;
        int counter = 0;

        public player()
        {
            InitializeComponent();


        }
        public player(string playerName, string playerNum,string captain, string playerPos, string path)
        {
            InitializeComponent();
            this.lbl_playerName.Text = playerName;
            this.lbl_playerPos.Text = playerPos;
            this.lbl_playerNum.Text = playerNum;
            this.lbl_playerCap.Text = captain;
            this.pb_player.ImageLocation = path;
            this.lbl_PlayerStar.Hide();
        }
        public void player_UpdateCMS(object sender, EventArgs e)
        {
            if (ObjectReferenceHolder.flp_favPlayers.Controls.Count == 3)
                contextMenuStrip1.Items[1].Text= "remove all from favorites";
            else
                contextMenuStrip1.Items[1].Text ="add to favourites";
        }
        public void player_UpdateCMS()
        {
            if (contextMenuStrip1.Items[1].Text == "add to favourites" && ObjectReferenceHolder.flp_favPlayers.Controls.Count == 3)
                contextMenuStrip1.Items[1].Text = "remove all from favorites";
            else
                contextMenuStrip1.Items[1].Text = "add to favourites";
        }
        private void lbl_playerNum_Click(object sender, EventArgs e)
        {

        }

        private void lbl_PlayerStar_Click(object sender, EventArgs e)
        {

        }

        private void player_Load(object sender, EventArgs e)
        {

        }
        public string ReturnName()
            {
            return this.lbl_playerName.Text;
            }

        public string ReturnNum()
        {
            return this.lbl_playerNum.Text;
        }
        public string RetunrImgPath()
        {
            return this.pb_player.ImageLocation;
        }
        public string ReturnCap()
        {
            return this.lbl_playerCap.Text;
        }
        public string ReturnPos()
        {
            return this.lbl_playerPos.Text;
        }
        public void SetInfo(string name,string number,bool captain,string pos)
        {
            this.lbl_playerName.Text = name;
            this.lbl_playerNum.Text = number;
            if(captain)
            {
                switch(UserInfo.lang)
                {
                    case "EN":
                        this.lbl_playerCap.Text = "Captain";
                        break;
                    case "HR":
                        this.lbl_playerCap.Text = "Kapetan";
                        break;
                }
                
            }
            this.lbl_playerPos.Text = pos.ToString();
        }
        public void ShowStar()
        {
            this.lbl_PlayerStar.Show();
        }
        //worldcup-sfg-io\worldcup.sfg.io\men
        private void pb_player_Click(object sender, EventArgs e)
        {
          
            //
        }

        private void player_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ObjectReferenceHolder.DNDsender = this;
                ObjectReferenceHolder.DNDsenderStar = this.lbl_PlayerStar;
                ObjectReferenceHolder.DNDsenderNum = this.lbl_playerNum;
                ObjectReferenceHolder.DNDsenderName = this.lbl_playerName;
                ObjectReferenceHolder.DNDsenderCap = this.lbl_playerCap;
                ObjectReferenceHolder.DNDsenderPath = this.pb_player.ImageLocation;
                ObjectReferenceHolder.DNDsenderCMS = contextMenuStrip1;
                ObjectReferenceHolder.DNDsenderPos = this.lbl_playerPos;
                this.DoDragDrop(sender, DragDropEffects.Move);
            }
            
            
        }

        
        private void player_MouseLeave(object sender, EventArgs e)
        {
            if (this.BackColor != Color.Green)
                this.BackColor = Color.Silver;
        }

        private void player_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void player_MouseEnter(object sender, EventArgs e)
        {

            if (this.BackColor != Color.Green)
                this.BackColor = Color.Blue;

        }

        private void player_DoubleClick(object sender, EventArgs e)
        {
            
            
           
        }

        private void player_Click(object sender, EventArgs e)
        {
            
        }

        private void player_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(contextMenuStrip1.Items[0].Text == "select")
            {
                if (ObjectReferenceHolder.selected.Count() + ObjectReferenceHolder.flp_favPlayers.Controls.Count < 3)
                {
                    if (this.BackColor != Color.Green)
                    {
                        this.BackColor = Color.Green;
                        ObjectReferenceHolder.selected.Add(this);
                        ObjectReferenceHolder.flp_favPlayers.Tag = counter++;
                    }
                    
                }  
                if (contextMenuStrip1.Items[0].Text == "select")
                {
                    contextMenuStrip1.Items[0].Text = "deselect";
                }
                else
                    contextMenuStrip1.Items[0].Text = "select";

            }
            else
            {
                if (this.BackColor == Color.Green)
                {
                    ObjectReferenceHolder.selected.Remove(this);
                    this.BackColor = Color.Silver;
                }
                if (contextMenuStrip1.Items[0].Text == "deselect")
                {
                    contextMenuStrip1.Items[0].Text = "select";
                }
            }

        }
        public void SetColor(Color c)
        {
            this.BackColor = c;
        }
        private void addToFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(contextMenuStrip1.Items[1].Text == "remove all from favorites")
            {
                DAL.dal.WriteFile(" ",UserInfo.path + @"\favourites.txt");
                foreach (Control c in ObjectReferenceHolder.flp_favPlayers.Controls)
                {
                    ObjectReferenceHolder.flp_players.Controls.Add(c);
                }
                ObjectReferenceHolder.flp_favPlayers.Controls.Clear();
                ObjectReferenceHolder.favPlayersList.Clear();
                //ObjectReferenceHolder.DNDsenderStar.Hide();
            }
            else
            {
                ObjectReferenceHolder.DNDsender = this;
                ObjectReferenceHolder.DNDsenderStar = this.lbl_PlayerStar;
                ObjectReferenceHolder.DNDsenderNum = this.lbl_playerNum;
                ObjectReferenceHolder.DNDsenderName = this.lbl_playerName;
                ObjectReferenceHolder.DNDsenderCap = this.lbl_playerCap;
                ObjectReferenceHolder.DNDsenderPath = this.pb_player.ImageLocation;
                ObjectReferenceHolder.DNDsenderCMS = contextMenuStrip1;
                ObjectReferenceHolder.DNDsenderPos = this.lbl_playerPos;

                StringBuilder sb = new StringBuilder();
                if (!DAL.dal.CheckFileExists(UserInfo.path, @"favourites.txt"))
                {
                    DAL.dal.CreateTextFile(UserInfo.path + @"\favourites.txt");
                }
                
                ObjectReferenceHolder.favPlayersList.Add(ObjectReferenceHolder.DNDsender as player);
                ObjectReferenceHolder.flp_favPlayers.Tag = counter++;
                ObjectReferenceHolder.PlayersList.Remove(ObjectReferenceHolder.DNDsender as player);
                if (ObjectReferenceHolder.flp_favPlayers.Controls.Count<3)
                {
                    
                    ObjectReferenceHolder.DNDsenderStar.Show();
                    ObjectReferenceHolder.flp_players.Controls.Remove(ObjectReferenceHolder.DNDsender);
                    ObjectReferenceHolder.flp_favPlayers.Controls.Add(ObjectReferenceHolder.DNDsender);


                    sb.Append(ObjectReferenceHolder.DNDsenderName.Text + "," + ObjectReferenceHolder.DNDsenderNum.Text + "," + ObjectReferenceHolder.DNDsenderCap.Text +","+ ObjectReferenceHolder.DNDsenderPos.Text +"," +ObjectReferenceHolder.DNDsenderPath+"#");
                   
                        string s = DAL.dal.ReadFile(UserInfo.path + @"\favourites.txt");
                    if (s.Count(f => (f == '#')) <= 3)
                    {
                        DAL.dal.AppendText(sb.ToString(), UserInfo.path + @"\favourites.txt");
                    }
                    

                }
                if (ObjectReferenceHolder.favPlayersList.Count >= 3)
                {
                    contextMenuStrip1.Items[1].Text = "remove all from favorites";
                }
                    

            }
            
        }

        private void pb_player_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.jpg;*.jpeg;*.png";
            openFileDialog.InitialDirectory = UserInfo.path;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                this.pb_player.ImageLocation = openFileDialog.FileName;
                //ObjectReferenceHolder.favPlayers[Array.IndexOf(ObjectReferenceHolder.favPlayers, this.lbl_playerName.Text)].imagePath = openFileDialog.FileName;
            }
            string[] favs = DAL.dal.ReadFileAsArray(UserInfo.path, @"\favourites.txt");
            DAL.dal.WriteFile("", UserInfo.path + @"\favourites.txt");

            for (int i = 0; i < favs.Length - 1; i++)
            {
                string[] details = favs[i].Split(',');
                if (details[0] == this.lbl_playerName.Text)
                {
                    details[4] = pb_player.ImageLocation;
                    StringBuilder sb = new StringBuilder();
                    sb.Append(details[0] + ",");
                    sb.Append(details[1] + ",");
                    sb.Append(details[2] + ",");
                    sb.Append(details[3] + ",");
                    sb.Append(details[4]);

                    favs[i] = sb.ToString();
                }

                DAL.dal.AppendText(favs[i] + "#", UserInfo.path + @"\favourites.txt");
            }

        }

        private void lbl_playerPos_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void lbl_playerPos_MouseLeave(object sender, EventArgs e)
        {
            if (this.BackColor != Color.Green)
                this.BackColor = Color.Silver;
        }

        private void lbl_playerPos_MouseEnter(object sender, EventArgs e)
        {
            if (this.BackColor != Color.Green)
                this.BackColor = Color.Blue;
        }

        private void lbl_playerCap_Click(object sender, EventArgs e)
        {

        }
        public void addCMS()
        {
            this.ContextMenuStrip = contextMenuStrip1;
        }
        public void removeCMS()
        {
            ContextMenuStrip = null;
        }

        private void lbl_playerPos_MouseHover_1(object sender, EventArgs e)
        {
           
        }

        private void player_MouseHover(object sender, EventArgs e)
        {
          
        }
    }
}
