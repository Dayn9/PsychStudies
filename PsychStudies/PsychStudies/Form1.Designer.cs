namespace PsychStudies
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
            this.studiesList = new System.Windows.Forms.ListBox();
            this.addNewButton = new System.Windows.Forms.Button();
            this.studyNameLabel = new System.Windows.Forms.Label();
            this.researcherLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.studyNameTextBox = new System.Windows.Forms.TextBox();
            this.researcherListBox = new System.Windows.Forms.ListBox();
            this.researcherNameTextBox = new System.Windows.Forms.TextBox();
            this.plusButton = new System.Windows.Forms.Button();
            this.descAddTextBox = new System.Windows.Forms.TextBox();
            this.sortLabel = new System.Windows.Forms.Label();
            this.studySortButton = new System.Windows.Forms.Button();
            this.researcherSortButton = new System.Windows.Forms.Button();
            this.dateRecentSortButton = new System.Windows.Forms.Button();
            this.dateOldestSortButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studiesList
            // 
            this.studiesList.FormattingEnabled = true;
            this.studiesList.Location = new System.Drawing.Point(12, 44);
            this.studiesList.Name = "studiesList";
            this.studiesList.Size = new System.Drawing.Size(302, 290);
            this.studiesList.TabIndex = 0;
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(534, 292);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(139, 42);
            this.addNewButton.TabIndex = 1;
            this.addNewButton.Text = "Add";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // studyNameLabel
            // 
            this.studyNameLabel.AutoSize = true;
            this.studyNameLabel.Location = new System.Drawing.Point(452, 50);
            this.studyNameLabel.Name = "studyNameLabel";
            this.studyNameLabel.Size = new System.Drawing.Size(81, 13);
            this.studyNameLabel.TabIndex = 2;
            this.studyNameLabel.Text = "Name of study: ";
            // 
            // researcherLabel
            // 
            this.researcherLabel.AutoSize = true;
            this.researcherLabel.Location = new System.Drawing.Point(452, 80);
            this.researcherLabel.Name = "researcherLabel";
            this.researcherLabel.Size = new System.Drawing.Size(76, 13);
            this.researcherLabel.TabIndex = 3;
            this.researcherLabel.Text = "Researcher(s):";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(462, 197);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(66, 13);
            this.descLabel.TabIndex = 5;
            this.descLabel.Text = "Description: ";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(496, 168);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(534, 165);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(70, 20);
            this.yearTextBox.TabIndex = 6;
            // 
            // studyNameTextBox
            // 
            this.studyNameTextBox.Location = new System.Drawing.Point(534, 47);
            this.studyNameTextBox.Name = "studyNameTextBox";
            this.studyNameTextBox.Size = new System.Drawing.Size(220, 20);
            this.studyNameTextBox.TabIndex = 7;
            // 
            // researcherListBox
            // 
            this.researcherListBox.FormattingEnabled = true;
            this.researcherListBox.Location = new System.Drawing.Point(534, 103);
            this.researcherListBox.Name = "researcherListBox";
            this.researcherListBox.Size = new System.Drawing.Size(173, 56);
            this.researcherListBox.TabIndex = 8;
            // 
            // researcherNameTextBox
            // 
            this.researcherNameTextBox.Location = new System.Drawing.Point(534, 77);
            this.researcherNameTextBox.Name = "researcherNameTextBox";
            this.researcherNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.researcherNameTextBox.TabIndex = 9;
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(714, 77);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(40, 40);
            this.plusButton.TabIndex = 10;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // descAddTextBox
            // 
            this.descAddTextBox.Location = new System.Drawing.Point(534, 194);
            this.descAddTextBox.Multiline = true;
            this.descAddTextBox.Name = "descAddTextBox";
            this.descAddTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descAddTextBox.Size = new System.Drawing.Size(220, 92);
            this.descAddTextBox.TabIndex = 11;
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Location = new System.Drawing.Point(317, 132);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(43, 13);
            this.sortLabel.TabIndex = 12;
            this.sortLabel.Text = "Sort by:";
            // 
            // studySortButton
            // 
            this.studySortButton.Location = new System.Drawing.Point(320, 148);
            this.studySortButton.Name = "studySortButton";
            this.studySortButton.Size = new System.Drawing.Size(83, 42);
            this.studySortButton.TabIndex = 13;
            this.studySortButton.Text = "Study (a-z)";
            this.studySortButton.UseVisualStyleBackColor = true;
            this.studySortButton.Click += new System.EventHandler(this.studySortButton_Click);
            // 
            // researcherSortButton
            // 
            this.researcherSortButton.Location = new System.Drawing.Point(320, 196);
            this.researcherSortButton.Name = "researcherSortButton";
            this.researcherSortButton.Size = new System.Drawing.Size(83, 42);
            this.researcherSortButton.TabIndex = 14;
            this.researcherSortButton.Text = "Researcher (a-z)";
            this.researcherSortButton.UseVisualStyleBackColor = true;
            // 
            // dateRecentSortButton
            // 
            this.dateRecentSortButton.Location = new System.Drawing.Point(320, 244);
            this.dateRecentSortButton.Name = "dateRecentSortButton";
            this.dateRecentSortButton.Size = new System.Drawing.Size(83, 42);
            this.dateRecentSortButton.TabIndex = 15;
            this.dateRecentSortButton.Text = "Date: Most Recent";
            this.dateRecentSortButton.UseVisualStyleBackColor = true;
            // 
            // dateOldestSortButton
            // 
            this.dateOldestSortButton.Location = new System.Drawing.Point(320, 292);
            this.dateOldestSortButton.Name = "dateOldestSortButton";
            this.dateOldestSortButton.Size = new System.Drawing.Size(83, 42);
            this.dateOldestSortButton.TabIndex = 16;
            this.dateOldestSortButton.Text = "Date: Oldest";
            this.dateOldestSortButton.UseVisualStyleBackColor = true;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 15);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(47, 13);
            this.searchLabel.TabIndex = 17;
            this.searchLabel.Text = "Search: ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(65, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(249, 20);
            this.textBox5.TabIndex = 18;
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(12, 340);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.ReadOnly = true;
            this.descTextBox.Size = new System.Drawing.Size(742, 123);
            this.descTextBox.TabIndex = 19;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(679, 292);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 42);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 472);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.dateOldestSortButton);
            this.Controls.Add(this.dateRecentSortButton);
            this.Controls.Add(this.researcherSortButton);
            this.Controls.Add(this.studySortButton);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.descAddTextBox);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.researcherNameTextBox);
            this.Controls.Add(this.researcherListBox);
            this.Controls.Add(this.studyNameTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.researcherLabel);
            this.Controls.Add(this.studyNameLabel);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.studiesList);
            this.Name = "Form1";
            this.Text = "Psych Studies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studiesList;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Label studyNameLabel;
        private System.Windows.Forms.Label researcherLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox studyNameTextBox;
        private System.Windows.Forms.ListBox researcherListBox;
        private System.Windows.Forms.TextBox researcherNameTextBox;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.TextBox descAddTextBox;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Button studySortButton;
        private System.Windows.Forms.Button researcherSortButton;
        private System.Windows.Forms.Button dateRecentSortButton;
        private System.Windows.Forms.Button dateOldestSortButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}

