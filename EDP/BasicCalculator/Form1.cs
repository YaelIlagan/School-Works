using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            

            try
            {

                if (!float.TryParse(txtnum1.Text, out float num1))
                {
                    MessageBox.Show("Please input a valid first number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnum1.Focus();
                    return;
                }

                if (!float.TryParse(txtnum2.Text, out float num2))
                {
                    MessageBox.Show("Please input a valid second number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnum2.Focus();
                    return;
                }

               

                switch (cbOperator.SelectedItem.ToString())
                {

                    case "+":
                        lblTotal.Text = BasicComputation.add(num1, num2).ToString();
                        break;
                    case "-":
                        lblTotal.Text = BasicComputation.subtract(num1, num2).ToString();
                        break;
                    case "*":
                        lblTotal.Text = BasicComputation.multiply(num1, num2).ToString();
                        break;
                    case "/":
                        try
                        {
                            lblTotal.Text = BasicComputation.divide(num1, num2).ToString();
                        }
                        catch (DivideByZeroException ex)
                        {
                            MessageBox.Show("Please input a valid Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    default:
                        MessageBox.Show("Please select a operator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            cbOperator.Text = "+";
        }

    }
    
}
