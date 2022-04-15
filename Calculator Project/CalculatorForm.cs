using System.Text;

namespace Calculator_Project
{
    public partial class CalculatorForm : Form
    {
        private int SavedNum { get; set; }

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void NumOneButton_Click(object sender, EventArgs e)
        {
            NumDisplay.Text += NumOneButton.Text;
        }

        private void NumTwoButton_Click(object sender, EventArgs e)
        {
            NumDisplay.Text += NumTwoButton.Text;
        }

        private void NumThreeButton_Click(object sender, EventArgs e)
        {
            NumDisplay.Text += NumThreeButton.Text;
        }

        private void NumFourButton_Click(object sender, EventArgs e)
        {
            NumDisplay.Text += NumFourButton.Text;
        }

        private void NumFiveButton_Click(object sender, EventArgs e)
        {
            NumDisplay.Text += NumFiveButton.Text;
        }

        private void NumSixButton_Click(object sender, EventArgs e)
        {
            NumDisplay.Text += NumSixButton.Text;
        }

        private void NumSevenButton_Click(object sender, EventArgs e)
        {
            NumDisplay.Text += NumSevenButton.Text;
        }

        private void NumEightButton_Click(object sender, EventArgs e)
        {
            NumDisplay.Text += NumEightButton.Text;
        }

        private void NumNineButton_Click(object sender, EventArgs e)
        {
            NumDisplay.Text += NumNineButton.Text;
        }

        private void NumZeroButton_Click(object sender, EventArgs e)
        {
            NumDisplay.Text += NumZeroButton.Text;
        }
    }
}