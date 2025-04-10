namespace Scheduler
{
    partial class ModifyApt
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
            this.LocationBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ContactBox1 = new System.Windows.Forms.ComboBox();
            this.StartDatePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DescriptionBox1 = new System.Windows.Forms.TextBox();
            this.TypeBox1 = new System.Windows.Forms.TextBox();
            this.TitleBox1 = new System.Windows.Forms.TextBox();
            this.IdTxtBox = new System.Windows.Forms.TextBox();
            this.ContactLbl = new System.Windows.Forms.Label();
            this.StartTimeLbl = new System.Windows.Forms.Label();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.StartTimeBox1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // AptLbl
            // 
            this.AptLbl.AutoSize = true;
            this.AptLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Italic);
            this.AptLbl.Location = new System.Drawing.Point(94, 42);
            this.AptLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AptLbl.Name = "AptLbl";
            this.AptLbl.Size = new System.Drawing.Size(264, 32);
            this.AptLbl.TabIndex = 29;
            this.AptLbl.Text = "Modify Appointment";
            // 
            // LocationBox1
            // 
            this.LocationBox1.FormattingEnabled = true;
            this.LocationBox1.Items.AddRange(new object[] {
            "Midtown",
            "Downtown"});
            this.LocationBox1.Location = new System.Drawing.Point(213, 272);
            this.LocationBox1.Margin = new System.Windows.Forms.Padding(2);
            this.LocationBox1.Name = "LocationBox1";
            this.LocationBox1.Size = new System.Drawing.Size(256, 31);
            this.LocationBox1.TabIndex = 73;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F);
            this.button1.Location = new System.Drawing.Point(371, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 72;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F);
            this.button2.Location = new System.Drawing.Point(214, 416);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 31);
            this.button2.TabIndex = 71;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ContactBox1
            // 
            this.ContactBox1.Enabled = false;
            this.ContactBox1.FormattingEnabled = true;
            this.ContactBox1.Location = new System.Drawing.Point(214, 381);
            this.ContactBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ContactBox1.Name = "ContactBox1";
            this.ContactBox1.Size = new System.Drawing.Size(256, 31);
            this.ContactBox1.TabIndex = 70;
            // 
            // StartDatePicker1
            // 
            this.StartDatePicker1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F);
            this.StartDatePicker1.Location = new System.Drawing.Point(214, 311);
            this.StartDatePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.StartDatePicker1.Name = "StartDatePicker1";
            this.StartDatePicker1.Size = new System.Drawing.Size(256, 27);
            this.StartDatePicker1.TabIndex = 69;
            // 
            // DescriptionBox1
            // 
            this.DescriptionBox1.AcceptsTab = true;
            this.DescriptionBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.DescriptionBox1.Location = new System.Drawing.Point(214, 235);
            this.DescriptionBox1.Margin = new System.Windows.Forms.Padding(2);
            this.DescriptionBox1.Name = "DescriptionBox1";
            this.DescriptionBox1.Size = new System.Drawing.Size(255, 30);
            this.DescriptionBox1.TabIndex = 68;
            // 
            // TypeBox1
            // 
            this.TypeBox1.AcceptsTab = true;
            this.TypeBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TypeBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.TypeBox1.Location = new System.Drawing.Point(214, 197);
            this.TypeBox1.Margin = new System.Windows.Forms.Padding(2);
            this.TypeBox1.Name = "TypeBox1";
            this.TypeBox1.Size = new System.Drawing.Size(255, 30);
            this.TypeBox1.TabIndex = 67;
            // 
            // TitleBox1
            // 
            this.TitleBox1.AcceptsTab = true;
            this.TitleBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.TitleBox1.Location = new System.Drawing.Point(214, 159);
            this.TitleBox1.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBox1.Name = "TitleBox1";
            this.TitleBox1.Size = new System.Drawing.Size(255, 30);
            this.TitleBox1.TabIndex = 66;
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdTxtBox.Enabled = false;
            this.IdTxtBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.IdTxtBox.Location = new System.Drawing.Point(214, 121);
            this.IdTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.Size = new System.Drawing.Size(255, 30);
            this.IdTxtBox.TabIndex = 65;
            this.IdTxtBox.Text = "Auto Genreated";
            this.IdTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContactLbl
            // 
            this.ContactLbl.AutoSize = true;
            this.ContactLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.ContactLbl.Location = new System.Drawing.Point(96, 392);
            this.ContactLbl.Name = "ContactLbl";
            this.ContactLbl.Size = new System.Drawing.Size(66, 20);
            this.ContactLbl.TabIndex = 64;
            this.ContactLbl.Text = "Contact";
            // 
            // StartTimeLbl
            // 
            this.StartTimeLbl.AutoSize = true;
            this.StartTimeLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.StartTimeLbl.Location = new System.Drawing.Point(90, 351);
            this.StartTimeLbl.Name = "StartTimeLbl";
            this.StartTimeLbl.Size = new System.Drawing.Size(84, 20);
            this.StartTimeLbl.TabIndex = 63;
            this.StartTimeLbl.Text = "Start Time";
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.StartDateLbl.Location = new System.Drawing.Point(90, 318);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(82, 20);
            this.StartDateLbl.TabIndex = 62;
            this.StartDateLbl.Text = "Start Date";
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.LocationLbl.Location = new System.Drawing.Point(90, 283);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(72, 20);
            this.LocationLbl.TabIndex = 61;
            this.LocationLbl.Text = "Location";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.DescriptionLbl.Location = new System.Drawing.Point(90, 245);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(93, 20);
            this.DescriptionLbl.TabIndex = 60;
            this.DescriptionLbl.Text = "Description";
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.TypeLbl.Location = new System.Drawing.Point(90, 207);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(45, 20);
            this.TypeLbl.TabIndex = 59;
            this.TypeLbl.Text = "Type";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.TitleLbl.Location = new System.Drawing.Point(90, 169);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(41, 20);
            this.TitleLbl.TabIndex = 58;
            this.TitleLbl.Text = "Title";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.IdLbl.Location = new System.Drawing.Point(90, 131);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(24, 20);
            this.IdLbl.TabIndex = 57;
            this.IdLbl.Text = "ID";
            // 
            // StartTimeBox1
            // 
            this.StartTimeBox1.CustomFormat = "\"HH:mm\"";
            this.StartTimeBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F);
            this.StartTimeBox1.Location = new System.Drawing.Point(214, 346);
            this.StartTimeBox1.Margin = new System.Windows.Forms.Padding(2);
            this.StartTimeBox1.Name = "StartTimeBox1";
            this.StartTimeBox1.ShowUpDown = true;
            this.StartTimeBox1.Size = new System.Drawing.Size(256, 27);
            this.StartTimeBox1.TabIndex = 74;
            this.StartTimeBox1.ValueChanged += new System.EventHandler(this.StartTimeBox1_ValueChanged);
            // 
            // ModifyApt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 503);
            this.Controls.Add(this.StartTimeBox1);
            this.Controls.Add(this.LocationBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ContactBox1);
            this.Controls.Add(this.StartDatePicker1);
            this.Controls.Add(this.DescriptionBox1);
            this.Controls.Add(this.TypeBox1);
            this.Controls.Add(this.TitleBox1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModifyApt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyApt";
            this.Load += new System.EventHandler(this.ModifyApt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AptLbl;
        private System.Windows.Forms.ComboBox LocationBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ContactBox1;
        private System.Windows.Forms.DateTimePicker StartDatePicker1;
        private System.Windows.Forms.TextBox DescriptionBox1;
        private System.Windows.Forms.TextBox TypeBox1;
        private System.Windows.Forms.TextBox TitleBox1;
        private System.Windows.Forms.TextBox IdTxtBox;
        private System.Windows.Forms.Label ContactLbl;
        private System.Windows.Forms.Label StartTimeLbl;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.Label LocationLbl;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.DateTimePicker StartTimeBox1;
    }
}