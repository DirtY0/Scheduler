namespace Scheduler
{
    partial class MainScreen
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
            this.FilterBox = new System.Windows.Forms.ComboBox();
            this.DeleteBtn2 = new System.Windows.Forms.Button();
            this.DeleteBtn1 = new System.Windows.Forms.Button();
            this.UpdateBtn1 = new System.Windows.Forms.Button();
            this.UpdateBtn2 = new System.Windows.Forms.Button();
            this.AddBtn2 = new System.Windows.Forms.Button();
            this.AddBtn1 = new System.Windows.Forms.Button();
            this.ApptLbl = new System.Windows.Forms.Label();
            this.CustomersLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ReportsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterBox
            // 
            this.FilterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FilterBox.FormattingEnabled = true;
            this.FilterBox.Items.AddRange(new object[] {
            "All Appointments",
            "Current Month",
            "Current Week"});
            this.FilterBox.Location = new System.Drawing.Point(1449, 93);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(216, 26);
            this.FilterBox.TabIndex = 22;
            this.FilterBox.SelectedIndexChanged += new System.EventHandler(this.FilterBox_SelectedIndexChanged);
            // 
            // DeleteBtn2
            // 
            this.DeleteBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn2.Location = new System.Drawing.Point(1579, 609);
            this.DeleteBtn2.Name = "DeleteBtn2";
            this.DeleteBtn2.Size = new System.Drawing.Size(86, 34);
            this.DeleteBtn2.TabIndex = 21;
            this.DeleteBtn2.Text = "Delete";
            this.DeleteBtn2.UseVisualStyleBackColor = true;
            this.DeleteBtn2.Click += new System.EventHandler(this.DeleteBtn2_Click);
            // 
            // DeleteBtn1
            // 
            this.DeleteBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn1.Location = new System.Drawing.Point(1579, 346);
            this.DeleteBtn1.Name = "DeleteBtn1";
            this.DeleteBtn1.Size = new System.Drawing.Size(86, 34);
            this.DeleteBtn1.TabIndex = 20;
            this.DeleteBtn1.Text = "Delete";
            this.DeleteBtn1.UseVisualStyleBackColor = true;
            this.DeleteBtn1.Click += new System.EventHandler(this.DeleteBtn1_Click);
            // 
            // UpdateBtn1
            // 
            this.UpdateBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn1.Location = new System.Drawing.Point(1487, 346);
            this.UpdateBtn1.Name = "UpdateBtn1";
            this.UpdateBtn1.Size = new System.Drawing.Size(86, 34);
            this.UpdateBtn1.TabIndex = 19;
            this.UpdateBtn1.Text = "Update";
            this.UpdateBtn1.UseVisualStyleBackColor = true;
            this.UpdateBtn1.Click += new System.EventHandler(this.UpdateBtn1_Click);
            // 
            // UpdateBtn2
            // 
            this.UpdateBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn2.Location = new System.Drawing.Point(1487, 609);
            this.UpdateBtn2.Name = "UpdateBtn2";
            this.UpdateBtn2.Size = new System.Drawing.Size(86, 34);
            this.UpdateBtn2.TabIndex = 18;
            this.UpdateBtn2.Text = "Update";
            this.UpdateBtn2.UseVisualStyleBackColor = true;
            this.UpdateBtn2.Click += new System.EventHandler(this.UpdateBtn2_Click);
            // 
            // AddBtn2
            // 
            this.AddBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn2.Location = new System.Drawing.Point(1395, 609);
            this.AddBtn2.Name = "AddBtn2";
            this.AddBtn2.Size = new System.Drawing.Size(86, 34);
            this.AddBtn2.TabIndex = 17;
            this.AddBtn2.Text = "Add";
            this.AddBtn2.UseVisualStyleBackColor = true;
            this.AddBtn2.Click += new System.EventHandler(this.AddBtn2_Click);
            // 
            // AddBtn1
            // 
            this.AddBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn1.Location = new System.Drawing.Point(1395, 346);
            this.AddBtn1.Name = "AddBtn1";
            this.AddBtn1.Size = new System.Drawing.Size(86, 34);
            this.AddBtn1.TabIndex = 16;
            this.AddBtn1.Text = "Add";
            this.AddBtn1.UseVisualStyleBackColor = true;
            this.AddBtn1.Click += new System.EventHandler(this.AddBtn1_Click);
            // 
            // ApptLbl
            // 
            this.ApptLbl.AutoSize = true;
            this.ApptLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.ApptLbl.Location = new System.Drawing.Point(96, 93);
            this.ApptLbl.Name = "ApptLbl";
            this.ApptLbl.Size = new System.Drawing.Size(146, 26);
            this.ApptLbl.TabIndex = 15;
            this.ApptLbl.Text = "Appointments";
            // 
            // CustomersLbl
            // 
            this.CustomersLbl.AutoSize = true;
            this.CustomersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.CustomersLbl.Location = new System.Drawing.Point(96, 354);
            this.CustomersLbl.Name = "CustomersLbl";
            this.CustomersLbl.Size = new System.Drawing.Size(118, 26);
            this.CustomersLbl.TabIndex = 14;
            this.CustomersLbl.Text = "Customers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(101, 148);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1564, 192);
            this.dataGridView1.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(101, 398);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.Size = new System.Drawing.Size(1564, 190);
            this.dataGridView2.TabIndex = 12;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.LogoutBtn.Location = new System.Drawing.Point(1552, 740);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(113, 34);
            this.LogoutBtn.TabIndex = 23;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.ReportsBtn.Location = new System.Drawing.Point(1552, 699);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(113, 35);
            this.ReportsBtn.TabIndex = 24;
            this.ReportsBtn.Text = "Reports";
            this.ReportsBtn.UseVisualStyleBackColor = true;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 25;
            this.label1.Text = "Scheduler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(1340, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Filters";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 799);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportsBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.DeleteBtn2);
            this.Controls.Add(this.DeleteBtn1);
            this.Controls.Add(this.UpdateBtn1);
            this.Controls.Add(this.UpdateBtn2);
            this.Controls.Add(this.AddBtn2);
            this.Controls.Add(this.AddBtn1);
            this.Controls.Add(this.ApptLbl);
            this.Controls.Add(this.CustomersLbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FilterBox;
        private System.Windows.Forms.Button DeleteBtn2;
        private System.Windows.Forms.Button DeleteBtn1;
        private System.Windows.Forms.Button UpdateBtn1;
        private System.Windows.Forms.Button UpdateBtn2;
        private System.Windows.Forms.Button AddBtn2;
        private System.Windows.Forms.Button AddBtn1;
        private System.Windows.Forms.Label ApptLbl;
        private System.Windows.Forms.Label CustomersLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ReportsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}