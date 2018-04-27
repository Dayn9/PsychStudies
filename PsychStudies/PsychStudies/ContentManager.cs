using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PsychStudies
{
    class ContentManager
    {
        TextBox descBox; //reference to the description box for writing
        ListBox studiesList; //reference to the studies list box for output
        private List<Study> studies; //list of all the created studies
        private Dictionary<string, Study> nameLookup;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="descBox">reference to the description box</param>
        /// <param name="studiesList">reference to the studies list box</param>
        public ContentManager(TextBox descBox, ListBox studiesList)
        {
            this.descBox = descBox;
            this.studiesList = studiesList;

            studies = new List<Study>();
            nameLookup = new Dictionary<string, Study>();


            ReadInFile("studies");
            Output();
            Write("Welcome to the Psych Studies Reviewer " +
                 "\nClick on a study to view it's description");
        }

        /// <summary>
        /// adds a study to the list
        /// </summary>
        /// <param name="study">study to add</param>
        public void AddStudy(Study study)
        {
            Write(study.Description);
            studies.Add(study);
        }

        /// <summary>
        /// outputs a list of Studies to the studies lits box
        /// </summary>
        public void Output()
        {
            studiesList.Items.Clear();
            foreach(Study study in studies)
            {
                studiesList.Items.Add(study.ToString());
            }
        }

        /// <summary>
        /// Prints the full description of a study to tje description box
        /// </summary>
        /// <param name="studyName">name of the study to print</param>
        public void WriteDescription(string studyName)
        {
            //make sure study exists first 
            if (nameLookup.ContainsKey(studyName))
            {
                //uses name lookup to quickly find 
                Write(nameLookup[studyName].ToDescription());
            }
            else
            {
                Write("Study does not exist in nameLookup");
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
            StreamReader reader = new StreamReader($"{filename}.txt"); //read form [filename].txt 

            try
            {
                studies.Clear(); //clear the current list

                //add to list
                string[] line;
                while((line = reader.ReadLine().Split('~')) != null) //-------------------- << For Future Reference data seperated by '-' and researchers seperated by ','
                {
                    Study newStudy = new Study(line[0], line[1].Split('`'), short.Parse(line[2]), line[3]);
                    studies.Add(newStudy);
                    nameLookup.Add(line[0], newStudy);
                }
            }
            catch (Exception e)
            {
                Write($"Exception reading in file {filename}: {e.Message}");
            }

            if(reader != null)
            {
                reader.Close();
            }
        }

        /// <summary>
        /// saves the list of studies to an externl .txt file
        /// </summary>
        /// <param name="filename">file to write to</param>
        public void Save(string filename)
        {
            StreamWriter writer = new StreamWriter($"{filename}.txt"); //write to [filename].txt 
            try
            {
                foreach(Study study in studies)
                {
                    string people = "";
                    for(int i=0; i<study.Researchers.Length; i++)
                    {
                        people += $"{study.Researchers[i]}`";
                    }
                    writer.WriteLine($"{study.Name}~{people}~{study.Year}~{study.Description}");
                }
            }
            catch (Exception e)
            {
                Write($"Exception writing to file {filename}: {e.Message}");
            }

            if(writer != null)
            {
                writer.Close();
            }

            //Write("Saved");
        }
    }
}
