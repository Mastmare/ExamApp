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
            Program.TeachersArray[Program.TeachersArray.Length - 1] = new Teacher(TeacherName);
            this.Close();
        }

        private void CreatChangeTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
