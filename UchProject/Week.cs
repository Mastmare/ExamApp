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

       /* public void CheckByTeahcer(string teacherName)
        {
            bool flag = false;
            if (WeekTable.Length > 1)
            {
                for (int i = 0; i <= WeekTable.Length - 2; i++)
                {
                    for (int j = i+1; j <= WeekTable.Length - 1; j++)
                    {
                        if (compareTime(ConvertTime(WeekTable[i]["Начало занятия"]),
                            ConvertTime(WeekTable[i]["Конец занятия"]),
                            ConvertTime(WeekTable[j]["Начало занятия"]),
                            ConvertTime(WeekTable[j]["Конец занятия"]))
                            &&(WeekTable[i]["Тип недели"]==WeekTable[j]["Тип недели"])&&
                            (WeekTable[i]["День недели"]==WeekTable[j]["День недели"]))
                        {
                            flag = true;
                            StringBuilder resultMessage = new StringBuilder();
                            resultMessage.AppendFormat("*Есть пересечение во времени у преподавателя {0}:" +
                                                       Environment.NewLine +
                                                       "Занятие по {1} {2}-{3}, каб{4}" +
                                                       Environment.NewLine +
                                                       "Занятие по {5} {6}-{7}, каб{8}" +
                                                       Environment.NewLine + "----" +
                                                       Environment.NewLine, teacherName,
                                WeekTable[i]["Наименование дисциплины"],
                                WeekTable[i]["Начало занятия"],
                                WeekTable[i]["Конец занятия"],
                                WeekTable[i]["Номер аудитории"],
                                WeekTable[j]["Наименование дисциплины"],
                                WeekTable[j]["Начало занятия"],
                                WeekTable[j]["Конец занятия"],
                                WeekTable[j]["Номер аудитории"]);
                            Program.AddResultToArray(Convert.ToString(resultMessage));
                        }
                    }
                }
            }
            if (!flag) Program.AddResultToArray("*Пересечений не обнаружено"+
                Environment.NewLine+ "----" + Environment.NewLine);
        } */

        public static void WeekTotalCheck(Week firstVarWeek, string currentFirstName)
        {
            int firstIndex=0;
            int secondIndex=0;
            Week secondVarWeek = firstVarWeek;
            string currentSecondName = currentFirstName;
            NextVarTable(ref secondVarWeek,ref secondIndex,ref currentSecondName);
            while ((currentFirstName!=Program.TeachersArray[Program.TeachersArray.Length-1].TeacherName)
                && (Program.TeachersArray[Program.TeachersArray.Length-1].TeachersWeek.WeekTable.Length-1
                <=firstIndex))
            {
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
                         secondVarWeek.WeekTable[secondIndex]["Номер группы"]))
                    {
                        string coincidenceType= "";
                        string coincidenceName= "";
                        if (currentFirstName == currentSecondName)
                        {
                            coincidenceType = "Преподавателя";
                            coincidenceName = currentFirstName;
                        }
                        else
                        {
                            coincidenceType = "Группы";
                            coincidenceName = firstVarWeek.WeekTable[firstIndex]["Номер группы"];
                        }
                        Program.AddResultToArray(string.Format(Environment.NewLine + "Обнаружено пересечение:"+
                            Environment.NewLine + "У {0} {1} одновременно 2 занятия" + 
                            Environment.NewLine + "1. Название предмета: {2}, время: {3}-{4}" + 
                            Environment.NewLine + "2. Название предмета: {5}, время: {6}-{7}"+
                            Environment.NewLine, coincidenceType, coincidenceName, 
                            firstVarWeek.WeekTable[firstIndex]["Название предмета"], 
                            firstVarWeek.WeekTable[firstIndex]["Начало занятия"],
                            firstVarWeek.WeekTable[firstIndex]["Конец Занятия"],
                            secondVarWeek.WeekTable[secondIndex]["Название предмета"],
                            secondVarWeek.WeekTable[secondIndex]["Начало занятия"],
                            secondVarWeek.WeekTable[secondIndex]["Конец занятия"]));

                    }   else if (firstVarWeek.WeekTable[firstIndex]["Номер группы"] ==
                                 secondVarWeek.WeekTable[secondIndex]["Номер группы"])
                    {
                    
                    }
                }
            }

        }

        public static void NextVarTable(ref Week checkableTable, ref int currentIndex, ref string name)
        {
            if (currentIndex+1 < checkableTable.WeekTable.Length + 1)
            {
                currentIndex++;
            }
            else if (currentIndex < Program.TeachersArray.Length)
            {
                currentIndex = (Program.NextTeacherIndexByName(name));
                name = Program.TeachersArray[currentIndex].TeacherName;
                checkableTable = Program.TeachersArray[currentIndex].TeachersWeek;
            } 
        }
    }
}
