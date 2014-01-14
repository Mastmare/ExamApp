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

        private void ResultForm_Load(object sender, EventArgs e)
        {
            string[] insertString = Program.GetDataString();
            foreach (string currentText in insertString)
            {
                textBoxResult.AppendText(currentText + Environment.NewLine);
            }
        }
    }
}
