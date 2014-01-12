using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UchProject
{
    class Week
    {
        private object[] WeekTable = new object[0];

        public Week()
        {
            AddRecordInTable();
        }

        public void AddRecordInTable()
        {
            Array.Resize(ref WeekTable, WeekTable.Length+1);
            WeekTable[WeekTable.Length - 1] = new Dictionary<string, object>();

        }

        
    }
}
