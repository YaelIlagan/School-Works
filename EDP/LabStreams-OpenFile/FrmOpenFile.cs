namespace LabStreams_OpenFile
{
    public partial class FrmOpenFile : Form
    {
        public FrmOpenFile()
        {
            InitializeComponent();
        }

        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = openFileDialog1.FileName;
            lvShowText.Items.Clear(); //reset list

            try
            {
                using (StreamReader streamReader = File.OpenText(filePath))
                {
                    string lineText;
                    while ((lineText = streamReader.ReadLine()) != null)
                    {
                        lvShowText.Items.Add(lineText);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Can't open file.", "File Error");
            }


        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }
    }
}
