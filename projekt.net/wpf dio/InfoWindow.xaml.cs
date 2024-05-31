using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace wpf_dio
{
    /// <summary>
    /// Interaction logic for InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        public InfoWindow(string fav,string other)
        {
            InitializeComponent();
            setLabels(fav, other);
        }

        private void setLabels(string fav, string other)
        {
            List<DAL.MatchResult> matches = new List<DAL.MatchResult>();
            if (FormsProject.UserInfo.readType == "FILE")
            {
                if (FormsProject.UserInfo.league == "F")
                {
                    DAL.dal.ReadJsonResults(FormsProject.UserInfo.path + @"\worldcup-sfg-io\worldcup.sfg.io\women\results.json");
                    matches = DAL.dal.ReadJsonResults(FormsProject.UserInfo.path + @"\stats.json");
                }
                else if (FormsProject.UserInfo.league == "M")
                {
                    DAL.dal.ReadJsonResults(FormsProject.UserInfo.path + @"\worldcup-sfg-io\worldcup.sfg.io\men\results.json");
                    matches = DAL.dal.ReadJsonResults(FormsProject.UserInfo.path + @"\stats.json");
                }
            }
            else if (FormsProject.UserInfo.readType == "WEB")
            {
                
                if (FormsProject.UserInfo.league == "F")
                {
                    DAL.dal.SaveJsonFromWeb("http://worldcup.sfg.io/teams/results", @"\stats.json", FormsProject.UserInfo.path);
                    matches = DAL.dal.ReadJsonResults(FormsProject.UserInfo.path + @"\stats.json");
                }
                else if (FormsProject.UserInfo.league == "M")
                {
                    DAL.dal.SaveJsonFromWeb(" http://world-cup-json-2018.herokuapp.com/teams/results", @"\stats.json", FormsProject.UserInfo.path);
                    matches = DAL.dal.ReadJsonResults(FormsProject.UserInfo.path + @"\stats.json");
                }
            }
                foreach (DAL.MatchResult matchResult in matches)
                {
                    if(matchResult.country==fav)
                    {
                        lbl_fav_country.Content= matchResult.country;
                        lbl_fav_code.Content= matchResult.code;
                      
                        lbl_fav_wins.Content = matchResult.wins;
                        lbl_fav_losses.Content = matchResult.losses;
                        lbl_fav_draws.Content = matchResult.drwas;
                        try
                        {
                            lbl_fav_played.Content = int.Parse(lbl_fav_wins.Content.ToString()) + int.Parse(lbl_fav_losses.Content.ToString()) + int.Parse(lbl_fav_draws.Content.ToString());
                        }
                        catch
                        {
                            MessageBoxResult mr = new MessageBoxResult();
                            if (FormsProject.UserInfo.lang == "EN")
                            {
                                mr = MessageBox.Show("error", "something went wrong", MessageBoxButton.OK);

                            }
                            if (FormsProject.UserInfo.lang == "HR")
                            {
                                mr = MessageBox.Show("greška", "dogodila se greška", MessageBoxButton.OK);

                            }
                            System.Windows.Application.Current.Shutdown();
                        }
                        lbl_fav_scored.Content = matchResult.goals_scored;
                        lbl_fav_taken.Content = matchResult.goals_taken;
                        lbl_fav_dif.Content = Math.Abs((int.Parse(matchResult.goal_dif)));

                    }
                    else if(matchResult.country==other)
                    {
                        lbl_other_country.Content = matchResult.country;
                        lbl_other_code.Content = matchResult.code;

                        lbl_other_wins.Content = matchResult.wins;
                        lbl_other_losses.Content = matchResult.losses;
                        lbl_other_draws.Content = matchResult.drwas;
                        try
                        {
                            lbl_other_played.Content = int.Parse(lbl_other_wins.Content.ToString()) + int.Parse(lbl_other_losses.Content.ToString()) + int.Parse(lbl_other_draws.Content.ToString());
                        }
                        catch
                        {
                            MessageBoxResult mr = new MessageBoxResult();
                            if (FormsProject.UserInfo.lang == "EN")
                            {
                                mr = MessageBox.Show("error", "something went wrong", MessageBoxButton.OK);

                            }
                            if (FormsProject.UserInfo.lang == "HR")
                            {
                                mr = MessageBox.Show("greška", "dogodila se greška", MessageBoxButton.OK);

                            }
                            System.Windows.Application.Current.Shutdown();
                        }
                        lbl_other_scored.Content = matchResult.goals_scored;
                        lbl_other_taken.Content = matchResult.goals_taken;
                        lbl_other_dif.Content = matchResult.goal_dif;
                    }
                }
            
            
        }
    }
}
