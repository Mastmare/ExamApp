using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UchProject
{
    internal class Week
    {
        private Dictionary<string, string>[] WeekTable = new Dictionary<string, string>[0];

        public void AddRecordInTable(string[] insertArray)
        {
            Array.Resize(ref WeekTable, WeekTable.Length + 1);
            WeekTable[WeekTable.Length - 1] = new Dictionary<string, string>();
            int currentWeek = WeekTable.Length - 1;
            WeekTable[currentWeek]["Тип занятия"] = insertArray[0];
            string[] times = insertArray[1].Split('-');
            WeekTable[currentWeek]["Начало занятия"] = times[0];
            WeekTable[currentWeek]["Конец занятия"] = times[1];
            WeekTable[currentWeek]["День недели"] = insertArray[2];
            WeekTable[currentWeek]["Тип недели"] = insertArray[3];
            WeekTable[currentWeek]["Номер группы"] = insertArray[4];
            WeekTable[currentWeek]["Наименование дисциплины"] = insertArray[5];
            WeekTable[currentWeek]["Номер аудитории"] = insertArray[6];
        }

        private static int ConvertTime(string insertString)
        {
            string[] stringArr = insertString.Split('.');
            return Convert.ToInt32(stringArr[0])*60 + Convert.ToInt32(stringArr[1]);
        }

        private static string ConvertTime(int insertInt)
        {
            StringBuilder result = null;
            result.AppendFormat("{0}.{1}", (insertInt - insertInt%60)/60, insertInt%60);
            return Convert.ToString(result);
        }

        private static bool compareTime(int firstStart, int firstEnd,
            int secondStart, int secondEnd)
        {
            if ((secondStart >= firstStart && secondStart <= firstEnd) ||
                (secondEnd >= firstStart && secondEnd <= firstEnd)) return true;
            return false;
        }

        public static void WeekTotalCheck()
        {
            Week firstVarWeek = Program.TeachersArray[0].TeachersWeek;
            string currentFirstName = Program.TeachersArray[0].TeacherName;
            int firstIndex=0;
            int secondIndex=0;
            Week secondVarWeek = firstVarWeek;
            string currentSecondName = currentFirstName;
            while ((currentFirstName!=Program.TeachersArray[Program.TeachersArray.Length-1].TeacherName)
                || (Program.TeachersArray[Program.TeachersArray.Length-1].TeachersWeek.WeekTable.Length-1
                >firstIndex))
            {
                NextVarTable(ref secondVarWeek, ref secondIndex, ref currentSecondName);
                if ((firstVarWeek.WeekTable[firstIndex]["День недели"] ==
                     secondVarWeek.WeekTable[secondIndex]["День недели"])
                    && (firstVarWeek.WeekTable[firstIndex]["Тип недели"] ==
                        secondVarWeek.WeekTable[secondIndex]["Тип недели"])
                    && (compareTime((ConvertTime(firstVarWeek.WeekTable[firstIndex]["Начало занятия"])),
                        ConvertTime(firstVarWeek.WeekTable[firstIndex]["Конец занятия"]),
                        ConvertTime(secondVarWeek.WeekTable[secondIndex]["Начало занятия"]),
                        ConvertTime(secondVarWeek.WeekTable[secondIndex]["Конец занятия"]))))
                {
                    if ((currentFirstName == currentSecondName) ||
                        (firstVarWeek.WeekTable[firstIndex]["Номер группы"] ==
                        secondVarWeek.WeekTable[secondIndex]["Номер группы"])||
                        (firstVarWeek.WeekTable[firstIndex]["Номер аудитории"] ==
                        secondVarWeek.WeekTable[secondIndex]["Номер аудитории"]))
                    {
                        Program.AddResultToArray(string.Format(Environment.NewLine + "Обнаружено пересечение:"+
                            Environment.NewLine +
                            "1. Имя преподавателя {0} Название предмета: {1}, время: {2}-{3},"+
                            " тип недели: {4}, день недели: {5} " +
                            Environment.NewLine +
                            "2. Имя преподавателя {6} Название предмета: {7}, время: {8}-{9}," +
                            " тип недели: {10}, день недели: {11} " +
                            Environment.NewLine,
                            currentFirstName,
                            firstVarWeek.WeekTable[firstIndex]["Наименование дисциплины"], 
                            firstVarWeek.WeekTable[firstIndex]["Начало занятия"],
                            firstVarWeek.WeekTable[firstIndex]["Конец занятия"],
                            firstVarWeek.WeekTable[firstIndex]["Тип недели"],
                            firstVarWeek.WeekTable[firstIndex]["День недели"],
                            currentSecondName,
                            secondVarWeek.WeekTable[secondIndex]["Наименование дисциплины"],
                            secondVarWeek.WeekTable[secondIndex]["Начало занятия"],
                            secondVarWeek.WeekTable[secondIndex]["Конец занятия"],
                            secondVarWeek.WeekTable[secondIndex]["Тип недели"],
                            secondVarWeek.WeekTable[secondIndex]["День недели"]));

                    }
                }
                NextVarTable(ref secondVarWeek, ref secondIndex, ref currentSecondName,
                    ref firstVarWeek, ref firstIndex, ref currentFirstName);
            }

        }

        public static void NextVarTable(ref Week checkableTable, ref int currentIndex, ref string name)
        {
            if (currentIndex+1 <= checkableTable.WeekTable.Length - 1)
            {
                currentIndex++;
            }
            else if (Program.NextTeacherIndexByName(name) != -1)
            {
                int newTeacherIndex = (Program.NextTeacherIndexByName(name));
                name = Program.TeachersArray[newTeacherIndex].TeacherName;
                checkableTable = Program.TeachersArray[newTeacherIndex].TeachersWeek;
                currentIndex = 0;
            } 
        }

        public static void NextVarTable(ref Week secondTable, ref int currentSecondIndex,
            ref string secondName, ref Week firstTable, ref int currentFirstIndex,
            ref string firstName)
        {
            if (currentSecondIndex == secondTable.WeekTable.Length - 1)
            {
                if (currentFirstIndex == firstTable.WeekTable.Length - 1)
                {
                    int newTeacherIndex = Program.NextTeacherIndexByName(firstName);
                    firstName = Program.TeachersArray[newTeacherIndex].TeacherName;
                    firstTable = Program.TeachersArray[newTeacherIndex].TeachersWeek;
                    currentFirstIndex = 0;
                    if (currentFirstIndex + 1 <= firstTable.WeekTable.Length - 1)
                    {
                        secondTable = firstTable;
                        secondName = firstName;
                        currentSecondIndex = currentFirstIndex + 1;
                    }
                    else if (Program.NextTeacherIndexByName(firstName) != -1)
                    {
                        newTeacherIndex = Program.NextTeacherIndexByName(firstName);
                        secondName = Program.TeachersArray[newTeacherIndex].TeacherName;
                        secondTable = Program.TeachersArray[newTeacherIndex].TeachersWeek;
                        currentSecondIndex = 0;
                    }
                }
                else currentFirstIndex++;
            }
        }
    }
}
