using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for StartingWindow.xaml
    /// </summary>
    public partial class StartingWindow : Window
    {
        public StartingWindow()
        {

            InitializeComponent();
            
            if(ParsePreferences())
            { SwitchToMainForm(); }
        }

        private void SwitchToMainForm()
        {
           MainWindow mw=new MainWindow();
            mw.Show();
            this.Close();

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FormsProject.UserInfo.resolution = cb_resolution.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          //  try
           // {
                FormsProject.UserInfo.path = txt_path.Text;
                DAL.dal.WriteFile($"{FormsProject.UserInfo.lang}# {FormsProject.UserInfo.favoriteRep}#{FormsProject.UserInfo.path}#{FormsProject.UserInfo.readType}#{FormsProject.UserInfo.resolution}", System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString() + @"\FormsProject\bin\Debug"
                + @"\preferences.txt");
            //}
            /*catch (Exception ex)
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
            FormsProject.UserInfo.favoriteRep = "M";
        }
        private void RadioButton_Rep_F_Checked(object sender, RoutedEventArgs e)
        {
            FormsProject.UserInfo.favoriteRep = "Ž";
        }
        private void RadioButton_Lang_EN_Checked(object sender, RoutedEventArgs e)
        {
            FormsProject.UserInfo.lang = "EN";
        }
        private void RadioButton_Lang_HR_Checked(object sender, RoutedEventArgs e)
        {
            FormsProject.UserInfo.lang = "HR";
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        public bool ParsePreferences()
        {
          //  try
          //  {
                string s = GetPath();

                if (DAL.dal.CheckFileExists(s, @"preferences.txt"))
                {

                    string[] strings = DAL.dal.ReadPreferences(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.ToString() + @"\FormsProject\bin\Debug");
                    FormsProject.UserInfo.lang = strings?[0];
                    FormsProject.UserInfo.league = strings?[1];
                    FormsProject.UserInfo.path = strings?[2];
                    FormsProject.UserInfo.readType = strings?[3];
                    FormsProject.UserInfo.favoriteRep = strings?[4];
                    FormsProject.UserInfo.resolution = strings?[5];
                     return true;
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
            return false;
        }
        public string GetPath()
        {
            var x = Environment.CurrentDirectory;
            var y = System.IO.Directory.GetParent(x).Parent.Parent.Parent.FullName;
            x = y;
            StringBuilder sb = new StringBuilder();
            sb.Append(x);
            sb.Append(@"\FormsProject\bin\Debug");
            x = sb.ToString();
            return sb.ToString();
        }
    }
}
