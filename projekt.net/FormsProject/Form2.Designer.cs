namespace FormsProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_path = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_path
            // 
            resources.ApplyResources(this.lbl_path, "lbl_path");
            this.lbl_path.Name = "lbl_path";
            // 
            // tb_path
            // 
            resources.ApplyResources(this.tb_path, "tb_path");
            this.tb_path.Name = "tb_path";
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // btn_save
            // 
            resources.ApplyResources(this.btn_save, "btn_save");
            this.btn_save.Name = "btn_save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_browse
            // 
            resources.ApplyResources(this.btn_browse, "btn_browse");
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.lbl_path);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_browse;
    }
}