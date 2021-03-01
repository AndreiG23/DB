namespace DatabaseApplicaton
{
    partial class Form1
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
            this.CompaniesDataGrid = new System.Windows.Forms.DataGridView();
            this.GamesDataGrid = new System.Windows.Forms.DataGridView();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_GenreID = new System.Windows.Forms.TextBox();
            this.textBox_CompanyID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ReleaseYear = new System.Windows.Forms.TextBox();
            this.textBox_PlatformID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CompaniesDataGrid
            // 
            this.CompaniesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompaniesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompaniesDataGrid.Location = new System.Drawing.Point(30, 44);
            this.CompaniesDataGrid.Name = "CompaniesDataGrid";
            this.CompaniesDataGrid.ReadOnly = true;
            this.CompaniesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CompaniesDataGrid.Size = new System.Drawing.Size(261, 252);
            this.CompaniesDataGrid.TabIndex = 0;
            this.CompaniesDataGrid.SelectionChanged += new System.EventHandler(this.CompaniesDataGrid_SelectionChanged);
            // 
            // GamesDataGrid
            // 
            this.GamesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GamesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GamesDataGrid.Location = new System.Drawing.Point(420, 44);
            this.GamesDataGrid.Name = "GamesDataGrid";
            this.GamesDataGrid.ReadOnly = true;
            this.GamesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GamesDataGrid.Size = new System.Drawing.Size(348, 252);
            this.GamesDataGrid.TabIndex = 1;
            this.GamesDataGrid.SelectionChanged += new System.EventHandler(this.GamesDataGrid_SelectionChanged);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(320, 119);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 2;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(320, 171);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 3;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(320, 223);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(75, 23);
            this.Update_Button.TabIndex = 4;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(417, 342);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(141, 20);
            this.textBox_Name.TabIndex = 5;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(417, 389);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(141, 20);
            this.textBox_Price.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Companies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Games";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "GenreID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CompanyID";
            // 
            // textBox_GenreID
            // 
            this.textBox_GenreID.Location = new System.Drawing.Point(594, 389);
            this.textBox_GenreID.Name = "textBox_GenreID";
            this.textBox_GenreID.Size = new System.Drawing.Size(72, 20);
            this.textBox_GenreID.TabIndex = 12;
            // 
            // textBox_CompanyID
            // 
            this.textBox_CompanyID.Location = new System.Drawing.Point(594, 342);
            this.textBox_CompanyID.Name = "textBox_CompanyID";
            this.textBox_CompanyID.Size = new System.Drawing.Size(72, 20);
            this.textBox_CompanyID.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(699, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Relesase Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(699, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "PlatformID";
            // 
            // textBox_ReleaseYear
            // 
            this.textBox_ReleaseYear.Location = new System.Drawing.Point(699, 389);
            this.textBox_ReleaseYear.Name = "textBox_ReleaseYear";
            this.textBox_ReleaseYear.Size = new System.Drawing.Size(72, 20);
            this.textBox_ReleaseYear.TabIndex = 16;
            // 
            // textBox_PlatformID
            // 
            this.textBox_PlatformID.Location = new System.Drawing.Point(699, 342);
            this.textBox_PlatformID.Name = "textBox_PlatformID";
            this.textBox_PlatformID.Size = new System.Drawing.Size(72, 20);
            this.textBox_PlatformID.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_ReleaseYear);
            this.Controls.Add(this.textBox_PlatformID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_GenreID);
            this.Controls.Add(this.textBox_CompanyID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.GamesDataGrid);
            this.Controls.Add(this.CompaniesDataGrid);
            this.Name = "Form1";
            this.Text = "Database Application";
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CompaniesDataGrid;
        private System.Windows.Forms.DataGridView GamesDataGrid;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_GenreID;
        private System.Windows.Forms.TextBox textBox_CompanyID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ReleaseYear;
        private System.Windows.Forms.TextBox textBox_PlatformID;
    }
}

