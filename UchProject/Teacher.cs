using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UchProject
{
    class Teacher
    {
        private string TeacherName;
        Week TeachersWeek = new Week();

        public Teacher(string TeacherName)
        {
            this.TeacherName = TeacherName;
        }

        public void CheckByTeacher()
        {
            TeachersWeek.CheckByTeahcer(TeacherName);
        }

        public string Name()
        {
            return TeacherName;
        }

        public void AddRec(string[] insert)
        {
            TeachersWeek.AddRecordInTable(insert);
        }

        public void SetTeacherName(string newName)
        {
            TeacherName = newName;
        }

    }
}
