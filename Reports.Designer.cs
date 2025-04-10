namespace Scheduler
{
    partial class Reports
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
            this.reportLbl = new System.Windows.Forms.Label();
            this.ContactBox = new System.Windows.Forms.ComboBox();
            this.AptInfoGrid = new System.Windows.Forms.DataGridView();
            this.AptFilterGrid = new System.Windows.Forms.DataGridView();
            this.LocationFilterGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportsBtn = new System.Windows.Forms.Button();
            this.MonthBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AptInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AptFilterGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationFilterGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // reportLbl
            // 
            this.reportLbl.AutoSize = true;
            this.reportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.reportLbl.Location = new System.Drawing.Point(62, 37);
            this.reportLbl.Name = "reportLbl";
            this.reportLbl.Size = new System.Drawing.Size(117, 33);
            this.reportLbl.TabIndex = 0;
            this.reportLbl.Text = "Reports";
            // 
            // ContactBox
            // 
            this.ContactBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ContactBox.FormattingEnabled = true;
            this.ContactBox.Location = new System.Drawing.Point(1016, 46);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(314, 26);
            this.ContactBox.TabIndex = 1;
            this.ContactBox.SelectedIndexChanged += new System.EventHandler(this.ContactBox_SelectedIndexChanged);
            // 
            // AptInfoGrid
            // 
            this.AptInfoGrid.AllowUserToAddRows = false;
            this.AptInfoGrid.AllowUserToDeleteRows = false;
            this.AptInfoGrid.AllowUserToResizeColumns = false;
            this.AptInfoGrid.AllowUserToResizeRows = false;
            this.AptInfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AptInfoGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AptInfoGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.AptInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AptInfoGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AptInfoGrid.Location = new System.Drawing.Point(68, 106);
            this.AptInfoGrid.MultiSelect = false;
            this.AptInfoGrid.Name = "AptInfoGrid";
            this.AptInfoGrid.ReadOnly = true;
            this.AptInfoGrid.RowHeadersVisible = false;
            this.AptInfoGrid.RowHeadersWidth = 51;
            this.AptInfoGrid.RowTemplate.Height = 24;
            this.AptInfoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AptInfoGrid.ShowEditingIcon = false;
            this.AptInfoGrid.Size = new System.Drawing.Size(1262, 216);
            this.AptInfoGrid.TabIndex = 14;
            // 
            // AptFilterGrid
            // 
            this.AptFilterGrid.AllowUserToAddRows = false;
            this.AptFilterGrid.AllowUserToDeleteRows = false;
            this.AptFilterGrid.AllowUserToResizeColumns = false;
            this.AptFilterGrid.AllowUserToResizeRows = false;
            this.AptFilterGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AptFilterGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AptFilterGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.AptFilterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AptFilterGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AptFilterGrid.Location = new System.Drawing.Point(68, 422);
            this.AptFilterGrid.MultiSelect = false;
            this.AptFilterGrid.Name = "AptFilterGrid";
            this.AptFilterGrid.RowHeadersVisible = false;
            this.AptFilterGrid.RowHeadersWidth = 51;
            this.AptFilterGrid.RowTemplate.Height = 24;
            this.AptFilterGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AptFilterGrid.ShowEditingIcon = false;
            this.AptFilterGrid.Size = new System.Drawing.Size(457, 194);
            this.AptFilterGrid.TabIndex = 15;
            // 
            // LocationFilterGrid
            // 
            this.LocationFilterGrid.AllowUserToAddRows = false;
            this.LocationFilterGrid.AllowUserToDeleteRows = false;
            this.LocationFilterGrid.AllowUserToResizeColumns = false;
            this.LocationFilterGrid.AllowUserToResizeRows = false;
            this.LocationFilterGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LocationFilterGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LocationFilterGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.LocationFilterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocationFilterGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.LocationFilterGrid.Location = new System.Drawing.Point(878, 422);
            this.LocationFilterGrid.MultiSelect = false;
            this.LocationFilterGrid.Name = "LocationFilterGrid";
            this.LocationFilterGrid.RowHeadersVisible = false;
            this.LocationFilterGrid.RowHeadersWidth = 51;
            this.LocationFilterGrid.RowTemplate.Height = 24;
            this.LocationFilterGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocationFilterGrid.ShowEditingIcon = false;
            this.LocationFilterGrid.Size = new System.Drawing.Size(452, 194);
            this.LocationFilterGrid.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(838, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Contact Name";
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.ReportsBtn.Location = new System.Drawing.Point(1217, 665);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(113, 35);
            this.ReportsBtn.TabIndex = 25;
            this.ReportsBtn.Text = "Back";
            this.ReportsBtn.UseVisualStyleBackColor = true;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // MonthBox
            // 
            this.MonthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MonthBox.FormattingEnabled = true;
            this.MonthBox.Items.AddRange(new object[] {
            "",
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthBox.Location = new System.Drawing.Point(296, 381);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(229, 26);
            this.MonthBox.TabIndex = 26;
            this.MonthBox.SelectedIndexChanged += new System.EventHandler(this.MonthBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Select Month";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 712);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.ReportsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocationFilterGrid);
            this.Controls.Add(this.AptFilterGrid);
            this.Controls.Add(this.AptInfoGrid);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.reportLbl);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AptInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AptFilterGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationFilterGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportLbl;
        private System.Windows.Forms.ComboBox ContactBox;
        private System.Windows.Forms.DataGridView AptInfoGrid;
        private System.Windows.Forms.DataGridView AptFilterGrid;
        private System.Windows.Forms.DataGridView LocationFilterGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReportsBtn;
        private System.Windows.Forms.ComboBox MonthBox;
        private System.Windows.Forms.Label label2;
    }
}