using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabStreams
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {

                if (!long.TryParse(txtStudentNo.Text, out long studentNumber))
                    throw new FormatException("Invalid Input. Letters/Special characters are not allowed.");


                if (string.IsNullOrWhiteSpace(txtLastName.Text) || !txtLastName.Text.All(character => char.IsLetter(character) || character == ' '))
                    throw new FormatException("Invalid input. Numbers/Special characters are not allowed.");


                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || !txtFirstName.Text.All(character => char.IsLetter(character) || character == ' '))
                    throw new FormatException("Invalid input. Numbers/Special characters are not allowed.");


                if (!int.TryParse(txtAge.Text, out int age))
                    throw new FormatException("Invalid Input.  Letters/Special characters are not allowed.");


                if (cbGender.SelectedIndex == -1)
                    throw new FormatException("Gender cannot be empty.");


                if (cbProgram.SelectedIndex == -1)
                    throw new FormatException("Program cannot be empty.");


                if (datePickerBirthday.Value.Date > DateTime.Today)
                    throw new FormatException("Invalid birthday. Past to present date only.");


                if (string.IsNullOrWhiteSpace(txtContactNumber.Text) || !txtContactNumber.Text.All(char.IsDigit))
                    throw new FormatException("Invalid contact number. Letters/Special characters are not allowed.");


                string folderPath = Application.StartupPath;

                string[] studentInfo =
                {
                    "Student No.: " + txtStudentNo.Text,
                    "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + " " + txtMiddleInitial.Text + ".",
                    "Program: " + cbProgram.Text,
                    "Gender: " + cbGender.Text,
                    "Age: " + txtAge.Text,
                    "Birthday: " + datePickerBirthday.Value.ToString("yyyy-MM-dd"),
                    "Contact No.: " + txtContactNumber.Text
                };

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(folderPath, txtStudentNo.Text + ".txt")))
                {
                    foreach (string infoLine in studentInfo)
                    {
                        outputFile.WriteLine(infoLine);
                    }
                }

                MessageBox.Show("Registration successful! Check " + folderPath);
            }
            catch (FormatException ex)
            {
                //warning message
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord studentRecordForm = new FrmStudentRecord();
            studentRecordForm.Show(this); //set owner
            this.Hide();
        }
    }
}
