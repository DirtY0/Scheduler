namespace Scheduler
{
    partial class AddCustomer
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
            this.CustomerLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.CountryLbl = new System.Windows.Forms.Label();
            this.StateLbl = new System.Windows.Forms.Label();
            this.PostalLbl = new System.Windows.Forms.Label();
            this.ZIpBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IdTxtBox = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CustomerLbl
            // 
            this.CustomerLbl.AutoSize = true;
            this.CustomerLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Italic);
            this.CustomerLbl.Location = new System.Drawing.Point(82, 66);
            this.CustomerLbl.Name = "CustomerLbl";
            this.CustomerLbl.Size = new System.Drawing.Size(187, 32);
            this.CustomerLbl.TabIndex = 0;
            this.CustomerLbl.Text = "Add Customer";
            this.CustomerLbl.Click += new System.EventHandler(this.CustomerLbl_Click);
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Italic);
            this.IdLbl.Location = new System.Drawing.Point(82, 153);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(32, 25);
            this.IdLbl.TabIndex = 1;
            this.IdLbl.Text = "ID";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Italic);
            this.NameLbl.Location = new System.Drawing.Point(82, 208);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(67, 25);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Name";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Italic);
            this.AddressLbl.Location = new System.Drawing.Point(82, 258);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(85, 25);
            this.AddressLbl.TabIndex = 3;
            this.AddressLbl.Text = "Address";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Italic);
            this.PhoneLbl.Location = new System.Drawing.Point(83, 315);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(152, 25);
            this.PhoneLbl.TabIndex = 4;
            this.PhoneLbl.Text = "Phone Number";
            // 
            // CountryLbl
            // 
            this.CountryLbl.AutoSize = true;
            this.CountryLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Italic);
            this.CountryLbl.Location = new System.Drawing.Point(82, 364);
            this.CountryLbl.Name = "CountryLbl";
            this.CountryLbl.Size = new System.Drawing.Size(85, 25);
            this.CountryLbl.TabIndex = 5;
            this.CountryLbl.Text = "Country";
            // 
            // StateLbl
            // 
            this.StateLbl.AutoSize = true;
            this.StateLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Italic);
            this.StateLbl.Location = new System.Drawing.Point(83, 413);
            this.StateLbl.Name = "StateLbl";
            this.StateLbl.Size = new System.Drawing.Size(47, 25);
            this.StateLbl.TabIndex = 6;
            this.StateLbl.Text = "City";
            // 
            // PostalLbl
            // 
            this.PostalLbl.AutoSize = true;
            this.PostalLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Italic);
            this.PostalLbl.Location = new System.Drawing.Point(82, 470);
            this.PostalLbl.Name = "PostalLbl";
            this.PostalLbl.Size = new System.Drawing.Size(122, 25);
            this.PostalLbl.TabIndex = 7;
            this.PostalLbl.Text = "Postal Code";
            // 
            // ZIpBox
            // 
            this.ZIpBox.AcceptsTab = true;
            this.ZIpBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZIpBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.ZIpBox.Location = new System.Drawing.Point(259, 467);
            this.ZIpBox.Margin = new System.Windows.Forms.Padding(2);
            this.ZIpBox.Name = "ZIpBox";
            this.ZIpBox.Size = new System.Drawing.Size(184, 30);
            this.ZIpBox.TabIndex = 24;
            // 
            // PhoneBox
            // 
            this.PhoneBox.AcceptsTab = true;
            this.PhoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.PhoneBox.Location = new System.Drawing.Point(260, 310);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(184, 30);
            this.PhoneBox.TabIndex = 23;
            // 
            // AddressBox
            // 
            this.AddressBox.AcceptsTab = true;
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.AddressBox.Location = new System.Drawing.Point(259, 255);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(184, 30);
            this.AddressBox.TabIndex = 22;
            // 
            // NameBox
            // 
            this.NameBox.AcceptsTab = true;
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.NameBox.Location = new System.Drawing.Point(260, 205);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(184, 30);
            this.NameBox.TabIndex = 21;
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdTxtBox.Enabled = false;
            this.IdTxtBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.IdTxtBox.Location = new System.Drawing.Point(260, 154);
            this.IdTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.Size = new System.Drawing.Size(184, 30);
            this.IdTxtBox.TabIndex = 20;
            this.IdTxtBox.Text = "Auto Genreated";
            this.IdTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F);
            this.CancelBtn.Location = new System.Drawing.Point(372, 539);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(70, 31);
            this.CancelBtn.TabIndex = 32;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F);
            this.SaveBtn.Location = new System.Drawing.Point(258, 539);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(70, 31);
            this.SaveBtn.TabIndex = 31;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CityBox
            // 
            this.CityBox.AcceptsTab = true;
            this.CityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CityBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.CityBox.Location = new System.Drawing.Point(258, 413);
            this.CityBox.Margin = new System.Windows.Forms.Padding(2);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(184, 30);
            this.CityBox.TabIndex = 34;
            // 
            // CountryBox
            // 
            this.CountryBox.AcceptsTab = true;
            this.CountryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CountryBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.CountryBox.Location = new System.Drawing.Point(258, 363);
            this.CountryBox.Margin = new System.Windows.Forms.Padding(2);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(184, 30);
            this.CountryBox.TabIndex = 35;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 619);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ZIpBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.IdTxtBox);
            this.Controls.Add(this.PostalLbl);
            this.Controls.Add(this.StateLbl);
            this.Controls.Add(this.CountryLbl);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.CustomerLbl);
            this.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerLbl;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label CountryLbl;
        private System.Windows.Forms.Label StateLbl;
        private System.Windows.Forms.Label PostalLbl;
        private System.Windows.Forms.TextBox ZIpBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IdTxtBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox CountryBox;
    }
}