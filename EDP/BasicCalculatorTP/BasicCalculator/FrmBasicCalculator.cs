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
                if (!float.TryParse(txtnum1.Text, out float a))
                {
                    MessageBox.Show("Input a valid first number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnum1.Focus();
                    return;
                }

                if (!float.TryParse(txtnum2.Text, out float b))
                {
                    MessageBox.Show("Input a valid second number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnum2.Focus();
                    return;
                }

                if (cbOperator.SelectedItem is not string operatorText)
                {
                    MessageBox.Show("Please select an operator.", "Missing operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbOperator.Focus();
                    return;
                }

                if (operatorText == "/" && b == 0)
                {
                    MessageBox.Show("Cant divide by 0.", "Invalid operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnum2.Focus();
                    return;
                }

                float result;

                switch (operatorText)
                {
                    case "+":
                        result = BasicComputation.add(a, b);
                        break;
                    case "-":
                        result = BasicComputation.subtract(a, b);
                        break;
                    case "*":
                        result = BasicComputation.multiply(a, b);
                        break;
                    case "/":
                        result = BasicComputation.divide(a, b);
                        break;
                    default:
                        MessageBox.Show("Please select a valid operator.", "Invalid operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbOperator.Focus();
                        return;
                }

                lblTotal.Text = result.ToString();
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
