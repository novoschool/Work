using Calculator.Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private CalculatorService _service = new CalculatorService();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(((Button)sender).Text, out var digit)) 
            {
                _service.InputDigit(digit);
                DisplayRegister();
            }
        }

        private void DisplayRegister()
        {
            DisplayLabel.Text = _service.Model.XRegister.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _service.Clear();
            DisplayRegister();
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            _service.ApplyOperator(((Button)sender).Text);
            DisplayRegister();
        }

        private void MoveXToYButton_Click(object sender, EventArgs e)
        {
            _service.MoveXToY();
            DisplayRegister();
        }
    }
}
