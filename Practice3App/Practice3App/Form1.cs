using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice3App
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private int i = 0;
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (i < 3)
            {
                Student aStudent = new Student();
                aStudent.regNo = regNoTextBox.Text;
                aStudent.firstName = firstNameTextBox.Text;
                aStudent.lastName = lastNameTextBox.Text;
                students.Add(aStudent);

                regNoTextBox.Text = string.Empty;
                firstNameTextBox.Text = string.Empty;
                lastNameTextBox.Text = string.Empty;

                i++;
            }
            else
            {
                {
                    MessageBox.Show("Already Three Student Information Saved");
                }
            }
            
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string showAll = "Registration Number \t Full Name \n";
            foreach (Student aStudent in students)
            {
                showAll = showAll + aStudent.regNo + "\t\t\t" + aStudent.GetFullName() + "\n";
            }

            MessageBox.Show(" \n" + showAll);
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            students.Clear();
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
        }
    }
}
