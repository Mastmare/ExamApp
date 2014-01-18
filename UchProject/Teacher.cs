using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UchProject
{
    class Teacher
    {
        private string tchName;
        Week TchWeek = new Week();

        public Week TeachersWeek
        {
            get { return TchWeek; }
        }

        public Teacher(string TeacherName)
        {
            this.TeacherName = TeacherName;
        }

        public void AddRec(string[] insert)
        {
            TchWeek.AddRecordInTable(insert);
        }

        public string TeacherName
        {
            get { return tchName; }
            set { tchName = value; }
        }
    }
}
