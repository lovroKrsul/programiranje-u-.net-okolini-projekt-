using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject
{
  
    public partial class fm_winForms : Form
    {
      List<player> players = new List<player>();
        List<player> favs = new List<player>();
        List<DAL.playerRank> PlayerRanks = new List<DAL.playerRank>();
        List<DAL.matchRank> MatchRanks = new List<DAL.matchRank>();
        
        public fm_winForms()
        {   
           
           InitializeComponent();

            setObjectReferences();
            

            if ( skipIntro())
            {
                parsePreferences();
               
                

                if (UserInfo.lang == "HR")
                {   //uđe al ne radi
                    this.Controls.Clear();
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hr");

                    
                    //dupla window kod exita
                    InitializeComponent();
                    this.FormClosing -= new FormClosingEventHandler(fm_winForms_FormClosing);


                    setObjectReferences();
                }
                else
                {    
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

                    this.Controls.Clear();
                    
                   
                    InitializeComponent();
                    this.FormClosing -= new FormClosingEventHandler(fm_winForms_FormClosing);
                    setObjectReferences();
                }
  
                skipIntro();
                
                LoadPlayersFromFavs();
                
                LoadPlayerRankings();
                
                loadMatchRankings();
                var xyz = Thread.CurrentThread.CurrentCulture;
            }
           
            
           

            flp_players.DragDrop += new DragEventHandler(flp_playrs_DragDrop);
            flp_players.DragDrop += new DragEventHandler(flp_playrs_DragEnter);
            flp_favPlayers.DragDrop += new DragEventHandler(flp_favPlayrs_DragDrop);
            flp_favPlayers.DragDrop += new DragEventHandler(flp_favPlayrs_DragDrop);

            




        }
      
        private void flp_favPlayrs_DragDrop(object sender, DragEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
           
            if (!DAL.dal.CheckFileExists(UserInfo.path, @"favourites.txt"))
            {
                DAL.dal.CreateTextFile(UserInfo.path + @"\favourites.txt");
            }


            if (ObjectReferenceHolder.DNDsender.BackColor == Color.Green)
            {
               
                for(int i=0;i<ObjectReferenceHolder.selected.Count;i++)
                {
                    //ObjectReferenceHolder.selected[i].BackColor = Color.Silver;
                   
                    sb.Append(ObjectReferenceHolder.selected[i].ReturnName() + "," + ObjectReferenceHolder.selected[i].ReturnNum() + "," + ObjectReferenceHolder.selected[i].ReturnCap()+ "," + ObjectReferenceHolder.selected[i].ReturnPos()+"," + ObjectReferenceHolder.selected[i].RetunrImgPath() + "#");
                 
                    favs.Add(ObjectReferenceHolder.selected[i]);
                    players.Remove(ObjectReferenceHolder.selected[i]);
                   
                    //ObjectReferenceHolder.selected[i].BackColor = Color.Silver;
                    if (flp_favPlayers.Controls.Count<3)
                    {
                        flp_players.Controls.Remove(ObjectReferenceHolder.selected[i]);
                        flp_favPlayers.Controls.Add(ObjectReferenceHolder.selected[i]);
                        ObjectReferenceHolder.selected[i].removeCMS();
                        ObjectReferenceHolder.selected[i].ShowStar();

                    }
                    else if(flp_favPlayers.Controls.Count == 3)
                    {
                        foreach(var selected in ObjectReferenceHolder.selected)
                        {
                            selected.player_UpdateCMS();
                        }
                    }
                   

                }

                
            }
            else
            {
                e.Effect = DragDropEffects.Move;
                favs.Add(ObjectReferenceHolder.DNDsender as player);

                players.Remove(ObjectReferenceHolder.DNDsender as player);
                if (flp_favPlayers.Controls.Count<3)
                {
                    ObjectReferenceHolder.DNDsenderStar.Show();
                    //if(flp_favPlayers.Controls.Count ==2)
                   
                    flp_players.Controls.Remove(ObjectReferenceHolder.DNDsender);
                    flp_favPlayers.Controls.Add(ObjectReferenceHolder.DNDsender);
                    ObjectReferenceHolder.DNDsenderCMS=null;
                   


                    sb.Append(ObjectReferenceHolder.DNDsenderName.Text + "," + ObjectReferenceHolder.DNDsenderNum.Text + ","+ ObjectReferenceHolder.DNDsenderCap.Text+ "," +ObjectReferenceHolder.DNDsenderPos.Text+ "," + ObjectReferenceHolder.DNDsenderPath+ "#");
                    if (favs.Count % 3 == 1)
                    {
                        DAL.dal.AppendText(sb.ToString(), UserInfo.path + @"\favourites.txt");
                    }
                }


               
            }

            for (int i = 0; i < ObjectReferenceHolder.selected.Count; i++)
            {
                ObjectReferenceHolder.selected[i].BackColor = Color.Silver;
            }
            ObjectReferenceHolder.selected.Clear();



            DAL.dal.AppendText(sb.ToString(), UserInfo.path + @"\favourites.txt");

        }

        private void flp_playrs_DragEnter(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void flp_playrs_DragDrop(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
          

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
           
        }
       
        private void rb_langHR_CheckedChanged(object sender, EventArgs e)
        {
            UserInfo.lang = "HR";
        }

        private void rb_langEN_CheckedChanged(object sender, EventArgs e)
        {
            UserInfo.lang = "EN";
        }

        private void rb_leagueFemale_CheckedChanged(object sender, EventArgs e)
        {
            UserInfo.league = "F";
        }

        private void rb_leagueMale_CheckedChanged(object sender, EventArgs e)
        {
            UserInfo.league = "M";
        }
        private bool skipIntro()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append(Environment.CurrentDirectory);
            if(DAL.dal.CheckFileExists(sb.ToString(),"preferences.txt"))
            {

               
                pnl_page1.Hide();
               
                pnl_page2.Show();
                return true;
            }
            return false;
        }

        private void pnl_page1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pnl_page2_Paint(object sender, PaintEventArgs e)
        {
        }
     
        private void btn_submit_Click_1(object sender, EventArgs e)
        {

            Form2 f2 = new Form2(pnl_page1,pnl_page2);
            ObjectReferenceHolder.form2 = f2;
            f2.Show();

        }

        private void rb_file_CheckedChanged(object sender, EventArgs e)
        {
            UserInfo.readType = "FILE";
          
        }

        private void rb_web_CheckedChanged(object sender, EventArgs e)
        {
            UserInfo.readType = "WEB";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
        private void parsePreferences()
        {

           StringBuilder sb=new StringBuilder();
            sb.Append(Environment.CurrentDirectory);
            if (DAL.dal.CheckFileExists(sb.ToString(),@"preferences.txt"))
                {
                
                string[] strings = DAL.dal.ReadPreferences(sb.ToString());
                UserInfo.lang = strings?[0];
                UserInfo.league = strings?[1];
                UserInfo.path = strings?[2];
                UserInfo.readType = strings?[3];
                UserInfo.favoriteRep = strings?[4];
                UserInfo.resolution = strings?[5];


            }
            



        }

       
        private void setObjectReferences()
        {
            ObjectReferenceHolder.form1 = this;
            ObjectReferenceHolder.page1 = pnl_page1;
            ObjectReferenceHolder.page2 = pnl_page2;
            ObjectReferenceHolder.langEN = rb_settingsLangEN;
            ObjectReferenceHolder.langHR = rb_settingsLangHR;
            ObjectReferenceHolder.fileF = rb_settingsFileF;
            ObjectReferenceHolder.fileW = rb_settingsFileW;
            ObjectReferenceHolder.leagueF = rb_settingsLeagueF;
            ObjectReferenceHolder.leagueM = rb_settingsLeagueM;
            ObjectReferenceHolder.favPlayersList = favs;
            ObjectReferenceHolder.PlayersList = players;
            ObjectReferenceHolder.flp_favPlayers = flp_favPlayers;
            ObjectReferenceHolder.flp_players = flp_players;
            // ObjectReferenceHolder.rankingsByMatch = pnl_rankingsByMatch;
            // ObjectReferenceHolder.rankingsByPlayer = pnl_rankingsByPlayer;
            // ObjectReferenceHolder.favReps = pnl_favReps;
            //ObjectReferenceHolder.favPlayers =favPlayers;
            // ObjectReferenceHolder.Flp = flp_menu;
        }

        private void loadComboBox(string path)

        {
          
                cb_favRep.Items.Clear();
            
            if(UserInfo.readType=="WEB")
            {
                switch(UserInfo.league)
                {
                    case "M":
                        DAL.dal.SaveJsonFromWeb("http://world-cup-json-2018.herokuapp.com/teams/results", "json.txt", UserInfo.path);
                        break;
                    case "F":
                        DAL.dal.SaveJsonFromWeb("http://worldcup.sfg.io/teams/results", "json.txt", UserInfo.path);
                        break;

                    default: break;
                }


               try
                {
                    List<DAL.Representation> reps = DAL.dal.ReadJsonReps(path + @"\json.txt");
                    foreach (var i in reps)
                    {
                        cb_favRep.Items.Add(i.fifa_code+ ":" + i.country).ToString().Trim();
                        int c = 0;
                        if(c==reps.Count())
                        {
                            cb_favRep.Text = (i.fifa_code + ":" + i.country);
                        }
                    }
                    
               }
                catch (Exception e)
                {
                    Error err = new Error("no such file",e.Message);
                    err.Show();
                }
                
            }
            else if (UserInfo.readType == "FILE")
            {
                
                try
                {
                    List<DAL.Representation> reps = new List<DAL.Representation>();
                    switch (UserInfo.league)
                    {
                         
                        case "M":
                        //treba promjenit na resurces path
                        
                       
                            reps = DAL.dal.ReadJsonReps(Environment.CurrentDirectory + @"\Resources\worldcup-sfg-io\worldcup.sfg.io\men\teams.json");
                            break;
                        case "F":
                            //treba promjenit na resurces path
                            reps = DAL.dal.ReadJsonReps(Environment.CurrentDirectory + @"\Resources\worldcup-sfg-io\worldcup.sfg.io\women\teams.json");
                            break;
                    }
                   
                    foreach (var i in reps)
                    {
                        cb_favRep.Items.Add(i.fifa_code + ": " + i.country);
                       
                    }
                }
                catch (Exception e)
                {
                    Error err = new Error("no such file", e.Message);
                    err.Show();
                }
            }
            else
            {

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserInfo.favoriteRep = cb_favRep.Text;
            DAL.dal.WriteFile($"{UserInfo.lang}#{UserInfo.league}#{UserInfo.path}#{UserInfo.readType}#{UserInfo.favoriteRep.Trim()}#{UserInfo.resolution}",UserInfo.path+@"\preferences.txt");
            
            if(DAL.dal.CheckFileExists(UserInfo.path, @"\favourites.txt"))
            {
                DAL.dal.WriteFile("", UserInfo.path + @"\favourites.txt");
                flp_favPlayers.Controls.Clear();

                flp_players.Controls.Clear();
                loadPlayers();
            }
            
            PlayerRanks.Clear();
            LoadPlayerRankings();
            loadMatchRankings();
            
            //loadMatchesIntoTable();
            
            //loadPlayersIntoTable();
        }
        private void LoadPlayersFromFavs()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append(Environment.CurrentDirectory);
            
            string[] pref= DAL.dal.ReadPreferences(sb.ToString());
            UserInfo.favoriteRep = pref[4];
            List<string> players = new List<string>();           
            if (!DAL.dal.CheckFileEmpty(UserInfo.path + @"\favourites.txt"))
            {
               
                string[] faves = DAL.dal.ReadFileAsArray(UserInfo.path, @"\favourites.txt");
               for (int i=0; i<faves.Count()-1; i++)
                {
                    string[] favs_i = faves[i].Split(',');
                        favs_i.Count();
                    player p = new player(favs_i[0], favs_i[1], favs_i[2], favs_i[3], favs_i[4]);
                    players.Add(favs_i[0]);
                    p.ShowStar();
                    ObjectReferenceHolder.favPlayersList.Add(p);
                    p.removeCMS();
                    flp_favPlayers.Controls.Add(p);


                   





                }

               
                
            }
            loadPlayers(players);


        }





    
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void showError(string text)
        {
            Error e= new Error("error",text);
        }

        public bool langChanged = false;
        public bool fileChanged = false;
        public bool leagueChanged = false;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_settingsFileW.Checked)
            {
                fileChanged = !fileChanged;
            }
            UserInfo.readType = "WEB";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            if (rb_settingsLeagueF.Checked)
            {
                leagueChanged = !leagueChanged;
            }
            UserInfo.league = "M";
        }

        private void sradioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_settingsFileF.Checked)
            {
                fileChanged = !fileChanged;
            }
            UserInfo.readType = "FILE";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_settingsLangHR.Checked)
            {
                langChanged = !langChanged;
            }
            UserInfo.lang = "HR";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
             if (rb_settingsLeagueM.Checked)
            {
                leagueChanged = !leagueChanged;
            }
            UserInfo.league = "F";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_settingsLangEN.Checked)
            {
                langChanged = !langChanged;
            }
            UserInfo.lang = "EN";
        }

        private void fm_winForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(UserInfo.lang=="HR")
            {
                DialogResult r = MessageBox.Show("Sigurno želite izači", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }


            }
            else
            {
                DialogResult r = MessageBox.Show("Are you sure you wish to exit", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }



        }

        private void btn_leagueBrowse_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.SelectedPath = tb_repPath.Text;
            fbd.ShowDialog();

            tb_repPath.Text = fbd.SelectedPath;


        }

        private void tb_repPath_TextChanged(object sender, EventArgs e)
        {
            if (DAL.dal.CheckFileExists(tb_repPath.Text, "results.txt"))
            {
               // UserInfo.leaguePath = tb_repPath.Text;
            }
               
            else

            {
                Error err = new Error("error","path does not exist",false);
               
                err.Show();
            }
        }

        private void cb_favRep_Click(object sender, EventArgs e)
        {
            //this.Controls.Clear();
            loadComboBox(UserInfo.path);

            
            
        }

        private void btn_confirmChanges_Click(object sender, EventArgs e)
        {
            ConfirmationForm cf = new ConfirmationForm(this);
            cf.Text = "Are you sure you want to save changes?";
            cf.Show();
           
              
        }

        private void tb_favPlayers_Click(object sender, EventArgs e)
        {

        }
        private void loadPlayers()
        {
            //dobi listu iz jsona
            List<DAL.Match> matches = new List<DAL.Match>();
            DAL.Match m=new DAL.Match();
            List<DAL.Player> players = new List<DAL.Player>();
            string path = "";
           
            string url = "";
            switch (UserInfo.readType)
            {
                
                case"WEB":
                    if (UserInfo.league == "F")
                    {
                        url = "http://worldcup.sfg.io/matches";
                    }
                    else if (UserInfo.league == "M")
                    {
                       url = "http://world-cup-json-2018.herokuapp.com/matches";

                    }
                    DAL.dal.SaveJsonFromWeb(url, @"\matchesJson.json", UserInfo.path);
                    matches = DAL.dal.ReadJsonMatch(UserInfo.path + @"\matchesJson.json");
                    break;
                    

                case "FILE":
                    if(UserInfo.league=="F")
                    {
                        path = @"Resources\worldcup-sfg-io\worldcup.sfg.io\women\matches.json";
                    }
                    else if(UserInfo.league=="M")
                    {
                        path = @"Resources\worldcup-sfg-io\worldcup.sfg.io\men\matches.json";

                    }
                    
                 
                    matches=DAL.dal.ReadJsonMatch(path);
                  
                    break;
            }
            //izaberi pravi i uloadaj
            var g = UserInfo.favoriteRep;
            
            var c = UserInfo.favoriteRep.Substring(4).Trim();
               
           
            //ne radi za web a radi iz fajla O_o
            m =matches.FirstOrDefault(match=>match.HomeTeamCountry.Trim()==UserInfo.favoriteRep.Substring(4).Trim());
            if(m==null)
            {
                if(UserInfo.lang=="HR")
                {
                    Error err = new Error("greska", "nema te zemlje u listi");
                    err.Show();
                }
                else
                {
                    Error err = new Error("error", "no such country");
                    err.Show();
                }
                
            }

            foreach (DAL.StartingEleven e in m.HomeTeamStatistics.StartingEleven)
            {
                players.Add(new DAL.Player
                {
                    name = e.Name,
                    number = e.ShirtNumber.ToString(),
                    position = e.Position,
                    captain = e.Captain,
                    favourite = false
                });
            }
            foreach (DAL.StartingEleven e in m.HomeTeamStatistics.Substitutes)
            {
                players.Add(new DAL.Player
                {
                    name = e.Name,
                    number = e.ShirtNumber.ToString(),
                    position = e.Position,
                    captain = e.Captain,
                    favourite = false

                });

            }


            foreach(DAL.Player p in players)
            {
                player pl = new player();
                pl.SetInfo(p.name, p.number, p.captain, p.position);

                if (!flp_favPlayers.Controls.Contains(pl))
                    pl.addCMS();
                flp_players.Controls.Add(pl);

            }
        }


        private void loadPlayers(List<string> pls)
        {
            List<DAL.Match> matches = new List<DAL.Match>();
            DAL.Match m = new DAL.Match();
            List<DAL.Player> players = new List<DAL.Player>();
            string path = @"C:\Users\THEMAN\source\repos\projekt.net\FormsProject\Resources\worldcup-sfg-io\worldcup.sfg.io\women\matches.json";

            string url = "";
            switch (UserInfo.readType)
            {

                case "WEB":
                    if (UserInfo.league == "F")
                    {
                        url = "http://worldcup.sfg.io/matches";
                    }
                    else if (UserInfo.league == "M")
                    {
                        url = "http://world-cup-json-2018.herokuapp.com/matches";

                    }
                    DAL.dal.SaveJsonFromWeb(url, @"\matchesJson.json", UserInfo.path);
                    matches = DAL.dal.ReadJsonMatch(UserInfo.path + @"\matchesJson.json");
                    break;


                case "FILE":
                    if (UserInfo.league == "F")
                    {
                        path = @"Resources\worldcup-sfg-io\worldcup.sfg.io\women\matches.json";
                    }
                    else if (UserInfo.league == "M")
                    {
                        path = @"Resources\worldcup-sfg-io\worldcup.sfg.io\men\matches.json";

                    }


                    matches = DAL.dal.ReadJsonMatch(path);

                    break;
            }
            //izaberi pravi i uloadaj
            var g = UserInfo.favoriteRep;

            var c = UserInfo.favoriteRep.Substring(4).Trim();


            //ne radi za web a radi iz fajla O_o
            
           
                m = matches.FirstOrDefault(match => match.HomeTeamCountry.Trim() == UserInfo.favoriteRep.Substring(4).Trim());
            if(m==null)
            {
                m = matches.FirstOrDefault(match => match.HomeTeamCountry.Trim() == "England");
                if (UserInfo.lang=="EN")
                {
                   
                    var result = MessageBox.Show("", "representation set to england because no your selected representation wasn't on the list, please choose new representation", MessageBoxButtons.OK);
                }
                else
                {
                   
                    var result = MessageBox.Show("", "reprezentacija je postavljena na engleku jer odabrana reprezentacija nije bila na listi, molim odaberite novu reprezentaciju", MessageBoxButtons.OK);
                }
             
               
            }

            
            
           
                foreach (DAL.StartingEleven e in m.HomeTeamStatistics.StartingEleven)

                {
                    players.Add(new DAL.Player
                    {
                        name = e.Name,
                        number = e.ShirtNumber.ToString(),
                        position = e.Position,
                        captain = e.Captain,
                        favourite = false
                    });
                }
            
            


            foreach (DAL.StartingEleven e in m.HomeTeamStatistics.StartingEleven)
            {
                players.Add(new DAL.Player
                {
                    name = e.Name,
                    number = e.ShirtNumber.ToString(),
                    position = e.Position,
                    captain = e.Captain,
                    favourite = false
                });
            }
            foreach (DAL.StartingEleven e in m.HomeTeamStatistics.Substitutes)
            {
                players.Add(new DAL.Player
                {
                    name = e.Name,
                    number = e.ShirtNumber.ToString(),
                    position = e.Position,
                    captain = e.Captain,
                    favourite = false

                });

            }


            foreach (DAL.Player p in players)
            {
                player pl = new player();
                pl.SetInfo(p.name, p.number, p.captain, p.position);

                if (!flp_favPlayers.Controls.Contains(pl))
                {

                    if (!pls.Contains(pl.ReturnName()))
                    {
                        pl.addCMS();
                        flp_players.Controls.Add(pl);
                    }
                       
                }
                   

            }
        }

        private void flp_players_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flp_favPlayers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flp_favPlayers_DragEnter(object sender, DragEventArgs e)
        {
      
            e.Effect = DragDropEffects.Move;
        }
        public void LoadPlayerRankings()
        {
           
            List<DAL.Match> matches = new List<DAL.Match>();
            DAL.Match m = new DAL.Match();
            List<DAL.playerRank> players = new List<DAL.playerRank>();
            PlayerRanks.Clear();
            
            string path = "";

            string url = "";
            switch (UserInfo.readType)
            {

                case "WEB":
                    if (UserInfo.league == "F")
                    {
                        url = "http://worldcup.sfg.io/matches";
                    }
                    else if (UserInfo.league == "M")
                    {
                        url = "http://world-cup-json-2018.herokuapp.com/matches";

                    }
                    DAL.dal.SaveJsonFromWeb(url, "matchesJson.json", UserInfo.path);
                    matches = DAL.dal.ReadJsonMatch(UserInfo.path + @"\matchesJson.json");
                    break;


                case "FILE":
                    if (UserInfo.league == "F")
                    {
                        path = @"Resources\worldcup-sfg-io\worldcup.sfg.io\women\matches.json";
                    }
                    else if (UserInfo.league == "M")
                    {
                        path = @"Resources\worldcup-sfg-io\worldcup.sfg.io\men\matches.json";

                    }


                    matches = DAL.dal.ReadJsonMatch(path);

                    break;
            }

            //Do shit
            
             foreach (DAL.Match match in matches)
            {
                
                if (match.HomeTeamCountry == UserInfo.favoriteRep.Substring(4).Trim() || match.AwayTeamCountry == UserInfo.favoriteRep.Substring(4).Trim())
                {
                    m = match;
                    foreach (var e in m.HomeTeamEvents)
                    {
                        if (e.TypeOfEvent == "yellow-card" || e.TypeOfEvent == "goal")
                        {
                            var x = e.TypeOfEvent;
                            switch (e.TypeOfEvent)

                            {
                                case "yellow-card":
                                    if (PlayerRanks.FirstOrDefault(pl => pl.Name == e.Player) == null)
                                    {
                                        string img = Environment.CurrentDirectory + @"\Resources\player.jpg";
                                        
                                        for (int i = 0; i < favs.Count; i++)
                                        {
                                            if (favs.FirstOrDefault(f => favs[i].Name == e.Player) != null)
                                            {
                                                img = favs[i].RetunrImgPath();
                                            }

                                        }

                                        PlayerRanks.Add(new DAL.playerRank
                                        {
                                            Name = e.Player,
                                            goal = 0,
                                            yellow = 1,
                                            ImgPath = img
                                        }
                                        ); ;
                                    }
                                    else
                                    {
                                        PlayerRanks.Find(pl => pl.Name == e.Player).yellow += 1;
                                    }

                                    break;
                                case "goal":
                                    if (PlayerRanks.FirstOrDefault(pl => pl.Name == e.Player) == null)
                                    {
                                        string img = Environment.CurrentDirectory+ @"\Resources\player.jpg";
                                        for (int i = 0; i < favs.Count; i++)
                                        {
                                            if (favs.FirstOrDefault(f => favs[i].Name == e.Player) != null)
                                            {
                                                img = favs[i].RetunrImgPath();
                                            }

                                        }
                                        PlayerRanks.Add(new DAL.playerRank
                                        {
                                            Name = e.Player,
                                            goal = 1,
                                            yellow = 0,
                                            ImgPath = img
                                        }
                                        );

                                    }
                                    else
                                    {
                                        PlayerRanks.Find(pl => pl.Name == e.Player).goal += 1;
                                    }

                                    break;
                            }

                        }
                    }
                
                
                    
                    foreach (var e in m.AwayTeamEvents)
                    {
                        if (e.TypeOfEvent == "yellow-card" || e.TypeOfEvent == "goal")
                        {
                            var x = e.TypeOfEvent;
                            switch (e.TypeOfEvent)
                            {
                                case "goal":
                                    if (PlayerRanks.FirstOrDefault(pl => pl.Name == e.Player) == null)
                                    {
                                        string img = Environment.CurrentDirectory + @"\Resources\player.jpg";
                                        for (int i = 0; i < favs.Count; i++)
                                        {
                                            if (favs.FirstOrDefault(f => favs[i].Name == e.Player) != null)
                                            {
                                                img = favs[i].RetunrImgPath();
                                            }

                                        }
                                        PlayerRanks.Add(new DAL.playerRank
                                        {
                                            Name = e.Player,
                                            goal = 0,
                                            yellow = 1,
                                            ImgPath = img
                                        }
                                        );
                                    }
                                    else
                                    {
                                        PlayerRanks.Find(pl => pl.Name == e.Player).goal += 1;
                                    }

                                    break;
                                case "yellow-card":
                                    if (PlayerRanks.FirstOrDefault(pl => pl.Name == e.Player) == null)
                                    {

                                        string img = Environment.CurrentDirectory + @"\Resources\player.jpg";
                                        for (int i = 0; i < favs.Count; i++)
                                        {
                                            if (favs.FirstOrDefault(f => favs[i].Name == e.Player) != null)
                                            {
                                                img = favs[i].RetunrImgPath();
                                            }

                                        }
                                        PlayerRanks.Add(new DAL.playerRank
                                        {
                                            Name = e.Player,
                                            goal = 1,
                                            yellow = 0,
                                            ImgPath = img
                                        }
                                        );

                                    }
                                    else
                                    {
                                        PlayerRanks.Find(pl => pl.Name == e.Player).yellow += 1;
                                    }

                                    break;
                               
                            }

                        }
                    }
                }
             }
            var c = PlayerRanks;
           
            loadPlayersIntoTable();


        }
        
        public void loadMatchRankings()
        {
            MatchRanks.Clear();
            List<DAL.Match> matches = new List<DAL.Match>();
            DAL.Match m = new DAL.Match();
            List<DAL.matchRank> matchRanks = new List<DAL.matchRank>();
            matchRanks.Clear();

            string path = "";

            string url = "";
            switch (UserInfo.readType)
            {

                case "WEB":
                    if (UserInfo.league == "F")
                    {
                        url = "http://worldcup.sfg.io/matches/";
                    }
                    else if (UserInfo.league == "M")
                    {
                        url = "http://world-cup-json-2018.herokuapp.com/matches/";

                    }
                    DAL.dal.SaveJsonFromWeb(url, "matchesJson.txt", UserInfo.path);
                    matches = DAL.dal.ReadJsonMatch(UserInfo.path + @"\matchesJson.txt");
                    break;


                case "FILE":
                    if (UserInfo.league == "F")
                    {
                        path = @"C:\Users\THEMAN\source\repos\projekt.net\FormsProject\Resources\worldcup-sfg-io\worldcup.sfg.io\women\matches.json";
                    }
                    else if (UserInfo.league == "M")
                    {
                        path = @"C:\Users\THEMAN\source\repos\projekt.net\FormsProject\Resources\worldcup-sfg-io\worldcup.sfg.io\men\matches.json";

                    }


                    matches = DAL.dal.ReadJsonMatch(path);

                    break;
            }

           
            foreach (DAL.Match match in matches)
            {
                var x = match.HomeTeamCountry;
                var y = match.AwayTeamCountry;
                var z = UserInfo.favoriteRep.Substring(4).Trim();
                if(z==x|| z==y)
                {

                }
              if (match.HomeTeamCountry == UserInfo.favoriteRep.Substring(4).Trim() || match.AwayTeamCountry == UserInfo.favoriteRep.Substring(4).Trim())
                {
                    m = match;

                    MatchRanks.Add(new DAL.matchRank
                    {
                        homeTeam = m.HomeTeamCountry,
                        awayTeam = m.AwayTeamCountry,
                        attendence = m.Attendance.ToString(),
                        location=m.Location.ToString()

                    }
                    ) ;
                }
                
            }
            loadMatchesIntoTable();
        }

        private void loadPlayersIntoTable()
        {
            DataTable dt=new DataTable();
            DataGridViewImageColumn ic=new DataGridViewImageColumn();
            
            BindingSource bs = new BindingSource();
            dgv_igraci.Columns.Clear();

            dt.Columns.Add("Name");
            dt.Columns.Add("Goals_scored");
            dt.Columns.Add("Yellow_cards");
           
           
            //dt.Columns.Add("Pic", typeof(byte[]));
           
            
            
            foreach (DAL.playerRank p in PlayerRanks)
            {
               
                
                DataRow dr = dt.NewRow();
                Image img = Image.FromFile(p.ImgPath);
                


                dr[0] = p.Name;
                dr[1] = p.yellow;
                dr[2] = p.goal;
               // dr[3] = imgToBytes(img);
              dt.Rows.Add(dr);
            }
           
          
            bs.DataSource = dt;
                dgv_igraci.DataSource= dt;
            
            
          
            

        }

       /* private object imgToBytes(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
       */
        private void loadMatchesIntoTable()
         {
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
           
            dt.Columns.Add("Location");
            dt.Columns.Add("Attendence");
            dt.Columns.Add("Home team");
            dt.Columns.Add("Away team");
            ;
            foreach (DAL.matchRank p in MatchRanks)
            {
                DataRow dr = dt.NewRow();
                dr[0] = p.location;
                dr[1] = p.attendence;
                dr[2] = p.homeTeam;
                dr[3] = p.awayTeam;
                dt.Rows.Add(dr);
            }
            bs.DataSource = dt;
            dgv_utakmice.DataSource = dt;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            //yellows
        }
           

        private void button4_Click(object sender, EventArgs e)
        {
          
        }
        private void radioButton2_CheckChanged(object sender, EventArgs e)
        {

        }

        private void dgv_igraci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_utakmice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_utakmice_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        Bitmap bit;
        private void button1_Click(object sender, EventArgs e)
        {
            int height = dgv_igraci.Height;
            dgv_igraci.Height = dgv_igraci.Height * 2;

            bit = new Bitmap(dgv_igraci.Height, dgv_igraci.Width);
            dgv_igraci.DrawToBitmap(bit,new Rectangle(0,0,dgv_igraci.Width,dgv_igraci.Height));
            dgv_igraci.Height = height;
            printPreviewDialog1.Show();
            
          
        }
       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bit,0,0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int height = dgv_utakmice.Height;
            dgv_utakmice.Height = dgv_utakmice.Height * 8;

            bit = new Bitmap(dgv_utakmice.Height, dgv_utakmice.Width);
            dgv_utakmice.DrawToBitmap(bit, new Rectangle(0, 0, dgv_utakmice.Width, dgv_utakmice.Height));
            dgv_utakmice.Height = height;
            printPreviewDialog1.Show();

        }

        private void rb_settingsFileF_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_settingsFileF.Checked)
            {
                fileChanged = !fileChanged;
            }
            UserInfo.readType = "FILE";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();


        }

        private void dgv_igraci_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
