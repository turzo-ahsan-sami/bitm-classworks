using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApplication
{
    public partial class StudentDetails : Form
    {

        List<Students> studentList = new List<Students>();
        Students newStudent = new Students();

        public StudentDetails()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            mobileTextBox.Text = "";
            ageTextBox.Text = "";
            gpaTextBox.Text = "";
            displayRichTextBox.Text = "";
        }

        private bool ValidateInputs()
        {
            string message = "";
            if (newStudent.name.Length != 4) return false;
            if (newStudent.mobile.Length != 11) return false;
            if (CustomLibrary.HasDuplicateContacts()) return false;
            if (newStudent.gpa < 0 || newStudent.gpa > 4) return false;

            if (message.Length > 0) MessageBox.Show(message);
            return true;
        } 
        
        private void AddStudent(object sender, EventArgs e)
        {
            Reset();
            try
            {
                if (ValidateInputs())
                {
                    studentList.Add(newStudent);
                    displayRichTextBox.Text = newStudent.ShowStudent(newStudent);
                    Reset();
                }
                else
                {
                    return;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ShowAllStudents(object sender, EventArgs e)
        {
            Reset();
            try
            {
                if (studentList.Count > 0)
                {
                    string output = "Student Details \n\n";
                    foreach(Students student in studentList)
                    {
                        output += newStudent.ShowStudent(student);
                    }
                    displayRichTextBox.Text = output;
                }
                else
                {
                    displayRichTextBox.Text = "";
                    return;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }






    class Students
    {
        public string id { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public int age { get; set; }
        public int gpa { get; set; }
        

        

        public Students()
        {
        }

        public Students(string id, string name, string mobile, int age, int gpa)
        {
            this.id = id;
            this.name = name;
            this.mobile = mobile;
            this.age = age;
            this.gpa = gpa;
        }

        public string ShowStudent(Students student)
        {
            string output = "ID : " + student.id + "\n"
                            + "Name : " + student.name + "\n"
                            + "Mobile : " + student.mobile + "\n"
                            + "Age : " + student.age + "\n"
                            + "GPA : " + student.gpa + "\n";
            return output;
        }


        public string DisplayMaxMinAvg(List<Students> students)
        {
            string output = "";
            if(students.Count > 0)
            {
                output = "Student : " + "\n"
                        + "Max : " + "\n"
                        + "Student : " + "\n"
                        + "Min : " + "\n"
                        + "Avg : " + "\n";
            }

            return output;
        }

    }
}
