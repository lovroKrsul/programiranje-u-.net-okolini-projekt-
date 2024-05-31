namespace FormsProject
{
    partial class Error
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            this.rtb_errorText = new System.Windows.Forms.RichTextBox();
            this.lbl_errorName = new System.Windows.Forms.Label();
            this.btn_errorOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_errorText
            // 
            resources.ApplyResources(this.rtb_errorText, "rtb_errorText");
            this.rtb_errorText.Name = "rtb_errorText";
            this.rtb_errorText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lbl_errorName
            // 
            resources.ApplyResources(this.lbl_errorName, "lbl_errorName");
            this.lbl_errorName.Name = "lbl_errorName";
            // 
            // btn_errorOk
            // 
            resources.ApplyResources(this.btn_errorOk, "btn_errorOk");
            this.btn_errorOk.Name = "btn_errorOk";
            this.btn_errorOk.UseVisualStyleBackColor = true;
            this.btn_errorOk.Click += new System.EventHandler(this.btn_errorOk_Click);
            // 
            // Error
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.btn_errorOk);
            this.Controls.Add(this.lbl_errorName);
            this.Controls.Add(this.rtb_errorText);
            this.Name = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_errorText;
        private System.Windows.Forms.Label lbl_errorName;
        private System.Windows.Forms.Button btn_errorOk;
    }
}