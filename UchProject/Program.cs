using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UchProject
{
    static class Program
    {
        public static Teacher[] TeachersArray = new Teacher[1];
        private static string[] ResultArray = new string[0];
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
            if (TeachersArray[0] != null)
            {
                Array.Resize(ref TeachersArray, TeachersArray.Length + 1);
            }
            TeachersArray[TeachersArray.Length-1] = new Teacher(NewTeacherName);
        }

        public static void ClearResult()
        {
            ResultArray = new string[0];
        }

        public static Teacher SearchTeacherByName(string searchebleName)
        {
            foreach (Teacher nowTeacher in TeachersArray)
            {
                if (nowTeacher.TeacherName == searchebleName) return nowTeacher;
            }   
            return null;
        }

        public static int NextTeacherIndexByName(string currentName)
        {
            for (int i = 0; i < TeachersArray.Length; i++)
            {
                if (TeachersArray[i].TeacherName == currentName && i + 1 <= TeachersArray.Length-1)
                {
                    return i + 1;
                }
            }
            return -1;
        }

        public static void AddResultToArray(string s)
        {
            Array.Resize(ref ResultArray, ResultArray.Length+1);
            ResultArray[ResultArray.Length - 1] = s;
        }

        public static string[] GetDataString()
        {
            return ResultArray;
        }
    }
}
