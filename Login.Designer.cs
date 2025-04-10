namespace Scheduler
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginLbl = new System.Windows.Forms.Label();
            this.UserLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.UserTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.LogBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.TimeZoneLbl = new System.Windows.Forms.Label();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lanLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLbl
            // 
            resources.ApplyResources(this.loginLbl, "loginLbl");
            this.loginLbl.Name = "loginLbl";
            // 
            // UserLbl
            // 
            resources.ApplyResources(this.UserLbl, "UserLbl");
            this.UserLbl.Name = "UserLbl";
            // 
            // PasswordLbl
            // 
            resources.ApplyResources(this.PasswordLbl, "PasswordLbl");
            this.PasswordLbl.Name = "PasswordLbl";
            // 
            // UserTxtBox
            // 
            resources.ApplyResources(this.UserTxtBox, "UserTxtBox");
            this.UserTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserTxtBox.Name = "UserTxtBox";
            // 
            // PasswordTxtBox
            // 
            resources.ApplyResources(this.PasswordTxtBox, "PasswordTxtBox");
            this.PasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            // 
            // LogBtn
            // 
            resources.ApplyResources(this.LogBtn, "LogBtn");
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.UseVisualStyleBackColor = true;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // ExitBtn
            // 
            resources.ApplyResources(this.ExitBtn, "ExitBtn");
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // TimeZoneLbl
            // 
            resources.ApplyResources(this.TimeZoneLbl, "TimeZoneLbl");
            this.TimeZoneLbl.Name = "TimeZoneLbl";
            // 
            // TimeLbl
            // 
            resources.ApplyResources(this.TimeLbl, "TimeLbl");
            this.TimeLbl.Name = "TimeLbl";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lanLbl
            // 
            resources.ApplyResources(this.lanLbl, "lanLbl");
            this.lanLbl.Name = "lanLbl";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lanLbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.TimeZoneLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.UserTxtBox);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.loginLbl);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox UserTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Button LogBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label TimeZoneLbl;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lanLbl;
    }
}