using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Configuration;
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

        private void FileDataReloaderAdd(ref string[] textData, string comboBoxText)
        {

            bool flag = false;
            foreach (var currNumber in textData)
            {
                if (currNumber == comboBoxText)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                Array.Resize(ref textData, textData.Length+1);
                textData[textData.Length - 1] = comboBoxText;
            }
        }

        private void FileDataReloaderDelete(ref string[] textData, string comboBoxText)
        {
            bool flag = false;
            int deleteStringNumber=0;
            foreach (var currNumber in textData)
            {
                if (currNumber == comboBoxText)
                {
                    flag = true;
                    deleteStringNumber = Array.IndexOf(textData, currNumber);
                    break;
                } 
            }
            if (flag)
            {
                textData[deleteStringNumber] = null;
                int incrementIndex = 0;
                string[] newTextData = new string[textData.Length-1];
                for (int i = 0; i < textData.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(textData[i]))
                    {
                        newTextData[incrementIndex++] = textData[i];
                    }
                }
                textData = newTextData;
            }
        }

        private void InsertData_Load(object sender, EventArgs e)
        {
            comboBoxTeacher.Items.Clear();
            comboBoxGroup.Items.Clear();
            comboBoxAuditory.Items.Clear();
            comboBoxDiscipline.Items.Clear();
            string[] auditoryText = System.IO.File.ReadAllLines("../../AuditoryFieldData.txt");
            comboBoxAuditory.Items.AddRange(auditoryText);
            string[] groupText = System.IO.File.ReadAllLines("../../GroupFieldData.txt");
            comboBoxGroup.Items.AddRange(groupText);
            string[] disciplineText = System.IO.File.ReadAllLines("../../DisciplineFieldData.txt");
            comboBoxDiscipline.Items.AddRange(disciplineText);
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
            if (string.IsNullOrEmpty(comboBoxTimeAndTypeOfLesson.Text))
            {
                MessageBox.Show("Поле типа и времени занятия не заполнено, введите данные");
            }
            else if (string.IsNullOrEmpty(comboBoxDayofWeek.Text))
            {
                MessageBox.Show("Поле дня недели не заполнено, выберите день недели");
            } else if (string.IsNullOrEmpty(comboBoxTypeOfWeek.Text))
            {
                MessageBox.Show("Поле типа недели не заполнено, выберите тип недели");
            } else if (string.IsNullOrEmpty(comboBoxGroup.Text))
            {
                MessageBox.Show("Поле группы не заполнено, введите номер группы");
            } else if (string.IsNullOrEmpty(comboBoxDiscipline.Text))
            {
                MessageBox.Show("Поле дисциплины не заполнено, введите название дисциплины");
            } else if (string.IsNullOrEmpty(comboBoxAuditory.Text))
            {
                MessageBox.Show("Поле дисциплины не заполнено, введите название дисциплины");
            }
            else
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
        }

        private void buttonAnalyseCollision_Click(object sender, EventArgs e)
        {
            Week.WeekTotalCheck();
            ResultForm newForm = new ResultForm();
            newForm.ClearText();
            newForm.Show();
            Program.ClearResult();
        }

        private void buttonAddNewGroup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBoxGroup.Text))
            {
                string[] textData = System.IO.File.ReadAllLines("../../GroupFieldData.txt");
                string BoxText = comboBoxGroup.Text;
                FileDataReloaderAdd(ref textData, BoxText);
                System.IO.File.WriteAllLines("../../GroupFieldData.txt", textData);
                comboBoxGroup.Items.Clear();
                comboBoxGroup.Items.AddRange(textData);
                comboBoxGroup.ResetText();
            }
            else MessageBox.Show("Заполните поле");
        }

        private void buttonAddDiscipline_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBoxDiscipline.Text))
            {
                string[] textData = System.IO.File.ReadAllLines("../../DisciplineFieldData.txt");
                string BoxText = comboBoxDiscipline.Text;
                FileDataReloaderAdd(ref textData, BoxText);
                System.IO.File.WriteAllLines("../../DisciplineFieldData.txt", textData);
                comboBoxDiscipline.Items.Clear();
                comboBoxDiscipline.Items.AddRange(textData);
                comboBoxDiscipline.ResetText();
            }
            else MessageBox.Show("Заполните поле");
        }

        private void buttonAddNumAuditory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBoxAuditory.Text))
            {
                string[] textData = System.IO.File.ReadAllLines("../../AuditoryFieldData.txt");
                string BoxText = comboBoxAuditory.Text;
                FileDataReloaderAdd(ref textData, BoxText);
                System.IO.File.WriteAllLines("../../AuditoryFieldData.txt", textData);
                comboBoxAuditory.Items.Clear();
                comboBoxAuditory.Items.AddRange(textData);
                comboBoxAuditory.ResetText();
            }
            else MessageBox.Show("Заполните поле");
        }

        private void buttonDeleteGroup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBoxGroup.Text))
            {
                string[] textData = System.IO.File.ReadAllLines("../../GroupFieldData.txt");
                string BoxText = comboBoxGroup.Text;
                FileDataReloaderDelete(ref textData, BoxText);
                System.IO.File.WriteAllLines("../../GroupFieldData.txt", textData);
                comboBoxGroup.Items.Clear();
                comboBoxGroup.Items.AddRange(textData);
                comboBoxGroup.ResetText();
            }
            else MessageBox.Show("Заполните поле");
        }

        private void buttonDeleteDiscipline_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBoxDiscipline.Text))
            {
                string[] textData = System.IO.File.ReadAllLines("../../DisciplineFieldData.txt");
                string BoxText = comboBoxDiscipline.Text;
                FileDataReloaderDelete(ref textData, BoxText);
                System.IO.File.WriteAllLines("../../DisciplineFieldData.txt", textData);
                comboBoxDiscipline.Items.Clear();
                comboBoxDiscipline.Items.AddRange(textData);
                comboBoxDiscipline.ResetText();
            }
            else MessageBox.Show("Заполните поле");
        }

        private void buttonDeleteNumAuditory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBoxAuditory.Text))
            {
                string[] textData = System.IO.File.ReadAllLines("../../AuditoryFieldData.txt");
                string BoxText = comboBoxAuditory.Text;
                FileDataReloaderDelete(ref textData, BoxText);
                System.IO.File.WriteAllLines("../../AuditoryFieldData.txt", textData);
                comboBoxAuditory.Items.Clear();
                comboBoxAuditory.Items.AddRange(textData);
                comboBoxAuditory.ResetText();
            }
            else MessageBox.Show("Заполните поле");
        }

        private void comboBoxTimeAndTypeOfLesson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
