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

                if (PreviousNum != null || CaughtError == true || SetNumType == NumType.Binary || SetNumType == NumType.Locational)
                {
                    NumDisplay.Text = btn.Text.ToString();
                    PreviousNum = null;
                    SavedNum = null;
                    SavedNumDisplay.Text = "";
                    SavedOperator = null;
                    CaughtError = false;
                    SetNumType = NumType.Decimal;
                }
            }
        }

        private void OperatorPanel_Click(object sender, EventArgs e)
        {
            string displayNum = NumDisplay.Text.ToString();

            if (sender is Button && CaughtError == false && SetNumType == NumType.Decimal)
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

            if (SetNumType == NumType.Decimal)
            {
                SavedNumDisplay.Text = SavedNum.ToString();
                NumDisplay.Text = "";
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (SavedNum != null && SavedOperator != null && !String.IsNullOrWhiteSpace(NumDisplay.Text.ToString()) && SetNumType == NumType.Decimal)
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
            SavedNumDisplay.Text = "";
            PreviousNum = null;
            SetNumType = NumType.Decimal;
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

        private void BINButton_Click(object sender, EventArgs e)
        {
            if (SetNumType == NumType.Locational)
            {
                DECButton_Click(sender, e);
            }

            if (!String.IsNullOrWhiteSpace(NumDisplay.Text))
            {
                int numToCompare = (int)(double.Parse(NumDisplay.Text.ToString()));
                SavedNumDisplay.Text = numToCompare.ToString();
                StringBuilder binaryNum = new StringBuilder();

                while (numToCompare != 0)
                {
                    binaryNum.Insert(0, (numToCompare % 2).ToString());
                    numToCompare /= 2;
                }

                NumDisplay.Text = binaryNum.ToString();
            }

            SetNumType = NumType.Binary;
        }

        private void DECButton_Click(object sender, EventArgs e)
        {
            if (SetNumType != NumType.Decimal)
            {
                NumDisplay.Text = SavedNumDisplay.Text.ToString();
                SavedNumDisplay.Text = SavedNum.ToString();

                if (PreviousNum != null)
                {
                    SavedNumDisplay.Text = "";
                }

                SetNumType = NumType.Decimal;
            }
        }

        private void LOCButton_Click(object sender, EventArgs e)
        {
            if (SetNumType == NumType.Binary)
            {
                DECButton_Click(sender, e);
            }

            if (!String.IsNullOrWhiteSpace(NumDisplay.Text))
            {
                int numToCompare = (int)(double.Parse(NumDisplay.Text.ToString()));
                SavedNumDisplay.Text = numToCompare.ToString();
                StringBuilder locationalNum = new StringBuilder();
                int lowestMultiple = 1;
                int multipleAmount = 0;

                while (lowestMultiple <= numToCompare)
                {
                    if (lowestMultiple * 2 > numToCompare)
                    {
                        Char c = (Char)(97 + multipleAmount);
                        locationalNum.Insert(0, c.ToString());
                        numToCompare -= lowestMultiple;

                        lowestMultiple = 1;
                        multipleAmount = 0;
                    }
                    else
                    {
                        lowestMultiple *= 2;
                        multipleAmount++;
                    }
                }

                NumDisplay.Text = locationalNum.ToString();
            }

            SetNumType = NumType.Locational;
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