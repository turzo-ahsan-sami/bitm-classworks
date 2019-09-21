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

        List<StudentInformation> studentList = new List<StudentInformation>();

        string id;
        string name;
        string mobile;
        int age;
        double gpa;

        public StudentDetails()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            mobileTextBox.Text = "";
            ageTextBox.Text = "";
            gpaTextBox.Text = "";

            idRadioButton.Checked = false;
            nameRadioButton.Checked = false;
            mobileRadioButton.Checked = false;
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
              

        private bool ValidateInputs()
        {
            id = idTextBox.Text;
            name = nameTextBox.Text;
            mobile = mobileTextBox.Text;
            age = (ageTextBox.Text == "") ? 0 : int.Parse(ageTextBox.Text);
            gpa = (gpaTextBox.Text == "") ? 0 : double.Parse(gpaTextBox.Text);

            if (id.Length != 4)
            {
                ShowMessage("ID should be of 4 characters!");
                return false;
            }

            if (mobile.Length != 4)
            {
                ShowMessage("Mobile number should be of 4 characters!");
                return false;
            }

            if (name.Length == 0)
            {
                ShowMessage("Name can not be empty!");
                return false;
            }

            if (CustomLibrary.HasDuplicateID(list: studentList, id))
            {
                ShowMessage("ID exists already!");
                return false;
            }

            if (CustomLibrary.HasDuplicateMobile(list: studentList, mobile))
            {
                ShowMessage("Mobile exists already!");
                return false;
            }

            if (age == 0)
            {
                ShowMessage("Age can not be 0!");
                return false;
            }

            if (gpa <= 0 || gpa > 4)
            {
                ShowMessage("GPA should be between 0 and 4!");
                return false;
            }
                      
            return true;
        } 
        
        private void AddStudent(object sender, EventArgs e)
        {
            displayRichTextBox.Text = "";
            try
            {
                if (ValidateInputs())
                {
                    StudentInformation newStudent = new StudentInformation(id, name, mobile, age, gpa);
                    studentList.Add(newStudent);
                    string output = "Student Added \n\n";
                    output += StudentInformation.ShowStudent(newStudent);
                    displayRichTextBox.Text = output;
                    Reset();
                }
                else
                {
                    return;
                }
            }
            catch (Exception exception)
            {
                ShowMessage(exception.Message);
            }
        }

        private void ShowAllStudents(object sender, EventArgs e)
        {
            Reset();
            displayRichTextBox.Text = "";
            try
            {
                if (studentList.Count > 0)
                {
                    string output = "Student Details \n\n";
                    foreach(StudentInformation student in studentList)
                    {
                        output += StudentInformation.ShowStudent(student);
                    }
                    output += StudentInformation.DisplayMaxMinAvgTotal(studentList);
                    displayRichTextBox.Text = output;                    
                }
                else
                {
                    ShowMessage("Please add students first!");
                    return;
                }
            }
            catch (Exception exception)
            {
                ShowMessage(exception.Message);
            }
        }

        private void SearchStudent(object sender, EventArgs e)
        {
            List<StudentInformation> students = new List<StudentInformation>();
            string searchText = searchTextBox.Text.ToLower();
            if (searchText == "") ShowMessage("Please enter id, name or mobile to search.");
            
            if (idRadioButton.Checked == true) students = studentList.FindAll(r => r.id.ToLower() == searchText);
            else if (nameRadioButton.Checked == true) students = studentList.FindAll(r => r.name.ToLower() == searchText);
            else if (mobileRadioButton.Checked == true) students = studentList.FindAll(r => r.mobile.ToLower() == searchText);
            else MessageBox.Show("Please select id, name or mobile to search.");

            if (students.Count == 0) ShowMessage("No student found that matches the description");
            else
            {
                string output = "Search Result \n\n";
                foreach (StudentInformation student in students)
                {
                    output += StudentInformation.ShowStudent(student);
                }                
                displayRichTextBox.Text = output;
            }
        }
    }






    class StudentInformation
    {
        public string id { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public int age { get; set; }
        public double gpa { get; set; }
        

        

        public StudentInformation()
        {
        }

        public StudentInformation(string id, string name, string mobile, int age, double gpa)
        {
            this.id = id;
            this.name = name;
            this.mobile = mobile;
            this.age = age;
            this.gpa = gpa;
        }

        public static string ShowStudent(StudentInformation student)
        {
            string output = "\nID : " + student.id
                            + "\nName : " + student.name
                            + "\nMobile : " + student.mobile
                            + "\nAge : " + student.age
                            + "\nGPA : " + student.gpa 
                            + "\n";
            return output;
        }


        public static string DisplayMaxMinAvgTotal(List<StudentInformation> studentList)
        {
            string output = "\n\nDetails (Max, Min, Avg, Total):";
            if(studentList.Count > 0)
            {
                output = "\nStudent : " + CustomLibrary.FindMaxInList(studentList).name
                        + " - Max GPA: " + CustomLibrary.FindMaxInList(studentList).gpa 
                        + "\nStudent : " + CustomLibrary.FindMinInList(studentList).name 
                        + " - Min GPS: " + CustomLibrary.FindMinInList(studentList).gpa 
                        + "\nAverage : " + CustomLibrary.FindAvgOfList(studentList)
                        + " - Total : " + CustomLibrary.FindTotalOfList(studentList)
                        + "\n";
            }

            return output;
        }

    }
}
