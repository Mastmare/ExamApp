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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        public void ClearText()
        {
            textBoxResult.Clear();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            string[] insertString = Program.GetDataString();
            if (insertString.Length == 0)
            {
                Array.Resize(ref insertString, insertString.Length+1);
                insertString[0] = "Пересечений не обнаружено";
            }
            foreach (string currentText in insertString)
            {
                textBoxResult.AppendText(currentText + Environment.NewLine);
            }
        }
    }
}
