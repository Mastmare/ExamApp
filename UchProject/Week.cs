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

        private int ConvertTime(string insertString)
        {
            string[] stringArr = insertString.Split('.');
            return Convert.ToInt32(stringArr[0])*60 + Convert.ToInt32(stringArr[1]);
        }

        private string ConvertTime(int insertInt)
        {
            StringBuilder result = null;
            result.AppendFormat("{0}.{1}", (insertInt - insertInt%60)/60, insertInt%60);
            return Convert.ToString(result);
        }

        private bool compareTime(int firstStart, int firstEnd,
            int secondStart, int secondEnd)
        {
            if ((secondStart >= firstStart && secondStart <= firstEnd) ||
                (secondEnd >= firstStart && secondEnd <= firstEnd)) return true;
            return false;
        }

        public void CheckByTeahcer(string teacherName)
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
        }

    }
}
