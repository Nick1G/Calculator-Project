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

        private void NumPanel_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (NumDisplay.Text.Length <= 12)
                {
                    Button btn = sender as Button;
                    NumDisplay.Text += btn.Text;
                }
            }
        }
    }
}