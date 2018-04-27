using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychStudies
{
    class Study
    {
        private string name;
        private string[] researchers;
        private short year;
        private string description;

        //basic constructor 
        public Study(string name, string[] researchers, short year, string description)
        {
            this.name = name;
            this.researchers = researchers;
            this.year = year;
            this.description = description;
        }

        public override string ToString()
        {
            //OPTION 1: ALL

            /*seperate our researcher names into one string
            string people = "";
            for (int i = 0; i < researchers.Length; i++)
            {
                people += $"{researchers[i]}, ";
            }*/

            //OPTION 2: ET AL
            string people = researchers.Length > 1 ? researchers[0] + " et al." : researchers[0];

            //return formatted string
            return $"{Name} ({people} {year})";
        }

        public string ToDescription()
        {
            string people = "";
            for (int i = 0; i < researchers.Length; i++)
            {
                people += $"{researchers[i]}, ";
            }

            return $"{Name}\nConducted by: {people.TrimEnd(',',' ')} in {year}\n{description}"; 
        }

        //can only GET data from fields once study has been created 
        public string Name { get { return name; } }
        public string[] Researchers { get { return researchers; } }
        public short Year { get { return year; } }
        public string Description { get { return description; } }
    }
}
