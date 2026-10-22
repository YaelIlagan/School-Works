using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabStreams
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
            this.FormClosed += FrmStudentRecord_FormClosed;
        }

        private void FrmStudentRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }

        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            lvShowRecord.Items.Clear(); //reset list

            try
            {
                using (StreamReader streamReader = File.OpenText(openFileDialog1.FileName))
                {
                    string lineText;
                    while ((lineText = streamReader.ReadLine()) != null)
                    {
                        lvShowRecord.Items.Add(lineText);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Can't open file.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            lvShowRecord.Items.Clear();
        }
    }
}
