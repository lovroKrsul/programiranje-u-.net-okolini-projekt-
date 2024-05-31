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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public fm_winForms form { get; set; }
        public Form3(fm_winForms form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btn_no_Click(object sender, EventArgs e)
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
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            DAL.DAL.CreateDirAndPath(UserInfo.path);
            StringBuilder sb = new StringBuilder();
            sb.Append(UserInfo.lang.Trim() + ":" + UserInfo.league.Trim() + ":" + UserInfo.readType.Trim());
            DAL.DAL.WritePreferences(sb.ToString().Trim(), UserInfo.path + @"\preferences.txt");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DAL.DAL.CreateDirAndPath(UserInfo.path);
            StringBuilder sb = new StringBuilder();
            sb.Append(UserInfo.lang.Trim() + ":" + UserInfo.league.Trim() + ":" + UserInfo.readType.Trim());
            DAL.DAL.WritePreferences(sb.ToString().Trim(), UserInfo.path + @"\preferences.txt");
        }
        private void confirmationForm_KeyDown(object sender,KeyEventArgs e)

        {
            if (e.KeyCode==Keys.Enter)
            {

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
            }
        }
    }
}
