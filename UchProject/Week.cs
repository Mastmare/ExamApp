using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UchProject
{
    class Week
    {
        private Dictionary<string,object>[] WeekTable = new Dictionary<string,object>[0];

        public Week()
        {
        }

        public void AddRecordInTable(string[] insertArray)
        {
            Array.Resize(ref WeekTable, WeekTable.Length+1);
            WeekTable[WeekTable.Length - 1] = new Dictionary<string, object>();
            int currentWeek = WeekTable.Length - 1;
            WeekTable[currentWeek]["Тип занятия"] = insertArray[0];


        }

        
    }
}
