namespace Scheduler
{
    partial class AddAppointment
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
            this.AptLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.StartTimeLbl = new System.Windows.Forms.Label();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.ContactLbl = new System.Windows.Forms.Label();
            this.IdTxtBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ContactBox = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.LocationBox = new System.Windows.Forms.ComboBox();
            this.StartTimeBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // AptLbl
            // 
            this.AptLbl.AutoSize = true;
            this.AptLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Italic);
            this.AptLbl.Location = new System.Drawing.Point(77, 47);
            this.AptLbl.Name = "AptLbl";
            this.AptLbl.Size = new System.Drawing.Size(229, 32);
            this.AptLbl.TabIndex = 0;
            this.AptLbl.Text = "Add Appointment";
            this.AptLbl.Click += new System.EventHandler(this.AptLbl_Click);
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.IdLbl.Location = new System.Drawing.Point(79, 117);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(24, 20);
            this.IdLbl.TabIndex = 1;
            this.IdLbl.Text = "ID";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.TitleLbl.Location = new System.Drawing.Point(79, 155);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(41, 20);
            this.TitleLbl.TabIndex = 2;
            this.TitleLbl.Text = "Title";
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.TypeLbl.Location = new System.Drawing.Point(79, 193);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(45, 20);
            this.TypeLbl.TabIndex = 3;
            this.TypeLbl.Text = "Type";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.DescriptionLbl.Location = new System.Drawing.Point(79, 231);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(93, 20);
            this.DescriptionLbl.TabIndex = 4;
            this.DescriptionLbl.Text = "Description";
            // 
            // StartTimeLbl
            // 
            this.StartTimeLbl.AutoSize = true;
            this.StartTimeLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.StartTimeLbl.Location = new System.Drawing.Point(79, 337);
            this.StartTimeLbl.Name = "StartTimeLbl";
            this.StartTimeLbl.Size = new System.Drawing.Size(84, 20);
            this.StartTimeLbl.TabIndex = 7;
            this.StartTimeLbl.Text = "Start Time";
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.StartDateLbl.Location = new System.Drawing.Point(79, 304);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(82, 20);
            this.StartDateLbl.TabIndex = 6;
            this.StartDateLbl.Text = "Start Date";
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.LocationLbl.Location = new System.Drawing.Point(79, 269);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(72, 20);
            this.LocationLbl.TabIndex = 5;
            this.LocationLbl.Text = "Location";
            // 
            // ContactLbl
            // 
            this.ContactLbl.AutoSize = true;
            this.ContactLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.ContactLbl.Location = new System.Drawing.Point(85, 378);
            this.ContactLbl.Name = "ContactLbl";
            this.ContactLbl.Size = new System.Drawing.Size(66, 20);
            this.ContactLbl.TabIndex = 14;
            this.ContactLbl.Text = "Contact";
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdTxtBox.Enabled = false;
            this.IdTxtBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.IdTxtBox.Location = new System.Drawing.Point(203, 107);
            this.IdTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.Size = new System.Drawing.Size(255, 30);
            this.IdTxtBox.TabIndex = 15;
            this.IdTxtBox.Text = "Auto Genreated";
            this.IdTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleBox
            // 
            this.TitleBox.AcceptsTab = true;
            this.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.TitleBox.Location = new System.Drawing.Point(203, 145);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(255, 30);
            this.TitleBox.TabIndex = 16;
            // 
            // TypeBox
            // 
            this.TypeBox.AcceptsTab = true;
            this.TypeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TypeBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.TypeBox.Location = new System.Drawing.Point(203, 183);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(2);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(255, 30);
            this.TypeBox.TabIndex = 17;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.AcceptsTab = true;
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.DescriptionBox.Location = new System.Drawing.Point(203, 221);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(255, 30);
            this.DescriptionBox.TabIndex = 18;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F);
            this.StartDatePicker.Location = new System.Drawing.Point(203, 297);
            this.StartDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(256, 27);
            this.StartDatePicker.TabIndex = 21;
            // 
            // ContactBox
            // 
            this.ContactBox.FormattingEnabled = true;
            this.ContactBox.Location = new System.Drawing.Point(203, 367);
            this.ContactBox.Margin = new System.Windows.Forms.Padding(2);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(256, 31);
            this.ContactBox.TabIndex = 26;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F);
            this.SaveBtn.Location = new System.Drawing.Point(203, 402);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(98, 31);
            this.SaveBtn.TabIndex = 29;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F);
            this.CancelBtn.Location = new System.Drawing.Point(360, 402);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(98, 31);
            this.CancelBtn.TabIndex = 30;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // LocationBox
            // 
            this.LocationBox.FormattingEnabled = true;
            this.LocationBox.Items.AddRange(new object[] {
            "Midtown",
            "Downtown"});
            this.LocationBox.Location = new System.Drawing.Point(202, 258);
            this.LocationBox.Margin = new System.Windows.Forms.Padding(2);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(256, 31);
            this.LocationBox.TabIndex = 31;
            // 
            // StartTimeBox
            // 
            this.StartTimeBox.CustomFormat = "\"HH:mm\"";
            this.StartTimeBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F);
            this.StartTimeBox.Location = new System.Drawing.Point(203, 332);
            this.StartTimeBox.Margin = new System.Windows.Forms.Padding(2);
            this.StartTimeBox.Name = "StartTimeBox";
            this.StartTimeBox.ShowUpDown = true;
            this.StartTimeBox.Size = new System.Drawing.Size(256, 27);
            this.StartTimeBox.TabIndex = 32;
            this.StartTimeBox.ValueChanged += new System.EventHandler(this.StartTimeBox_ValueChanged);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 538);
            this.Controls.Add(this.StartTimeBox);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.IdTxtBox);
            this.Controls.Add(this.ContactLbl);
            this.Controls.Add(this.StartTimeLbl);
            this.Controls.Add(this.StartDateLbl);
            this.Controls.Add(this.LocationLbl);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.TypeLbl);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.AptLbl);
            this.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.Name = "AddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AptLbl;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label StartTimeLbl;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.Label LocationLbl;
        private System.Windows.Forms.Label ContactLbl;
        private System.Windows.Forms.TextBox IdTxtBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.ComboBox ContactBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ComboBox LocationBox;
        private System.Windows.Forms.DateTimePicker StartTimeBox;
    }
}