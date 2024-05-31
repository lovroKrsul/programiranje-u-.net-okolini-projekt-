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
    public partial class ConfirmationForm : Form
    {
       
        public ConfirmationForm()
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
        public fm_winForms form { get; set; }
        public ConfirmationForm(fm_winForms form)
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
               

            this.form = form;
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            if (form.langChanged)
            {
                ObjectReferenceHolder.langEN.Checked = !ObjectReferenceHolder.langEN.Checked;
               
            }
            if (form.leagueChanged)
            {
                ObjectReferenceHolder.leagueM.Checked = !ObjectReferenceHolder.leagueM.Checked;
            
            }
            if (form.fileChanged)
            {
                ObjectReferenceHolder.fileW.Checked = !ObjectReferenceHolder.fileW.Checked;
                ObjectReferenceHolder.fileF.Checked = !ObjectReferenceHolder.fileF.Checked;
            }
            form.langChanged = false;
            form.leagueChanged = false;
            form.fileChanged = false;
            this.Close();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {

            char del = '#';
            try
            {
                DAL.dal.CreateDirAndPath(UserInfo.path);
                StringBuilder sb = new StringBuilder();
                sb.Append(UserInfo.lang.Trim() + del + UserInfo.league.Trim() + del + UserInfo.path + del + UserInfo.readType.Trim() + "#" + UserInfo.favoriteRep);
                DAL.dal.WriteFile(sb.ToString().Trim(), UserInfo.path + @"\preferences.txt");
                this.Close();
            }
            catch (Exception ex)
            {
                string s = "error";
                if (UserInfo.lang == "HR")
                     s = "greska";

                Error err = new Error(s, ex.Message);
                err.Show();
                    }
        }

       
        private void confirmationForm_KeyDown(object sender,KeyEventArgs e)

        {
            if (e.KeyCode==Keys.Enter)
            {
                DAL.dal.CreateDirAndPath(UserInfo.path);
                StringBuilder sb = new StringBuilder();
                sb.Append(UserInfo.lang.Trim() + "#" + UserInfo.league.Trim() + "#" + UserInfo.readType.Trim());
                DAL.dal.WriteFile(sb.ToString().Trim(), UserInfo.path + @"\preferences.txt");
                this.Close();
            }
            else if (e.KeyCode==Keys.Escape)
            {
                if (form.langChanged)
                {
                    ObjectReferenceHolder.langEN.Checked = !ObjectReferenceHolder.langEN.Checked;
                    ObjectReferenceHolder.langHR.Checked = !ObjectReferenceHolder.langHR.Checked;
                }
                if (form.leagueChanged)
                {
                    ObjectReferenceHolder.leagueM.Checked = !ObjectReferenceHolder.leagueM.Checked;
                    ObjectReferenceHolder.leagueF.Checked = !ObjectReferenceHolder.leagueF.Checked;
                }
                if (form.fileChanged)
                {
                    ObjectReferenceHolder.fileW.Checked = !ObjectReferenceHolder.fileW.Checked;
                    ObjectReferenceHolder.fileF.Checked = !ObjectReferenceHolder.fileF.Checked;
                }
                form.langChanged = false;
                form.leagueChanged = false;
                form.fileChanged = false;
                this.Close();
            }
        }
    }
}
