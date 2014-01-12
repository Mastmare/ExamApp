using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UchProject
{
    static class Program
    {
        public static Teacher[] TeachersArray = new Teacher[1];
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InsertData());
        }

        public static void AddNewTeacher(string NewTeacherName)
        {
            TeachersArray[TeachersArray.Length-1] = new Teacher(NewTeacherName);
        }

        public static Teacher SearchTeacherByName(string searchebleName)
        {
            foreach (Teacher nowTeacher in TeachersArray)
            {
                if (nowTeacher.Name() == searchebleName) return nowTeacher;
            }   
            return null;
        } 
    }
}
