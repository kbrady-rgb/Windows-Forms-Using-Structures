using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : Student Structure
* Author      : Kabrina Brady
* Created     : 10/13/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : Program accepts user input and creates a new student with the input provided
*               Input:  Name, ID, major, button clicks
*               Output: Name, ID, major
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace StudentStructureBrady
{
    //Student structure
    struct Student
    {
        public string name;
        public int studentID;
        public string major;
    }

    public partial class studentStructureForm : Form
    {
        public studentStructureForm()
        {
            InitializeComponent();
        }

        //creates method that assigns user input to structure elements
        private void DisplayStudent(ref Student studentInfo)
        {
            try
            {
                studentInfo.name = txtName.Text;
                studentInfo.studentID = int.Parse(txtID.Text);
                studentInfo.major = txtMajor.Text;
            }
            catch
            {
                MessageBox.Show("Invalid input."); //error message if studentID isn't a number
            }
        }

    private void BtnCreateStudent_Click(object sender, EventArgs e)
        {
            //create instance of StudentInfo structure
            Student details = new Student();

            //get user input
            DisplayStudent(ref details);

            try
            {
                //show info
                lblNameOutput.Text = details.name.ToString() + ", " + details.studentID.ToString() + ", " + details.major.ToString();
            }
            catch
            {
                //error message if no input
                MessageBox.Show("Please enter student details.");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closes form
        }
    }
}
