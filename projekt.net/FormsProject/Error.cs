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
    public partial class Error : Form
    {

        public bool IsCritical { get; set; } = true;
        public Error()
        {
            if (UserInfo.lang == "HR")
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("hr");
                InitializeComponent();
            }

            if (UserInfo.lang == "EN")
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                InitializeComponent();
            }

        }
        public Error(string name,string text)
        {
            if (UserInfo.lang == "HR")
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("hr");
                InitializeComponent();
            }

            if (UserInfo.lang == "EN")
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                InitializeComponent();
            }
        }
        public Error(string name, string text,bool iscritical)
        {
            if (UserInfo.lang == "HR")
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("hr");
                InitializeComponent();
            }

            if (UserInfo.lang == "EN")
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                InitializeComponent();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_errorOk_Click(object sender, EventArgs e)
        {
            if(IsCritical)
            {
                Application.Exit();
            }
            else if(!IsCritical)
            {
                this.Close();
            }
           
        }
    }
}
