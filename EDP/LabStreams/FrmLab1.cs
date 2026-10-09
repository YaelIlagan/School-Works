namespace LabStreams
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFileName frmName = new FrmFileName();
            frmName.ShowDialog();

            string getInput = txtInput.Text;
            string docPath = Application.StartupPath;

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }
        }
    }
}
