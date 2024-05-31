using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace wpf_dio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<DAL.Match> matches = new List<DAL.Match>();

        public MainWindow()
        {
            try
            {
        
               
                LoadUserInfo();
                if(!System.IO.Directory.Exists(FormsProject.UserInfo.path))
                {
                    System.IO.File.Delete(System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.ToString() + @"\FormsProject\bin\Debug\preferences.txt");
                    throw new Exception("no directory,please run the first part again");
                }
               
                if (FormsProject.UserInfo.lang == "HR")
                {

                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hr");
                  
                   


                    //dupla window kod exita
                    InitializeComponent();

                }
                if (FormsProject.UserInfo.lang == "EN")
                {
                   
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                  

                    //dupla window kod exita
                    InitializeComponent();

                }
                LoadFavRepCB(FormsProject.UserInfo.path);
                if (FormsProject.UserInfo.resolution != "Fullscreen")
                {
                    var x = FormsProject.UserInfo.resolution;
                    var y = FormsProject.UserInfo.resolution.Split('x')[0];
                     x = null;
                    wdMain.Width = double.Parse(FormsProject.UserInfo.resolution.Split('x')[0].Trim());
                    wdMain.Height = double.Parse(FormsProject.UserInfo.resolution.Split('x')[1].Trim());
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    this.WindowStyle = WindowStyle.None;
                }

            }

            catch (Exception ex)
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

        }

        private void LoadUserInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.ToString() + @"\FormsProject\bin\Debug");
            if (DAL.dal.CheckFileExists(sb.ToString(), @"\preferences.txt"))
            {

                string[] strings = DAL.dal.ReadPreferences(sb.ToString());
                FormsProject.UserInfo.lang = strings?[0];
                FormsProject.UserInfo.league = strings?[1];
                FormsProject.UserInfo.path = strings?[2];
                FormsProject.UserInfo.readType = strings?[3];
                FormsProject.UserInfo.favoriteRep = strings?[4];
                FormsProject.UserInfo.resolution = strings?[5];


            }
        }

        private void LoadFavRepCB(string path)
        {

            cb_favRep.Items.Clear();

            if (FormsProject.UserInfo.readType == "WEB")
            {
                //try
                //{
                    switch (FormsProject.UserInfo.league)
                    {
                        case "M":
                            DAL.dal.SaveJsonFromWeb("http://world-cup-json-2018.herokuapp.com/teams/results", "json.txt", FormsProject.UserInfo.path);
                            break;
                        case "F":
                            DAL.dal.SaveJsonFromWeb("http://worldcup.sfg.io/teams/results", "json.txt", FormsProject.UserInfo.path);
                            break;

                        default: break;
                    }
               // }
              /*  catch (Exception ex)
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

                }*/

                //try
                //{
                    List<DAL.Representation> reps = DAL.dal.ReadJsonReps(path + @"\json.txt");
                    foreach (var i in reps)
                    {
                        cb_favRep.Items.Add(i.fifa_code + ":" + i.country).ToString().Trim();
                        int c = 0;
                        if (c == reps.Count())
                        {
                            cb_favRep.Text = (i.fifa_code + ":" + i.country);
                        }
                    }

               // }
              /*  catch (Exception e)
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
              */
            }
            else if (FormsProject.UserInfo.readType == "FILE")
            {

             //   try
               // {
                    List<DAL.Representation> reps = new List<DAL.Representation>();
                    switch (FormsProject.UserInfo.league)
                    {

                        case "M":
                        //treba promjenit na resurces path
                        
                            reps = DAL.dal.ReadJsonReps(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent + @"\FormsProject\bin\Debug" + @"\Resources\worldcup-sfg-io\worldcup.sfg.io\men\teams.json");
                            break;
                        case "F":

                        //treba promjenit na resurces path
                        reps = DAL.dal.ReadJsonReps(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent + @"\FormsProject\bin\Debug" + @"\Resources\worldcup-sfg-io\worldcup.sfg.io\women\teams.json");

                        break;
                    }

                    foreach (var i in reps)
                    {
                        cb_favRep.Items.Add(i.fifa_code + ": " + i.country);

                    }
               // }
              /*  catch (Exception e)
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

                }*/
            }

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult mr = new MessageBoxResult();
            if (FormsProject.UserInfo.lang == "HR")
            {

                mr = MessageBox.Show("izlaz", "sigurno zelite izaci", MessageBoxButton.OKCancel);

            }
            else
            {
                mr = MessageBox.Show("exit", "are you sure you wish to exit", MessageBoxButton.OKCancel);
            }

            if (mr == MessageBoxResult.Cancel)
                e.Cancel = true;


        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Confirm_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mr = new MessageBoxResult();
            if (FormsProject.UserInfo.lang == "HR")
            {

                mr = MessageBox.Show("izlaz", "sigurno zelite izaci", MessageBoxButton.OKCancel);

            }
            else
            {
                mr = MessageBox.Show("exit", "are you sure you wish to exit", MessageBoxButton.OKCancel);
            }

            if (mr == MessageBoxResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"{ FormsProject.UserInfo.lang.Trim()}# {FormsProject.UserInfo.league.Trim()}#{FormsProject.UserInfo.path.Trim()}#{FormsProject.UserInfo.readType.Trim()}#{FormsProject.UserInfo.favoriteRep.Trim()}#{FormsProject.UserInfo.resolution.Trim()}");

                DAL.dal.WriteFile(sb.ToString(), System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString() + @"\FormsProject\bin\Debug\preferences.txt");
            }

        }

        private void Button_Settings_Click(object sender, RoutedEventArgs e)
        {
           // try
          //  {

                var x = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.ToString() + @"\FormsProject\bin\Debug\preferences.txt";

               
                DAL.dal.WriteFile($"{FormsProject.UserInfo.lang.Trim()}#{FormsProject.UserInfo.league.Trim()}#{FormsProject.UserInfo.path.Trim()}#{FormsProject.UserInfo.readType.Trim()}#{FormsProject.UserInfo.favoriteRep.Trim()}#{FormsProject.UserInfo.resolution.Trim()}", x);
                //nesto
                if(FormsProject.UserInfo.lang=="HR")
                {
                    var mr = MessageBox.Show("Jezik Promjenjen", "Restartirajte program kako bi se promjene dogodile", MessageBoxButton.OK);

                }
                else
                {
                    var mr = MessageBox.Show("Language changed", "Please restart for changes to take effect", MessageBoxButton.OK);
                }
             
           // }
            /* catch (Exception ex)
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

            }*/
        }

        private void RadioButton_Rep_M_Checked(object sender, RoutedEventArgs e)
        {
            FormsProject.UserInfo.league = "M";
        }
        private void RadioButton_Rep_F_Checked(object sender, RoutedEventArgs e)
        {
            FormsProject.UserInfo.league = "Ž";
        }
        private void RadioButton_Lang_EN_Checked(object sender, RoutedEventArgs e)
        {
            FormsProject.UserInfo.lang = "EN";
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

         

        }
        private void RadioButton_Lang_HR_Checked(object sender, RoutedEventArgs e)
        {
            FormsProject.UserInfo.lang = "HR";
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hr");
         



        }

        private void ComboBox_Settings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           var item = (ComboBoxItem)cb_settings_resolution.SelectedValue;
            string s = (string)item.Content;
            FormsProject.UserInfo.resolution =s;
        }

        private void cb_favRep_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // try
          //  {
                FormsProject.UserInfo.favoriteRep = cb_favRep.SelectedValue.ToString();
                
                DAL.dal.WriteFile($"{FormsProject.UserInfo.lang.Trim()}#{FormsProject.UserInfo.league.Trim()}#{FormsProject.UserInfo.path.Trim()}#{FormsProject.UserInfo.readType.Trim()}#{FormsProject.UserInfo.favoriteRep.Trim()}#{FormsProject.UserInfo.resolution.Trim()}#", System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.ToString() + @"\FormsProject\bin\Debug\preferences.txt");

                cb_other.Items.Clear();


                loadOthersCB(FormsProject.UserInfo.path);




           // }
           /* catch (Exception ex)
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

            }*/

        }

        private void loadOthersCB(string path)
        {
            if (FormsProject.UserInfo.readType == "WEB")
            {
              //  try
               // {
                    if (matches.Count == 0 || matches[0].HomeTeam == null)
                    {
                        switch (FormsProject.UserInfo.league)
                        {
                            case "M":
                                DAL.dal.SaveJsonFromWeb("https://world-cup-json-2018.herokuapp.com/matches", "json.txt", FormsProject.UserInfo.path);
                                break;
                            case "F":
                                DAL.dal.SaveJsonFromWeb("http://worldcup.sfg.io/matches", "json.txt", FormsProject.UserInfo.path);
                                break;

                            default: break;
                        }

                    }

               // }
              /*  catch (Exception ex)
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

                }*/


              //  try
              //  {
                    //List<DAL.Representation> reps = DAL.dal.ReadJsonReps(path + @"\json.txt");
                    if (matches.Count == 0 || matches[0].HomeTeam == null)
                    {
                        matches = DAL.dal.ReadJsonMatch(path + @"\json.txt");

                    }



                foreach (var i in matches)
                {
                    var x = FormsProject.UserInfo.favoriteRep.Substring(4).Trim();
                    var y = i.HomeTeamCountry;
                    if (x == y)
                    {

                    }
                        if (i.HomeTeamCountry == FormsProject.UserInfo.favoriteRep.Substring(4).Trim())
                            cb_other.Items.Add(i.AwayTeam.Code + ":" + i.AwayTeam.Country).ToString().Trim();
                        else if (i.AwayTeamCountry == FormsProject.UserInfo.favoriteRep.Substring(4).Trim())
                            cb_other.Items.Add(i.HomeTeam.Code + ":" + i.HomeTeam.Country).ToString().Trim();

                    }

               // }
             /*   catch (Exception e)
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
             */
            }
            else if (FormsProject.UserInfo.readType == "FILE")
            {

              //  try
               // {
                    if (matches.Count == 0 || matches[0].HomeTeam == null)
                    {
                        switch (FormsProject.UserInfo.league)
                        {

                            case "M":
                                //treba promjenit na resurces path

                                matches = DAL.dal.ReadJsonMatch(path + @"\worldcup-sfg-io\worldcup.sfg.io\men\matches.json");


                                break;
                            case "F":
                                //treba promjenit na resurces path

                                matches = DAL.dal.ReadJsonMatch(path + @"\worldcup-sfg-io\worldcup.sfg.io\women\matches.json");

                                break;
                        }
                    }





                    foreach (var i in matches)
                    {
                        if (i.HomeTeamCountry == FormsProject.UserInfo.favoriteRep)
                            cb_other.Items.Add(i.AwayTeam.Code + ":" + i.AwayTeam.Country).ToString().Trim();
                        else if (i.AwayTeamCountry == FormsProject.UserInfo.favoriteRep)
                            cb_other.Items.Add(i.HomeTeam.Code + ":" + i.HomeTeam.Country).ToString().Trim();

                    }
              //  }
             /*   catch (Exception e)
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

                }*/
            }
            else
            {

            }
        }




        private void cb_other_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (FormsProject.UserInfo.readType == "WEB")
            {
               // try
               // {
                    switch (FormsProject.UserInfo.league)
                    {
                        case "M":
                            DAL.dal.SaveJsonFromWeb("https://world-cup-json-2018.herokuapp.com/matches", "json.txt", FormsProject.UserInfo.path);
                            break;
                        case "F":
                            DAL.dal.SaveJsonFromWeb("http://worldcup.sfg.io/matches", "json.txt", FormsProject.UserInfo.path);
                            break;

                        default: break;
                    }
                    if (matches.Count == 0 || matches[0].HomeTeam == null)
                    {

                        matches = DAL.dal.ReadJsonMatch(FormsProject.UserInfo.path + @"\json.txt");

                    }



                    if (cb_other.SelectedValue != null)
                    {
                        foreach (var i in matches)
                        {

                            if (i.HomeTeamCountry == cb_favRep.SelectedValue.ToString().Substring(4).Trim() && i.AwayTeamCountry == cb_other.SelectedValue.ToString().Substring(4).Trim())
                            {
                                lblScore.Content = $"{i.HomeTeam.Goals}:{i.AwayTeam.Goals}";
                            }
                            else if (i.AwayTeamCountry == cb_favRep.SelectedValue.ToString().Substring(4).Trim() && i.HomeTeamCountry == cb_other.SelectedValue.ToString().Substring(4).Trim())
                            {
                                lblScore.Content = $"{i.HomeTeam.Goals}:{i.AwayTeam.Goals}";
                            }
                        }
                    }

              //  }
              /*  catch (Exception ex)
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
              */


            }


            else if (FormsProject.UserInfo.readType == "WEB")
            {

               // try
              //  {
                    if (matches.Count == 0 || matches[0].HomeTeam == null)
                    {
                        switch (FormsProject.UserInfo.league)
                        {

                            case "M":
                                //treba promjenit na resurces path

                                matches = DAL.dal.ReadJsonMatch(FormsProject.UserInfo.path + @"\worldcup-sfg-io\worldcup.sfg.io\men\matches.json");



                                break;
                            case "F":
                                //treba promjenit na resurces path

                                matches = DAL.dal.ReadJsonMatch(FormsProject.UserInfo.path + @"\worldcup-sfg-io\worldcup.sfg.io\women\matches.json");

                                break;
                        }
                    }



                    if (cb_other.SelectedValue != null)
                    {
                        foreach (var i in matches)
                        {
                            if (i.HomeTeamCountry == cb_favRep.SelectedValue.ToString().Substring(4).Trim() && i.AwayTeamCountry == cb_other.SelectedValue.ToString().Substring(4).Trim())
                            {
                                lblScore.Content = $"{i.HomeTeam.Goals}:{i.AwayTeam.Goals}";
                            }
                            else if (i.AwayTeamCountry == cb_favRep.SelectedValue.ToString().Substring(4).Trim() && i.HomeTeamCountry == cb_other.SelectedValue.ToString().Substring(4).Trim())
                            {
                                lblScore.Content = $"{i.HomeTeam.Goals}:{i.AwayTeam.Goals}";
                            }

                        }
                    }
               // }
              /*  catch (Exception ex)
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

                }*/
            }

            DAL.Match m = new DAL.Match();
            bool home = true;


           // try
          //  {
                if (cb_other.SelectedValue != null)
                {
                    m = matches.FirstOrDefault(x => x.HomeTeam.Country == cb_favRep.SelectedValue.ToString().Split(':')[1] && x.AwayTeam.Country == cb_other.SelectedValue.ToString().Split(':')[1]);
                    if (m == null)
                    {
                        m = matches.FirstOrDefault(x => x.AwayTeam.Country == cb_favRep.SelectedValue.ToString().Split(':')[1] && x.HomeTeam.Country == cb_other.SelectedValue.ToString().Split(':')[1]);

                    }
                    Home1.ime.Content = m.HomeTeamStatistics.StartingEleven.Find(x => x.Position == "Goalie").Name;
                    Home1.broj.Content = m.HomeTeamStatistics.StartingEleven.Find(x => x.Position == "Goalie").ShirtNumber;
                    Home1.captain.Content = m.HomeTeamStatistics.StartingEleven.Find(x => x.Position == "Goalie").Captain;
                    Home1.pos.Content = m.HomeTeamStatistics.StartingEleven.Find(x => x.Position == "Goalie").Position;
                    Home1.yellows.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Home1.ime.Content.ToString().Split(' ')[0] + " " + Home1.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home1.goals.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Home1.ime.Content.ToString().Split(' ')[0] + " " + Home1.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();

                    Home2.ime.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[0].Name;
                    Home2.broj.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[0].ShirtNumber;
                    Home2.captain.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[0].Captain;
                    Home2.pos.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[0].Position;
                    Home2.yellows.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Home2.ime.Content.ToString().Split(' ')[0] + " " + Home2.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home2.goals.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Home2.ime.Content.ToString().Split(' ')[0] + " " + Home2.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home3.ime.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[1].Name;
                    Home3.broj.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[1].ShirtNumber;
                    Home3.captain.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[1].Captain;
                    Home3.pos.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[1].Position;
                    Home3.yellows.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Home3.ime.Content.ToString().Split(' ')[0] + " " + Home3.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home3.goals.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Home3.ime.Content.ToString().Split(' ')[0] + " " + Home3.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home4.ime.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[2].Name;
                    Home4.broj.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[2].ShirtNumber;
                    Home4.captain.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[2].Captain;
                    Home4.pos.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[2].Position;
                    Home4.yellows.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Home4.ime.Content.ToString().Split(' ')[0] + " " + Home4.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home4.goals.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Home4.ime.Content.ToString().Split(' ')[0] + " " + Home4.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home5.ime.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[3].Name;
                    Home5.broj.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[3].ShirtNumber;
                    Home5.captain.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[3].Captain;
                    Home5.pos.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[3].Position;
                    Home5.yellows.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Home5.ime.Content.ToString().Split(' ')[0] + " " + Home5.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home5.goals.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Home5.ime.Content.ToString().Split(' ')[0] + " " + Home5.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home6.ime.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[4].Name;
                    Home6.broj.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[4].ShirtNumber;
                    Home6.captain.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[4].Captain;
                    Home6.pos.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[4].Position;
                    Home6.yellows.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Home6.ime.Content.ToString().Split(' ')[0] + " " + Home6.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home6.goals.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Home6.ime.Content.ToString().Split(' ')[0] + " " + Home6.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home7.ime.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[5].Name;
                    Home7.broj.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[5].ShirtNumber;
                    Home7.captain.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[5].Captain;
                    Home7.pos.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[5].Position;
                    Home7.yellows.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Home7.ime.Content.ToString().Split(' ')[0] + " " + Home7.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home7.goals.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Home7.ime.Content.ToString().Split(' ')[0] + " " + Home7.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home8.ime.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[6].Name;
                    Home8.broj.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[6].ShirtNumber;
                    Home8.captain.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[6].Captain;
                    Home8.pos.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[6].Position;
                    Home8.yellows.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Home8.ime.Content.ToString().Split(' ')[0] + " " + Home8.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home8.goals.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Home8.ime.Content.ToString().Split(' ')[0] + " " + Home8.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home9.ime.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[7].Name;
                    Home9.broj.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[7].ShirtNumber;
                    Home9.captain.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[7].Captain;
                    Home9.pos.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[7].Position;
                    Home9.yellows.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Home9.ime.Content.ToString().Split(' ')[0] + " " + Home9.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home9.goals.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Home9.ime.Content.ToString().Split(' ')[0] + " " + Home9.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home10.ime.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[8].Name;
                    Home10.broj.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[8].ShirtNumber;
                    Home10.captain.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[8].Captain;
                    Home10.pos.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[8].Position;
                    Home10.yellows.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Home10.ime.Content.ToString().Split(' ')[0] + " " + Home10.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home10.goals.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Home10.ime.Content.ToString().Split(' ')[0] + " " + Home10.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home11.ime.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[9].Name;
                    Home11.broj.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[9].ShirtNumber;
                    Home11.captain.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[9].Captain;
                    Home11.pos.Content = m.HomeTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[9].Position;

                    Home11.yellows.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Home11.ime.Content.ToString().Split(' ')[0] + " " + Home11.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Home11.goals.Content = m.HomeTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Home11.ime.Content.ToString().Split(' ')[0] + " " + Home11.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();



                    Other1.ime.Content = m.AwayTeamStatistics.StartingEleven.Find(x => x.Position == "Goalie").Name;
                    Other1.broj.Content = m.AwayTeamStatistics.StartingEleven.Find(x => x.Position == "Goalie").ShirtNumber;
                    Other1.captain.Content = m.AwayTeamStatistics.StartingEleven.Find(x => x.Position == "Goalie").Captain;
                    Other1.pos.Content = m.AwayTeamStatistics.StartingEleven.Find(x => x.Position == "Goalie").Position;
                    Other1.yellows.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Other1.ime.Content.ToString().Split(' ')[0] + " " + Other1.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other1.goals.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Other1.ime.Content.ToString().Split(' ')[0] + " " + Other1.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();


                    Other2.ime.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[0].Name;
                    Other2.broj.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[0].ShirtNumber;
                    Other2.captain.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[0].Captain;
                    Other2.pos.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[0].Position;
                    Other2.yellows.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Other2.ime.Content.ToString().Split(' ')[0] + " " + Other2.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other2.goals.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Other2.ime.Content.ToString().Split(' ')[0] + " " + Other2.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other3.ime.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[1].Name;
                    Other3.broj.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[1].ShirtNumber;
                    Other3.captain.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[1].Captain;
                    Other3.pos.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[1].Position;
                    Other3.yellows.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Other3.ime.Content.ToString().Split(' ')[0] + " " + Other3.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other3.goals.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Other3.ime.Content.ToString().Split(' ')[0] + " " + Other3.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other4.ime.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[2].Name;
                    Other4.broj.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[2].ShirtNumber;
                    Other4.captain.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[2].Captain;
                    Other4.pos.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[2].Position;
                    Other4.yellows.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Other4.ime.Content.ToString().Split(' ')[0] + " " + Other4.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other4.goals.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Other4.ime.Content.ToString().Split(' ')[0] + " " + Other4.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other5.ime.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[3].Name;
                    Other5.broj.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[3].ShirtNumber;
                    Other5.captain.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[3].Captain;
                    Other5.pos.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[3].Position;
                    Other5.yellows.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Other5.ime.Content.ToString().Split(' ')[0] + " " + Other5.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other5.goals.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Other5.ime.Content.ToString().Split(' ')[0] + " " + Other5.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other6.ime.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[4].Name;
                    Other6.broj.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[4].ShirtNumber;
                    Other6.captain.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[4].Captain;
                    Other6.pos.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[4].Position;
                    Other6.yellows.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Other6.ime.Content.ToString().Split(' ')[0] + " " + Other6.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other6.goals.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Other6.ime.Content.ToString().Split(' ')[0] + " " + Other6.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other7.ime.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[5].Name;
                    Other7.broj.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[5].ShirtNumber;
                    Other7.captain.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[5].Captain;
                    Other7.pos.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[5].Position;
                    Other7.yellows.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Other7.ime.Content.ToString().Split(' ')[0] + " " + Other7.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other7.goals.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Other7.ime.Content.ToString().Split(' ')[0] + " " + Other7.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other8.ime.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[6].Name;
                    Other8.broj.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[6].ShirtNumber;
                    Other8.captain.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[6].Captain;
                    Other8.pos.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[6].Position;

                    Other8.yellows.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Other8.ime.Content.ToString().Split(' ')[0] + " " + Other8.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other8.goals.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Other8.ime.Content.ToString().Split(' ')[0] + " " + Other8.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other9.ime.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[7].Name;
                    Other9.broj.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[7].ShirtNumber;
                    Other9.captain.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[7].Captain;
                    Other9.pos.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[7].Position;
                    Other9.yellows.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Other9.ime.Content.ToString().Split(' ')[0] + " " + Other9.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other9.goals.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Other9.ime.Content.ToString().Split(' ')[0] + " " + Other9.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other10.ime.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[8].Name;
                    Other10.broj.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[8].ShirtNumber;
                    Other10.captain.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[8].Captain;
                    Other10.pos.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[8].Position;
                    Other10.goals.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Other10.ime.Content.ToString().Split(' ')[0] + " " + Other10.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other10.yellows.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Other10.ime.Content.ToString().Split(' ')[0] + " " + Other10.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other11.ime.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[9].Name;
                    Other11.broj.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[9].ShirtNumber;
                    Other11.captain.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[9].Captain;
                    Other11.pos.Content = m.AwayTeamStatistics.StartingEleven.FindAll(x => x.Position != "Goalie")[9].Position;
                    Other11.yellows.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "yellow-card" && x.Player == (Other11.ime.Content.ToString().Split(' ')[0] + " " + Other11.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                    Other11.goals.Content = m.AwayTeamEvents.FindAll(x => x.TypeOfEvent == "goal" && x.Player == (Other11.ime.Content.ToString().Split(' ')[0] + " " + Other11.ime.Content.ToString().Split(' ')[1].ToString().ToUpper())).Count();
                }
           // }
          /*  catch (Exception ex)
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

            }*/
        }



        private void Button_info_click(object sender, RoutedEventArgs e)
        {
            InfoWindow ifw = new InfoWindow(cb_favRep.SelectedValue.ToString().Substring(4).Trim(), cb_other.SelectedValue.ToString().Substring(4).Trim());
            ifw.Show();
        }
    }
}
