using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabStreams
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnSetFileName_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text + ".txt";
            this.Close();
        }
    }
}
