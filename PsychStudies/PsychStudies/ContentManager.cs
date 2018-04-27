using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsychStudies
{
    class ContentManager
    {
        TextBox descBox; //reference to the description box for writing
        ListBox studiesList; //reference to the studies list box for output
        private List<Study> studies; //list of all the created studies

        public ContentManager(TextBox descBox, ListBox studiesList)
        {
            this.descBox = descBox;
            this.studiesList = studiesList;
            studies = new List<Study>();
            ReadInFile("studies");

            Write("Welcome to the Psych Studies Reviewer " +
                 "\nClick on a study to view it's description");
        }


        /// <summary>
        /// adds a study to the list
        /// </summary>
        /// <param name="study">study to add</param>
        public void AddStudy(Study study)
        {
            studies.Add(study);
        }

        /// <summary>
        /// outputs a list of Studies to the studies lits box
        /// </summary>
        /// <param name="studies"></param>
        public void Output()
        {
            studiesList.Items.Clear();
            foreach(Study study in studies)
            {
                studiesList.Items.Add(study.ToString());
            }
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
            descBox.Lines = text.Split('\n');
        }

        /// <summary>
        /// reads in data from .txt file and adds studies to list
        /// </summary>
        /// <param name="filename">name of the .txt file</param>
        private void ReadInFile(string filename)
        {
            //StreamReader TODO
        }
    }
}
