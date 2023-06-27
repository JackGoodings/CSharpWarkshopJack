using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDeveloper
{
    public class Student
    {
        public int StudyHoursPerWeek { get; set; }
        public int StudyWeeksCompleted { get; set; }
        public string StudentName { get; set; }

        //for the sake of the output
        public string OutputStorage { get; set; }

        public void BuildStudentInformation()
        {
            this.OutputStorage = $"Student name : {this.StudentName} Study Hours : {this.StudyHoursPerWeek} Number of weeks completed : {this.StudyWeeksCompleted}";

        }

        public void DisplayStudentInformation()
        {
            Console.Write(this.OutputStorage);
        }
    }
}
