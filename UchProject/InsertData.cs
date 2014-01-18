using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace UchProject
{
    public partial class InsertData : Form
    {
        private string DeleteTeacher = null;


        public InsertData()
        {
            InitializeComponent();
        }

        public void Delete(string name)
        {
            Teacher currenTeacher = Program.SearchTeacherByName(name);
            currenTeacher.TeacherName = name;
            comboBoxTeacher.Items.Remove(name);
        }

        private void buttonAddChangeTeacher_Click(object sender, EventArgs e)
        {
            CreatChangeTeacher newForm = new CreatChangeTeacher();
            newForm.Show();
            
        }

        private void InsertData_Load(object sender, EventArgs e)
        {
            comboBoxTeacher.Items.Clear();
        }

        private void comboBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.TeachersArray.Length; i++)
            {
                if (Program.TeachersArray[i] != null)
                {
                    string NowName = Program.TeachersArray[i].TeacherName;
                    bool flag = false;
                    for (int j = 0; j < comboBoxTeacher.Items.Count; j++)
                    {
                        if (Convert.ToString(comboBoxTeacher.Items[j]) == NowName)
                            flag = true;
                    }
                    if (!flag) comboBoxTeacher.Items.Add(NowName);
                }
            }
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            string FindTeacherName = comboBoxTeacher.Text;
            Teacher currentTeacher = Program.SearchTeacherByName(FindTeacherName);
            InsertData generalForm = new InsertData();
            string[] SendData = new string[7];
            string[] send = comboBoxTimeAndTypeOfLesson.Text.Split(':');
            SendData[0] = send[0];
            SendData[1] = send[1];
            SendData[2] = comboBoxDayofWeek.Text;
            SendData[3] = comboBoxTypeOfWeek.Text;
            SendData[4] = comboBoxGroup.Text;
            SendData[5] = comboBoxDiscipline.Text;
            SendData[6] = comboBoxAuditory.Text;
            currentTeacher.AddRec(SendData);

        }

        private void buttonAnalyseCollision_Click(object sender, EventArgs e)
        {
            Week.WeekTotalCheck();
            ResultForm newForm = new ResultForm();
            newForm.Show();
        }

    }
}
