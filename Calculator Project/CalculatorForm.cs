using System.Text;

namespace Calculator_Project
{
    public partial class CalculatorForm : Form
    {
        private double? SavedNum { get; set; }
        private Operator? SavedOperator { get; set; }
        private NumType SetNumType { get; set; } = NumType.Decimal;
        private double? PreviousNum { get; set; }
        private bool CaughtError { get; set; } = false;

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

                if (PreviousNum != null || CaughtError == true)
                {
                    NumDisplay.Text = btn.Text.ToString();
                    PreviousNum = null;
                    SavedNum = null;
                    SavedOperator = null;
                    CaughtError = false;
                }
            }
        }

        private void OperatorPanel_Click(object sender, EventArgs e)
        {
            string displayNum = NumDisplay.Text.ToString();

            if (sender is Button && CaughtError == false)
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
                SavedNum = double.Parse(displayNum);
            }

            PreviousNum = null;
            SavedNumDisplay.Text = SavedNum.ToString();
            NumDisplay.Text = "";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (SavedNum != null && SavedOperator != null && !String.IsNullOrWhiteSpace(NumDisplay.Text.ToString()))
            {
                double? result = 0;

                if (PreviousNum == null)
                {
                    PreviousNum = double.Parse(NumDisplay.Text.ToString());
                }

                switch (SavedOperator)
                {
                    case Operator.Addition:
                        try
                        {
                            result = SavedNum + double.Parse(NumDisplay.Text.ToString());
                        }
                        catch
                        {
                            NumDisplay.Text = "ERROR";
                            CaughtError = true;
                            break;
                        }

                        if (String.IsNullOrWhiteSpace(SavedNumDisplay.Text) && String.IsNullOrWhiteSpace(OperatorDisplay.Text))
                        {
                            result = SavedNum + PreviousNum;
                        }
                        break;
                    case Operator.Subtraction:
                        try
                        {
                            result = SavedNum - double.Parse(NumDisplay.Text.ToString());
                        }
                        catch
                        {
                            NumDisplay.Text = "ERROR";
                            CaughtError = true;
                            break;
                        }

                        if (String.IsNullOrWhiteSpace(SavedNumDisplay.Text) && String.IsNullOrWhiteSpace(OperatorDisplay.Text))
                        {
                            result = SavedNum - PreviousNum;
                        }
                        break;
                    case Operator.Multiplication:
                        try
                        {
                            result = SavedNum * double.Parse(NumDisplay.Text.ToString());
                        }
                        catch
                        {
                            NumDisplay.Text = "ERROR";
                            CaughtError = true;
                            break;
                        }

                        if (String.IsNullOrWhiteSpace(SavedNumDisplay.Text) && String.IsNullOrWhiteSpace(OperatorDisplay.Text))
                        {
                            result = SavedNum * PreviousNum;
                        }
                        break;
                    case Operator.Division:
                        try
                        {
                            result = SavedNum / double.Parse(NumDisplay.Text.ToString());
                        }
                        catch
                        {
                            NumDisplay.Text = "ERROR";
                            CaughtError = true;
                            break;
                        }

                        if (String.IsNullOrWhiteSpace(SavedNumDisplay.Text) && String.IsNullOrWhiteSpace(OperatorDisplay.Text))
                        {
                            result = SavedNum / PreviousNum;
                        }
                        break;
                }

                if (result != null && CaughtError == false)
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

                if (!NumDisplay.Text.Contains("."))
                {
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


                        if (PreviousNum != null || CaughtError == true)
                        {
                            NumDisplay.Text = btn.Text.ToString();
                            PreviousNum = null;
                            SavedNum = null;
                            SavedOperator = null;
                            CaughtError = false;
                        }
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