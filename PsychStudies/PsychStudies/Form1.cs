using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsychStudies
{
    public partial class Form1 : Form
    {
        ContentManager contentManager;
        public Form1()
        {
            InitializeComponent();

            contentManager = new ContentManager(descTextBox, studiesList);
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            //make sure all fields are filled and print message if not 
            if(studyNameTextBox.Text == "") { Write("Please enter NAME of study"); return; }
            if (researcherListBox.Items.Count == 0) { Write("Please enter RESEARCHER(S) of study"); return; }
            if (yearTextBox.Text == "") { Write("Please enter YEAR of study (-1 if unkown)"); return; } //-------------------- << For Future Reference NO YEAR == -1
            if (studyNameTextBox.Text == "") { Write("Please enter NAME of study"); return; }

            //convert collection of researchers into string array
            string[] tempResearchers = new string[researcherListBox.Items.Count];
            byte i = 0;
            foreach(string str in researcherListBox.Items)
            {
                tempResearchers[i] = str;
                i++;
            }
            contentManager.AddStudy(new Study(studyNameTextBox.Text, tempResearchers, short.Parse(yearTextBox.Text), studyNameTextBox.Text));
        }

        /// <summary>
        /// writes text to the description text box
        ///     - used to output study description
        ///     - debug code
        ///     - print messages to user
        /// </summary>
        /// <param name="text">text to write</param>
        private void Write(string text)
        {
            //\n used to seperate new lines
            descTextBox.Lines = text.Split('\n');
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            //make sure researcher name field is filled
            if(researcherNameTextBox.Text == "") { Write("Please enter RESEARCHER name"); return; }

            researcherListBox.Items.Add(researcherNameTextBox.Text);
            
        }

        private void studySortButton_Click(object sender, EventArgs e)
        {
            //------------------------------ << Temp code for testing output
            contentManager.Output();
        }
    }
}
