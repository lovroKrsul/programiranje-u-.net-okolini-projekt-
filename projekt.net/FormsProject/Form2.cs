using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject
{
    public partial class Form2 : Form
    {
        public Panel p { get; set; }
        public Panel p2 { get; set; }
        public Form2(Panel p, Panel p2)
        {
            InitializeComponent();
            this.p = p;
            this.p2 = p2;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            if (UserInfo.lang == "HR")
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("hr");
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char del = '#';
            try
            {
               
                UserInfo.path = tb_path.Text;
                DAL.dal.CreateDirAndPath(UserInfo.path);
                StringBuilder sb = new StringBuilder();
                sb.Append(UserInfo.lang.Trim() + del + UserInfo.league.Trim() +del+UserInfo.path+ del + UserInfo.readType.Trim()+"#"+UserInfo.favoriteRep +"#" + UserInfo.resolution);
                DAL.dal.WriteFile(sb.ToString().Trim(),@"preferences.txt");
                ObjectReferenceHolder.page1.Hide();
                ObjectReferenceHolder.page2.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                Error error = new Error("cannot read", ex.Message.ToString());
                error.ShowDialog();
            }
            
        }

    

        private void btn_browse_Click(object sender, EventArgs e)
        {

              FolderBrowserDialog fbd= new FolderBrowserDialog();

             fbd.SelectedPath= tb_path.Text;
             fbd.ShowDialog();

             tb_path.Text = fbd.SelectedPath;
            
           



        }
    }
}
