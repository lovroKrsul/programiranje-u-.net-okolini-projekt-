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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_dio
{
    /// <summary>
    /// Interaction logic for igrac.xaml
    /// </summary>
    public partial class igrac : UserControl
    {
        public igrac()
        {
            InitializeComponent();
        }

        private void btnPlayer_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.lblName.Content = ime.Content.ToString();
            w1.lblNumber.Content = broj.Content.ToString();
            w1.lblPos.Content = pos.Content.ToString();
            w1.lblCap.Content = captain.Content.ToString();
            w1.lblGoal.Content = goals.Content.ToString();
            w1.lblYellow.Content =yellows.Content.ToString();
            w1.imgPic.Source = imgb.ImageSource;
            w1.imgPic.Stretch = imgb.Stretch;
            w1.Show();
        }
    }
}
