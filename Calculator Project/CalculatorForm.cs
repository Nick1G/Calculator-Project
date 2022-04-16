using System.Text;

namespace Calculator_Project
{
    public partial class CalculatorForm : Form
    {
        private decimal? SavedNum { get; set; }
        private Operator? SavedOperator { get; set; }
        private bool EnteredOperator { get; set; } = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void NumPanel_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (EnteredOperator == true)
                {
                    NumDisplay.Text = "";
                }

                if (NumDisplay.Text.Length <= 12)
                {
                    Button btn = sender as Button;
                    NumDisplay.Text += btn.Text;
                }

                EnteredOperator = false;
            }
        }

        private void OperatorPanel_Click(object sender, EventArgs e)
        {
            string displayNum = NumDisplay.Text.ToString();
            SavedNum = decimal.Parse(displayNum);
            if (sender is Button)
            {
                Button btn = sender as Button;

                if (!String.IsNullOrWhiteSpace(displayNum))
                {
                    switch (btn.Text.ToString())
                    {
                        case "+":
                            OperatorDisplay.Text = btn.Text.ToString();
                            SavedOperator = Operator.Addition;
                            break;
                        case "-":
                            OperatorDisplay.Text = btn.Text.ToString();
                            SavedOperator = Operator.Subtraction;
                            break;
                        case "*":
                            OperatorDisplay.Text = btn.Text.ToString();
                            SavedOperator = Operator.Multiplication;
                            break;
                        case "/":
                            OperatorDisplay.Text = btn.Text.ToString();
                            SavedOperator = Operator.Division;
                            break;
                    }

                    EnteredOperator = true;
                }
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (SavedNum != null && SavedOperator != null && !String.IsNullOrWhiteSpace(NumDisplay.Text.ToString()))
            {
                decimal? result = 0;

                switch (SavedOperator)
                {
                    case Operator.Addition:
                        result = SavedNum + decimal.Parse(NumDisplay.Text.ToString());
                        break;
                    case Operator.Subtraction:
                        result = SavedNum - decimal.Parse(NumDisplay.Text.ToString());
                        break;
                    case Operator.Multiplication:
                        result = SavedNum * decimal.Parse(NumDisplay.Text.ToString());
                        break;
                    case Operator.Division:
                        result = SavedNum / decimal.Parse(NumDisplay.Text.ToString());
                        break;
                }

                if (result != null)
                {
                    SavedNum = result;
                    NumDisplay.Text = result.ToString();
                    SavedOperator = null;
                    OperatorDisplay.Text = "";
                    EnteredOperator = false;
                }
            }
        }
    }

    public enum Operator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
    }
}