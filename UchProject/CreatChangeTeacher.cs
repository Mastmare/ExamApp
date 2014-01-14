using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UchProject
{
    public partial class CreatChangeTeacher : Form
    {
        public CreatChangeTeacher()
        {
            InitializeComponent();
        }

        private void buttonAddNewTeacher_Click(object sender, EventArgs e)
        {
            string TeacherName = comboBoxAddChangeTeacher.Text;
            Program.AddNewTeacher(TeacherName);
            this.Close();
        }

        private void CreatChangeTeacher_Load(object sender, EventArgs e)
        {
            comboBoxAddChangeTeacher.Items.Clear();
        }

        private void buttonChangeTeacher_Click(object sender, EventArgs e)
        {
            Teacher changeTeacher = Program.SearchTeacherByName(comboBoxAddChangeTeacher.Text);
            changeTeacher.SetTeacherName(textBoxNewName.Text);
            InsertData form = new InsertData();
            form.Delete(textBoxNewName.Text);
            this.Close();
        }

        private void comboBoxAddChangeTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < Program.TeachersArray.Length; i++)
            {
                if (Program.TeachersArray[i] != null)
                {
                    string NowName = Program.TeachersArray[i].Name();
                    bool flag = false;
                    for (int j = 0; j < comboBoxAddChangeTeacher.Items.Count; j++)
                    {
                        if (Convert.ToString(comboBoxAddChangeTeacher.Items[j]) == NowName)
                            flag = true;
                    }
                    if (!flag) comboBoxAddChangeTeacher.Items.Add(NowName);
                }
            }
        }
    }
}
