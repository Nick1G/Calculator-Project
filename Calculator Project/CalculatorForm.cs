using System.Text;

namespace Calculator_Project
{
    public partial class CalculatorForm : Form
    {
        private decimal? SavedNum { get; set; }
        private Operator? SavedOperator { get; set; }
        private NumType SetNumType { get; set; } = NumType.Decimal;
        private decimal? PreviousNum { get; set; }

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void NumPanel_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = sender as Button;

                if (NumDisplay.Text.Length <= 12)
                {
                    NumDisplay.Text += btn.Text;
                }

                if (PreviousNum != null)
                {
                    NumDisplay.Text = btn.Text.ToString();
                    PreviousNum = null;
                    SavedNum = null;
                    SavedOperator = null;
                }
            }
        }

        private void OperatorPanel_Click(object sender, EventArgs e)
        {
            string displayNum = NumDisplay.Text.ToString();

            if (sender is Button)
            {
                Button btn = sender as Button;

                if (!String.IsNullOrWhiteSpace(displayNum) || SavedNum != null)
                {
                    if (SavedNum != null && !String.IsNullOrWhiteSpace(displayNum) && SavedOperator != null && !String.IsNullOrWhiteSpace(SavedNumDisplay.Text))
                    {
                        EqualButton_Click(sender, e);
                    }

                    SavedOperator = null;
                    OperatorDisplay.Text = btn.Text.ToString();

                    switch (btn.Text.ToString())
                    {
                        case "+":
                            SavedOperator = Operator.Addition;
                            break;
                        case "-":
                            SavedOperator = Operator.Subtraction;
                            break;
                        case "*":
                            SavedOperator = Operator.Multiplication;
                            break;
                        case "/":
                            SavedOperator = Operator.Division;
                            break;
                    }
                }
            }

            if (!String.IsNullOrWhiteSpace(displayNum) && SavedNum == null)
            {
                SavedNum = decimal.Parse(displayNum);
            }

            PreviousNum = null;
            SavedNumDisplay.Text = SavedNum.ToString();
            NumDisplay.Text = "";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (SavedNum != null && SavedOperator != null && !String.IsNullOrWhiteSpace(NumDisplay.Text.ToString()))
            {
                decimal? result = 0;

                if (PreviousNum == null)
                {
                    PreviousNum = decimal.Parse(NumDisplay.Text.ToString());
                }

                switch (SavedOperator)
                {
                    case Operator.Addition:
                        result = SavedNum + decimal.Parse(NumDisplay.Text.ToString());

                        if (String.IsNullOrWhiteSpace(SavedNumDisplay.Text) && String.IsNullOrWhiteSpace(OperatorDisplay.Text))
                        {
                            result = SavedNum + PreviousNum;
                        }
                        break;
                    case Operator.Subtraction:
                        result = SavedNum - decimal.Parse(NumDisplay.Text.ToString());

                        if (String.IsNullOrWhiteSpace(SavedNumDisplay.Text) && String.IsNullOrWhiteSpace(OperatorDisplay.Text))
                        {
                            result = SavedNum - PreviousNum;
                        }
                        break;
                    case Operator.Multiplication:
                        result = SavedNum * decimal.Parse(NumDisplay.Text.ToString());

                        if (String.IsNullOrWhiteSpace(SavedNumDisplay.Text) && String.IsNullOrWhiteSpace(OperatorDisplay.Text))
                        {
                            result = SavedNum * PreviousNum;
                        }
                        break;
                    case Operator.Division:
                        result = SavedNum / decimal.Parse(NumDisplay.Text.ToString());

                        if (String.IsNullOrWhiteSpace(SavedNumDisplay.Text) && String.IsNullOrWhiteSpace(OperatorDisplay.Text))
                        {
                            result = SavedNum / PreviousNum;
                        }
                        break;
                }

                if (result != null)
                {
                    SavedNum = result;
                    SavedNumDisplay.Text = "";
                    NumDisplay.Text = result.ToString();
                    OperatorDisplay.Text = "";
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SavedNum = null;
            SavedOperator = null;
            OperatorDisplay.Text = "";
            NumDisplay.Text = "";
            PreviousNum = null;
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = sender as Button;

                if (NumDisplay.Text.Length <= 12)
                {
                    if (NumDisplay.Text.Length == 0)
                    {
                        NumDisplay.Text += "0.";
                    } 
                    else
                    {
                        NumDisplay.Text += btn.Text;
                    }
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

    public enum NumType
    {
        Decimal,
        Binary,
        Locational,
    }
}