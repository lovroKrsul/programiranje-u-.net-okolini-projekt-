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
    public partial class closeingForm : Form
    {
        public fm_winForms form { get; set; }
        public closeingForm(fm_winForms form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            form.DialogResult = DialogResult.Yes;
            this.Close();
        }
        private void btn_no_Click(object sender, EventArgs e)
        {
            form.DialogResult = DialogResult.No;
            this.Close();
        }
        private void closeingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                    form.DialogResult = DialogResult.Yes;
                    this.Close();
                
            }
            else if (e.KeyCode == Keys.Escape)
            {
                form.DialogResult = DialogResult.No;
                this.Close();
            }
            
        }

      
    }
}
